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
    public partial class ucExpertiseDetail : DevExpress.XtraEditors.XtraUserControl
    {

        public event EventHandler BackButtonClick;
        public string MaCM;
        private BindingSource bindingSource = new BindingSource();
        public ucExpertiseDetail()
        {
            InitializeComponent();
        }

        private void InitializeDataBindings(Expertise chuyenmon)
        {
            bindingSource.DataSource = chuyenmon;
            txtMaCM.DataBindings.Add("Text", bindingSource, nameof(Expertise.MaCM));
            txtTenCM.DataBindings.Add("Text", bindingSource, nameof(Expertise.TenCM));
            cbTDCM.DataBindings.Add("Text", bindingSource, nameof(Expertise.MaTDCM), true, DataSourceUpdateMode.OnPropertyChanged);

        }
        

        private async void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                Expertise chuyenmon = (Expertise)bindingSource.Current;
                if (chuyenmon == null)
                {
                    return;
                }

                using (var context = new AppDbContext())
                {
                    context.ChuyenMons.AddOrUpdate(chuyenmon);

                    context.SaveChanges();
                }

                MessageBox.Show("Thông tin nhân viên đã được lưu thành công.");

            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "ucExpertiseDetail", ex.ToString()); }
            
        }

        private void ucExpertiseDetail_Load(object sender, EventArgs e)
        {
            try
            {
                clsCommon.initialValue("TrinhDoChuyenMon", "MaTDCM", "TenTDCM", cbTDCMView, cbTDCM, clsInitialGridColumn.InitialExpertise());
                if (string.IsNullOrEmpty(MaCM))
                {
                    InitializeDataBindings(new Expertise());
                }
                else
                {
                    using (var context = new AppDbContext())
                    {
                        var chuyenMon = context.ChuyenMons.Find(Convert.ToInt32( MaCM));
                        InitializeDataBindings(chuyenMon);

                    }
                }

            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "ucExpertiseDetail", ex.ToString()); }
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
