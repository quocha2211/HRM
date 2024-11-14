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
    public class LevelLanguageController : IucControlController
    {
        private ucBaseMasterDetail View;
        public BaseController masterController;
        public ucBaseSingleList masterForm;
        public frmLevelExpertisesDetail detailForm;
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
                    var chuyenMon = context.ChuyenMons.Find(Convert.ToInt32(masterForm.GetPrimaryKey("MaTDNN")));  

                    if (chuyenMon != null)
                    {
                        context.ChuyenMons.Remove(chuyenMon);  

                        context.SaveChanges();

                        LoadData();

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
                InitialDetailPage(Convert.ToInt32( masterForm.GetPrimaryKey("MaTDNN")));
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
                    var model = context.TrinhDoNgoaiNgus.Find(id);
                    detailForm = new frmLevelExpertisesDetail() { Dock = DockStyle.Fill };
                    detailForm.screenIndex = 1;
                    if (id > 0)
                        detailForm.levelLanguage = model;
                    else
                        detailForm.levelLanguage = new LevelLanguage();
                    var dialogResult = detailForm.ShowDialog();
                    if (dialogResult == DialogResult.OK)
                    {
                        LoadData();
                    }    
                }

            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "LanguageController", ex.ToString()); }
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
                    var query = (from nn in context.NgoaiNgus
                                 join tdnn in context.TrinhDoNgoaiNgus
                                 on nn.MaNN equals tdnn.MaNN
                                 select new
                                 {
                                     tdnn.MaTDNN,
                                     nn.TenNN,
                                     tdnn.TenTDNN
                                 }).ToList();

                    clsCommon.OpenWaitingForm(View);
                    masterForm.SetTitle("Quản lý trình độ ngoại ngữ");
                    masterForm.SetDataSource(query, clsInitialGridColumn.InitialLevelLanguage());
                    masterForm.SetSpecialGridProperties();

                }
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "ucEmployeeMaster", ex.ToString()); }

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
