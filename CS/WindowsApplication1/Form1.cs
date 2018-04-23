using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1 {
    public partial class Form1: Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender,EventArgs e) {
            DataSet1 ds = new DataSet1();
            ds.MasterTable.AddMasterTableRow("Row1",1);
            ds.MasterTable.AddMasterTableRow("Row2",2);
            ds.MasterTable.AddMasterTableRow("Row3",3);
            ds.MasterTable.AddMasterTableRow("Row4",4);
            ds.MasterTable.AddMasterTableRow("Row5",5);

            ds.ChildTable.Rows.Add(new object[] {TimeSpan.FromHours(8),10,1 });
            ds.ChildTable.Rows.Add(new object[] { TimeSpan.FromHours(8.5),11,1 });
            ds.ChildTable.Rows.Add(new object[] { TimeSpan.FromHours(9),12,1 });

            ds.ChildTable.Rows.Add(new object[] { TimeSpan.FromHours(8),10,2 });
            ds.ChildTable.Rows.Add(new object[] { TimeSpan.FromHours(8.5),11,2 });
            ds.ChildTable.Rows.Add(new object[] { TimeSpan.FromHours(9),12,2 });
            ds.ChildTable.Rows.Add(new object[] { TimeSpan.FromHours(9.5),13,2 });

            ds.ChildTable.Rows.Add(new object[] { TimeSpan.FromHours(8),10,3 });
            ds.ChildTable.Rows.Add(new object[] { TimeSpan.FromHours(8.5),11,3 });
            ds.ChildTable.Rows.Add(new object[] { TimeSpan.FromHours(9),12,3 });
            ds.ChildTable.Rows.Add(new object[] { TimeSpan.FromHours(9.5),13,3 });
            ds.ChildTable.Rows.Add(new object[] { TimeSpan.FromHours(10),13,3 });

            ds.ChildTable.Rows.Add(new object[] { TimeSpan.FromHours(8),10,4 });
            ds.ChildTable.Rows.Add(new object[] { TimeSpan.FromHours(8.5),11,4 });
            ds.ChildTable.Rows.Add(new object[] { TimeSpan.FromHours(9),12,4 });
            ds.ChildTable.Rows.Add(new object[] { TimeSpan.FromHours(9.5),13,4 });
            ds.ChildTable.Rows.Add(new object[] { TimeSpan.FromHours(10),13,4 });
            ds.ChildTable.Rows.Add(new object[] { TimeSpan.FromHours(10.5),13,4 });

            ds.ChildTable.Rows.Add(new object[] { TimeSpan.FromHours(8),10,5 });
            ds.ChildTable.Rows.Add(new object[] { TimeSpan.FromHours(8.5),11,5 });
            ds.ChildTable.Rows.Add(new object[] { TimeSpan.FromHours(9),12,5 });
            ds.ChildTable.Rows.Add(new object[] { TimeSpan.FromHours(9.5),13,5 });
            ds.ChildTable.Rows.Add(new object[] { TimeSpan.FromHours(10),13,5 });
            ds.ChildTable.Rows.Add(new object[] { TimeSpan.FromHours(10.5),13,5 });
            ds.ChildTable.Rows.Add(new object[] { TimeSpan.FromHours(11),13,5 });

            XtraReport1 report = new XtraReport1();
            report.DataSource = ds;
            report.ShowPreviewDialog();
        }
    }
}