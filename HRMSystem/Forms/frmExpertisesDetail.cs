using DevExpress.XtraEditors;
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
    public partial class frmExpertisesDetail : DevExpress.XtraEditors.XtraForm
    {
        public int screenIndex = 0; // 0: Chuyên Môn, 1: Ngoại ngữ
        public event EventHandler BackButtonClick;
        public string MaCM;
        public Expertise ChuyenMon = new Expertise();
        public Language NgoaiNgu = new Language() ;
        private BindingSource bindingSource = new BindingSource();

        public frmExpertisesDetail()
        {
            InitializeComponent();
        }

        private void frmExpertisesDetail_Load(object sender, EventArgs e)
        {
            switch (screenIndex)
            {
                case 0:
                    InitializeDataBindings(ChuyenMon);
                    break;
                case 1:
                    InitializeDataBindings(NgoaiNgu);
                    break;
               
            }

        }


        private void InitializeDataBindings(Language ngoaiNgu)
        {
            bindingSource.DataSource = ngoaiNgu;
            txtName.DataBindings.Add("Text", bindingSource, nameof(Language.TenNN));
        }

        private void InitializeDataBindings(Expertise chuyenmon)
        {
            bindingSource.DataSource = chuyenmon;
            txtName.DataBindings.Add("Text", bindingSource, nameof(Expertise.TenCM));
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
               
                this.ActiveControl = null;

                using (var context = new AppDbContext())
                {
                    switch (screenIndex)
                    {
                        case 0:
                            Expertise chuyenmon = (Expertise)bindingSource.Current;
                            context.ChuyenMons.AddOrUpdate(chuyenmon);
                            context.SaveChanges();
                            break;
                        case 1:
                            Language ngoaiNgu = (Language)bindingSource.Current;
                            context.NgoaiNgus.AddOrUpdate(ngoaiNgu);
                            context.SaveChanges();
                            break;
                        
                    }

                }

                DialogResult = MessageBox.Show("Thông tin đã được lưu thành công.");

                this.Close();

            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "ucExpertiseDetail", ex.ToString()); }

        }

        private void btnBack_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}