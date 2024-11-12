using DevExpress.XtraEditors;
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

namespace HRMSystem.Forms
{
    public partial class frmCertificateDetail : DevExpress.XtraEditors.XtraForm
    {
        public event EventHandler BackButtonClick;
        public string MaCV;
        private BindingSource bindingSource = new BindingSource();

        public frmCertificateDetail()
        {
            InitializeComponent();
        }


        private void InitializeDataBindings(Certificate model)
        {
            bindingSource.DataSource = model;
            txtName.DataBindings.Add("Text", bindingSource, nameof(Certificate.TenCC));
            txtAddress.DataBindings.Add("Text", bindingSource, nameof(Certificate.NoiCap));
            txtStartDate.DataBindings.Add("Text", bindingSource, nameof(Certificate.NgayCap));
            txtEndDate.DataBindings.Add("Text", bindingSource, nameof(Certificate.NgayHetHan));
            cboEmployee.DataBindings.Add("EditValue", bindingSource, nameof(Certificate.MaNV), true, DataSourceUpdateMode.OnPropertyChanged);
        }


        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.groupControl1.Focus();
                Certificate model = (Certificate)bindingSource.Current;
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

                DialogResult = MessageBox.Show("Thông tin đã được lưu thành công.");

                this.Close();

            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "ucChungChiDetail", ex.ToString()); }

        }


    

        private void frmCertificateDetail_Load(object sender, EventArgs e)
        {
            try
            {
                List<GridColumnModel> lst = new List<GridColumnModel>();
                lst.Add(new GridColumnModel() { Name = "colMaNV", Caption = "Mã nhân viên", FieldName = "MaNV", Visible = false });
                lst.Add(new GridColumnModel() { Name = "colMaNV", Caption = "Tên nhân viên", FieldName = "TenNV", Visible = true });
                clsCommon.initialValue("NhanVien", "MaNV", "TenNV", cboEmployeeView, cboEmployee, lst);
                if (string.IsNullOrEmpty(MaCV))
                {
                    InitializeDataBindings(new Certificate());
                }
                else
                {
                    using (var context = new AppDbContext())
                    {
                        var model = context.ChungChis.Find(Convert.ToInt32(MaCV));
                        InitializeDataBindings(model);

                    }
                }

            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "ucChungChiDetail", ex.ToString()); }
        }

        private void btnBack_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}