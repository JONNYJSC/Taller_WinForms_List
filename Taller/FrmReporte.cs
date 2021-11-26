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
using Taller.Clases;

namespace Taller
{
    public partial class FrmReporte : Form
    {
        List<Empleado> lista = Empleado.Empleados.ToList();
        public FrmReporte()
        {
            InitializeComponent();
        }

        private void FrmReporte_Load(object sender, EventArgs e)
        {
            reportViewer1.SetDisplayMode(DisplayMode.Normal);
            reportViewer1.ZoomMode = ZoomMode.PageWidth;

            this.reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", lista));
            this.reportViewer1.RefreshReport();
        }
    }
}
