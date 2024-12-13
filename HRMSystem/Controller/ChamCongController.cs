using DevExpress.XtraBars.Navigation;
using DevExpress.XtraGrid.Views.Base;
using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.VariantTypes;
using HRMSystem.Controls;
using HRMSystem.Forms;
using HRMSystem.Interfaces;
using HRMSystem.Utilities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HRMSystem.Controls.ucBangLuong;

namespace HRMSystem.Controller
{
    public class ChamCongController : IucControlController
    {
        private ucBaseMasterDetail View;
        public BaseController masterController;
        public ucBangLuong masterForm;
        public frmChamCongNgay detailForm;
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

        private void MasterForm_EditButtonClick(int nam, int thang)
        {
            try
            {
                detailForm = new frmChamCongNgay() { Dock = DockStyle.Fill };
                DevExpress.XtraGrid.Columns.GridColumn a = (DevExpress.XtraGrid.Columns.GridColumn) masterForm.GetFocusedColumn();
                DateTime date = new DateTime(nam, thang, Convert.ToInt32(a.FieldName));
                if (date.DayOfWeek == DayOfWeek.Sunday) return;
                detailForm.MaNV = Convert.ToInt32(masterForm.GetPrimaryKey("MaNV1"));
                detailForm.Date = date;
                detailForm.Nam = nam;
                detailForm.Thang = thang;
                var rs = detailForm.ShowDialog();
                if (rs == DialogResult.OK)
                {
                    LoadData(nam, thang);
                }
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "SalaryScaleController", ex.ToString()); }
        }



        private void MasterForm_SearchButtonClick(int nam, int thang)
        {
            LoadData(nam, thang);
        }

        private void LoadData(int nam, int thang)
        {
            try
            {
                int daysInMonth = 30;

                StringBuilder columnList = new StringBuilder();
                for (int i = 1; i <= daysInMonth; i++)
                {
                    if (i > 1)
                    {
                        columnList.Append(", ");  
                    }
                    columnList.Append($"[{i}]"); 
                }
                StringBuilder queryBuilder = new StringBuilder();

                 queryBuilder.AppendLine ( $@"
                            SELECT MaNV, {columnList} INTO #temp
    
                            FROM
                            (
                                SELECT MaNV, DAY(Ngay) AS DayOfMonth, NoiDung, IsCheck
                                FROM [dbo].[ChamCongNgay] WHERE YEAR(Ngay) = {nam} AND MONTH(Ngay)= {thang}
                            ) AS SourceTable
                            PIVOT
                            (
                                MAX(IsCheck)  
                                FOR DayOfMonth IN ({columnList})
                            ) AS PivotTable;
                            
                            ");

                queryBuilder.Append("SELECT  count(*) as SoCong, MaNV, ");

                // Thêm các cột MAX([1]), MAX([2]), ..., MAX([30])
                for (int i = 1; i <= daysInMonth; i++)
                {
                    if (i > 1)
                    {
                        queryBuilder.Append(", ");  // Thêm dấu phẩy giữa các cột
                    }

                    queryBuilder.Append($"MAX([{i}]) AS [{i}]");
                }
                queryBuilder.Append(" INTO #temp1 FROM #temp GROUP BY MaNV;");
                queryBuilder.Append("Select nv.MaNV as MaNV1, TenNV, cc.* from NhanVien nv left join #temp1 cc on nv.MaNV = cc.MaNV;\r\n                      Drop Table #temp;      Drop Table #temp1;");
                
                var query = SQLHelper.ExecuteSelect(queryBuilder.ToString());

                clsCommon.OpenWaitingForm(View);
                masterForm.SetTitle("Quản lý chấm công");
                masterForm.SetDataSource(query, clsInitialGridColumn.InitialBangChamCong());
                masterForm.SetSpecialGridProperties();
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "ucEmployeeMaster", ex.ToString()); }
            finally { clsCommon.CloseWaitingForm(); }


        }

        private void MasterController_Load(object sender, EventArgs e)
        {
            LoadData(DateTime.Now.Year, DateTime.Now.Month);
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
