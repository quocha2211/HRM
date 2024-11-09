using DevExpress.XtraBars.Navigation;
using HRMSystem.Controls;
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
        public ucLanguageDetail detailForm;
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
                    var model = context.NgoaiNgus.Find(masterForm.GetPrimaryKey("MaCM"));

                    if (model != null)
                    {
                        context.NgoaiNgus.Remove(model);

                        context.SaveChanges();

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
                clsCommon.OpenWaitingForm(View);
                if (masterForm == null)
                    return;
                InitialDetailPage(masterForm.GetPrimaryKey("MaNN"));
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "LanguageController", ex.ToString()); }
            finally { clsCommon.CloseWaitingForm(); }
        }

        private void MasterForm_AddButtonClick(object sender, EventArgs e)
        {
            try
            {
                clsCommon.OpenWaitingForm(View);
                InitialDetailPage("");
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "LanguageController", ex.ToString()); }
            finally { clsCommon.CloseWaitingForm(); }
        }

        private void InitialDetailPage(string pKey)
        {
            try
            {
                View.PageDetail.Controls.Clear();
                if (detailForm != null)
                    detailForm.Dispose();
                detailForm = new ucLanguageDetail() { Dock = DockStyle.Fill };
                detailForm.MaNN = pKey;
                detailForm.BackButtonClick -= DetailForm_BackButtonClick; 
                detailForm.BackButtonClick += DetailForm_BackButtonClick;
                View.PageDetail.Controls.Add(detailForm);
                View.NavigatorFrame.SelectedPage = View.PageDetail;
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

        private void MasterController_Load(object sender, EventArgs e)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var query = (from nn in context.NgoaiNgus
                                 join tdnn in context.TrinhDoNgoaiNgus
                                 on nn.MaTDNN equals tdnn.MaTDNN
                                 select new
                                 {
                                     nn.MaNN,
                                     nn.TenNN,
                                     tdnn.TenTDNN
                                 }).ToList();

                    clsCommon.OpenWaitingForm(View);
                    masterForm.SetTitle("Quản lý Ngoại ngữ");
                    masterForm.SetDataSource(query, clsInitialGridColumn.InitialLanguage());
                    masterForm.SetSpecialGridProperties();

                }
            }
            catch(Exception ex)
            {

            }
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
