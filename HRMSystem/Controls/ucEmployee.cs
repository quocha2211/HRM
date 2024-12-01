using DevExpress.XtraEditors;
using HRMSystem.Forms;
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
    public partial class ucEmployee : DevExpress.XtraEditors.XtraUserControl
    {
        public event EventHandler AddButtonClick;
        public event EventHandler EditButtonClick;
        public event EventHandler DeleteButtonClick;
        public event EventHandler ReLoadButtonClick;
        public ucEmployee()
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

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xoá không ?", "Câu hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                DeleteButtonClick?.Invoke(sender, e);
            }

        }

        private void btnLoad_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ReLoadButtonClick?.Invoke(sender, e);

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmCongTac frm = new frmCongTac() { Dock = DockStyle.Fill };
                frm.MaNV = Convert.ToInt32(this.GetPrimaryKey("MaNV"));
                frm.MaCCT = "";
                frm.MaCV = Convert.ToInt32(this.GetPrimaryKey("MaChucVu"));
                var rs = frm.ShowDialog();
                if (rs == DialogResult.OK)
                {
                    
                }
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "SalaryScaleController", ex.ToString()); }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmDaoTao frm = new frmDaoTao() { Dock = DockStyle.Fill };
                frm.MaNV = Convert.ToInt32(this.GetPrimaryKey("MaNV"));
                frm.MaQTDT = "";
                frm.MaCV = Convert.ToInt32(this.GetPrimaryKey("MaChucVu"));
                var rs = frm.ShowDialog();
                if (rs == DialogResult.OK)
                {

                }
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "SalaryScaleController", ex.ToString()); }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmKhenThuongKyLuat frm = new frmKhenThuongKyLuat() { Dock = DockStyle.Fill };
                frm.MaNV = Convert.ToInt32(this.GetPrimaryKey("MaNV"));
                frm.MaKTKL = "";
                var rs = frm.ShowDialog();
                if (rs == DialogResult.OK)
                {

                }
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "SalaryScaleController", ex.ToString()); }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmContract frm = new frmContract() { Dock = DockStyle.Fill };
                frm.MaNV = Convert.ToInt32(this.GetPrimaryKey("MaNV"));
                frm.MaHD = "";
                frm.MaCV = Convert.ToInt32(this.GetPrimaryKey("MaChucVu"));
                var rs = frm.ShowDialog();
                if (rs == DialogResult.OK)
                {

                }
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "SalaryScaleController", ex.ToString()); }
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmThanNhan frm = new frmThanNhan() { Dock = DockStyle.Fill };
                frm.MaNV = Convert.ToInt32(this.GetPrimaryKey("MaNV"));
                var rs = frm.ShowDialog();
                if (rs == DialogResult.OK)
                {

                }
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "SalaryScaleController", ex.ToString()); }
        }
    }
}
