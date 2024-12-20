﻿using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using HRMSystem.Controls;
using HRMSystem.Forms;
using HRMSystem.Report;
using HRMSystem.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

        public bool CheckUserRole(UserRole requiredRole)
        {
            if (UserSession.CurrentUserRole != requiredRole)
            {
                MessageBox.Show("Bạn không có quyền truy cập !", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false; 
            }

            return true;
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
            clsCommon.OpenChildPage("HRMSystem.Controls.ucBaseMasterDetail", "HRMSystem.Controller.ProvinceController", Navigator);
        }

        private void btnReligion_Click(object sender, EventArgs e)
        {
            clsCommon.OpenChildPage("HRMSystem.Controls.ucBaseMasterDetail", "HRMSystem.Controller.ReligionController", Navigator);
        }

        private void accordionControlElement15_Click(object sender, EventArgs e)
        {
            clsCommon.OpenChildPage("HRMSystem.Controls.ucBaseMasterDetail", "HRMSystem.Controller.EthnicController", Navigator);
        }

        private void accordionControlElement14_Click(object sender, EventArgs e)
        {
            clsCommon.OpenChildPage("HRMSystem.Controls.ucBaseMasterDetail", "HRMSystem.Controller.DutyController", Navigator);
        }

        private void accordionControlElement13_Click(object sender, EventArgs e)
        {
            if (!CheckUserRole(UserRole.Admin))
            {
                return;
            }
            clsCommon.OpenChildPage("HRMSystem.Controls.ucBaseMasterDetail", "HRMSystem.Controller.DepartmentController", Navigator);
        }

        private void btnSkills_Click(object sender, EventArgs e)
        {
            clsCommon.OpenChildPage("HRMSystem.Controls.ucBaseMasterDetail", "HRMSystem.Controller.ExpertiseController", Navigator);
        }

        private void accordionControlElement6_Click(object sender, EventArgs e)
        {
            clsCommon.OpenChildPage("HRMSystem.Controls.ucBaseMasterDetail", "HRMSystem.Controller.LanguageController", Navigator);
        }

        private void accordionControlElement9_Click(object sender, EventArgs e)
        {
            clsCommon.OpenChildPage("HRMSystem.Controls.ucBaseMasterDetail", "HRMSystem.Controller.LevelSalaryController", Navigator);
        }

        private void accordionControlElement7_Click(object sender, EventArgs e)
        {
            clsCommon.OpenChildPage("HRMSystem.Controls.ucBaseMasterDetail", "HRMSystem.Controller.CertificateDetailController", Navigator);
        }

        private void accordionControlElement8_Click(object sender, EventArgs e)
        {
            clsCommon.OpenChildPage("HRMSystem.Controls.ucBaseMasterDetail", "HRMSystem.Controller.MinSalaryController", Navigator);

        }

        private void accordionControlElement10_Click(object sender, EventArgs e)
        {
            clsCommon.OpenChildPage("HRMSystem.Controls.ucBaseMasterDetail", "HRMSystem.Controller.PetrolNormsController", Navigator);
        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {
            clsCommon.OpenChildPage("HRMSystem.Controls.ucBaseMasterDetail", "HRMSystem.Controller.LevelExpertiseController", Navigator);
        }

        private void accordionControlElement5_Click(object sender, EventArgs e)
        {
            clsCommon.OpenChildPage("HRMSystem.Controls.ucBaseMasterDetail", "HRMSystem.Controller.LevelLanguageController", Navigator);
        }

        private void accordionControlElement11_Click(object sender, EventArgs e)
        {
            clsCommon.OpenChildPage("HRMSystem.Controls.ucBaseMasterDetail", "HRMSystem.Controller.LevelEducationalController", Navigator);
        }

        private void accordionControlElement21_Click(object sender, EventArgs e)
        {
            clsCommon.OpenChildPage("HRMSystem.Controls.ucBaseMasterDetail", "HRMSystem.Controller.EmployeeRankingController", Navigator);
        }

        private void accordionControlElement28_Click(object sender, EventArgs e)
        {
            clsCommon.OpenChildPage("HRMSystem.Controls.ucBaseMasterDetail", "HRMSystem.Controller.TimeKeepingController", Navigator);
        }

        private void accordionControlElement26_Click(object sender, EventArgs e)
        {
            clsCommon.OpenChildPage("HRMSystem.Controls.ucBaseMasterDetail", "HRMSystem.Controller.SalaryAdvanceController", Navigator);
        }

        private void accordionControlElement22_Click(object sender, EventArgs e)
        {
            clsCommon.OpenChildPage("HRMSystem.Controls.ucBaseMasterDetail", "HRMSystem.Controller.ContractController", Navigator);
        }

        private void accordionControlElement24_Click(object sender, EventArgs e)
        {
            clsCommon.OpenChildPage("HRMSystem.Controls.ucBaseMasterDetail", "HRMSystem.Controller.ThanNhanController", Navigator);
        }

        private void accordionControlElement27_Click(object sender, EventArgs e)
        {

            if (!CheckUserRole(UserRole.Admin))
            {
                return;
            }
            clsCommon.OpenChildPage("HRMSystem.Controls.ucBaseMasterDetail", "HRMSystem.Controller.BangLuongController", Navigator);
        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {
            if (!CheckUserRole(UserRole.Admin))
            {
                return;
            }
            clsCommon.OpenChildPage("HRMSystem.Controls.ucBaseMasterDetail", "HRMSystem.Controller.UserController", Navigator);
        }

        private void accordionControlElement3_Click(object sender, EventArgs e)
        {
            frmRegister frm = new frmRegister();
            frm.MaND = UserSession.LoginId;
            frm.ShowDialog();

        }

        private void accordionControlElement38_Click(object sender, EventArgs e)
        {
            if (!CheckUserRole(UserRole.Admin))
            {
                return;
            }
            clsCommon.OpenChildPage("HRMSystem.Controls.ucBaseMasterDetail", "HRMSystem.Controller.ReportController", Navigator);
        }

        private void accordionControlElement41_Click(object sender, EventArgs e)
        {
            clsCommon.OpenChildPage("HRMSystem.Controls.ucBaseMasterDetail", "HRMSystem.Controller.ReportNghiHuuController", Navigator);
        }

        private void accordionControlElement43_Click(object sender, EventArgs e)
        {
            clsCommon.OpenChildPage("HRMSystem.Controls.ucBaseMasterDetail", "HRMSystem.Controller.ReportLuongController", Navigator);
        }

        private void accordionControlElement42_Click(object sender, EventArgs e)
        {
            clsCommon.OpenChildPage("HRMSystem.Controls.ucBaseMasterDetail", "HRMSystem.Controller.ReportHopDongController", Navigator);

        }

        private void accordionControlElement19_Click(object sender, EventArgs e)
        {
            clsCommon.OpenChildPage("HRMSystem.Controls.ucBaseMasterDetail", "HRMSystem.Controller.CongTacController", Navigator);
        }

        private void accordionControlElement20_Click(object sender, EventArgs e)
        {
            clsCommon.OpenChildPage("HRMSystem.Controls.ucBaseMasterDetail", "HRMSystem.Controller.KhenThuongKyLuatController", Navigator);
        }

        private void accordionControlElement39_Click(object sender, EventArgs e)
        {
            clsCommon.OpenChildPage("HRMSystem.Controls.ucBaseMasterDetail", "HRMSystem.Controller.ReportSinhNhatController", Navigator);
        }

        private void accordionControlElement40_Click(object sender, EventArgs e)
        {
            clsCommon.OpenChildPage("HRMSystem.Controls.ucBaseMasterDetail", "HRMSystem.Controller.ReportKTKLController", Navigator);
        }

        private void accordionControlElement12_Click(object sender, EventArgs e)
        {
            clsCommon.OpenChildPage("HRMSystem.Controls.ucBaseMasterDetail", "HRMSystem.Controller.QuaTrinhLuongController", Navigator);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void accordionControlElement4_Click(object sender, EventArgs e)
        {
            SQLHelper.ExecuteSelect($"EXECUTE [dbo].[BackupDatabase] '{Application.StartupPath}'");
            if( MessageBox.Show("Backup thành công !") == DialogResult.OK)
            {
                Process.Start(Application.StartupPath);
            }    
        }

        private void Q_Click(object sender, EventArgs e)
        {
            clsCommon.OpenChildPage("HRMSystem.Controls.ucBaseMasterDetail", "HRMSystem.Controller.DaoTaoController", Navigator);
        }

        private void accordionControlElement15_Click_1(object sender, EventArgs e)
        {
            clsCommon.OpenChildPage("HRMSystem.Controls.ucBaseMasterDetail", "HRMSystem.Controller.QuaTrinhCongTacController", Navigator);
        }

        private void CHam_Click(object sender, EventArgs e)
        {
            clsCommon.OpenChildPage("HRMSystem.Controls.ucBaseMasterDetail", "HRMSystem.Controller.ChamCongController", Navigator);
        }
    }
}

