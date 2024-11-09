using ClosedXML.Excel;
using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.DocumentView;
using DevExpress.Utils.MVVM.Services;
using DevExpress.Utils.Svg;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using DevExpress.XtraSplashScreen;
using DocumentFormat.OpenXml.Spreadsheet;
using ExcelDataReader;
using HRMSystem.Interfaces;
using HRMSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control = System.Windows.Forms.Control;

namespace HRMSystem.Utilities
{
    public enum MessageStyle
    {
        Warning = 0,
        Notification = 1,
        Question = 2
    }
    public static class clsCommon
    {
        public static IOverlaySplashScreenHandle HandleOverlay;
        public static DateTime MIN_DATE = new DateTime(1950, 1, 1);
        private static OverlayWindowOptions OptionsOverLay = new OverlayWindowOptions(startupDelay: 1000, backColor: System.Drawing.Color.FromArgb(54, 75, 109), opacity: 0, fadeIn: true, fadeOut: true, imageSize: new Size(128, 128), rotationParameters: new ImageRotationParams(80, 100)); //
        public static string PathImages = Application.StartupPath + @"\Images";
        #region Messages
        /// <summary>
        /// Title
        /// </summary>
        //public const string Warning = "WARNING";
        //public const string Notification = "Notification";
        //public const string Question = "Question";
        /// <summary>
        /// Common Warning
        /// </summary>
        //public const string COMMON_WARNING_FAILED = "This task failed!";
        //public const string COMMON_WARNING_CODE_DUPLICATION = "Code duplication!";
        //public const string COMMON_WARNING_EMPTY_ALL = "Please fill all information!";
        //public const string COMMON_WARNING_EMPTY_ALL_VI = "Vui lòng điền đầy đủ thông tin!";
        //public const string COMMON_WARNING_EMPTY_CODE = "Please enter the Code.";
        //public const string COMMON_WARNING_EMPTY_NAME = "Please enter the Name.";
        //public const string COMMON_WARNING_EMPTY_START_DATE = "Please enter the Start Date.";
        //public const string COMMON_WARNING_EMPTY_END_DATE = "Please enter the End Date.";
        //public const string COMMON_WARNING_COMPARE_START_DATE_END_DATE = "The start date cannot be greater than the end date.  Please choose again!";
        //public const string COMMON_WARNING_EXIST_FILE_V = "Tệp đã tồn tại!";
        //public const string COMMON_WARNING_EXIST_SHIFT_V = "Ca làm việc này đã được chọn!";
        //public const string COMMON_WARNING_EMPTY_TIME_USER_HISTORY_V = "Vui lòng chọn thời gian trước!";
        //public const string COMMON_WARNING_EXIST_FILE = "The file already exist!";
        /// <summary>
        /// Common Notification
        /// </summary>
        //public const string COMMON_NOTIFICATION_SUCCESSFULL = "Successfully!";
        //public const string COMMON_NOTIFICATION_SUCCESSFULL_VI = "Thành công!";
        /// <summary>
        /// Common Question
        /// </summary>
        //public const string COMMON_QUESTION_DELETE = "Are you sure to delete this record?";
        //public const string COMMON_QUESTION_DELETE_VI = "Bạn có muốn xóa bản ghi này không?";
        //public const string COMMON_QUESTION_DELETE_EXPORTED_DATA_VI = "Toàn bộ dữ liệu Excel cũ sẽ bị xóa. Bạn có muốn tiếp tục không ?";
        //public const string COMMON_QUESTION_RESTORE_VI = "Bạn có muốn khôi phục lại ghi này không?";
        //public const string COMMON_QUESTION_DELETE_All_VI = "Bạn có muốn xóa tất cả bản ghi không?";
        //public const string COMMON_QUESTION_EXIT_VI = "Bản ghi chưa được lưu. Bạn có muốn thoát không?";

        //public const string Project_Infor_Overview_Duplication = "Overview duplication!";
        //public const string User_Detail_WARNING_Empty_Password = "Please enter the Password.";
        //public static DialogResult ShowMess(string contentCode, MessageStyle messageStyle, bool isCommon = true)
        //{
        //    // Đặt ngôn ngữ hiện tại
        //    Thread.CurrentThread.CurrentUICulture = new CultureInfo(clsSystemSettings.LangCode);
        //    string title = "";
        //    string content = isCommon ? clsSystemSettings.ResourceManager.GetString(contentCode) : clsSystemSettings.ResourceSpecial.GetString(contentCode);
        //    if (messageStyle == MessageStyle.Warning)
        //    {
        //        title = clsSystemSettings.ResourceManager.GetString("Common_Message_Title_Warning");
        //        return MessageBox.Show(content, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    else if (messageStyle == MessageStyle.Notification)
        //    {
        //        title = clsSystemSettings.ResourceManager.GetString("Common_Message_Title_Notification");
        //        return MessageBox.Show(content, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    else
        //    {
        //        title = clsSystemSettings.ResourceManager.GetString("Common_Message_Title_Question");
        //        return MessageBox.Show(content, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //    }

        //}
        #endregion Messages


        //public static List<SlideBarIcon> LoadImagesFromFolder(string folderPath)
        //{
        //    // Khởi tạo danh sách chứa các đối tượng Image
        //    List<SlideBarIcon> images = new List<SlideBarIcon>();

        //    // Các đuôi file ảnh mà bạn muốn lấy
        //    string[] extensions = { "*.jpg", "*.png", "*.bmp", "*.gif", "*.svg" };

        //    try
        //    {
        //        // Lấy tất cả các file với các đuôi được định nghĩa trong folder
        //        foreach (var extension in extensions)
        //        {
        //            string[] files = Directory.GetFiles(folderPath, extension);
        //            foreach (var file in files)
        //            {
        //                try
        //                {
        //                    // Kiểm tra nếu file là SVG
        //                    if (Path.GetExtension(file).ToLower() == ".svg")
        //                    {
        //                        // Sử dụng SharpVectors để tải SVG
        //                        SlideBarIcon svgIcon = LoadSvgImage(file);
        //                        if (svgIcon != null)
        //                        {
        //                            images.Add(svgIcon);
        //                        }
        //                    }
        //                    else
        //                    {
        //                        // Xử lý ảnh bitmap với System.Drawing
        //                        using (Image img = Image.FromFile(file))
        //                        {
        //                            Image newImg = (Image)img.Clone();
        //                            SlideBarIcon newItem = new SlideBarIcon() { Name = Path.GetFileName(file), Img = newImg };
        //                            images.Add(newItem);  // Clone để giải phóng tài nguyên
        //                        }
        //                    }
        //                }
        //                catch (Exception ex)
        //                {
        //                    SQLiteHelper.SaveToLog(ex.Message, "LoadImagesFromFolder", ex.ToString());
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        SQLiteHelper.SaveToLog(ex.Message, "LoadImagesFromFolder", ex.ToString());
        //    }

        //    // Trả về danh sách ảnh đã tải
        //    return images;
        //}

        //private static SlideBarIcon LoadSvgImage(string filePath)
        //{
        //    try
        //    {
        //        SvgImage image = SvgImage.FromFile(filePath);

        //        SvgBitmap bm = new SvgBitmap(image);

        //        Image img = bm.Render(null, 1.0);
        //        return new SlideBarIcon() { Name = Path.GetFileName(filePath), Img = img };
        //    }
        //    catch (Exception ex)
        //    {
        //        // Log lỗi nếu không thể tải file SVG
        //        SQLiteHelper.SaveToLog(ex.Message, "LoadSvgImage", ex.ToString());
        //        return null;
        //    }
        //}
        public static void initialValue(string tableName, string valueMember, string displayMember, GridView grv, SearchLookUpEdit cbo, List<GridColumnModel> lst)
        {
            try
            {
                grv.InitialGridColumn(lst);
                cbo.Properties.DataSource = clsSQLAllValue.GetAllValueFromTable(tableName);
                cbo.Properties.ValueMember = valueMember;
                cbo.Properties.DisplayMember = displayMember;
                grv.SetGridControlProperties();

            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "ucEmployeeDetail", ex.ToString()); }
        }
        public static void OpenChildPage(string userControlName, string controllerName, NavigationFrame navigator)
        {
            try
            {
                //string controllerName = $"{userControlName.Replace(".Controls", ".BusinessLogic")}Controller";
                // Sử dụng reflection để tạo UserControl từ tên chuỗi
                Type userControlType = Type.GetType(userControlName);
                if (userControlType != null && userControlType.IsSubclassOf(typeof(UserControl)))
                {
                    // Tạo page mới
                    NavigationPage np = new NavigationPage() { Name = $"{"page" + controllerName.Replace("Controller", "")}" };

                    // Tìm page theo tên
                    NavigationPage page = navigator.Pages.FirstOrDefault(e => e.Name == np.Name) as NavigationPage;
                    if (page == null)
                    {
                        navigator.Pages.Add(np);
                        page = np; // Nếu không có page, thêm và dùng page mới
                    }

                    // Kiểm tra nếu page đã được chọn
                    if (navigator.SelectedPage == page)
                        return;

                    // Xóa các control hiện tại trong page
                    page.Controls.Clear();

                    // Tạo UserControl bằng reflection
                    UserControl uc = (UserControl)Activator.CreateInstance(userControlType);
                    uc.Dock = DockStyle.Fill;

                    // Sử dụng reflection để tạo Controller tương ứng
                    Type controllerType = Type.GetType(controllerName);
                    if (controllerType != null && typeof(IucControlController).IsAssignableFrom(controllerType))
                    {
                        IucControlController controller = (IucControlController)Activator.CreateInstance(controllerType);
                        controller.Initialize(uc); // Khởi tạo controller với UserControl
                    }
                    else
                    {
                        throw new ArgumentException($"Controller '{controllerName}' không tồn tại hoặc không hợp lệ.");
                    }

                    // Thêm UserControl vào page
                    page.Controls.Add(uc);

                    // Chọn page
                    navigator.SelectedPage = page;
                }
                else
                {
                    throw new ArgumentException($"UserControl '{userControlName}' không tồn tại hoặc không hợp lệ.");
                }
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, userControlName, ex.ToString()); }
        }

        public static void OpenWaitingForm(Control frm)
        {
            CloseWaitingForm();
            //Point StartPosition = new Point((Screen.PrimaryScreen.Bounds.Width / 2) - 123, (Screen.PrimaryScreen.Bounds.Height / 2) - 36);
            //SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, SplashFormStartPosition.Manual, StartPosition);
            HandleOverlay = SplashScreenManager.ShowOverlayForm(frm, OptionsOverLay);
        }
        public static void CloseWaitingForm()
        {
            if (HandleOverlay != null)
            {
                HandleOverlay.Close();
                HandleOverlay.Dispose();
            }
        }
        public static void OpenChildForm(PanelControl pnl, XtraUserControl userControl)
        {
            try
            {
                if (pnl.Controls[0].Name == userControl.Name)
                    return;
                pnl.Controls.Clear();
                pnl.Controls.Add(userControl);
                userControl.Dock = DockStyle.Fill;
                userControl.BringToFront();
            }
            catch (Exception)
            {
                throw;
            }
        }

        #region 01. Convert type
        public static string ToString(object x)
        {
            if (x != null)
            {
                return x.ToString().Trim();
            }
            return "";
        }
        public static int ToInt2(object x)
        {
            try
            {
                return Convert.ToInt32(x);
            }
            catch
            {
                return -1;
            }
        }
        /// <summary>
        /// Chuyển giá trị sang kiểu integer
        /// </summary>
        /// <param name="x">giá trị cần chuyển</param>
        /// <returns></returns>
        public static int ToInt(object x)
        {
            try
            {
                return Convert.ToInt32(x);
            }
            catch
            {
                return 0;
            }
        }

        /// <summary>
        /// Chuyển giá trị sang kiểu long
        /// </summary>
        /// <param name="x">giá trị cần chuyển</param>
        /// <returns></returns>
        public static Int64 ToInt64(object x)
        {
            try
            {
                return Convert.ToInt64(x);
            }
            catch
            {
                return 0;
            }
        }

        /// <summary>
        /// Chuyển giá trị sang kiểu decimal
        /// </summary>
        /// <param name="x">giá trị cần chuyển</param>
        /// <returns></returns>
        public static Decimal ToDecimal(object x)
        {
            try
            {
                return Convert.ToDecimal(x);
            }
            catch
            {
                return 0;
            }
        }

        /// <summary>
        /// Chuyển giá trị sang kiểu double
        /// </summary>
        /// <param name="x">giá trị cần chuyển</param>
        /// <returns></returns>
        public static Double ToDouble(object x)
        {
            try
            {
                return Convert.ToDouble(x);
            }
            catch
            {
                return 0;
            }
        }

        /// <summary>
        /// Chuyển giá trị sang kiểu bool
        /// </summary>
        /// <param name="x">giá trị cần chuyển</param>
        /// <returns></returns>
        public static bool ToBoolean(object x)
        {
            try
            {
                return Convert.ToBoolean(x);
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Chuyển giá trị chuỗi sang kiểu datetime
        /// </summary>
        /// <param name="date">chuỗi cần chuyển</param>
        /// <returns></returns>
        public static DateTime ToDate(string date)
        {
            try
            {
                try
                {
                    return DateTime.Parse(date, new CultureInfo("en-US", true));
                }
                catch
                {
                    return DateTime.Parse(date, new CultureInfo("fr-FR", true));
                }
            }
            catch
            {
                return MIN_DATE;
            }
        }

        public static DateTime ToDate1(string date)
        {
            try
            {
                try
                {
                    return DateTime.Parse(date, new CultureInfo("vi-VN", true));
                }
                catch
                {
                    return DateTime.Parse(date, new CultureInfo("fr-FR", true));
                }
            }
            catch
            {
                return MIN_DATE;
            }
        }

        public static DateTime? ToDate2(object x)
        {
            string date = "";
            if (x != null)
            {
                date = x.ToString();
            }
            try
            {
                try
                {
                    return DateTime.Parse(date, new CultureInfo("en-US", true));
                }
                catch
                {
                    return DateTime.Parse(date, new CultureInfo("fr-FR", true));
                }
            }
            catch
            {
                return null;
            }
        }

        public static DateTime ToDate3(object x)
        {
            string date = "";
            if (x != null)
            {
                date = x.ToString();
            }
            try
            {
                try
                {
                    return DateTime.Parse(date, new CultureInfo("en-US", true));
                }
                catch
                {
                    return DateTime.Parse(date, new CultureInfo("fr-FR", true));
                }
            }
            catch
            {
                return MIN_DATE;
            }
        }

        /// <summary>
        /// Chuyển giá trị datetime sang kiểu chuỗi ngày tháng định dạng Việt Nam
        /// </summary>
        /// <param name="date">Ngày cần chuyển</param>
        /// <returns></returns>
        public static string DateToStringVN(DateTime date)
        {
            return date.ToString("dd/MM/yyyy");
        }

        /// <summary>
        /// Chuyển dạng số thành dạng %
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static string FormatPercentNumber(Decimal x)
        {
            return String.Format("{0:#0.00}%", x);
        }
        public static Guid ToGuid(object value)
        {
            string val = string.Empty;
            try
            {
                val = Convert.ToString(value);
                return Guid.Parse(val);
            }
            catch (Exception ex) { return new Guid(); }


        }
        #endregion 01. Convert type

        public static void ExportExcelAutoFitCollumn(DevExpress.XtraGrid.Views.Grid.GridView grvData)
        {
            try
            {
                //grvData.OptionsPrint.UsePrintStyles = true;
                //grvData.OptionsPrint.ExpandAllDetails = true;
                //grvData.OptionsPrint.PrintDetails = true;
                if (grvData.RowCount == 0) return;
                string date = DateTime.Now.ToString("yyMM");
                FolderBrowserDialog ofd = new FolderBrowserDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string moduleCode = $"History{date}_{DateTime.Now.ToString("HH_mm_ss")}";
                    string filepath = ofd.SelectedPath + "//" + moduleCode; //+ ".xls"
                    grvData.SaveLayoutToXml($"{filepath}.xml");
                    grvData.OptionsPrint.AutoWidth = false;
                    //grvData.OptionsView.ColumnAutoWidth = false;
                    grvData.BestFitColumns(true);
                    if (filepath != "")
                    {
                        try { grvData.ExportToXls($"{filepath}.xls", new XlsExportOptionsEx { ExportType = DevExpress.Export.ExportType.WYSIWYG }); }
                        catch
                        {
                            //grvData.ExportToExcelOld(filepath); 
                        }
                        Process.Start($"{filepath}.xls");
                    }
                    grvData.RestoreLayoutFromXml($"{filepath}.xml");
                    File.Delete($"{filepath}.xml");
                }
            }
            catch (Exception ex)
            {

                throw;
            }

        }
        public static DataTable ReadCsvFile(string filePath, bool hasHeader = true)
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (var reader = new StreamReader(filePath))
                {
                    // Đọc dòng đầu tiên để tạo cột cho DataTable
                    string firstLine = reader.ReadLine();
                    if (firstLine == null)
                    {
                        Console.WriteLine("Tệp CSV trống hoặc không thể đọc được.");
                        return null;
                    }

                    // Phân tách dòng đầu tiên để lấy tiêu đề cột hoặc dữ liệu dòng đầu tiên
                    string[] headers = firstLine.Split(',');

                    // Nếu có tiêu đề, tạo cột từ dòng đầu tiên
                    if (hasHeader)
                    {
                        foreach (var header in headers)
                        {
                            dataTable.Columns.Add(header);
                        }
                    }
                    else
                    {
                        // Nếu không có tiêu đề, tạo cột mặc định (Column1, Column2, ...)
                        for (int i = 0; i < headers.Length; i++)
                        {
                            dataTable.Columns.Add($"Column{i + 1}");
                        }

                        // Thêm dòng đầu tiên vào DataTable vì nó là dữ liệu chứ không phải tiêu đề
                        dataTable.Rows.Add(headers);
                    }

                    // Đọc và thêm các dòng còn lại vào DataTable
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] values = line.Split(',');

                        // Đảm bảo số lượng giá trị tương ứng với số lượng cột
                        if (values.Length != dataTable.Columns.Count)
                        {
                            Console.WriteLine("Số lượng giá trị trong dòng không khớp với số lượng cột.");
                            continue;
                        }

                        dataTable.Rows.Add(values);
                    }
                }

                return dataTable;
            }
            catch (Exception ex)
            {
                // Log thông tin chi tiết ngoại lệ
                Console.WriteLine($"Lỗi khi đọc tệp CSV: {ex.Message}");
                return null;
            }
        }
        public static DataTable ReadExcelToDataTable(string filePath)
        {
            var dataTable = new DataTable();

            // Kiểm tra file có tồn tại không
            if (!File.Exists(filePath))
            {
                Console.WriteLine("File không tồn tại.");
                return null;
            }

            // Sử dụng ClosedXML để mở và đọc file Excel
            using (var workbook = new XLWorkbook(filePath))
            {
                // Lấy trang tính đầu tiên
                var worksheet = workbook.Worksheet(1);

                // Lấy hàng đầu tiên để tạo cột cho DataTable
                var firstRow = worksheet.FirstRowUsed();
                foreach (var cell in firstRow.Cells())
                {
                    dataTable.Columns.Add(cell.Value.ToString()); // Tạo cột cho DataTable
                }

                // Lấy dữ liệu từ hàng tiếp theo
                var rows = worksheet.RowsUsed().Skip(1); // Bỏ qua hàng tiêu đề

                foreach (var row in rows)
                {
                    var dataRow = dataTable.NewRow();
                    int columnIndex = 0;
                    foreach (var cell in row.Cells())
                    {
                        dataRow[columnIndex] = cell.Value;
                        columnIndex++;
                    }
                    dataTable.Rows.Add(dataRow);
                }
            }

            return dataTable;
        }
        public static DataTable ConvertCsvToDataTable(string filePath)
        {
            //Load xlsx
            try
            {
                // Sử dụng `using` để đảm bảo `FileStream` và `IExcelDataReader` được đóng đúng cách
                using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                    {
                        // Sử dụng cấu hình `UseHeaderRow = true` nếu tệp Excel có tiêu đề
                        DataSet ds = reader.AsDataSet(new ExcelDataSetConfiguration()
                        {
                            UseColumnDataType = false,
                            ConfigureDataTable = (tableReader) => new ExcelDataTableConfiguration()
                            {
                                UseHeaderRow = true // Đổi thành true nếu tệp có tiêu đề
                            }
                        });

                        // Kiểm tra nếu không có bảng hoặc bảng rỗng
                        if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
                        {
                            Console.WriteLine("Không tìm thấy dữ liệu trong tệp Excel.");
                            return null;
                        }

                        return ds.Tables[0];
                    }
                }
            }
            catch (Exception ex)
            {
                // Log chi tiết ngoại lệ để biết thêm thông tin về lỗi
                Console.WriteLine($"Lỗi khi đọc tệp Excel: {ex.Message}");
                return null;
            }


        }

    }
}
