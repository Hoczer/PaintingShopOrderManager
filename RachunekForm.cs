using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Diagnostics;

namespace ZleceniaMalarnia
{
    public partial class RachunekForm : Form
    {
        public RachunekForm()
        {
            InitializeComponent();
        }

        private void RachunekForm_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            
        }
        public void utworzRachunek(int nrZlecenia)
        {

            MalarniaDBDataSetTableAdapters.KlienciTableAdapter klienciTable = new MalarniaDBDataSetTableAdapters.KlienciTableAdapter();
            MalarniaDBDataSetTableAdapters.ZleceniaTableAdapter zleceniaTable = new MalarniaDBDataSetTableAdapters.ZleceniaTableAdapter();
            int idKlienta = (int)zleceniaTable.getIdKlientaZlecenia(nrZlecenia);
            string NazwaKlienta = klienciTable.GetNazwaKlienta(idKlienta);
            string Firma = klienciTable.GetFirma(idKlienta);
            string Adres = klienciTable.GetAdres(idKlienta);
            string NIP = klienciTable.GetNip(idKlienta);
            decimal cena = (decimal)zleceniaTable.GetCena(nrZlecenia);
            string Cena = cena.ToString("0.##") + " zł";
            decimal cenazVat = (decimal)zleceniaTable.GetCenaVAT(nrZlecenia);
            string CenaVAT = cenazVat.ToString("0.##") + " zł";
            string dataWystawienia = zleceniaTable.GetDataZakonczenia(nrZlecenia);
            string nrZleceniaMiesiacznego = zleceniaTable.GetNrZlecenia(nrZlecenia);
            Debug.WriteLine(Cena);


            
            Microsoft.Reporting.WinForms.ReportParameter[] reportParameters = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pSuma",Cena),
                new ReportParameter("pNazwaKlienta",NazwaKlienta),
                new ReportParameter("pFirma",Firma),
                new ReportParameter("pNIP",NIP),
                new ReportParameter("pDataWystawienia",dataWystawienia),
                new ReportParameter("pAdres",Adres),
                new ReportParameter("pNrZlecenia",nrZleceniaMiesiacznego),
                new ReportParameter("pSumaBrutto",CenaVAT),
                new ReportParameter("pID",nrZlecenia.ToString())

            };
            reportViewer1.LocalReport.SetParameters(reportParameters);
            reportViewer1.RefreshReport();


        }
    }
}
