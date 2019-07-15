using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace WindowsApplication1 {
    public partial class XtraReport1: DevExpress.XtraReports.UI.XtraReport {
        public XtraReport1() {
            InitializeComponent();
        }

        private void calculatedField1_GetValue(object sender,GetValueEventArgs e) {
            DetailItemClass currentRow = e.Row as DetailItemClass;
            List<ParentItemClass> ds = (List<ParentItemClass>)e.Report.DataSource;
            List<DetailItemClass> childRows = ds.Single(x => x.ItemID == currentRow.ParentID).DetailItems;
            e.Value = GetCurrentRowIndex(currentRow,childRows);
        }

        private int GetCurrentRowIndex(DetailItemClass row, List<DetailItemClass> rows) {
            int currentTimeStampIndex = 1;
            int numberOfFullRows = rows.Count / 3;
            int numberofAdditionalCells = rows.Count % 3;
            for(int i = 0; i < rows.Count; i++) {
                if(((TimeSpan)rows[i].TimeStamp) < row.TimeStamp) {
                    currentTimeStampIndex++;
                }
            }
            int columnIndex = 1;
            int cellsCount = 0;
            for(columnIndex = 1; columnIndex < 4; columnIndex++) {
                int currentColumnCellsCount = 0;
                if(columnIndex > numberofAdditionalCells) {
                    cellsCount += numberOfFullRows;
                    currentColumnCellsCount = numberOfFullRows;
                } else {
                    cellsCount += numberOfFullRows + 1;
                    currentColumnCellsCount = numberOfFullRows + 1;
                }
                if(currentTimeStampIndex <= cellsCount) {
                    int rowindex = currentTimeStampIndex - (cellsCount - currentColumnCellsCount);
                    return (rowindex - 1) * 3 + columnIndex;
                }
            }
            return -1;
        }

    }
}
