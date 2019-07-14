using DevExpress.XtraReports.UI;
using System;
using System.Windows.Forms;

namespace WindowsApplication1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e) {
            InitializeReport();
        }
        private void InitializeReport() {
            XtraReport1 report = new XtraReport1();
            report.DataSource = FillReportDataSource();
            ReportPrintTool tool = new ReportPrintTool(report);
            tool.ShowPreviewDialog();
        }
        object FillReportDataSource() {
            return new DemoDataSource().GetData();
        }
    }
}