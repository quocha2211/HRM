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
    public class LevelSalaryController : IucControlController
    {
        private ucBaseMasterDetail View;
        public BaseController masterController;
        public ucBaseSingleList masterForm;
        public frmLevelSalaryDetail detailForm;
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
                    var model = context.ThangLuongs.Find(masterForm.GetPrimaryKey("MaTL"));

                    if (model != null)
                    {
                        context.ThangLuongs.Remove(model);

                        context.SaveChanges();

                    }

                }
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "LevelSalaryController", ex.ToString()); }
            finally { clsCommon.CloseWaitingForm(); }
        }


        private void MasterForm_EditButtonClick(object sender, EventArgs e)
        {
            try
            {
                if (masterForm == null)
                    return;
                InitialDetailPage(masterForm.GetPrimaryKey("MaTL"));
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "LevelSalaryController", ex.ToString()); }
            finally { clsCommon.CloseWaitingForm(); }
        }

        private void MasterForm_AddButtonClick(object sender, EventArgs e)
        {
            try
            {
                InitialDetailPage("");
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "LevelSalaryController", ex.ToString()); }
            finally { clsCommon.CloseWaitingForm(); }
        }

        private void InitialDetailPage(string pKey)
        {
            try
            {
                View.PageDetail.Controls.Clear();
                if (detailForm != null)
                    detailForm.Dispose();
                detailForm = new frmLevelSalaryDetail() { Dock = DockStyle.Fill };
                detailForm.MaTL = pKey;
                var result = detailForm.ShowDialog();
                if(result == DialogResult.OK)
                {
                    LoadData();
                }    

            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "LevelSalaryController", ex.ToString()); }
        }
        private void LoadData()
        {
            using (var context = new AppDbContext())
            {
                var query = context.ThangLuongs.ToList();

                clsCommon.OpenWaitingForm(View);
                masterForm.SetTitle("Quản lý Thang Lương");
                masterForm.SetDataSource(query, clsInitialGridColumn.InitialSalaryScale());
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
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "LevelSalaryController", ex.ToString()); }
            finally { clsCommon.CloseWaitingForm(); }
        }



    }
}
