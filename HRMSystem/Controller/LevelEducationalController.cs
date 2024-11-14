
using DevExpress.XtraBars.Navigation;
using DocumentFormat.OpenXml.Office2010.Excel;
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
    public class LevelEducationalController : IucControlController
    {
        private ucBaseMasterDetail View;
        public BaseController masterController;
        public ucBaseSingleList masterForm;
        public frmLevelEducationalDetail detailForm;
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
                    var chuyenMon = context.ChuyenMons.Find(masterForm.GetPrimaryKey("MaTDVH"));

                    if (chuyenMon != null)
                    {
                        context.ChuyenMons.Remove(chuyenMon);

                        context.SaveChanges();

                        LoadData();

                    }

                }
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "LevelEducationalController", ex.ToString()); }
            finally { clsCommon.CloseWaitingForm(); }
        }


        private void MasterForm_EditButtonClick(object sender, EventArgs e)
        {
            try
            {
                if (masterForm == null)
                    return;
                InitialDetailPage(masterForm.GetPrimaryKey("MaTDVH"));
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "LevelEducationalController", ex.ToString()); }
            finally { clsCommon.CloseWaitingForm(); }
        }

        private void MasterForm_AddButtonClick(object sender, EventArgs e)
        {
            try
            {
                InitialDetailPage("");
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "LevelEducationalController", ex.ToString()); }
            finally { clsCommon.CloseWaitingForm(); }
        }

        private void InitialDetailPage(string pKey)
        {

            try
            {
                View.PageDetail.Controls.Clear();
                if (detailForm != null)
                    detailForm.Dispose();

                detailForm = new frmLevelEducationalDetail() { Dock = DockStyle.Fill };
                detailForm.MaTDVH = pKey;
                var result = detailForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    LoadData();
                }

            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "LevelEducationalController", ex.ToString()); }
        }

        private void LoadData()
        {
            using (var context = new AppDbContext())
            {

                var query = context.TrinhDoVanHoas.ToList();
                clsCommon.OpenWaitingForm(View);
                masterForm.SetTitle("Quản lý Trình Độ Văn Hoá");
                masterForm.SetDataSource(query, clsInitialGridColumn.InitialLevelEducational());
                masterForm.SetSpecialGridProperties();

            }
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
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "LevelEducationalController", ex.ToString()); }
            finally { clsCommon.CloseWaitingForm(); }
        }



    }
}
