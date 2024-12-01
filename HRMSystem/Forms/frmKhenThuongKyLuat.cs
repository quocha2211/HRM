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
    public partial class frmKhenThuongKyLuat : DevExpress.XtraEditors.XtraForm
    {
        public event EventHandler BackButtonClick;
        public string MaKTKL;
        public int MaNV;
        private BindingSource bindingSource = new BindingSource();

        public frmKhenThuongKyLuat()
        {
            InitializeComponent();
        }


        private void InitializeDataBindings(KhenThuongKyLuat model)
        {
            bindingSource.DataSource = model;
            if (model.MaNV == null)
            {
                model.MaNV = MaNV;
                
            }
            txtDonVi.DataBindings.Add("Text", bindingSource, nameof(KhenThuongKyLuat.DonviKTKL), true, DataSourceUpdateMode.OnPropertyChanged);
            txtTenKTKL.DataBindings.Add("Text", bindingSource, nameof(KhenThuongKyLuat.TenKTKL), true, DataSourceUpdateMode.OnPropertyChanged);
            txtHinhThuc.DataBindings.Add("Text", bindingSource, nameof(KhenThuongKyLuat.HinhThuc), true, DataSourceUpdateMode.OnPropertyChanged);
            txtLyDo.DataBindings.Add("Text", bindingSource, nameof(KhenThuongKyLuat.LyDo), true, DataSourceUpdateMode.OnPropertyChanged);
            txtSoQD.DataBindings.Add("Text", bindingSource, nameof(KhenThuongKyLuat.SoQD), true, DataSourceUpdateMode.OnPropertyChanged);
            txtDate.DataBindings.Add("Text", bindingSource, nameof(KhenThuongKyLuat.NgayQD), true, DataSourceUpdateMode.OnPropertyChanged);
            cboEmployee.DataBindings.Add("EditValue", bindingSource, nameof(KhenThuongKyLuat.MaNV), true, DataSourceUpdateMode.OnPropertyChanged);
        }


        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.groupControl1.Focus();
                KhenThuongKyLuat model = (KhenThuongKyLuat)bindingSource.Current;
                if (model == null)
                {
                    MessageBox.Show("Lưu thất bại.");
                    return;
                }

                using (var context = new AppDbContext())
                {

                    context.khenThuongKyLuats.AddOrUpdate(model);

                    context.SaveChanges();
                }

                DialogResult = MessageBox.Show("Thông tin đã được lưu thành công.");

                this.Close();

            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "ucChungChiDetail", ex.ToString()); }

        }


    

        private void frmKhenThuongKyLuatDetail_Load(object sender, EventArgs e)
        {
            try
            {
                clsCommon.initialValue("NhanVien", "MaNV", "TenNV", cboEmployeeView, cboEmployee, clsInitialGridColumn.InitialComboEmployee());

                if (string.IsNullOrEmpty(MaKTKL))
                {
                    InitializeDataBindings(new KhenThuongKyLuat());
                }
                else
                {
                    using (var context = new AppDbContext())
                    {
                        var model = context.khenThuongKyLuats.Find(Convert.ToInt32(MaKTKL));
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