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
    public partial class ucDutyDetail : DevExpress.XtraEditors.XtraUserControl
    {

        public event EventHandler BackButtonClick;
        public string MaCV;
        private BindingSource bindingSource = new BindingSource();
        public ucDutyDetail()
        {
            InitializeComponent();
        }

        private void InitializeDataBindings(ChucVu model)
        {
            bindingSource.DataSource = model;
            txtMaCM.DataBindings.Add("Text", bindingSource, nameof(ChucVu.MaChucVu));
            txtTenPB.DataBindings.Add("Text", bindingSource, nameof(ChucVu.TenChucVu));
            txtCapDo.DataBindings.Add("Text", bindingSource, nameof(ChucVu.CapDo));
            txtNu.DataBindings.Add("EditValue", bindingSource, nameof(ChucVu.HeSoChucDanh));

        }
        

        private async void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.ActiveControl = null;
                ChucVu model = (ChucVu)bindingSource.Current;
                if (model == null)
                {
                    MessageBox.Show("Lưu thất bại.");
                    return;
                }

                using (var context = new AppDbContext())
                {
                    context.ChucVus.AddOrUpdate(model);

                    context.SaveChanges();
                }

                MessageBox.Show("Thông tin đã được lưu thành công.");

            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "ucChucVuDetail", ex.ToString()); }
            
        }

        private void ucChucVuDetail_Load(object sender, EventArgs e)
        {
            try
            {
                //clsCommon.initialValue("TrinhDoChuyenMon", "MaTDCM", "TenTDCM", cbTDCMView, cbTDCM, clsInitialGridColumn.InitialDepartment());
                if (string.IsNullOrEmpty(MaCV))
                {
                    InitializeDataBindings(new ChucVu());
                }
                else
                {
                    using (var context = new AppDbContext())
                    {
                        var model = context.ChucVus.Find(Convert.ToInt32( MaCV));
                        InitializeDataBindings(model);

                    }
                }

            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "ucChucVuDetail", ex.ToString()); }
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
