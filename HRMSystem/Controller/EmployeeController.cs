using DocumentFormat.OpenXml.Wordprocessing;
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
    public class EmployeeController : IucControlController
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
                View.SetTitle("Quản lý nhân viên");
                View.SetDataSource(SQLHelper.GetDataTableFromSP("GetNhanVienDetails", new string[0], new object[0]), clsInitialGridColumn.InitialEmployee());
                View.SetSpecialGridProperties();
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "EmployeeController", ex.ToString()); }
            finally { clsCommon.CloseWaitingForm(); }
        }
    }
}
