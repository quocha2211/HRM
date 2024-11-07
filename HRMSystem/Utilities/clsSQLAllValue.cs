using HRMSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSystem.Utilities
{
    public static class clsSQLAllValue
    {
        public static DataTable GetAllValueFromTable(string tableName)
        {
            DataTable dt = new DataTable();
            try
            {
                string[] lstParam = new string[1] { "@TableName" };
                object[] lstValue = new object[1] { $"{tableName}" };
                dt = SQLHelper.GetDataTableFromSP("GetAllColumnsFromTable", lstParam, lstValue);
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "clsInitialGridColumn", ex.ToString()); }
            return dt;
        }
    }
}
