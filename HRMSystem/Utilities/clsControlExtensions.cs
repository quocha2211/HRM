using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using HRMSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HRMSystem.Utilities
{
    public static class clsControlExtensions
    {
        public static List<T> ToList<T>(this DataTable table, bool isConvertDate = false) where T : new()
        {
            // Khởi tạo danh sách kết quả
            List<T> list = new List<T>();

            // Lấy tất cả các thuộc tính công khai của lớp T
            var properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (DataRow row in table.Rows)
            {
                // Tạo một đối tượng mới của T
                T obj = new T();

                foreach (var property in properties)
                {
                    // Kiểm tra nếu DataTable chứa cột có tên trùng với thuộc tính trong T
                    if (table.Columns.Contains(property.Name))
                    {
                        var value = row[property.Name];

                        // Kiểm tra nếu giá trị là DBNull
                        if (value == DBNull.Value)
                        {
                            // Nếu kiểu dữ liệu là nullable, gán giá trị null
                            if (Nullable.GetUnderlyingType(property.PropertyType) != null)
                            {
                                property.SetValue(obj, null, null);
                            }
                            // Nếu kiểu dữ liệu không nullable, bỏ qua hoặc gán giá trị mặc định
                        }
                        else
                        {
                            // Kiểm tra nếu thuộc tính là DateTime để chỉ lấy phần Date
                            if (property.PropertyType == typeof(DateTime) || Nullable.GetUnderlyingType(property.PropertyType) == typeof(DateTime))
                            {
                                // Chuyển đổi thành DateTime và chỉ lấy phần ngày
                                var dateValue = Convert.ToDateTime(value).Date;
                                property.SetValue(obj, dateValue, null);
                            }
                            else
                            {
                                // Gán giá trị từ DataTable vào thuộc tính của đối tượng T
                                property.SetValue(obj, Convert.ChangeType(value, Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType), null);
                            }
                        }
                    }
                }

                // Thêm đối tượng vào danh sách kết quả
                list.Add(obj);
            }

            return list;
        }

        public static List<T> ToList<T>(this DataTable table) where T : new()
        {
            // Khởi tạo danh sách kết quả
            List<T> list = new List<T>();

            // Lấy tất cả các thuộc tính công khai của lớp T
            var properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (DataRow row in table.Rows)
            {
                // Tạo một đối tượng mới của T
                T obj = new T();

                foreach (var property in properties)
                {
                    // Kiểm tra nếu DataTable chứa cột có tên trùng với thuộc tính trong T
                    if (table.Columns.Contains(property.Name))
                    {
                        var value = row[property.Name];

                        // Kiểm tra nếu giá trị là DBNull
                        if (value == DBNull.Value)
                        {
                            // Nếu kiểu dữ liệu là nullable, gán giá trị null
                            if (Nullable.GetUnderlyingType(property.PropertyType) != null)
                            {
                                property.SetValue(obj, null, null);
                            }
                            // Nếu kiểu dữ liệu không nullable, bỏ qua hoặc gán giá trị mặc định
                        }
                        else
                        {
                            // Gán giá trị từ DataTable vào thuộc tính của đối tượng T
                            property.SetValue(obj, Convert.ChangeType(value, Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType), null);
                        }
                    }
                }

                // Thêm đối tượng vào danh sách kết quả
                list.Add(obj);
            }

            return list;
        }
        public static void SetColumnProperties(this GridColumn col)
        {
            try
            {
                col.AppearanceHeader.Font = clsSystemSettings.CaptionColumnHeaderFont;
                col.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                col.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
                col.OptionsColumn.AllowEdit = false;
                col.OptionsColumn.ReadOnly = true;

            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "clsControlExtensions.SetColumnProperties.GridColumn", ex.ToString()); }
        }

        public static void SetColumnProperties(this TreeListColumn col)
        {
            try
            {
                col.AppearanceHeader.Font = clsSystemSettings.CaptionColumnHeaderFont;
                col.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                col.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
                col.OptionsColumn.AllowEdit = false;
                col.OptionsColumn.ReadOnly = true;

            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "clsControlExtensions.SetColumnProperties.TreeListColumn", ex.ToString()); }
        }

        public static void InitialGridColumn(this GridView grv, List<GridColumnModel> lst)
        {
            try
            {
                grv.Columns.Clear();
                foreach (GridColumnModel col in lst)
                {
                    GridColumn gc = new GridColumn()
                    {
                        Name = col.Name,
                        FieldName = col.FieldName,
                        Visible = col.Visible,
                        Caption = col.Caption,
                        Fixed = col.Frozen,

                    };
                    if(col.DisplayFormat != null)
                    {
                        gc.DisplayFormat.FormatString = "N0";
                        gc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                    }    
                    

                    grv.Columns.Add(gc);
                }
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "clsControlExtensions.SetGridControlProperties.GridView", ex.ToString()); }
        }

        public static void SetGridControlProperties(this GridView grv)
        {
            try
            {
                grv.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
                grv.OptionsFind.AlwaysVisible = true;
                foreach (GridColumn col in grv.Columns)
                {
                    col.SetColumnProperties();
                }
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "clsControlExtensions.SetGridControlProperties.GridView", ex.ToString()); }
        }

        public static void SetGridControlProperties(this TreeList tv)
        {
            try
            {
                tv.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
                //tv.OptionsFind.AlwaysVisible = true;
                foreach (TreeListColumn col in tv.Columns)
                {
                    col.SetColumnProperties();
                }
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "clsControlExtensions.SetGridControlProperties.TreeList", ex.ToString()); }
        }
    }
}
