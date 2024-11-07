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
    public partial class ucBaseSingleList : DevExpress.XtraEditors.XtraUserControl
    {
        public event EventHandler AddButtonClick;
        public event EventHandler EditButtonClick;
        public ucBaseSingleList()
        {
            InitializeComponent();
        }
        public void SetTitle(string title)
        {
            lblTitle.Text = title;
        }
        public void SetDataSource(DataTable dt, List<GridColumnModel> lstInitialGridColumn)
        {
            try
            {
                grvData.InitialGridColumn(lstInitialGridColumn);
                grdData.DataSource = dt;
                grvData.SetGridControlProperties();
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
    }
}
