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
    public partial class ucMucLuongToiThieu : DevExpress.XtraEditors.XtraUserControl
    {

        public event EventHandler BackButtonClick;
        public string MaMLTT;
        private BindingSource bindingSource = new BindingSource();
        public ucMucLuongToiThieu()
        {
            InitializeComponent();
        }

        private void InitializeDataBindings(MucLuongToiThieu model)
        {
            bindingSource.DataSource = model;
            txtMaMLTT.DataBindings.Add("Text", bindingSource, nameof(MucLuongToiThieu.MaMLTT));
            dNgayCap.DataBindings.Add("Text", bindingSource, nameof(MucLuongToiThieu.NgayAD));
            txtVung.DataBindings.Add("Text", bindingSource, nameof(MucLuongToiThieu.MLTTVung));
            txtMLTTC.DataBindings.Add("Text", bindingSource, nameof(MucLuongToiThieu.MLTTC));
        }


        private async void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.ActiveControl = null;
                MucLuongToiThieu model = (MucLuongToiThieu)bindingSource.Current;
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

                MessageBox.Show("Thông tin đã được lưu thành công.");

            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "ucMucLuongToiThieuDetail", ex.ToString()); }
            
        }

        private void ucMucLuongToiThieuDetail_Load(object sender, EventArgs e)
        {
            try
            {
                
                if (string.IsNullOrEmpty(MaMLTT))
                {
                    InitializeDataBindings(new MucLuongToiThieu());
                }
                else
                {
                    using (var context = new AppDbContext())
                    {
                        var model = context.MucLuongToiThieus.Find(Convert.ToInt32( MaMLTT));
                        InitializeDataBindings(model);

                    }
                }

            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "ucMucLuongToiThieuDetail", ex.ToString()); }
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
