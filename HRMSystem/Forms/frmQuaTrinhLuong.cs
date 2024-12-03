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
    public partial class frmQuaTrinhLuong : DevExpress.XtraEditors.XtraForm
    {
        public event EventHandler BackButtonClick;
        public string MaCCT;
        public int MaNV;
        public int MaCV;
        private BindingSource bindingSource = new BindingSource();
        public int nam;
        public int thang;
        public frmQuaTrinhLuong()
        {
            InitializeComponent();
        }


        private void InitializeDataBindings(QuaTrinhLuong model)
        {
            bindingSource.DataSource = model;
            if (model.MaNV == null)
            {
                model.MaNV = MaNV;
            }
            cboEmployee.DataBindings.Add("EditValue", bindingSource, nameof(QuaTrinhLuong.MaNV), true, DataSourceUpdateMode.OnPropertyChanged);
            txtNgayHuong.DataBindings.Add("Text", bindingSource, nameof(QuaTrinhLuong.NgayHuong), true, DataSourceUpdateMode.OnPropertyChanged);
            txtNgayNangCapLuong.DataBindings.Add("Text", bindingSource, nameof(QuaTrinhLuong.NgayNangCapLuong), true, DataSourceUpdateMode.OnPropertyChanged);
            txtThangLuong.DataBindings.Add("EditValue", bindingSource, nameof(QuaTrinhLuong.MaBL), true, DataSourceUpdateMode.OnPropertyChanged);
            txtMucLuong.DataBindings.Add("EditValue", bindingSource, nameof(QuaTrinhLuong.MaMLTT), true, DataSourceUpdateMode.OnPropertyChanged);
        }


        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.groupControl1.Focus();
                QuaTrinhLuong model = (QuaTrinhLuong)bindingSource.Current;


                if (model == null)
                {
                    MessageBox.Show("Lưu thất bại.");
                    return;
                }

                using (var context = new AppDbContext())
                {

                    context.QuaTrinhLuongs.AddOrUpdate(model);

                    context.SaveChanges();
                }

                DialogResult = MessageBox.Show("Thông tin đã được lưu thành công.");

                this.Close();

            }
            catch (Exception ex) { MessageBox.Show("Lưu thất bại."); SQLiteHelper.SaveToLog(ex.Message, "ucChungChiDetail", ex.ToString()); }

        }




        private void frmEmployeeRankingDetail_Load(object sender, EventArgs e)
        {
            try
            {
                clsCommon.initialValue("NhanVien", "MaNV", "TenNV", cboEmployeeView, cboEmployee, clsInitialGridColumn.InitialComboEmployee());
                clsCommon.initialValue("ThangLuong", "MaTL", "TenTL", txtThangLuongView, txtThangLuong, clsInitialGridColumn.InitialComboThangLuong());
                clsCommon.initialValue("MucLuongToiThieu", "MaMLTT", "MLTTC", txtMucLuongView, txtMucLuong, clsInitialGridColumn.InitialMinSalary());
                if (string.IsNullOrEmpty(MaCCT))
                {
                    InitializeDataBindings(new QuaTrinhLuong());
                }
                else
                {
                    using (var context = new AppDbContext())
                    {
                        var model = context.QuaTrinhLuongs.Find(Convert.ToInt32(MaCCT));

                        InitializeDataBindings(model);

                    }
                }

            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "ucChungChiDetail", ex.ToString()); }
        }

        private void btnBack_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}