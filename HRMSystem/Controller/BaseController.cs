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
    public class BaseController : IucControlController
    {

        private ucBaseSingleList View;
        private ucBaseDoubleList ucBaseDoubleList;
        private ucBangLuong BangLuong;
        private ucChamCong ChamCong;
        private ucReportTemp ReportTemp;
        public event EventHandler Load;
        public void Initialize(UserControl _view)
        {
            View = _view as ucBaseSingleList;
            View.Load += View_Load;
        }

        public void Initialize(ucBaseDoubleList _view)
        {
            ucBaseDoubleList = _view as ucBaseDoubleList;
            ucBaseDoubleList.Load += View_Load;
        }

        public void Initialize(ucBangLuong _view)
        {
            BangLuong = _view ;
            BangLuong.Load += View_Load;
        }

        public void Initialize(ucChamCong _view)
        {
            ChamCong = _view;
            ChamCong.Load += View_Load;
        }

        public void Initialize(ucReportTemp _view)
        {
            ReportTemp = _view;
            ReportTemp.Load += View_Load;
        }

        private void View_Load(object sender, EventArgs e)
        {
            try
            {
                Load?.Invoke(sender, e);
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "EmployeeController", ex.ToString()); }
            finally { clsCommon.CloseWaitingForm(); }
        }

    }
}
