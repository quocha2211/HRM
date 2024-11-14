using DevExpress.XtraBars.Navigation;
using HRMSystem.Controls;
using HRMSystem.Forms;
using HRMSystem.Interfaces;
using HRMSystem.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMSystem.Controller
{
    public class LanguageController : IucControlController
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
                masterForm.DeleteButtonClick += MasterForm_DeleteButtonClick; ;

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
                    var model = context.NgoaiNgus.Find(Convert.ToInt32(masterForm.GetPrimaryKey("MaNN")));

                    if (model != null)
                    {
                        context.NgoaiNgus.Remove(model);

                        context.SaveChanges();

                        LoadData();

                    }

                }
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "LanguageController", ex.ToString()); }
            finally { clsCommon.CloseWaitingForm(); }
        }

        private void MasterForm_EditButtonClick(object sender, EventArgs e)
        {
            try
            {
                if (masterForm == null)
                    return;
                InitialDetailPage( Convert.ToInt32(masterForm.GetPrimaryKey("MaNN")));
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "LanguageController", ex.ToString()); }
            finally { clsCommon.CloseWaitingForm(); }
        }

        private void MasterForm_AddButtonClick(object sender, EventArgs e)
        {
            try
            {
                InitialDetailPage(0);
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "LanguageController", ex.ToString()); }
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
                    var ngoaiNgu = context.NgoaiNgus.Find(id);
                    detailForm = new frmExpertisesDetail() { Dock = DockStyle.Fill };
                    detailForm.screenIndex = 1; 
                    if(id > 0)
                        detailForm.NgoaiNgu = ngoaiNgu;
                    else
                        detailForm.NgoaiNgu = new Language();
                    var rs = detailForm.ShowDialog();
                    if (rs == DialogResult.OK)
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

                    var query = context.NgoaiNgus.ToList();
                    clsCommon.OpenWaitingForm(View);
                    masterForm.SetTitle("Quản lý Ngoại ngữ");
                    masterForm.SetDataSource(query, clsInitialGridColumn.InitialLanguage());
                    masterForm.SetSpecialGridProperties();

                }
            }
            catch (Exception ex)
            {

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
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "LanguageController", ex.ToString()); }
            finally { clsCommon.CloseWaitingForm(); }
        }
    }
}
