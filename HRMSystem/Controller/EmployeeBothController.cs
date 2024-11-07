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
    public class EmployeeBothController : IucControlController
    {
        private ucEmployeeMaster View;
        public void Initialize(UserControl _view)
        {
            View = _view as ucEmployeeMaster;
        }
    }
}
