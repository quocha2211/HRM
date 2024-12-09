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
    public partial class frmQuaTrinhCongTac : DevExpress.XtraEditors.XtraForm
    {
        public event EventHandler BackButtonClick;
        public string MaQTCT;
        public int MaNV;
        public int MaCV;
        public int MaPB;
        private BindingSource bindingSource = new BindingSource();
        public int nam;
        public int thang;
        public frmQuaTrinhCongTac()
        {
            InitializeComponent();
        }


        private void InitializeDataBindings(QuaTrinhCongTac model)
        {
            bindingSource.DataSource = model;
            if (model.MaNV == null)
            {
                model.MaNV = MaNV;
                model.MaChucVu = MaCV;
                model.MaPB = MaPB;
            }
            cboEmployee.DataBindings.Add("EditValue", bindingSource, nameof(QuaTrinhCongTac.MaNV), true, DataSourceUpdateMode.OnPropertyChanged);
            txtNgayBatDau.DataBindings.Add("Text", bindingSource, nameof(QuaTrinhCongTac.NgayBatDau), true, DataSourceUpdateMode.OnPropertyChanged);
            txtNgayKetThuc.DataBindings.Add("Text", bindingSource, nameof(QuaTrinhCongTac.NgayKetThuc), true, DataSourceUpdateMode.OnPropertyChanged);
            txtNgay.DataBindings.Add("EditValue", bindingSource, nameof(QuaTrinhCongTac.Ngay), true, DataSourceUpdateMode.OnPropertyChanged);
            txtchucVu.DataBindings.Add("EditValue", bindingSource, nameof(QuaTrinhCongTac.MaChucVu), true, DataSourceUpdateMode.OnPropertyChanged);
        }


        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.groupControl1.Focus();
                QuaTrinhCongTac model = (QuaTrinhCongTac)bindingSource.Current;
               

                if (model == null)
                {
                    MessageBox.Show("Lưu thất bại.");
                    return;
                }

                using (var context = new AppDbContext())
                {
                    if(model.MaQTCT == null)
                        context.QuaTrinhCongTacs.Add(model);
                    else
                        context.QuaTrinhCongTacs.AddOrUpdate(model);

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
                clsCommon.initialValue("ChucVu", "MaChucVu", "TenChucVu", txtChucVuView, txtchucVu, clsInitialGridColumn.InitialComboChucVu());
                if (string.IsNullOrEmpty(MaQTCT))
                {
                    InitializeDataBindings(new QuaTrinhCongTac());
                }
                else
                {
                    using (var context = new AppDbContext())
                    {
                        var model = context.QuaTrinhCongTacs.Find(Convert.ToInt32(MaQTCT));
                       
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