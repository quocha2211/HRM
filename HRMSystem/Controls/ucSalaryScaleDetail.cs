using DevExpress.Xpo.DB.Helpers;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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
    public partial class ucSalaryScaleDetail : DevExpress.XtraEditors.XtraUserControl
    {

        public event EventHandler BackButtonClick;
        public string MaTL;
        private BindingSource bindingSource = new BindingSource();
        public ucSalaryScaleDetail()
        {
            InitializeComponent();
        }

        private void InitializeDataBindings(ThangLuong thangLuong)
        {
            bindingSource.DataSource = thangLuong;
            txtMaCM.DataBindings.Add("Text", bindingSource, nameof(ThangLuong.MaTL));
            txtTenCM.DataBindings.Add("Text", bindingSource, nameof(ThangLuong.TenTL));
            cbTDCM.DataBindings.Add("Text", bindingSource, nameof(ThangLuong.DienGiai), true, DataSourceUpdateMode.OnPropertyChanged);

        }

        private async void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.ActiveControl = null;
            ThangLuong thangLuong = (ThangLuong)bindingSource.Current;
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

            MessageBox.Show("Thông tin đã được lưu thành công.");
        }

        private void ucThangLuongDetail_Load(object sender, EventArgs e)
        {
            try
            {
                
               
                if (string.IsNullOrEmpty(MaTL))
                {
                    InitializeDataBindings(new ThangLuong());
                }
                else
                {
                    using (var context = new AppDbContext())
                    {
                        var thangLuong = context.ThangLuongs.Find( Convert.ToInt32(MaTL));
                        InitializeDataBindings(thangLuong);
                    }
                }

            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "ucEmployeeDetail", ex.ToString()); }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BackButtonClick?.Invoke(sender, e);
        }
    }
}
