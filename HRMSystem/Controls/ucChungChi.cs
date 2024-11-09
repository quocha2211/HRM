using DevExpress.Xpo.DB.Helpers;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DocumentFormat.OpenXml.Spreadsheet;
using HRMSystem.Models;
using HRMSystem.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMSystem.Controls
{
    public partial class ucChungChi : DevExpress.XtraEditors.XtraUserControl
    {

        public event EventHandler BackButtonClick;
        public string MaCV;
        private BindingSource bindingSource = new BindingSource();
        public ucChungChi()
        {
            InitializeComponent();
        }

        private void InitializeDataBindings(ChungChi model)
        {
            bindingSource.DataSource = model;
            txtMaCC.DataBindings.Add("Text", bindingSource, nameof(ChungChi.MaCC));
            txtTenCC.DataBindings.Add("Text", bindingSource, nameof(ChungChi.TenCC));
            cbNhanVien.DataBindings.Add("EditValue", bindingSource, nameof(ChungChi.MaNV));
            dNgayCap.DataBindings.Add("Text", bindingSource, nameof(ChungChi.NgayCap));
            dNgayHetHan.DataBindings.Add("Text", bindingSource, nameof(ChungChi.NgayHetHan));
            txtNoiCap.DataBindings.Add("Text", bindingSource, nameof(ChungChi.NoiCap));
        }


        private async void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.ActiveControl = null;
                ChungChi model = (ChungChi)bindingSource.Current;
                if (model == null)
                {
                    MessageBox.Show("Lưu thất bại.");
                    return;
                }

                using (var context = new AppDbContext())
                {
                    context.ChungChis.AddOrUpdate(model);

                    context.SaveChanges();
                }

                MessageBox.Show("Thông tin đã được lưu thành công.");

            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "ucChungChiDetail", ex.ToString()); }
            
        }

        private void ucChungChiDetail_Load(object sender, EventArgs e)
        {
            try
            {
                List<GridColumnModel> lst = new List<GridColumnModel>();
                lst.Add(new GridColumnModel() { Name = "colMaNV", Caption = "Mã nhân viên", FieldName = "MaNV", Visible = false });
                lst.Add(new GridColumnModel() { Name = "colMaNV", Caption = "Ten nhân viên", FieldName = "TenNV", Visible = true });
                clsCommon.initialValue("NhanVien", "MaNV", "TenNV", cbNhanVienView, cbNhanVien, lst);
                if (string.IsNullOrEmpty(MaCV))
                {
                    InitializeDataBindings(new ChungChi());
                }
                else
                {
                    using (var context = new AppDbContext())
                    {
                        var model = context.ChungChis.Find(Convert.ToInt32( MaCV));
                        InitializeDataBindings(model);

                    }
                }

            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "ucChungChiDetail", ex.ToString()); }
        }

        private void btnBack_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BackButtonClick?.Invoke(sender, e);
        }
    }
}
