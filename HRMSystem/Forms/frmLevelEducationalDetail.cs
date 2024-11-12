using DevExpress.XtraEditors;
using DocumentFormat.OpenXml.Office2010.Excel;
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
    public partial class frmLevelEducationalDetail : DevExpress.XtraEditors.XtraForm
    {
        public event EventHandler BackButtonClick;
        public string MaTDVH;
        private BindingSource bindingSource = new BindingSource();
        public frmLevelEducationalDetail()
        {
            InitializeComponent();
        }

        private void InitializeDataBindings(LevelEducational model)
        {
            bindingSource.DataSource = model;
            txtName.DataBindings.Add("Text", bindingSource, nameof(LevelEducational.TenTDVH));
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.groupControl1.Focus();
                LevelEducational model = (LevelEducational)bindingSource.Current;
                if (model == null)
                {
                    MessageBox.Show("Lưu thất bại.");
                    return;
                }

                using (var context = new AppDbContext())
                {
                    context.TrinhDoVanHoas.AddOrUpdate(model);

                    context.SaveChanges();
                }

                DialogResult = MessageBox.Show("Thông tin đã được lưu thành công.");

                this.Close();

            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "frmLevelEducationalDetail", ex.ToString()); }

        }

        private void frmSalaryLevelDetail_Load(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(MaTDVH))
                {
                    InitializeDataBindings(new LevelEducational());
                }
                else
                {
                    using (var context = new AppDbContext())
                    {
                        var model = context.TrinhDoVanHoas.Find(Convert.ToInt32(MaTDVH));
                        InitializeDataBindings(model);

                    }
                }

            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "frmLevelEducationalDetail", ex.ToString()); }
        }

        private void btnBack_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();

        }

     

    }
}