using DevExpress.Utils.Extensions;
using DevExpress.XtraBars.Navigation;
using HRMSystem.Controls;
using HRMSystem.Forms;
using HRMSystem.Interfaces;
using HRMSystem.Utilities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.Xpo.Helpers.AssociatedCollectionCriteriaHelper;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace HRMSystem.Controller
{
    public class QuaTrinhCongTacController : IucControlController
    {
        private ucBaseMasterDetail View;
        public BaseController masterController;
        public ucBaseDoubleList masterForm;
        public frmQuaTrinhCongTac detailForm;
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
                masterForm = new ucBaseDoubleList() { Dock = DockStyle.Fill };


                masterController.Initialize(masterForm);
                masterController.Load += MasterController_Load;
                masterForm.AddButtonClick += MasterForm_AddButtonClick;
                masterForm.EditButtonClick += MasterForm_EditButtonClick;
                masterForm.FocusRowChange += MasterForm_FocusRowChange; 
                masterForm.DeleteButtonClick += MasterForm_DeleteButtonClick;

                View.PageMaster.Controls.Add(masterForm);
                View.NavigatorFrame.SelectedPage = View.PageMaster;
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "ex", ex.ToString()); }
        }

        private void MasterForm_FocusRowChange(object sender, EventArgs e)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    int id = Convert.ToInt32(masterForm.GetPrimaryKey("MaNV"));

                    var detail = (from nv in context.NhanViens
                                  join xl in context.QuaTrinhCongTacs on nv.MaNV equals xl.MaNV into hopDongGroup
                                  from xl in hopDongGroup.DefaultIfEmpty()
                                  join cv in context.ChucVus on xl.MaChucVu equals cv.MaChucVu into CVGroup
                                  from cv in CVGroup.DefaultIfEmpty()
                                  join pb in context.PhongBans on xl.MaPB equals pb.MaPB into pbGroup
                                  from pb in pbGroup.DefaultIfEmpty()
                                  where xl.MaNV == id orderby xl.NgayBatDau descending
                                  select new
                                  {
                                      xl.MaQTCT,
                                      xl.NgayBatDau,
                                      xl.NgayKetThuc,
                                      xl.Ngay,
                                      nv.TenNV,
                                      nv.MaNV,
                                      cv.TenChucVu,
                                      pb.TenPB,
                                  }).ToList();

                    masterForm.setDataDetail(detail, clsInitialGridColumn.InitialQuaTrinhCongTac());
                }
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "SalaryScaleController", ex.ToString()); }
            finally { clsCommon.CloseWaitingForm(); }
        }


        private void MasterForm_DeleteButtonClick(object sender, EventArgs e)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var model = context.QuaTrinhCongTacs.Find(Convert.ToInt32(masterForm.GetPrimaryKey("MaQTCT")));

                    if (model != null)
                    {
                        context.QuaTrinhCongTacs.Remove(model);

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
                
                InitialDetailPage(masterForm.GetPrimaryKey("MaQTCT"));
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
                detailForm = new frmQuaTrinhCongTac() { Dock = DockStyle.Fill };
                detailForm.MaNV = Convert.ToInt32( masterForm.GetPrimaryKey("MaNV"));
                detailForm.MaQTCT = pKey;
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
                                join xl in context.QuaTrinhCongTacs on nv.MaNV equals xl.MaNV into hopDongGroup
                                from xl in hopDongGroup.DefaultIfEmpty()
                                 join cv in context.ChucVus on xl.MaChucVu equals cv.MaChucVu into CVGroup
                                 from cv in CVGroup.DefaultIfEmpty()
                                 join pb in context.PhongBans on xl.MaPB equals pb.MaPB into pbGroup
                                 from pb in pbGroup.DefaultIfEmpty()
                                   orderby xl.NgayBatDau descending
                                 select new
                                {
                                    xl.MaQTCT,
                                    xl.NgayBatDau,
                                    xl.NgayKetThuc,
                                    xl.Ngay,
                                    nv.TenNV,
                                    nv.MaNV,
                                    cv.TenChucVu,
                                    pb.TenPB,
                                }).ToList();

                    var objDictionary = new Dictionary<int?, int?>();
                    
                    query.ToList().ForEach(x => {
                        
                        if (!objDictionary.ContainsKey(x.MaNV))
                        {
                            objDictionary.Add(x.MaNV, x.MaQTCT); 
                        }
                    });

                    var result = query.Where(x => x.MaQTCT == 0).ToList();

                    foreach (var x in objDictionary)
                    {
                        var found = query.FirstOrDefault(e => e.MaQTCT == x.Value && e.MaNV == x.Key); 
                        if (found != null)
                        {
                            result.Add(found); 
                        }
                    }
                    
                   
                    clsCommon.OpenWaitingForm(View);
                    masterForm.SetTitle("Quản lý Quá Trình Công Tác");
                    masterForm.SetDataSource(result, clsInitialGridColumn.InitialQuaTrinhCongTac());
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
