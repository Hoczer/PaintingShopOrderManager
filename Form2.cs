using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZleceniaMalarnia
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        MalarniaDBDataSetTableAdapters.KlienciTableAdapter klienciTable = new MalarniaDBDataSetTableAdapters.KlienciTableAdapter();
        DataTable klienciTableRobocza = new DataTable();
        MalarniaDBDataSetTableAdapters.ProduktyTableAdapter ProduktyTable = new MalarniaDBDataSetTableAdapters.ProduktyTableAdapter();
        string nrAktualnegoZlecenia;
        //string idKlienta;
        int idKlientaint;
        int selectedID;
        private void Form2_Load(object sender, EventArgs e)
        {
            
            JmCombo.SelectedIndex = 1;

        }

        private void klientButton_Click(object sender, EventArgs e)
        {
            var form3 = new ListaKlientowForm();
            form3.Show();
            this.Close();
        }

        private void dodajButt_Click(object sender, EventArgs e)
        {
            if (cenaJmBox.Text != null&&iloscBox.Text!=null)
            {
                string iloscPrzecinki = iloscBox.Text.Replace(".", ",");
                decimal ilosc;
                if (Decimal.TryParse(iloscPrzecinki, out ilosc)) { } else { MessageBox.Show("Błędna wartość Ilości", "Błąd"); return; }
                string cenaPrzecinki = cenaJmBox.Text.Replace(".", ",");
                decimal cenaJm;
                if (Decimal.TryParse(cenaPrzecinki, out cenaJm)) { } else { MessageBox.Show("Błędna wartość CenaJm", "Błąd"); return; }
                decimal cenaProduktu = ilosc * cenaJm;
                decimal cenazVAT = (cenaProduktu * 23 / 100) + cenaProduktu;
                produktyTableAdapter.InsertQueryProdukty(nazwaPBox.Text, ilosc.ToString(), JmCombo.SelectedItem.ToString(), kolorBox.Text, cenaJm, cenaProduktu, int.Parse(nrAktualnegoZlecenia),idKlientaint,(decimal)cenazVAT);
                odzwierzDaneWtabeliProduktowDanegoKlientaiZlecenia();
                foreach (Control item in this.Controls)
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }

            }
            else
            {
                MessageBox.Show("Okna Ilość i Cena Jm nie mogą być puste", "Błąd");
            }
        }
        /// <summary>
        /// Zmienia dane klienta na te pobrane z tabeli
        /// Tworzy nowe zlecenie i pobiera jego numer do zmiennej
        /// </summary>
        /// <param name="idWybranegoKlienta">Numer indeksu aktualnie klikniętego wiersza tabeli</param>
        /// <returns></returns>
        public bool aktywujKlienta(int idWybranegoKlienta)
        {
            klienciTableRobocza = klienciTable.GetWierszGdzieIDKlienta(idWybranegoKlienta);
            Debug.WriteLine("::TABLE::");
            idKlientaint = idWybranegoKlienta;


            foreach (Control item in groupBox1.Controls)
                if (item is Label)
                {
                    try
                    {
                        int i = item.TabIndex;
                        item.Text += klienciTableRobocza.Rows[0][i].ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Nie wybrano Klienta");
                        return false;
                    }
                    
                }
            var zleceniaForm = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            string pelnaNazwaKlienta = klienciTable.GetNazwaKlienta(idKlientaint) + " " + klienciTable.GetFirma(idKlientaint);
            nrAktualnegoZlecenia = zleceniaForm.utworzNoweZlecenie(pelnaNazwaKlienta,idKlientaint);
            Debug.WriteLine("Aktualne Id:" + nrAktualnegoZlecenia);
            return true;
        }
        public void odzwierzDaneWtabeliProduktowDanegoKlientaiZlecenia()
        {
            dataGridView1.DataSource = ProduktyTable.GetProduktyIdKlientaIdZlecenia(int.Parse(nrAktualnegoZlecenia), idKlientaint);
        }

        private void wybranoWierszCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)  // ignore header row and any column
                return;
            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            Int32.TryParse(id, out selectedID);
            nazwaPBox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            iloscBox.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            JmCombo.SelectedItem = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            kolorBox.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            cenaJmBox.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            //do wywalenia debuging wybranego wiersza
            
            Debug.WriteLine("wybrany wiersz: " + selectedID);

        }

        private void usunButt_Click(object sender, EventArgs e)
        {
            int selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            
            if (selectedRowCount > 0&& selectedID>0)
            {
                DialogResult dialogResult = MessageBox.Show("Czy napewno usunąć?", "Usuń", MessageBoxButtons.YesNo);//tu mozna jescze dodac ikone okienka, po message box buttons
                if (dialogResult == DialogResult.Yes)
                {
                    string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    Int32.TryParse(id, out selectedID);
                    ProduktyTable.DeleteQueryProduktyTable(selectedID);
                    odzwierzDaneWtabeliProduktowDanegoKlientaiZlecenia();
                    foreach (Control item in this.Controls)
                        if (item is TextBox)
                        {
                            item.Text = "";
                        }
                }
                else if(dialogResult == DialogResult.No)
                {
                    odzwierzDaneWtabeliProduktowDanegoKlientaiZlecenia();
                    return;
                }
            }
            
        }

        private void edytujButt_Click(object sender, EventArgs e)
        {
            int selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selectedRowCount > 0 && selectedID > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Czy napewno zmienić?", "Edytuj", MessageBoxButtons.YesNo);//tu mozna jescze dodac ikone okienka, po message box buttons
                if (dialogResult == DialogResult.Yes)
                {
                    if (cenaJmBox.Text != null && iloscBox.Text != null)
                    {
                        string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                        Int32.TryParse(id, out selectedID);
                        string iloscPrzecinki = iloscBox.Text.Replace(".", ",");
                        decimal ilosc;
                        if (Decimal.TryParse(iloscPrzecinki, out ilosc)) { } else { MessageBox.Show("Błędna wartość Ilości", "Błąd"); return; }
                        string cenaPrzecinki = cenaJmBox.Text.Replace(".", ",");
                        decimal cenaJm;
                        if (Decimal.TryParse(cenaPrzecinki, out cenaJm)) { } else { MessageBox.Show("Błędna wartość CenaJm", "Błąd"); return; }
                        decimal cenaProduktu = ilosc * cenaJm;
                        decimal cenazVAT = (cenaProduktu * 23 / 100) + cenaProduktu;
                        produktyTableAdapter.UpdateQueryProdukty(nazwaPBox.Text, ilosc.ToString(), JmCombo.SelectedItem.ToString(), kolorBox.Text, cenaJm, cenaProduktu, int.Parse(nrAktualnegoZlecenia), idKlientaint,(decimal)cenazVAT,selectedID);
                        odzwierzDaneWtabeliProduktowDanegoKlientaiZlecenia();
                        foreach (Control item in this.Controls)
                            if (item is TextBox)
                            {
                                item.Text = "";
                            }

                    }
                    else
                    {
                        MessageBox.Show("Okna Ilość i Cena Jm nie mogą być puste", "Błąd");
                    }
                    
                    
                }
                else if (dialogResult == DialogResult.No)
                {
                    odzwierzDaneWtabeliProduktowDanegoKlientaiZlecenia();
                    return;
                }
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Debug.WriteLine("Liczba wierszy: " + dataGridView1.RowCount);
            if (dataGridView1.RowCount>0)
            {
                decimal SumaCalkowitaProduktow = (decimal)ProduktyTable.SumaCenyProduktowDanegoZlecenia(int.Parse(nrAktualnegoZlecenia));
                decimal cenaVAT = (SumaCalkowitaProduktow * 23 / 100) + SumaCalkowitaProduktow;
                Debug.WriteLine("Cena z VAT= " + cenaVAT);
                MalarniaDBDataSetTableAdapters.ZleceniaTableAdapter TabelaZlecenia = new MalarniaDBDataSetTableAdapters.ZleceniaTableAdapter();
                TabelaZlecenia.SetCenaZlecenia(SumaCalkowitaProduktow, int.Parse(nrAktualnegoZlecenia));
                TabelaZlecenia.SetCenaVAT((decimal)cenaVAT, int.Parse(nrAktualnegoZlecenia));
                
                var Form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
                Form1.OdswierzDaneWtabeli();
            }
            else
            {
                MalarniaDBDataSetTableAdapters.ZleceniaTableAdapter TabelaZlecenia = new MalarniaDBDataSetTableAdapters.ZleceniaTableAdapter();
                TabelaZlecenia.SetCenaZlecenia(0, int.Parse(nrAktualnegoZlecenia));
                TabelaZlecenia.SetCenaVAT(0, int.Parse(nrAktualnegoZlecenia));
                var Form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
                Form1.OdswierzDaneWtabeli();
            }
            
        }
    }
}
