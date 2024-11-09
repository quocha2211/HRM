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
    public partial class ucDinhMucXangXe : DevExpress.XtraEditors.XtraUserControl
    {

        public event EventHandler BackButtonClick;
        public string MaDMXX;
        private BindingSource bindingSource = new BindingSource();
        public ucDinhMucXangXe()
        {
            InitializeComponent();
        }

        private void InitializeDataBindings(DinhMucXangXe model)
        {
            bindingSource.DataSource = model;
            txtMaMLTT.DataBindings.Add("Text", bindingSource, nameof(DinhMucXangXe.MaDMXX));
            txtVung.DataBindings.Add("Text", bindingSource, nameof(DinhMucXangXe.TenPTien));
            txtMLTTC.DataBindings.Add("Text", bindingSource, nameof(DinhMucXangXe.DMXX));
        }


        private async void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.ActiveControl = null;
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

                MessageBox.Show("Thông tin đã được lưu thành công.");

            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "ucDinhMucXangXeDetail", ex.ToString()); }
            
        }

        private void ucDinhMucXangXeDetail_Load(object sender, EventArgs e)
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
                        var model = context.DinhMucXangXes.Find(Convert.ToInt32( MaDMXX));
                        InitializeDataBindings(model);

                    }
                }

            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "ucDinhMucXangXeDetail", ex.ToString()); }
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
