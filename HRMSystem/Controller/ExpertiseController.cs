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
    public class ExpertiseController : IucControlController
    {
        private ucBaseMasterDetail View;
        public BaseController masterController;
        public ucBaseSingleList masterForm;
        public frmExpertisesDetail detailForm;
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
                    var chuyenMon = context.ChuyenMons.Find(masterForm.GetPrimaryKey("MaCM"));  

                    if (chuyenMon != null)
                    {
                        context.ChuyenMons.Remove(chuyenMon);  

                        context.SaveChanges();

                    }
                    
                }
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "ExpertiseController", ex.ToString()); }
            finally { clsCommon.CloseWaitingForm(); }
        }


        private void MasterForm_EditButtonClick(object sender, EventArgs e)
        {
            try
            {
                if (masterForm == null)
                    return;
                InitialDetailPage(Convert.ToInt32( masterForm.GetPrimaryKey("MaCM")));
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "ExpertiseController", ex.ToString()); }
            finally { clsCommon.CloseWaitingForm(); }
        }

        private void MasterForm_AddButtonClick(object sender, EventArgs e)
        {
            try
            {
                InitialDetailPage(0);
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "ExpertiseController", ex.ToString()); }
            finally { clsCommon.CloseWaitingForm(); }
        }

        private void InitialDetailPage(int id)
        {
           
            try
            {
                View.PageDetail.Controls.Clear();
                if (detailForm != null)
                    detailForm.Dispose();

                using (var context = new AppDbContext())
                {
                    var chuyenMon = context.ChuyenMons.Find(id);
                    detailForm = new frmExpertisesDetail() { Dock = DockStyle.Fill };
                    detailForm.screenIndex = 1;
                    if (id > 0)
                        detailForm.ChuyenMon = chuyenMon;
                    else
                        detailForm.ChuyenMon = new Expertise();
                    
                    var rs = detailForm.ShowDialog();
                    if(rs == DialogResult.OK)
                    {
                        LoadData();
                    }    
                }

            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "LanguageController", ex.ToString()); }
        }

        private void LoadData()
        {
            using (var context = new AppDbContext())
            {


                var query = context.ChuyenMons.ToList();
                clsCommon.OpenWaitingForm(View);
                masterForm.SetTitle("Quản lý Chuyên Môn");
                masterForm.SetDataSource(query, clsInitialGridColumn.InitialExpertise());
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
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "ExpertiseController", ex.ToString()); }
            finally { clsCommon.CloseWaitingForm(); }
        }

        
        
    }
}
