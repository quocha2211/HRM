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
using static HRMSystem.Controls.ucBangLuong;

namespace HRMSystem.Controller
{
    public class BangLuongController : IucControlController
    {
        private ucBaseMasterDetail View;
        public BaseController masterController;
        public ucBangLuong masterForm;
        public frmContract detailForm;
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
                masterForm = new ucBangLuong() { Dock = DockStyle.Fill };


                masterController.Initialize(masterForm);
                masterController.Load += MasterController_Load;
                masterForm.searchDelegate = new SearchButtonClick(MasterForm_SearchButtonClick);

                View.PageMaster.Controls.Add(masterForm);
                View.NavigatorFrame.SelectedPage = View.PageMaster;
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "ex", ex.ToString()); }
        }

        private void MasterForm_SearchButtonClick(int nam, int thang)
        {
            LoadData(nam, thang);
        }

        private void LoadData(int nam, int thang)
        {
            try
            {
                using (var context = new AppDbContext())
                {

                    var query = (from nv in context.NhanViens
                                 join cc in context.ChamCongTLs on nv.MaNV equals cc.MaNV into chamCongGroup
                                 from cc in chamCongGroup.DefaultIfEmpty()
                                 join xx in context.DinhMucXangXes on nv.MaDMXX equals xx.MaDMXX into xangXeGroup
                                 from xx in xangXeGroup.DefaultIfEmpty()
                                 join tu in context.BangTamUngs on nv.MaNV equals tu.MaNV into tuGroup
                                 from tu in tuGroup.DefaultIfEmpty()
                                 join ml in context.MucLuongToiThieus on nv.MaMLTT equals ml.MaMLTT into MLTT
                                 from ml in MLTT.DefaultIfEmpty()
                                 join tl in context.ThangLuongs on nv.MaTL equals tl.MaTL into TLG
                                 from tl in TLG.DefaultIfEmpty()
                                 where (cc.Nam == nam && cc.Thang == thang) || (cc.Nam == null && cc.Thang == null)
                                 select new
                                 {
                                     nv.TenNV,
                                     nv.MaNV,
                                     ml.MLTTC,
                                     tl.HeSo,
                                     LuongCoBan = ml.MLTTC * tl.HeSo,
                                     NgayCongTrongThang = (cc.NgayCongTrongThang ?? 0),
                                     LuongThoiGian = (ml.MLTTC * tl.HeSo) / 26 * (cc.NgayCongTrongThang ?? 0),
                                     xx.DMXX,
                                     TienAn = (cc.NgayCongTrongThang ?? 0) * 25000,
                                     TongLuong = (ml.MLTTC * tl.HeSo) / 26 * (cc.NgayCongTrongThang ?? 0) + (cc.NgayCongTrongThang ?? 0) * 25000 + xx.DMXX,
                                     BHXH = (ml.MLTTC * tl.HeSo) * 8 / 100,
                                     BHYT = (ml.MLTTC * tl.HeSo) * 1.5 / 100,
                                     BHTN = (ml.MLTTC * tl.HeSo) * 1 / 100,
                                     SoTienTU = (tu.SoTienTU ?? 0),
                                     LuongGiamTru = (ml.MLTTC * tl.HeSo) * 8 / 100 + (ml.MLTTC * tl.HeSo) * 1.5 / 100 + (ml.MLTTC * tl.HeSo) * 1 / 100 + (tu.SoTienTU ?? 0),
                                     LuongThucNhan = cc.NgayCongTrongThang == null ? 0 : (ml.MLTTC * tl.HeSo) / 26 * (cc.NgayCongTrongThang ?? 0) + (cc.NgayCongTrongThang ?? 0) * 25000 + xx.DMXX - ((ml.MLTTC * tl.HeSo) * 8 / 100 + (ml.MLTTC * tl.HeSo) * 1.5 / 100 + (ml.MLTTC * tl.HeSo) * 1 / 100 + (tu.SoTienTU ?? 0))

                                 }).ToList();

                    clsCommon.OpenWaitingForm(View);
                    masterForm.SetTitle("Lập bảng lương");
                    masterForm.SetDataSource(query, clsInitialGridColumn.InitialBangLuong());
                    masterForm.SetSpecialGridProperties();

                }
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "ucEmployeeMaster", ex.ToString()); }
            finally { clsCommon.CloseWaitingForm(); }


        }

        private void MasterController_Load(object sender, EventArgs e)
        {
            LoadData(DateTime.Now.Year, DateTime.Now.Month);
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
