using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using HRMSystem.Controller;
using HRMSystem.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMSystem.Controls
{
    public partial class ucEmployeeMaster : DevExpress.XtraEditors.XtraUserControl
    {
        public ucEmployeeDetail detailForm;
        public EmployeeController masterController;
        public ucBaseSingleList masterForm;
        public ucEmployeeMaster()
        {
            InitializeComponent();
        }
        public void InitialMasterPage()
        {
            try
            {
                pageMaster.Controls.Clear();
                if (masterForm != null)
                    masterForm.Dispose();
                masterController = new EmployeeController();
                masterForm = new ucBaseSingleList() { Dock = DockStyle.Fill };

                masterForm.AddButtonClick -= MasterForm_AddButtonClick;
                masterForm.AddButtonClick += MasterForm_AddButtonClick;

                masterForm.EditButtonClick -= MasterForm_EditButtonClick;
                masterForm.EditButtonClick += MasterForm_EditButtonClick;

                masterController.Initialize(masterForm);
                pageMaster.Controls.Add(masterForm);
                Navigator.SelectedPage = pageMaster;
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "ucEmployeeMaster", ex.ToString()); }
        }

        private void MasterForm_EditButtonClick(object sender, EventArgs e)
        {
            try
            {
                clsCommon.OpenWaitingForm(this);
                if (masterForm == null)
                    return;
                InitialDetailPage(masterForm.GetPrimaryKey("MaNV"));
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "ucEmployeeMaster", ex.ToString()); }
            finally { clsCommon.CloseWaitingForm(); }
        }

        private void InitialDetailPage(string pKey)
        {
            try
            {
                pageDetail.Controls.Clear();
                if (detailForm != null)
                    detailForm.Dispose();
                detailForm = new ucEmployeeDetail() { Dock = DockStyle.Fill };
                detailForm.MaNV = pKey;
                detailForm.BackButtonClick -= DetailForm_BackButtonClick;
                detailForm.BackButtonClick += DetailForm_BackButtonClick;
                pageDetail.Controls.Add(detailForm);
                Navigator.SelectedPage = pageDetail;
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "ucEmployeeMaster", ex.ToString()); }
        }
       

        private void DetailForm_BackButtonClick(object sender, EventArgs e)
        {
            try
            {
                clsCommon.OpenWaitingForm(this);
                InitialMasterPage();
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "ucEmployeeMaster", ex.ToString()); }
            finally { clsCommon.CloseWaitingForm(); }
        }

        private void ucEmployeeMaster_Load(object sender, EventArgs e)
        {
            try
            {
                clsCommon.OpenWaitingForm(this);
                InitialMasterPage();
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "ucEmployeeMaster", ex.ToString()); }
            finally { clsCommon.CloseWaitingForm(); }
        }


        private void MasterForm_AddButtonClick(object sender, EventArgs e)
        {
            try
            {
                clsCommon.OpenWaitingForm(this);
                InitialDetailPage("");
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "ucEmployeeMaster", ex.ToString()); }
            finally { clsCommon.CloseWaitingForm(); }
        }
    }
}
