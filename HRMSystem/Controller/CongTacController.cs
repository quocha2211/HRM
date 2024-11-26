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
    public class CongTacController : IucControlController
    {
        private ucBaseMasterDetail View;
        public BaseController masterController;
        public ucBaseSingleList masterForm;
        public frmCongTac detailForm;
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
                    var model = context.HopDongs.Find(Convert.ToInt32(masterForm.GetPrimaryKey("MaCCT")));

                    if (model != null)
                    {
                        context.HopDongs.Remove(model);

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
                
                InitialDetailPage(masterForm.GetPrimaryKey("MaCCT"));
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
                detailForm = new frmCongTac() { Dock = DockStyle.Fill };
                detailForm.MaNV = Convert.ToInt32( masterForm.GetPrimaryKey("MaNV"));
                detailForm.MaCCT = pKey;
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
            try
            {
                using (var context = new AppDbContext())
                {

                    var query = (from nv in context.NhanViens
                                join xl in context.DieuChuyenCongTacs on nv.MaNV equals xl.MaNV into hopDongGroup
                                from xl in hopDongGroup.DefaultIfEmpty()
                                 join cv in context.ChucVus on xl.MaChucVu equals cv.MaChucVu into CVGroup
                                 from cv in CVGroup.DefaultIfEmpty()
                                 join pb in context.PhongBans on xl.MaPB equals pb.MaPB into pbGroup
                                 from pb in pbGroup.DefaultIfEmpty()
                                 join tl in context.ThangLuongs on xl.MaTL equals tl.MaTL into tlGroup
                                 from tl in tlGroup.DefaultIfEmpty()
                                 select new
                                {
                                    xl.MaCCT,
                                    xl.NgayChuyen,
                                    xl.SoQD,
                                    nv.TenNV,
                                    nv.MaNV,
                                    cv.TenChucVu,
                                    pb.TenPB,
                                    tl.TenTL,
                                    xl.GhiChu
                                }).ToList();

                    clsCommon.OpenWaitingForm(View);
                    masterForm.SetTitle("Quản lý Điều Chuyển Công Tác");
                    masterForm.SetDataSource(query, clsInitialGridColumn.InitialDieuChuyenCongTac());
                    masterForm.SetSpecialGridProperties();

                }
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "ucEmployeeMaster", ex.ToString()); }
            finally { clsCommon.CloseWaitingForm(); }


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
