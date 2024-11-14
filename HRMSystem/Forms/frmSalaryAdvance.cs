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
    public partial class frmSalaryAdvance : DevExpress.XtraEditors.XtraForm
    {
        public event EventHandler BackButtonClick;
        public string MaBTU;
        private BindingSource bindingSource = new BindingSource();

        public frmSalaryAdvance()
        {
            InitializeComponent();
        }


        private void InitializeDataBindings(SalaryAdvance model)
        {
            bindingSource.DataSource = model;
            txtThang.DataBindings.Add("Text", bindingSource, nameof(SalaryAdvance.Thang), true, DataSourceUpdateMode.OnPropertyChanged);
            txtStartDate.DataBindings.Add("Text", bindingSource, nameof(SalaryAdvance.NgayTU), true, DataSourceUpdateMode.OnPropertyChanged);
            txtNam.DataBindings.Add("Text", bindingSource, nameof(SalaryAdvance.Nam), true, DataSourceUpdateMode.OnPropertyChanged);
            txtSotien.DataBindings.Add("Text", bindingSource, nameof(SalaryAdvance.SoTienTU), true, DataSourceUpdateMode.OnPropertyChanged);
            txtDienGiai.DataBindings.Add("Text", bindingSource, nameof(SalaryAdvance.DienGiai), true, DataSourceUpdateMode.OnPropertyChanged);
            cboEmployee.DataBindings.Add("EditValue", bindingSource, nameof(SalaryAdvance.MaNV), true, DataSourceUpdateMode.OnPropertyChanged);
        }


        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.groupControl1.Focus();
                SalaryAdvance model = (SalaryAdvance)bindingSource.Current;
                if (model == null)
                {
                    MessageBox.Show("Lưu thất bại.");
                    return;
                }

                using (var context = new AppDbContext())
                {
                    context.BangTamUngs.AddOrUpdate(model);

                    context.SaveChanges();
                }

                DialogResult = MessageBox.Show("Thông tin đã được lưu thành công.");

                this.Close();

            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "ucChungChiDetail", ex.ToString()); }

        }


    

        private void frmSalaryAdvanceDetail_Load(object sender, EventArgs e)
        {
            try
            {
                clsCommon.initialValue("NhanVien", "MaNV", "TenNV", cboEmployeeView, cboEmployee, clsInitialGridColumn.InitialComboEmployee());
               
                if (string.IsNullOrEmpty(MaBTU))
                {
                    InitializeDataBindings(new SalaryAdvance());
                }
                else
                {
                    using (var context = new AppDbContext())
                    {
                        var model = context.BangTamUngs.Find(Convert.ToInt32(MaBTU));
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