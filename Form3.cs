using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ZleceniaMalarnia
{
    public partial class ListaKlientowForm : Form
    {
        public ListaKlientowForm()
        {
            InitializeComponent();
        }
        int selectedID;
        MalarniaDBDataSetTableAdapters.KlienciTableAdapter klienciTable = new MalarniaDBDataSetTableAdapters.KlienciTableAdapter();
        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'malarniaDBDataSet.Klienci' . Możesz go przenieść lub usunąć.
            this.klienciTableAdapter.Fill(this.malarniaDBDataSet.Klienci);
            szukajCBox.SelectedIndex = 0;

        }

        private void zapiszButt_Click(object sender, EventArgs e)
        {
            klienciTable.InsertQueryKlienci(klientBox.Text, firmaBox.Text,adresText.Text, nipBox.Text, telefonBox.Text);
            this.klienciTableAdapter.Fill(this.malarniaDBDataSet.Klienci);

            foreach (Control item in panel1.Controls)
                if (item is TextBox)
                {
                    item.Text = "";
                }


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)  // ignore header row and any column
                return;
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            Debug.WriteLine("rowIndex =" + rowIndex);
            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            Int32.TryParse(id, out selectedID);
            klientBox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            firmaBox.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            adresText.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            nipBox.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            telefonBox.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void zmienButt_Click(object sender, EventArgs e)
        {
            int selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selectedRowCount > 0 && selectedID > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Czy napewno zmienić?", "Edytuj", MessageBoxButtons.YesNo);//tu mozna jescze dodac ikone okienka, po message box buttons
                if (dialogResult == DialogResult.Yes)
                {
                    string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    Int32.TryParse(id, out selectedID);
                    klienciTable.UpdateQueryKlienci(klientBox.Text, firmaBox.Text,adresText.Text, nipBox.Text, telefonBox.Text, selectedID);
                    this.klienciTableAdapter.Fill(this.malarniaDBDataSet.Klienci);
                    foreach (Control item in panel1.Controls)
                        if (item is TextBox)
                        {
                            item.Text = "";
                        }
                }
                else if (dialogResult == DialogResult.No)
                {
                    this.klienciTableAdapter.Fill(this.malarniaDBDataSet.Klienci);
                    return;
                }
            }
            

        }

        private void usuńButton_Click(object sender, EventArgs e)
        {
            int selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selectedRowCount > 0 && selectedID > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Czy napewno usunąć?", "Usuń", MessageBoxButtons.YesNo);//tu mozna jescze dodac ikone okienka, po message box buttons
                if (dialogResult == DialogResult.Yes)
                {
                    string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    Int32.TryParse(id, out selectedID);
                    klienciTable.DeleteQueryKlienci(selectedID);
                    this.klienciTableAdapter.Fill(this.malarniaDBDataSet.Klienci);
                    foreach (Control item in panel1.Controls)
                        if (item is TextBox)
                        {
                            item.Text = "";
                        }
                }
                else if (dialogResult == DialogResult.No)
                {
                    this.klienciTableAdapter.Fill(this.malarniaDBDataSet.Klienci);
                    return;
                }
            }
           
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (szukajCBox.SelectedItem.ToString() == "Klient")
            {
                dataGridView1.DataSource = klienciTable.GetSzukajKlient('%' + textBox1.Text + '%');
            }
            if (szukajCBox.SelectedItem.ToString() == "Firma")
            {
                dataGridView1.DataSource = klienciTable.GetSzukajFirma('%' + textBox1.Text + '%');
            }
            if (szukajCBox.SelectedItem.ToString() == "NIP")
            {
                dataGridView1.DataSource = klienciTable.GetSzukajNIP('%' + textBox1.Text + '%');
            }
            if (szukajCBox.SelectedItem.ToString() == "Telefon")
            {
                dataGridView1.DataSource = klienciTable.GetSzukajTelefon('%' + textBox1.Text + '%');
            }
        }

        private void wybranoKlientaEvent(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)  // ignore header row and any column
                return;
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            Debug.WriteLine("rowIndex =" + rowIndex);
            
            if (rowIndex>=0)
            {
                var form2 = new Form2();
                form2.Show();


                var listaKlientowForm = Application.OpenForms.OfType<Form2>().FirstOrDefault();

                if (listaKlientowForm.aktywujKlienta(selectedID))
                {
                    this.Close();
                }
                else
                {
                    form2.Close();
                }
            }
           
            

            


        }
    }
}
