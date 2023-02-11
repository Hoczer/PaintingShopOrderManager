using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZleceniaMalarnia
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            
        }
        public  void UtworzRaport(string SumaCalkowita,string SumaZaplaconych, string SumaNieZaplaconych)
        {

            Microsoft.Reporting.WinForms.ReportParameter[] reportParameters = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pSumaCalkowita",SumaCalkowita),
                new ReportParameter("pSumaZaplaconych",SumaZaplaconych),
                new ReportParameter("pSumaNieZaplaconych",SumaNieZaplaconych),
                new ReportParameter("pData", DateTime.Now.ToString("dd/MM/yyyy"))
                

            };
            reportViewer1.LocalReport.SetParameters(reportParameters);
            reportViewer1.RefreshReport();
        }
    }
}
