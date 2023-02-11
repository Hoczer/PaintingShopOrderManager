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
    public partial class EdytujZlecenieForm : Form
    {
        public EdytujZlecenieForm()
        {
            InitializeComponent();
        }

        MalarniaDBDataSetTableAdapters.KlienciTableAdapter klienciTable = new MalarniaDBDataSetTableAdapters.KlienciTableAdapter();
        DataTable klienciTableRobocza = new DataTable();
        MalarniaDBDataSetTableAdapters.ProduktyTableAdapter ProduktyTable = new MalarniaDBDataSetTableAdapters.ProduktyTableAdapter();
        MalarniaDBDataSetTableAdapters.ZleceniaTableAdapter ZleceniaTable = new MalarniaDBDataSetTableAdapters.ZleceniaTableAdapter();
        int nrAktualnegoZlecenia;
        int idKlientaGlobal;

        int selectedID;
        private void EdytujZlecenieForm_Load(object sender, EventArgs e)
        {

            JmCombo.SelectedIndex = 1;



        }



        private void dodajButt_Click(object sender, EventArgs e)
        {
            if (cenaJmBox.Text != null && iloscBox.Text != null)
            {
                string iloscPrzecinki = iloscBox.Text.Replace(".", ",");
                Decimal ilosc;
                if (Decimal.TryParse(iloscPrzecinki, out ilosc)) { } else { MessageBox.Show("Błędna wartość Ilości", "Błąd"); return; }
                string cenaPrzecinki = cenaJmBox.Text.Replace(".", ",");
                decimal cenaJm;
                if (Decimal.TryParse(cenaPrzecinki, out cenaJm)) { } else { MessageBox.Show("Błędna wartość CenaJm", "Błąd"); return; }
                Decimal cenaProduktu = ilosc * cenaJm;
                decimal cenazVAT = (cenaProduktu * 23 / 100) + cenaProduktu;
                produktyTableAdapter.InsertQueryProdukty(nazwaPBox.Text, ilosc.ToString(), JmCombo.SelectedItem.ToString(), kolorBox.Text, cenaJm, cenaProduktu, nrAktualnegoZlecenia, idKlientaGlobal, (decimal)cenazVAT);
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
        /// <param name="idKlienta">Numer indeksu aktualnie klikniętego wiersza tabeli</param>
        /// <returns></returns>
        public void SetKlientaINrZlecenia(int? idKlienta, int idZlecenia)
        {
            int idKlientaInt = (int)idKlienta;
            klienciTableRobocza = klienciTable.GetKlienciTableWhereId(idKlientaInt);

            Debug.WriteLine("::TABLE::");



            Debug.WriteLine("::IDKlienta:: " + this.idKlientaGlobal);
            foreach (DataRow row in klienciTableRobocza.Rows)
            {
                Debug.WriteLine("ROW: {0}", string.Join(",", row.ItemArray));
            }

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
                        MessageBox.Show("Błąd");
                        return;
                    }

                }
            nrAktualnegoZlecenia = idZlecenia;
            idKlientaGlobal = idKlientaInt;
            odzwierzDaneWtabeliProduktowDanegoKlientaiZlecenia();
            WczytajDaneZleceniaDoTextBoxow(nrAktualnegoZlecenia);
            decimal? status = ZleceniaTable.GetStatus(nrAktualnegoZlecenia);
            if (status == 10)
            {
                statusBox.SelectedIndex = 2;
                Debug.WriteLine("status > 0:" + status);
                Debug.WriteLine(nrAktualnegoZlecenia);

            }
            else if (status == 5)
            {
                statusBox.SelectedIndex = 1;
            }
            else if (status == 0 || status == null)
            {
                statusBox.SelectedIndex = 0;
                Debug.WriteLine("status <0");
                Debug.WriteLine(nrAktualnegoZlecenia);
            }


        }
        public void odzwierzDaneWtabeliProduktowDanegoKlientaiZlecenia()
        {
            dataGridView1.DataSource = ProduktyTable.GetProduktyIdKlientaIdZlecenia(nrAktualnegoZlecenia, idKlientaGlobal);
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

            if (selectedRowCount > 0 && selectedID > 0)
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
                else if (dialogResult == DialogResult.No)
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
                        produktyTableAdapter.UpdateQueryProdukty(nazwaPBox.Text, ilosc.ToString(), JmCombo.SelectedItem.ToString(), kolorBox.Text, cenaJm, cenaProduktu, nrAktualnegoZlecenia, idKlientaGlobal, (decimal)cenazVAT, selectedID);
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
        private void WczytajDaneZleceniaDoTextBoxow(int nrZlecenia)
        {
            DataPrzyBox.Text = ZleceniaTable.GetDataPrzyjecia(nrZlecenia);

            decimal? status = ZleceniaTable.GetStatus(nrZlecenia);
            if (status == null || status <= 0)
            {
                statusBox.SelectedItem = "W trakcie.";
            }
            else
            {
                statusBox.SelectedItem = "Zakończono.";
            }
            DataZakBox.Text = ZleceniaTable.GetDataZakonczenia(nrZlecenia);
            NrZleceniaBox.Text = ZleceniaTable.GetNrZlecenia(nrZlecenia);

        }

        private void zmienButton_Click(object sender, EventArgs e)
        {
            decimal? status;
            if (statusBox.SelectedItem.ToString() == "Zakończono.")
            {
                status = 10;
            }
            else
            {
                status = 0;
            }
            ZleceniaTable.UpdateDataStatus(DataPrzyBox.Text, (decimal)status, DataZakBox.Text, NrZleceniaBox.Text, nrAktualnegoZlecenia);
            var Form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            Form1.OdswierzDaneWtabeli();
        }

        private void EdytujZlecenieForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Debug.WriteLine("Liczba wierszy: " + dataGridView1.RowCount);
            if (dataGridView1.RowCount > 0)
            {
                decimal SumaCalkowitaProduktow = (decimal)ProduktyTable.SumaCenyProduktowDanegoZlecenia(nrAktualnegoZlecenia);
                decimal cenaVAT = (SumaCalkowitaProduktow * 23 / 100) + SumaCalkowitaProduktow;
                Debug.WriteLine("Cena z VAT= " + cenaVAT);
                MalarniaDBDataSetTableAdapters.ZleceniaTableAdapter TabelaZlecenia = new MalarniaDBDataSetTableAdapters.ZleceniaTableAdapter();
                TabelaZlecenia.SetCenaZlecenia(SumaCalkowitaProduktow, nrAktualnegoZlecenia);
                TabelaZlecenia.SetCenaVAT((decimal)cenaVAT, nrAktualnegoZlecenia);

                var Form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
                Form1.SprawdzCzyByloCosWyszukiwane();
            }
            else
            {
                MalarniaDBDataSetTableAdapters.ZleceniaTableAdapter TabelaZlecenia = new MalarniaDBDataSetTableAdapters.ZleceniaTableAdapter();
                TabelaZlecenia.SetCenaZlecenia(0, nrAktualnegoZlecenia);
                TabelaZlecenia.SetCenaVAT(0, nrAktualnegoZlecenia);
                var Form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
                Form1.SprawdzCzyByloCosWyszukiwane();
            }
        }
    }
}
