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
    public partial class ucLanguageDetail : DevExpress.XtraEditors.XtraUserControl
    {

        public event EventHandler BackButtonClick;
        public string MaNN;
        private BindingSource bindingSource = new BindingSource();
        public ucLanguageDetail()
        {
            InitializeComponent();
        }

        private void InitializeDataBindings(Language ngoaiNgu)
        {
            bindingSource.DataSource = ngoaiNgu;
            txtMaCM.DataBindings.Add("Text", bindingSource, nameof(Language.MaNN));
            txtTenCM.DataBindings.Add("Text", bindingSource, nameof(Language.TenNN));
            cbTDCM.DataBindings.Add("Text", bindingSource, nameof(Language.MaTDNN), true, DataSourceUpdateMode.OnPropertyChanged);

        }

        private async void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Language ngoaiNgu = (Language)bindingSource.Current;
            if (ngoaiNgu == null)
            {
                MessageBox.Show("Thông tin ngoại ngữ lưu thất bại.");
                return;
            }

            using (var context = new AppDbContext())
            {
                context.NgoaiNgus.AddOrUpdate(ngoaiNgu);

                await context.SaveChangesAsync();
            }

            MessageBox.Show("Thông tin ngoại ngữ đã được lưu thành công.");
        }

        private void ucLanguageDetail_Load(object sender, EventArgs e)
        {
            try
            {
                
               
                if (string.IsNullOrEmpty(MaNN))
                {
                    InitializeDataBindings(new Language());
                }
                else
                {
                    using (var context = new AppDbContext())
                    {
                        var ngoaiNgu = context.NgoaiNgus.Find( Convert.ToInt32(MaNN));
                        InitializeDataBindings(ngoaiNgu);
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
