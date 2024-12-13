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
    public partial class frmChamCongNgay : DevExpress.XtraEditors.XtraForm
    {
        public event EventHandler BackButtonClick;
        public int MaNV;
        public int Nam;
        public int Thang;
        public DateTime Date;
        private BindingSource bindingSource = new BindingSource();

        public frmChamCongNgay()
        {
            InitializeComponent();
        }


        private void InitializeDataBindings(ChamCongNgay model)
        {
            bindingSource.DataSource = model;
            if (model.MaNV == null)
            {
                model.MaNV = MaNV;
                model.Ngay = Date;
            }
            txtNote.DataBindings.Add("Text", bindingSource, nameof(ChamCongNgay.NoiDung), true, DataSourceUpdateMode.OnPropertyChanged);
            txtDate.DataBindings.Add("Text", bindingSource, nameof(ChamCongNgay.Ngay), true, DataSourceUpdateMode.OnPropertyChanged);
            cboEmployee.DataBindings.Add("EditValue", bindingSource, nameof(ChamCongNgay.MaNV), true, DataSourceUpdateMode.OnPropertyChanged);
        }


        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.groupControl1.Focus();
                ChamCongNgay model = (ChamCongNgay)bindingSource.Current;
                if (model == null)
                {
                    MessageBox.Show("Lưu thất bại.");
                    return;
                }

                using (var context = new AppDbContext())
                {



                    context.ChamCongNgays.AddOrUpdate(model);

                    context.SaveChanges();
                }

                DialogResult = MessageBox.Show("Thông tin đã được lưu thành công.");

                this.Close();

            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "ucChungChiDetail", ex.ToString()); }

        }




        private void frmChamCongNgayDetail_Load(object sender, EventArgs e)
        {
            try
            {
                clsCommon.initialValue("NhanVien", "MaNV", "TenNV", cboEmployeeView, cboEmployee, clsInitialGridColumn.InitialComboEmployee());

          
                    using (var context = new AppDbContext())
                    {
                        var model = context.ChamCongNgays.FirstOrDefault(x => x.MaNV == MaNV && x.Ngay == Date);
                        if (model == null)
                            InitializeDataBindings(new ChamCongNgay());
                        else
                        InitializeDataBindings(model);

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