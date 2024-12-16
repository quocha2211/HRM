using DevExpress.XtraBars.Navigation;
using HRMSystem.Controls;
using HRMSystem.Forms;
using HRMSystem.Interfaces;
using HRMSystem.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HRMSystem.Controls.ucBangLuong;

namespace HRMSystem.Controller
{
    public class BangLuongController : IucControlController
    {
        private ucBaseMasterDetail View;
        public BaseController masterController;
        public ucBangLuong masterForm;
        public frmContract detailForm;
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
                masterForm = new ucBangLuong() { Dock = DockStyle.Fill };

                masterController.Initialize(masterForm);
                masterController.Load += MasterController_Load;
                masterForm.searchDelegate = new SearchButtonClick(MasterForm_SearchButtonClick);
                masterForm.EditClick = new SearchButtonClick(MasterForm_EditButtonClick);

                View.PageMaster.Controls.Add(masterForm);
                View.NavigatorFrame.SelectedPage = View.PageMaster;
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "ex", ex.ToString()); }
        }

        private void MasterForm_EditButtonClick(int nam, int thang, double tienAn, double bhxh)
        {
            try
            {
                frmTimeKeeping frm = new frmTimeKeeping() { Dock = DockStyle.Fill };
                frm.MaNV = Convert.ToInt32(masterForm.GetPrimaryKey("MaNV"));
                frm.Nam = nam;
                frm.Thang = thang;
                var rs = frm.ShowDialog();
                if (rs == DialogResult.OK)
                {
                    LoadData(nam, thang, tienAn, bhxh);
                }
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "SalaryScaleController", ex.ToString()); }
        }


        private void MasterForm_SearchButtonClick(int nam, int thang, double tienAn, double bhxh)
        {
            LoadData(nam, thang, tienAn, bhxh);
        }

        private void LoadData(int nam, int thang, double tienAn1day, double bhxhHeso)
        {
            try
            {
                DataTable query = SQLHelper.GetDataTableFromSP("GetInfoLuongNhanVien", new string[] { "@nam", "@thang" }, new object[] { nam, thang });

                DataTable dt = query;
                dt.Columns.Add("LuongCoBan", typeof(double));
                dt.Columns.Add("LuongThoiGian", typeof(double));
                dt.Columns.Add("TienK3", typeof(double));
                dt.Columns.Add("TienAn", typeof(double));
                dt.Columns.Add("TongLuong", typeof(double));
                dt.Columns.Add("BHXH", typeof(double));
                dt.Columns.Add("BHYT", typeof(double));
                dt.Columns.Add("BHTN", typeof(double));
                dt.Columns.Add("LuongGiamTru", typeof(double));
                dt.Columns.Add("LuongThucNhan", typeof(double));
                for (int i = 0; i < query.Rows.Count; i++)
                {
                    double mltt = (double)query.Rows[i]["MLTTC"]; // Mức lương tối thiểu
                    double heSo = (double)query.Rows[i]["HeSo"]; // Hệ số lương
                    double soCong = (double)query.Rows[i]["NgayCongTrongThang"]; // số công
                    double dmxx = (double)query.Rows[i]["DMXX"]; //định mức xăng xe
                    double ot = (double)query.Rows[i]["OT"]; // giờ OT
                    double soTienTU = (double)query.Rows[i]["SoTienTU"]; // số tiền tạm ứng
                    double luongcoban = mltt * heSo; // Lương cơ bản
                    double LuongThoiGian = luongcoban / 26 * soCong; // Lương thời gian
                    double TienK3 = luongcoban / 26 / 8 * ot * 2; // Tiền ot
                    double TienAn = soCong * tienAn1day; // Tiền ăn
                    double TongLuong = LuongThoiGian + TienK3 + TienAn + dmxx; // Tiền ăn
                    double BHXH = luongcoban * bhxhHeso / 100; // BHXH
                    double BHYT = luongcoban * 1.5 / 100; // BHYT
                    double BHTN = luongcoban * 1 / 100; // BHTN
                    double luongGiamTru = BHXH + BHYT + BHTN + soTienTU; // Lương giảm trừ
                    double luongThucNhan = TongLuong - luongGiamTru; // Lương thực nhận
                    query.Rows[i]["LuongCoBan"] = luongcoban;
                    query.Rows[i]["LuongThoiGian"] = LuongThoiGian;
                    query.Rows[i]["TienK3"] = TienK3;
                    query.Rows[i]["TienAn"] = TienAn;
                    query.Rows[i]["TongLuong"] = TongLuong;
                    query.Rows[i]["BHXH"] = BHXH;
                    query.Rows[i]["BHYT"] = BHYT;
                    query.Rows[i]["BHTN"] = BHTN;
                    query.Rows[i]["LuongGiamTru"] = luongGiamTru;
                    query.Rows[i]["LuongThucNhan"] = luongThucNhan;

                }

                clsCommon.OpenWaitingForm(View);
                masterForm.SetTitle("Lập bảng lương");
                masterForm.SetDataSource(query, clsInitialGridColumn.InitialBangLuong());
                masterForm.SetSpecialGridProperties();
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "ucEmployeeMaster", ex.ToString()); }
            finally { clsCommon.CloseWaitingForm(); }


        }

        private void MasterController_Load(object sender, EventArgs e)
        {
            LoadData(DateTime.Now.Year, DateTime.Now.Month, (double)25000, (double)8);
        }

        private void View_Load(object sender, EventArgs e)
        {
            try
            {
                clsCommon.OpenWaitingForm(View);
                InitialMasterPage();
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "SalaryScaleController", ex.ToString()); }
            finally { clsCommon.CloseWaitingForm(); }
        }



    }
}
