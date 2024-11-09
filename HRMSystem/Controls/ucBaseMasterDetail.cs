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
    public partial class ucBaseMasterDetail : DevExpress.XtraEditors.XtraUserControl
    {
        #region param
        public ucEmployeeDetail detailForm;
        public BaseController masterController;
        public ucBaseSingleList masterForm;
        private NavigationPage _pageMaster;
        public NavigationPage PageMaster
        {
            get { return pageMaster; }
            set
            {
                if (value != null)
                {
                    pageMaster = value;
                }
            }
        }

        private NavigationPage _pageDetail;
        public NavigationPage PageDetail
        {
            get { return pageDetail; }
            set
            {
                if (value != null)
                {
                    pageDetail = value;
                }
            }
        }
        private NavigationFrame _navigator;

        public NavigationFrame NavigatorFrame
        {
            get { return Navigator; }
            set
            {
                if (value != null)
                {
                    Navigator = value;
                }
            }
        }
        #endregion

        public ucBaseMasterDetail()
        {
            InitializeComponent();
        }

        

       

        private void DetailForm_BackButtonClick(object sender, EventArgs e)
        {
            try
            {
                clsCommon.OpenWaitingForm(this);
                //InitialMasterPage();
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "ucEmployeeMaster", ex.ToString()); }
            finally { clsCommon.CloseWaitingForm(); }
        }

        private void ucEmployeeMaster_Load(object sender, EventArgs e)
        {
            try
            {
                clsCommon.OpenWaitingForm(this);
                //InitialMasterPage();
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "ucEmployeeMaster", ex.ToString()); }
            finally { clsCommon.CloseWaitingForm(); }
        }


        
    }
}
