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
    public partial class frmChungChi : DevExpress.XtraEditors.XtraForm
    {
        public event EventHandler BackButtonClick;
        public string MaCC;
        public int MaNV;
        private BindingSource bindingSource = new BindingSource();

        public frmChungChi()
        {
            InitializeComponent();
        }


        private void InitializeDataBindings(Certificate model)
        {
            bindingSource.DataSource = model;
            if (model.MaNV == null)
            {
                model.MaNV = MaNV;
            }
            txtNoiCap.DataBindings.Add("Text", bindingSource, nameof(Certificate.NoiCap), true, DataSourceUpdateMode.OnPropertyChanged);
            cboEmployee.DataBindings.Add("EditValue", bindingSource, nameof(Certificate.MaNV), true, DataSourceUpdateMode.OnPropertyChanged);
            txtNgayCap.DataBindings.Add("Text", bindingSource, nameof(Certificate.NgayCap), true, DataSourceUpdateMode.OnPropertyChanged);
            txtNgayHetHan.DataBindings.Add("Text", bindingSource, nameof(Certificate.NgayHetHan), true, DataSourceUpdateMode.OnPropertyChanged);
            txtName.DataBindings.Add("Text", bindingSource, nameof(Certificate.TenCC), true, DataSourceUpdateMode.OnPropertyChanged);
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
            catch (Exception ex) { MessageBox.Show("Lưu thất bại."); SQLiteHelper.SaveToLog(ex.Message, "ucChungChiDetail", ex.ToString()); }

        }




        private void frmEmployeeRankingDetail_Load(object sender, EventArgs e)
        {
            try
            {
                clsCommon.initialValue("NhanVien", "MaNV", "TenNV", cboEmployeeView, cboEmployee, clsInitialGridColumn.InitialComboEmployee());
                if (string.IsNullOrEmpty(MaCC))
                {
                    InitializeDataBindings(new Certificate());
                }
                else
                {
                    using (var context = new AppDbContext())
                    {
                        var model = context.ChungChis.Find(Convert.ToInt32(MaCC));

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