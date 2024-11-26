using DevExpress.XtraBars.Navigation;
using HRMSystem.Controls;
using HRMSystem.Forms;
using HRMSystem.Interfaces;
using HRMSystem.Utilities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMSystem.Controller
{
    public class KhenThuongKyLuatController : IucControlController
    {
        private ucBaseMasterDetail View;
        public BaseController masterController;
        public ucBaseSingleList masterForm;
        public frmKhenThuongKyLuat detailForm;
        public void Initialize(UserControl _view)
        {
            View = _view as ucBaseMasterDetail;
            View.Load += View_Load;
        }

        private void InitialMasterPage()
        {
            try
            {
                View.PageMaster.Controls.Clear();
                if (masterForm != null)
                    masterForm.Dispose();
                masterController = new BaseController();
                masterForm = new ucBaseSingleList() { Dock = DockStyle.Fill };


                masterController.Initialize(masterForm);
                masterController.Load += MasterController_Load;
                masterForm.AddButtonClick += MasterForm_AddButtonClick;
                masterForm.EditButtonClick += MasterForm_EditButtonClick;
                masterForm.DeleteButtonClick += MasterForm_DeleteButtonClick;

                View.PageMaster.Controls.Add(masterForm);
                View.NavigatorFrame.SelectedPage = View.PageMaster;
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "ex", ex.ToString()); }
        }

        private void MasterForm_DeleteButtonClick(object sender, EventArgs e)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var phongBan = context.khenThuongKyLuats.Find(Convert.ToInt32(masterForm.GetPrimaryKey("MaKTKL")));

                    if (phongBan != null)
                    {
                        context.khenThuongKyLuats.Remove(phongBan);

                        context.SaveChanges();
                        LoadData();

                    }

                }
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "SalaryScaleController", ex.ToString()); }
            finally { clsCommon.CloseWaitingForm(); }
        }


        private void MasterForm_EditButtonClick(object sender, EventArgs e)
        {
            try
            {
                
                if (masterForm == null)
                    return;
                InitialDetailPage(masterForm.GetPrimaryKey("MaKTKL"));
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "SalaryScaleController", ex.ToString()); }
            finally { clsCommon.CloseWaitingForm(); }
        }

        private void MasterForm_AddButtonClick(object sender, EventArgs e)
        {
            try
            {
               
                InitialDetailPage("");
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "SalaryScaleController", ex.ToString()); }
            finally { clsCommon.CloseWaitingForm(); }
        }

        private void InitialDetailPage(string pKey)
        {
            try
            {
                View.PageDetail.Controls.Clear();
                if (detailForm != null)
                    detailForm.Dispose();
                detailForm = new frmKhenThuongKyLuat() { Dock = DockStyle.Fill };
                detailForm.MaKTKL = pKey;
                var rs = detailForm.ShowDialog();
                if (rs == DialogResult.OK)
                {
                    LoadData();
                }
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "SalaryScaleController", ex.ToString()); }
        }

        private void DetailForm_BackButtonClick(object sender, EventArgs e)
        {
            try
            {
                clsCommon.OpenWaitingForm(View);
                InitialMasterPage();
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "ucEmployeeMaster", ex.ToString()); }
            finally { clsCommon.CloseWaitingForm(); }
        }

        private void LoadData()
        {
            using (var context = new AppDbContext())
            {
                var query = (from nv in context.NhanViens
                             join cm in context.khenThuongKyLuats on nv.MaNV equals cm.MaNV
                             select new
                             {
                                 nv.MaNV,
                                 nv.TenNV,
                                 nv.GioiTinh,
                                 cm.MaKTKL,
                                 cm.TenKTKL,
                                 cm.SoQD,
                                 cm.NgayQD,
                                 cm.HinhThuc,
                                 cm.LyDo,
                                 cm.DonviKTKL

                             }).ToList();

                clsCommon.OpenWaitingForm(View);
                masterForm.SetTitle("Quản lý Khen Thưởng Kỷ Luật");
                masterForm.SetDataSource(query, clsInitialGridColumn.InitialKTKL());
                masterForm.SetSpecialGridProperties();

            }
        }

        private void MasterController_Load(object sender, EventArgs e)
        {

            LoadData();

        }

        private void View_Load(object sender, EventArgs e)
        {
            try
            {
                clsCommon.OpenWaitingForm(View);
                InitialMasterPage();
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "SalaryScaleController", ex.ToString()); }
            finally { clsCommon.CloseWaitingForm(); }
        }



    }
}
