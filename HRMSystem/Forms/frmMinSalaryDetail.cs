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
    public partial class frmMinSalaryDetail : DevExpress.XtraEditors.XtraForm
    {

        public event EventHandler BackButtonClick;
        public string MaMLTT;
        private BindingSource bindingSource = new BindingSource();
        public frmMinSalaryDetail()
        {
            InitializeComponent();
        }

        private void InitializeDataBindings(MinSalary model)
        {
            bindingSource.DataSource = model;
            dateEdit1.DataBindings.Add("Text", bindingSource, nameof(MinSalary.NgayAD));
            txtAdress.DataBindings.Add("Text", bindingSource, nameof(MinSalary.MLTTVung));
            txtLevel.DataBindings.Add("Text", bindingSource, nameof(MinSalary.MLTTC));
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.groupControl1.Focus();
                MinSalary model = (MinSalary)bindingSource.Current;
                if (model == null)
                {
                    MessageBox.Show("Lưu thất bại.");
                    return;
                }

                using (var context = new AppDbContext())
                {
                    context.MucLuongToiThieus.AddOrUpdate(model);

                    context.SaveChanges();
                }

                DialogResult = MessageBox.Show("Thông tin đã được lưu thành công.");

                this.Close();

            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "ucMucLuongToiThieuDetail", ex.ToString()); }

        }

        private void frmSalaryLevelDetail_Load(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(MaMLTT))
                {
                    InitializeDataBindings(new MinSalary());
                }
                else
                {
                    using (var context = new AppDbContext())
                    {
                        var model = context.MucLuongToiThieus.Find(Convert.ToInt32(MaMLTT));
                        InitializeDataBindings(model);

                    }
                }

            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "ucMucLuongToiThieuDetail", ex.ToString()); }
        }

        private void btnBack_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}