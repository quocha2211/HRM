
using DevExpress.XtraBars.Navigation;
using HRMSystem.Controls;
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
    public class DutyController : IucControlController
    {
        private ucBaseMasterDetail View;
        public BaseController masterController;
        public ucBaseSingleList masterForm;
        public ucDutyDetail detailForm;
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
                    var model = context.ChucVus.Find(masterForm.GetPrimaryKey("MaChucVu"));

                    if (model != null)
                    {
                        context.ChucVus.Remove(model);

                        context.SaveChanges();

                    }

                }
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "ChucVuController", ex.ToString()); }
            finally { clsCommon.CloseWaitingForm(); }
        }


        private void MasterForm_EditButtonClick(object sender, EventArgs e)
        {
            try
            {
                clsCommon.OpenWaitingForm(View);
                if (masterForm == null)
                    return;
                InitialDetailPage(masterForm.GetPrimaryKey("MaChucVu"));
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "ChucVuController", ex.ToString()); }
            finally { clsCommon.CloseWaitingForm(); }
        }

        private void MasterForm_AddButtonClick(object sender, EventArgs e)
        {
            try
            {
                clsCommon.OpenWaitingForm(View);
                InitialDetailPage("");
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "ChucVuController", ex.ToString()); }
            finally { clsCommon.CloseWaitingForm(); }
        }

        private void InitialDetailPage(string pKey)
        {
            try
            {
                View.PageDetail.Controls.Clear();
                if (detailForm != null)
                    detailForm.Dispose();
                detailForm = new ucDutyDetail() { Dock = DockStyle.Fill };
                detailForm.MaCV = pKey;
                detailForm.BackButtonClick -= DetailForm_BackButtonClick; ;
                detailForm.BackButtonClick += DetailForm_BackButtonClick;
                View.PageDetail.Controls.Add(detailForm);
                View.NavigatorFrame.SelectedPage = View.PageDetail;
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "ChucVuController", ex.ToString()); }
        }

        private void DetailForm_BackButtonClick(object sender, EventArgs e)
        {
            try
            {
                clsCommon.OpenWaitingForm(View);
                InitialMasterPage();
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "ChucVuController", ex.ToString()); }
            finally { clsCommon.CloseWaitingForm(); }
        }

        private void MasterController_Load(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                var query = context.ChucVus.ToList();

                clsCommon.OpenWaitingForm(View);
                masterForm.SetTitle("Quản lý Chức vụ");
                masterForm.SetDataSource(query, clsInitialGridColumn.InitialDuty());
                masterForm.SetSpecialGridProperties();

            }


        }

        private void View_Load(object sender, EventArgs e)
        {
            try
            {
                clsCommon.OpenWaitingForm(View);
                InitialMasterPage();
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "ChucVuController", ex.ToString()); }
            finally { clsCommon.CloseWaitingForm(); }
        }



    }
}
