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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int selectedID;
        bool PrzyciskSzukaj = false;
        string SumaCalkowita = "pusty";
        string SumaZaplaconych = "pusty";
        string SumaNieZaplaconych = "pusty";

        MalarniaDBDataSetTableAdapters.ZleceniaTableAdapter TabelaZlecenia = new MalarniaDBDataSetTableAdapters.ZleceniaTableAdapter();
        MalarniaDBDataSetTableAdapters.ProduktyTableAdapter ProduktyTable = new MalarniaDBDataSetTableAdapters.ProduktyTableAdapter();
        private void Form1_Load(object sender, EventArgs e)
        {
            OdswierzDaneWtabeli();
            szukajCBox.SelectedIndex = 0;


        }

        private void noweZlButton_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.OpenForms["ListaKlientowForm"] as ListaKlientowForm != null)
            {
                MessageBox.Show("Zakończ wybór klienta");
                return;
            }


            if (System.Windows.Forms.Application.OpenForms["Form2"] as Form2 != null)
            {
                MessageBox.Show("Zakończ dodawanie nowych produktów");
                return;
            }
            if (System.Windows.Forms.Application.OpenForms["LKlientForm"] as LKlientForm != null)
            {
                MessageBox.Show("Zamknij listę klientów");
                return;
            }
            if (System.Windows.Forms.Application.OpenForms["Form2"] as Form2 == null && System.Windows.Forms.Application.OpenForms["ListaKlientowForm"] as ListaKlientowForm == null && System.Windows.Forms.Application.OpenForms["LKlientForm"] as LKlientForm == null)
            {
                var form3 = new ListaKlientowForm();
                form3.Show();
            }


        }
        public string utworzNoweZlecenie(string Klient, int idKlienta)
        {
            DateTime obecznyczas = DateTime.Now;
            zleceniaTableAdapter.InsertQueryZlecenia(Klient, obecznyczas.ToString(), 0, 0, "", idKlienta, NadajNrZlecenia());
            string ostatnieID = zleceniaTableAdapter.getOstatnieId().ToString();
            Debug.WriteLine("Aktualne Id FORM1:" + ostatnieID);
            //NadajNrZlecenia();

            return ostatnieID;
        }

        private void usunButton_Click(object sender, EventArgs e)
        {
            int selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selectedRowCount > 0 && selectedID > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Czy napewno usunąć?", "Usuń", MessageBoxButtons.YesNo);//tu mozna jescze dodac ikone okienka, po message box buttons
                if (dialogResult == DialogResult.Yes)
                {
                    string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    Int32.TryParse(id, out selectedID);
                    TabelaZlecenia.DeleteQueryZlecenia(selectedID);
                    ProduktyTable.DeleteQueryProduktyNrZlecenia(selectedID);
                    SprawdzCzyByloCosWyszukiwane();

                }
                else if (dialogResult == DialogResult.No)
                {
                    SprawdzCzyByloCosWyszukiwane();
                    return;
                }
            }
        }

        private void dataGridCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)  // ignore header row and any column
                return;
            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            Int32.TryParse(id, out selectedID);
        }

        private void EdytujZlecenieDoubleCellClickEvent(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)  // ignore header row and any column
                return;

            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            Int32.TryParse(id, out selectedID);
            int? idKlienta = TabelaZlecenia.getIdKlientaZlecenia(selectedID);
            Debug.WriteLine("idKlienta:" + idKlienta + "IdZlecenia" + selectedID);
            var EdytujZlecenieForm = new EdytujZlecenieForm();
            EdytujZlecenieForm.Show();
            var EdytujZlecenieOpenForm = Application.OpenForms.OfType<EdytujZlecenieForm>().FirstOrDefault();
            EdytujZlecenieOpenForm.SetKlientaINrZlecenia(idKlienta, selectedID);



        }
        public void OdswierzDaneWtabeli()
        {

            dataGridView1.DataSource = TabelaZlecenia.GetData();
            if (PrzyciskSzukaj)
            {
                dataGridView1.Sort(dataGridView1.Columns[5], ListSortDirection.Ascending);

            }
            else
            {
                dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Descending);

            }


            KolorujWiersze();

        }
        private void KolorujWiersze()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToInt32(row.Cells[5].Value) == 10)
                {
                    row.DefaultCellStyle.BackColor = Color.Green;
                }
                if (Convert.ToInt32(row.Cells[5].Value) == 5)
                {
                    row.DefaultCellStyle.BackColor = Color.Orange;
                }
            }
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            KolorujWiersze();
        }

        private void button1_Click(object sender, EventArgs e)//ListaKlientow Button
        {
            if (System.Windows.Forms.Application.OpenForms["LKlientForm"] as LKlientForm != null)
            {
                MessageBox.Show("Zamknij listę klientów");
                return;
            }
            if (System.Windows.Forms.Application.OpenForms["Form2"] as Form2 == null && System.Windows.Forms.Application.OpenForms["ListaKlientowForm"] as ListaKlientowForm == null && System.Windows.Forms.Application.OpenForms["LKlientForm"] as LKlientForm == null)
            {
                var Lkientow = new LKlientForm();
                Lkientow.Show();
            }

        }

        private void zakonczButton_Click(object sender, EventArgs e)
        {
            TabelaZlecenia.SetStatusZlecenia(10, selectedID);

            SprawdzCzyByloCosWyszukiwane();


        }

        private void trwaButton_Click(object sender, EventArgs e)
        {
            TabelaZlecenia.SetStatusZlecenia(0, selectedID);
            SprawdzCzyByloCosWyszukiwane();



        }

        private void WZButton_Click(object sender, EventArgs e)
        {
            if (selectedID > 0)
            {

                if (System.Windows.Forms.Application.OpenForms["Form4"] as Form4 != null)
                {
                    MessageBox.Show("Zamknij aktualna WZ");
                    return;
                }
                if (System.Windows.Forms.Application.OpenForms["Form2"] as Form2 == null && System.Windows.Forms.Application.OpenForms["ListaKlientowForm"] as ListaKlientowForm == null && System.Windows.Forms.Application.OpenForms["LKlientForm"] as LKlientForm == null)
                {
                    DateTime obecznyczas = DateTime.Now;
                    TabelaZlecenia.SetDataZakonczeniaZlecenia(obecznyczas.ToString(), selectedID);
                    SprawdzCzyByloCosWyszukiwane();
                    var form4 = new Form4();
                    form4.Show();
                    var wzForm = Application.OpenForms.OfType<Form4>().FirstOrDefault();
                    wzForm.utworzWZ(selectedID);
                }

            }



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (szukajCBox.SelectedItem.ToString() == "Klient")
            {
                dataGridView1.DataSource = TabelaZlecenia.GetDataBySzukajKlient('%' + textBox1.Text + '%');
                SumaCalkowita = TabelaZlecenia.GetSumaKlient('%' + textBox1.Text + '%').ToString();
                SumaZaplaconych = TabelaZlecenia.GetSumaKlientZaplacone('%' + textBox1.Text + '%').ToString();
                SumaNieZaplaconych = TabelaZlecenia.GetSumaKlientNieZaplaconych('%' + textBox1.Text + '%').ToString();
            }
            if (szukajCBox.SelectedItem.ToString() == "Data Przyjęcia")
            {
                dataGridView1.DataSource = TabelaZlecenia.GetSzukajDataPrzyjecia('%' + textBox1.Text + '%');
                SumaCalkowita = TabelaZlecenia.GetSumaDataPrzyjecia('%' + textBox1.Text + '%').ToString();
                SumaZaplaconych = TabelaZlecenia.GetSumaDataPrzyjeciaZaplacone('%' + textBox1.Text + '%').ToString();
                SumaNieZaplaconych = TabelaZlecenia.GetSumaDataPrzyjeciaNieZaplaconych('%' + textBox1.Text + '%').ToString();
            }
            if (szukajCBox.SelectedItem.ToString() == "Data Zakończenia")
            {
                dataGridView1.DataSource = TabelaZlecenia.GetSzukajDataZakonczenia('%' + textBox1.Text + '%');
                SumaCalkowita = TabelaZlecenia.GetSumaDataZakonczenia('%' + textBox1.Text + '%').ToString();
                SumaZaplaconych = TabelaZlecenia.GetSumaDataZakonczeniaZaplacone('%' + textBox1.Text + '%').ToString();
                SumaNieZaplaconych = TabelaZlecenia.GetSumaDataZakonczeniaNieZaplaconych('%' + textBox1.Text + '%').ToString();
            }
            if (szukajCBox.SelectedItem.ToString() == "ID")
            {
                int ID;
                if (Int32.TryParse(textBox1.Text, out ID))
                {
                    dataGridView1.DataSource = TabelaZlecenia.GetSzukajID(ID);
                }


            }
            if (szukajCBox.SelectedItem.ToString() == "Nr Zlecenia")
            {
                dataGridView1.DataSource = TabelaZlecenia.GetSzukajNrZlecenia('%' + textBox1.Text + '%');
                SumaCalkowita = TabelaZlecenia.GetSumaNrZlecenia('%' + textBox1.Text + '%').ToString();
                SumaZaplaconych = TabelaZlecenia.GetSumaNrZleceniaZaplacone('%' + textBox1.Text + '%').ToString();
                SumaNieZaplaconych = TabelaZlecenia.GetSumaNrZleceniaNieZaplaconych('%' + textBox1.Text + '%').ToString();
            }

            if (String.IsNullOrWhiteSpace(textBox1.Text))
            {
                OdswierzDaneWtabeli();
            }
            SzukajNieZaplaconychOnOff(false);
            KolorujWiersze();
        }

        private void rachunekButton_Click(object sender, EventArgs e)
        {
            if (selectedID > 0)
            {
                if (System.Windows.Forms.Application.OpenForms["RachunekForm"] as RachunekForm != null)
                {
                    MessageBox.Show("Zamknij aktualny Rachunek");
                    return;
                }
                if (System.Windows.Forms.Application.OpenForms["Form2"] as Form2 == null && System.Windows.Forms.Application.OpenForms["ListaKlientowForm"] as ListaKlientowForm == null && System.Windows.Forms.Application.OpenForms["LKlientForm"] as LKlientForm == null)
                {
                    DateTime obecznyczas = DateTime.Now;
                    TabelaZlecenia.SetDataZakonczeniaZlecenia(obecznyczas.ToString(), selectedID);
                    SprawdzCzyByloCosWyszukiwane();
                    var rachunekForm = new RachunekForm();
                    rachunekForm.Show();
                    var rachunekForm1 = Application.OpenForms.OfType<RachunekForm>().FirstOrDefault();
                    rachunekForm.utworzRachunek(selectedID);
                }

            }
        }

        private string NadajNrZlecenia()
        {

            string rok = DateTime.Now.Year.ToString();
            string miesiac = DateTime.Now.Month.ToString();
            Debug.WriteLine("Czas Rok i Miesiac: " + rok + miesiac);
            int? LiczbaZlecen = zleceniaTableAdapter.CountNrZlecenia('%' + rok + "/" + miesiac + '%');
            Debug.WriteLine("Liczba zlecen pierwsze sprawdzenie: " + LiczbaZlecen);
            if (LiczbaZlecen == 0 || LiczbaZlecen == null)
            {
                string nrZlecenia = "ZL/" + rok + "/" + miesiac + "/1";
                Debug.WriteLine("Brak innych zlecen: " + nrZlecenia);
                return nrZlecenia;
                //zleceniaTableAdapter.InsertNRZlecenia("ZL/" + rok + "/" + miesiac + "/1");
            }
            else
            {

                string NrZlecenia = "ZL/" + rok + "/" + miesiac + "/" + LiczbaZlecen;
                Debug.WriteLine("Liczba zlecen wieksza od 0 i nie null: " + LiczbaZlecen);
                //zleceniaTableAdapter.InsertNRZlecenia(NrZlecenia);
                int? licznik = zleceniaTableAdapter.CountNrZlecenia('%' + NrZlecenia + '%');
                int? tester = LiczbaZlecen;
                while (licznik >= 1)
                {
                    Debug.WriteLine("Pętla ucruchomiona: " + tester);
                    tester++;
                    NrZlecenia = "ZL/" + rok + "/" + miesiac + "/" + tester;
                    //zleceniaTableAdapter.InsertNRZlecenia(NrZlecenia);
                    licznik = zleceniaTableAdapter.CountNrZlecenia('%' + NrZlecenia + '%');


                }
                return NrZlecenia;
            }
        }

        private void SzukajNiezaplaconychButton_Click(object sender, EventArgs e)
        {
            if (!PrzyciskSzukaj)
            {
                SzukajNieZaplaconychOnOff(true);
                KolorujWiersze();
            }
            else
            {
                SzukajNieZaplaconychOnOff(false);
                SprawdzCzyByloCosWyszukiwane();
            }


        }

        private void fakturaButton_Click(object sender, EventArgs e)
        {
            TabelaZlecenia.SetStatusZlecenia(5, selectedID);

            SprawdzCzyByloCosWyszukiwane();
        }
        public void SprawdzCzyByloCosWyszukiwane()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                OdswierzDaneWtabeli();
            }
            else
            {
                //OdswierzDaneWtabeli();
                if (szukajCBox.SelectedItem.ToString() == "Klient")
                {
                    dataGridView1.DataSource = TabelaZlecenia.GetDataBySzukajKlient('%' + textBox1.Text + '%');
                    SumaCalkowita = TabelaZlecenia.GetSumaKlient('%' + textBox1.Text + '%').ToString();
                    SumaZaplaconych = TabelaZlecenia.GetSumaKlientZaplacone('%' + textBox1.Text + '%').ToString();
                    SumaNieZaplaconych = TabelaZlecenia.GetSumaKlientNieZaplaconych('%' + textBox1.Text + '%').ToString();
                }
                if (szukajCBox.SelectedItem.ToString() == "Data Przyjęcia")
                {
                    dataGridView1.DataSource = TabelaZlecenia.GetSzukajDataPrzyjecia('%' + textBox1.Text + '%');
                    SumaCalkowita = TabelaZlecenia.GetSumaDataPrzyjecia('%' + textBox1.Text + '%').ToString();
                    SumaZaplaconych = TabelaZlecenia.GetSumaDataPrzyjeciaZaplacone('%' + textBox1.Text + '%').ToString();
                    SumaNieZaplaconych = TabelaZlecenia.GetSumaDataPrzyjeciaNieZaplaconych('%' + textBox1.Text + '%').ToString();
                }
                if (szukajCBox.SelectedItem.ToString() == "Data Zakończenia")
                {
                    dataGridView1.DataSource = TabelaZlecenia.GetSzukajDataZakonczenia('%' + textBox1.Text + '%');
                    SumaCalkowita = TabelaZlecenia.GetSumaDataZakonczenia('%' + textBox1.Text + '%').ToString();
                    SumaZaplaconych = TabelaZlecenia.GetSumaDataZakonczeniaZaplacone('%' + textBox1.Text + '%').ToString();
                    SumaNieZaplaconych = TabelaZlecenia.GetSumaDataZakonczeniaNieZaplaconych('%' + textBox1.Text + '%').ToString();
                }
                if (szukajCBox.SelectedItem.ToString() == "ID")
                {
                    int ID;
                    if (Int32.TryParse(textBox1.Text, out ID))
                    {
                        dataGridView1.DataSource = TabelaZlecenia.GetSzukajID(ID);
                    }


                }
                if (szukajCBox.SelectedItem.ToString() == "Nr Zlecenia")
                {
                    dataGridView1.DataSource = TabelaZlecenia.GetSzukajNrZlecenia('%' + textBox1.Text + '%');
                    SumaCalkowita = TabelaZlecenia.GetSumaNrZlecenia('%' + textBox1.Text + '%').ToString();
                    SumaZaplaconych = TabelaZlecenia.GetSumaNrZleceniaZaplacone('%' + textBox1.Text + '%').ToString();
                    SumaNieZaplaconych = TabelaZlecenia.GetSumaNrZleceniaNieZaplaconych('%' + textBox1.Text + '%').ToString();
                }
                if (PrzyciskSzukaj)
                {
                    dataGridView1.Sort(dataGridView1.Columns[5], ListSortDirection.Ascending);
                    KolorujWiersze();
                }
                else
                {
                    dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Descending);
                    KolorujWiersze();
                }


            }
        }

        private void raportButton_Click(object sender, EventArgs e)
        {
            if (selectedID > 0)
            {
                if (System.Windows.Forms.Application.OpenForms["Form5"] as Form5 != null)
                {
                    MessageBox.Show("Zamknij aktualny Raport");
                    return;
                }
                if (System.Windows.Forms.Application.OpenForms["Form2"] as Form2 == null && System.Windows.Forms.Application.OpenForms["ListaKlientowForm"] as ListaKlientowForm == null && System.Windows.Forms.Application.OpenForms["LKlientForm"] as LKlientForm == null)
                {
                    if (string.IsNullOrWhiteSpace(textBox1.Text))
                    {
                        SumaCalkowita = TabelaZlecenia.GetSumaWszystkichZlecen().ToString();
                        SumaNieZaplaconych = TabelaZlecenia.GetSumaWszystkichZleNieZaplaconych().ToString();
                        SumaZaplaconych = TabelaZlecenia.GetSumaWszystkichZleZaplaconych().ToString();
                    }
                    var form5 = new Form5();
                    form5.Show();
                    var form5Open = Application.OpenForms.OfType<Form5>().FirstOrDefault();
                    form5Open.UtworzRaport(SumaCalkowita, SumaZaplaconych, SumaNieZaplaconych);
                }

            }

        }
        private void SzukajNieZaplaconychOnOff(bool wlacz)
        {
            if (wlacz)
            {
                dataGridView1.Sort(dataGridView1.Columns[5], ListSortDirection.Ascending);
                SzukajNiezaplaconychButton.Image = Properties.Resources.szukajWcisniete;
                PrzyciskSzukaj = true;
            }
            else if (!wlacz)
            {
                SzukajNiezaplaconychButton.Image = Properties.Resources.szukajOff;
                dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Descending);
                PrzyciskSzukaj = false;
            }
        }
    }
}
