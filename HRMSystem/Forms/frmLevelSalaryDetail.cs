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
    public partial class frmLevelSalaryDetail : DevExpress.XtraEditors.XtraForm
    {
        public string MaTL;
        private BindingSource bindingSource = new BindingSource();

        public frmLevelSalaryDetail()
        {
            InitializeComponent();
        }
  

        private void InitializeDataBindings(SalaryScale thangLuong)
        {
            bindingSource.DataSource = thangLuong;
            txtName.DataBindings.Add("Text", bindingSource, nameof(SalaryScale.TenTL));
            txtAddress.DataBindings.Add("Text", bindingSource, nameof(SalaryScale.DienGiai));

        }

        private async void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Focus();
            groupControl1.Focus();
            SalaryScale thangLuong = (SalaryScale)bindingSource.Current;
            if (thangLuong == null)
            {
                MessageBox.Show("Lưu thất bại.");
                return;
            }

            using (var context = new AppDbContext())
            {
                context.ThangLuongs.AddOrUpdate(thangLuong);

                await context.SaveChangesAsync();
            }
            
            DialogResult = MessageBox.Show("Thông tin đã được lưu thành công.");
            this.Close();
        }

        private void frmLevelSalaryDetail_Load(object sender, EventArgs e)
        {
            try
            {


                if (string.IsNullOrEmpty(MaTL))
                {
                    InitializeDataBindings(new SalaryScale());
                }
                else
                {
                    using (var context = new AppDbContext())
                    {
                        var thangLuong = context.ThangLuongs.Find(Convert.ToInt32(MaTL));
                        InitializeDataBindings(thangLuong);
                    }
                }

            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "ucEmployeeDetail", ex.ToString()); }
        }

        private void btnBack_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          DialogResult = DialogResult.OK;
          this.Close();
        }
    }
}