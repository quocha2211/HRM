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
    public partial class ucDepartmentDetail : DevExpress.XtraEditors.XtraUserControl
    {

        public event EventHandler BackButtonClick;
        public string MaPB;
        private BindingSource bindingSource = new BindingSource();
        public ucDepartmentDetail()
        {
            InitializeComponent();
        }

        private void InitializeDataBindings(PhongBan phongBan)
        {
            bindingSource.DataSource = phongBan;
            txtMaCM.DataBindings.Add("Text", bindingSource, nameof(PhongBan.MaPB));
            txtTenPB.DataBindings.Add("Text", bindingSource, nameof(PhongBan.TenPB));
            txtCapDo.DataBindings.Add("Text", bindingSource, nameof(PhongBan.CapDo));
            txtNu.DataBindings.Add("EditValue", bindingSource, nameof(PhongBan.DoTuoiVeHuuNu));
            txtNam.DataBindings.Add("EditValue", bindingSource, nameof(PhongBan.DoTuoiVeHuuNam));

        }
        

        private async void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.ActiveControl = null;
                PhongBan phongBan = (PhongBan)bindingSource.Current;
                if (phongBan == null)
                {
                    return;
                }

                using (var context = new AppDbContext())
                {
                    context.PhongBans.AddOrUpdate(phongBan);

                    context.SaveChanges();
                }

                MessageBox.Show("Thông tin nhân viên đã được lưu thành công.");

            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "ucPhongBanDetail", ex.ToString()); }
            
        }

        private void ucPhongBanDetail_Load(object sender, EventArgs e)
        {
            try
            {
                //clsCommon.initialValue("TrinhDoChuyenMon", "MaTDCM", "TenTDCM", cbTDCMView, cbTDCM, clsInitialGridColumn.InitialDepartment());
                if (string.IsNullOrEmpty(MaPB))
                {
                    InitializeDataBindings(new PhongBan());
                }
                else
                {
                    using (var context = new AppDbContext())
                    {
                        var phongBan = context.PhongBans.Find(Convert.ToInt32( MaPB));
                        InitializeDataBindings(phongBan);

                    }
                }

            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "ucPhongBanDetail", ex.ToString()); }
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
