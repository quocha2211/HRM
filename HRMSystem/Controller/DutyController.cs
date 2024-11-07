using HRMSystem.Controls;
using HRMSystem.Interfaces;
using HRMSystem.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMSystem.Controller
{
    public class DutyController : IucControlController
    {
        private ucBaseSingleList View;
        public void Initialize(UserControl _view)
        {
            View = _view as ucBaseSingleList;
            View.Load += View_Load;

        }

        private void View_Load(object sender, EventArgs e)
        {
            try
            {
                clsCommon.OpenWaitingForm(View);
                View.SetTitle("Quản lý chức vụ");
                View.SetDataSource(clsSQLAllValue.GetAllValueFromTable("ChucVu"), clsInitialGridColumn.InitialDuty());
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "DutyController", ex.ToString()); }
            finally { clsCommon.CloseWaitingForm(); }
        }
    }
}
