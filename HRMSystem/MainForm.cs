using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
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

namespace HRMSystem
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void grpSystem_Click(object sender, EventArgs e)
        {
            try
            {
                AccordionControlElement grp = (AccordionControlElement)sender;
                if (!grp.Expanded) {
                    Sidebar.CollapseAll();
                    grp.Expanded = false;
                }
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, this.Name, ex.ToString()); }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                Sidebar.CollapseAll();
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, this.Name, ex.ToString()); }
        }

        private void accordionControlElement18_Click(object sender, EventArgs e)
        {

        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            clsCommon.OpenChildPage("HRMSystem.Controls.ucEmployeeMaster", "HRMSystem.Controller.EmployeeBothController", Navigator);
        }

        private void grpHome_Click(object sender, EventArgs e)
        {
            Navigator.SelectedPage = npWelcome;
        }

        private void btnProvince_Click(object sender, EventArgs e)
        {
            clsCommon.OpenChildPage("HRMSystem.Controls.ucBaseSingleList", "HRMSystem.Controller.ProvinceController", Navigator);
        }

        private void btnReligion_Click(object sender, EventArgs e)
        {
            clsCommon.OpenChildPage("HRMSystem.Controls.ucBaseSingleList", "HRMSystem.Controller.ReligionController", Navigator);
        }

        private void accordionControlElement15_Click(object sender, EventArgs e)
        {
            clsCommon.OpenChildPage("HRMSystem.Controls.ucBaseSingleList", "HRMSystem.Controller.EthnicController", Navigator);
        }

        private void accordionControlElement14_Click(object sender, EventArgs e)
        {
            clsCommon.OpenChildPage("HRMSystem.Controls.ucBaseSingleList", "HRMSystem.Controller.DutyController", Navigator);
        }

        private void accordionControlElement13_Click(object sender, EventArgs e)
        {
            clsCommon.OpenChildPage("HRMSystem.Controls.ucBaseSingleList", "HRMSystem.Controller.DepartmentController", Navigator);
        }

        private void btnSkills_Click(object sender, EventArgs e)
        {
            clsCommon.OpenChildPage("HRMSystem.Controls.ucBaseMasterDetail", "HRMSystem.Controller.ExpertiseController", Navigator);
        }

        private void accordionControlElement6_Click(object sender, EventArgs e)
        {
            clsCommon.OpenChildPage("HRMSystem.Controls.ucBaseMasterDetail", "HRMSystem.Controller.LanguageController", Navigator);
        }
    }
}