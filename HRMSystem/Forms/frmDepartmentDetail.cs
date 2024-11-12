using HRMSystem.Models;
using HRMSystem.Utilities;
using System;
using System.Data.Entity.Migrations;
using System.Windows.Forms;

namespace HRMSystem.Forms
{
    public partial class frmDepartmentDetail : DevExpress.XtraEditors.XtraForm
    {

        public event EventHandler BackButtonClick;
        public string MaPB;
        private BindingSource bindingSource = new BindingSource();

        public frmDepartmentDetail()
        {
            InitializeComponent();
        }

        private void InitializeDataBindings(PhongBan phongBan)
        {
            bindingSource.DataSource = phongBan;
            txtName.DataBindings.Add("Text", bindingSource, nameof(PhongBan.TenPB));
            txtLevel.DataBindings.Add("EditValue", bindingSource, nameof(PhongBan.CapDo));
            txtFemale.DataBindings.Add("EditValue", bindingSource, nameof(PhongBan.DoTuoiVeHuuNu));
            txtMale.DataBindings.Add("EditValue", bindingSource, nameof(PhongBan.DoTuoiVeHuuNam));

        }


        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.groupControl1.Focus();
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

                DialogResult = MessageBox.Show("Thông tin đã được lưu thành công.");

                this.Close();
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
                        var phongBan = context.PhongBans.Find(Convert.ToInt32(MaPB));
                        InitializeDataBindings(phongBan);

                    }
                }

            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "ucPhongBanDetail", ex.ToString()); }
        }

        private void btnBack_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}