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
    public partial class frmTimeKeeping : DevExpress.XtraEditors.XtraForm
    {
        public event EventHandler BackButtonClick;
        public string MaCCTL;
        private BindingSource bindingSource = new BindingSource();

        public frmTimeKeeping()
        {
            InitializeComponent();
        }


        private void InitializeDataBindings(TimeKeeping model)
        {
            bindingSource.DataSource = model;
            txtName.DataBindings.Add("Text", bindingSource, nameof(TimeKeeping.TenCCTL), true, DataSourceUpdateMode.OnPropertyChanged);
            txtNam.DataBindings.Add("Text", bindingSource, nameof(TimeKeeping.Nam), true, DataSourceUpdateMode.OnPropertyChanged);
            txtThang.DataBindings.Add("Text", bindingSource, nameof(TimeKeeping.Thang), true, DataSourceUpdateMode.OnPropertyChanged);
            //txtKhoa.DataBindings.Add("Text", bindingSource, nameof(TimeKeeping.Khoa), true, DataSourceUpdateMode.OnPropertyChanged);
            txtSoCong.DataBindings.Add("Text", bindingSource, nameof(TimeKeeping.NgayCongTrongThang), true, DataSourceUpdateMode.OnPropertyChanged);
            txtDate.DataBindings.Add("Text", bindingSource, nameof(TimeKeeping.NgayTinhCong), true, DataSourceUpdateMode.OnPropertyChanged);
            cboEmployee.DataBindings.Add("EditValue", bindingSource, nameof(TimeKeeping.MaNV), true, DataSourceUpdateMode.OnPropertyChanged);
        }


        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.groupControl1.Focus();
                TimeKeeping model = (TimeKeeping)bindingSource.Current;
                if (model == null)
                {
                    MessageBox.Show("Lưu thất bại.");
                    return;
                }

                using (var context = new AppDbContext())
                {
                    var chamCong = context.ChamCongTLs.FirstOrDefault(x=> x.Nam == model.Nam && x.Thang == model.Thang && x.MaNV == model.MaNV );

                    if (chamCong != null)
                    {
                        model.MaCCTL = chamCong.MaCCTL;

                    }


                    context.ChamCongTLs.AddOrUpdate(model);

                    context.SaveChanges();
                }

                DialogResult = MessageBox.Show("Thông tin đã được lưu thành công.");

                this.Close();

            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "ucChungChiDetail", ex.ToString()); }

        }


    

        private void frmTimeKeepingDetail_Load(object sender, EventArgs e)
        {
            try
            {
                clsCommon.initialValue("NhanVien", "MaNV", "TenNV", cboEmployeeView, cboEmployee, clsInitialGridColumn.InitialComboEmployee());

                if (string.IsNullOrEmpty(MaCCTL))
                {
                    InitializeDataBindings(new TimeKeeping());
                }
                else
                {
                    using (var context = new AppDbContext())
                    {
                        var model = context.ChamCongTLs.Find(Convert.ToInt32(MaCCTL));
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