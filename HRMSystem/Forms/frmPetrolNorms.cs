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
    public partial class frmPetrolNorms : DevExpress.XtraEditors.XtraForm
    {
        public event EventHandler BackButtonClick;
        public string MaDMXX;
        private BindingSource bindingSource = new BindingSource();

        public frmPetrolNorms()
        {
            InitializeComponent();
        }


        private void InitializeDataBindings(DinhMucXangXe model)
        {
            bindingSource.DataSource = model;
            txtName.DataBindings.Add("Text", bindingSource, nameof(DinhMucXangXe.TenPTien));
            txtLevel.DataBindings.Add("Text", bindingSource, nameof(DinhMucXangXe.DMXX));
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.groupControl1.Focus();
                DinhMucXangXe model = (DinhMucXangXe)bindingSource.Current;
                if (model == null)
                {
                    MessageBox.Show("Lưu thất bại.");
                    return;
                }

                using (var context = new AppDbContext())
                {
                    context.DinhMucXangXes.AddOrUpdate(model);

                    context.SaveChanges();
                }

                DialogResult = MessageBox.Show("Thông tin đã được lưu thành công.");

                this.Close();

            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "ucDinhMucXangXeDetail", ex.ToString()); }

        }

        private void frmPetrolNorms_Load(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(MaDMXX))
                {
                    InitializeDataBindings(new DinhMucXangXe());
                }
                else
                {
                    using (var context = new AppDbContext())
                    {
                        var model = context.DinhMucXangXes.Find(Convert.ToInt32(MaDMXX));
                        InitializeDataBindings(model);

                    }
                }

            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "ucDinhMucXangXeDetail", ex.ToString()); }
        }

        private void btnBack_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}