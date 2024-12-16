using DevExpress.XtraEditors;
using HRMSystem.Models;
using HRMSystem.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMSystem.Controls
{
    public partial class ucBaseDoubleList : DevExpress.XtraEditors.XtraUserControl
    {
        public event EventHandler AddButtonClick;
        public event EventHandler EditButtonClick;
        public event EventHandler DoubleButtonClick;
        public event EventHandler FocusRowChange;
        public event EventHandler DeleteButtonClick;
        public ucBaseDoubleList()
        {
            InitializeComponent();
        }
        public void SetTitle(string title)
        {
            lblTitle.Text = title;
        }
        public int getRowIndex()
        {
            return grvData.FocusedRowHandle;
        }

        public void setRowIndex(int idx)
        {
            grvData.FocusedRowHandle = idx;
        }

        public void SetDataSource(object dt, List<GridColumnModel> lstInitialGridColumn)
        {
            try
            {
                grvData.InitialGridColumn(lstInitialGridColumn);
                grdData.DataSource = dt;
                grvData.SetGridControlProperties();
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, this.Name, ex.ToString()); }
        }

        public void setDataDetail(object dt, List<GridColumnModel> lstInitialGridColumn)
        {
            try
            {
                gridView1.InitialGridColumn(lstInitialGridColumn);
                gridControl1.DataSource = dt;
                gridView1.SetGridControlProperties();
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, this.Name, ex.ToString()); }
        }
        public string GetPrimaryKey(string fieldName)
        {
            string pKey = "";
            try
            {
                pKey = clsCommon.ToString(grvData.GetFocusedRowCellValue(fieldName));
                return pKey;
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, this.Name, ex.ToString()); }
            return pKey;
        }
        public void SetSpecialGridProperties()
        {
            try
            {
                grvData.OptionsView.ColumnAutoWidth = false;
                grvData.BestFitColumns();
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, this.Name, ex.ToString()); }
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddButtonClick?.Invoke(sender, e);
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditButtonClick?.Invoke(sender, e);
        }

        private void grdData_DoubleClick(object sender, EventArgs e)
        {
            EditButtonClick?.Invoke(sender, e);
        }

        private void grdData_FocusedViewChanged(object sender, DevExpress.XtraGrid.ViewFocusEventArgs e)
        {

        }

        private void grvData_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            FocusRowChange?.Invoke(sender, e);
        }
    }
}
