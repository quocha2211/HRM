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
    public partial class frmDaoTao : DevExpress.XtraEditors.XtraForm
    {
        public event EventHandler BackButtonClick;
        public string MaQTDT;
        public int MaNV;
        public int MaCV;
        public int MaPB;
        private BindingSource bindingSource = new BindingSource();
        public int nam;
        public int thang;
        public frmDaoTao()
        {
            InitializeComponent();
        }


        private void InitializeDataBindings(QuaTrinhDaoTao model)
        {
            bindingSource.DataSource = model;
            if (model.MaNV == null)
            {
                model.MaNV = MaNV;
                model.MaChucVu = MaCV;
                model.MaPB = MaPB;
            }
            txtNganhDaoTao.DataBindings.Add("Text", bindingSource, nameof(QuaTrinhDaoTao.NganhDaoTao), true, DataSourceUpdateMode.OnPropertyChanged);
            txtNuocDaoTao.DataBindings.Add("Text", bindingSource, nameof(QuaTrinhDaoTao.NuocDaoTao), true, DataSourceUpdateMode.OnPropertyChanged);
            txtSchool.DataBindings.Add("Text", bindingSource, nameof(QuaTrinhDaoTao.TruongDaoTao), true, DataSourceUpdateMode.OnPropertyChanged);
            txtTrinhDoDaoTao.DataBindings.Add("Text", bindingSource, nameof(QuaTrinhDaoTao.TrinhDoDaoTao), true, DataSourceUpdateMode.OnPropertyChanged);
            cboEmployee.DataBindings.Add("EditValue", bindingSource, nameof(QuaTrinhDaoTao.MaNV), true, DataSourceUpdateMode.OnPropertyChanged);
            txtNgayBatDau.DataBindings.Add("Text", bindingSource, nameof(QuaTrinhDaoTao.NgayBatDau), true, DataSourceUpdateMode.OnPropertyChanged);
            txtNgayKetThuc.DataBindings.Add("Text", bindingSource, nameof(QuaTrinhDaoTao.NgayHetHan), true, DataSourceUpdateMode.OnPropertyChanged);
            txtHinhThucDaoTao.DataBindings.Add("Text", bindingSource, nameof(QuaTrinhDaoTao.HinhThucDaoTao), true, DataSourceUpdateMode.OnPropertyChanged);
            txtchucVu.DataBindings.Add("EditValue", bindingSource, nameof(QuaTrinhDaoTao.MaChucVu), true, DataSourceUpdateMode.OnPropertyChanged);
        }


        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.groupControl1.Focus();
                QuaTrinhDaoTao model = (QuaTrinhDaoTao)bindingSource.Current;
               

                if (model == null)
                {
                    MessageBox.Show("Lưu thất bại.");
                    return;
                }

                using (var context = new AppDbContext())
                {
                    if(model.MaQTDT == null)
                        context.QuaTrinhDaoTaos.Add(model);
                    else
                        context.QuaTrinhDaoTaos.AddOrUpdate(model);

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
                if (string.IsNullOrEmpty(MaQTDT))
                {
                    InitializeDataBindings(new QuaTrinhDaoTao());
                }
                else
                {
                    using (var context = new AppDbContext())
                    {
                        var model = context.QuaTrinhDaoTaos.Find(Convert.ToInt32(MaQTDT));
                       
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