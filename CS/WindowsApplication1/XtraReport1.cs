using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace WindowsApplication1 {
    public partial class XtraReport1: DevExpress.XtraReports.UI.XtraReport {
        public XtraReport1() {
            InitializeComponent();
        }

        private void calculatedField1_GetValue(object sender,GetValueEventArgs e) {
            WindowsApplication1.DataSet1.ChildTableRow row = ((DataRowView)e.Row).Row as WindowsApplication1.DataSet1.ChildTableRow;
            DataRow[] rows = row.MasterTableRow.GetChildRows("MasterTable_ChildTable");
            e.Value = GetCurrentRowIndex(row,rows);
        }

        private int GetCurrentRowIndex(DataSet1.ChildTableRow row,DataRow[] rows) {
            int currentTimeStampIndex = 1;
            int numberOfFullRows= rows.Length/3;
            int numberofAdditionalCells =rows.Length % 3;
            for(int i = 0;i < rows.Length;i++) {
                if(((TimeSpan)rows[i]["TimeStamp"]) < row.TimeStamp) {
                    currentTimeStampIndex++;
                }
            }
            int columnIndex = 1;
            int cellsCount=0;
            for(columnIndex = 1;columnIndex < 4;columnIndex++) {
                int currentColumnCellsCount = 0;
                if(columnIndex > numberofAdditionalCells) {
                    cellsCount += numberOfFullRows;
                    currentColumnCellsCount = numberOfFullRows;
                } else {
                    cellsCount += numberOfFullRows + 1;
                    currentColumnCellsCount = numberOfFullRows+1;
                }
                if(currentTimeStampIndex <= cellsCount) {
                    int rowindex = currentTimeStampIndex -(cellsCount - currentColumnCellsCount);
                    return (rowindex - 1) * 3 + columnIndex;
                }
            }
            return -1;
        }

    }
}
