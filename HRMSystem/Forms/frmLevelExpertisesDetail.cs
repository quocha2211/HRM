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
    public partial class frmLevelExpertisesDetail : DevExpress.XtraEditors.XtraForm
    {

        public event EventHandler BackButtonClick;
        public string MaCM;
        public int screenIndex = 0;
        public LevelExpertise levelExpertise;
        public LevelLanguage levelLanguage;
        private BindingSource bindingSource = new BindingSource();

        public frmLevelExpertisesDetail()
        {
            InitializeComponent();
        }

        private void InitializeDataBindings(LevelExpertise model)
        {
            bindingSource.DataSource = model;
            txtLevel.DataBindings.Add("EditValue", bindingSource, nameof(LevelExpertise.MaCM), true, DataSourceUpdateMode.OnPropertyChanged);
            txtName.DataBindings.Add("Text", bindingSource, nameof(LevelExpertise.TenTDCM));
        }

        private void InitializeDataBindings(LevelLanguage model)
        {
            bindingSource.DataSource = model;
            txtLevel.DataBindings.Add("EditValue", bindingSource, nameof(LevelLanguage.MaNN), true, DataSourceUpdateMode.OnPropertyChanged);
            txtName.DataBindings.Add("Text", bindingSource, nameof(LevelLanguage.TenTDNN));
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.groupControl1.Focus();
                using (var context = new AppDbContext())
                {
                    switch (screenIndex)
                    {
                        case 0:
                            LevelExpertise lvExpertise = (LevelExpertise)bindingSource.Current;
                            context.TrinhDoChuyenMons.AddOrUpdate(lvExpertise);
                            context.SaveChanges();
                            break;
                        case 1:
                            LevelLanguage lvLanguage = (LevelLanguage)bindingSource.Current;
                            context.TrinhDoNgoaiNgus.AddOrUpdate(lvLanguage);
                            context.SaveChanges();
                            break;
                    }
                }

                DialogResult = MessageBox.Show("Thông tin đã được lưu thành công.");

                this.Close();

            }
            catch (Exception ex) {
                MessageBox.Show("Lưu thất bại.");
                SQLiteHelper.SaveToLog(ex.Message, "ucExpertiseDetail", ex.ToString());
            }

        }

        private void btnBack_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void frmLevelExpertisesDetail_Load(object sender, EventArgs e)
        {
            List<GridColumnModel> lst = new List<GridColumnModel>();

            switch (screenIndex)
            {
                case 0:
                    lst.Add(new GridColumnModel() { Name = "colMaNV", Caption = "Mã chuyên môn", FieldName = "MaCM", Visible = false });
                    lst.Add(new GridColumnModel() { Name = "colMaNV", Caption = "Tên chuyên môn", FieldName = "TenCM", Visible = true });
                    clsCommon.initialValue("ChuyenMon", "MaCM", "TenCM", txtLevelView, txtLevel, lst);
                    InitializeDataBindings(levelExpertise);
                    break;
                case 1:
                    lst.Add(new GridColumnModel() { Name = "colMaNV", Caption = "Mã ngoại ngữ", FieldName = "MaNN", Visible = false });
                    lst.Add(new GridColumnModel() { Name = "colMaNV", Caption = "Tên ngoại ngữ", FieldName = "TenNN", Visible = true });
                    clsCommon.initialValue("NgoaiNgu", "MaNN", "TenNN", txtLevelView, txtLevel, lst);
                    InitializeDataBindings(levelLanguage);
                    break;

            }

        }
    }
}