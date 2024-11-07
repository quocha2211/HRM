using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSystem.Utilities
{
    public static class clsHandleQuerySqlite
    {
        //public static List<SlideBarModel> GetAllSlideBar()
        //{
        //    List<SlideBarModel> slideBarModels = new List<SlideBarModel>(); 
        //    try
        //    {
        //        string queryCMD = "SELECT * FROM SideBar";
        //        DataTable dt = SQLiteHelper.GetTableData(queryCMD);
        //        if (dt.Rows.Count > 0)
        //        {
        //            slideBarModels = dt.ToList<SlideBarModel>();
        //            List<SlideBarIcon> lst = clsCommon.LoadImagesFromFolder(clsSystemSettings.TargetForder);
        //            foreach (SlideBarModel item in slideBarModels)
        //            {
        //                var result = lst.FirstOrDefault(e => e.Name.Contains(item.Icon));
        //                if (result != null)
        //                    item.IconImg = result.Img;
        //            }
        //        }
        //        return slideBarModels;
        //    }
        //    catch (Exception ex)
        //    {
        //        SQLiteHelper.SaveToLog(ex.Message, "clsHandleQuerySqlite", ex.ToString());
        //        return slideBarModels;
        //    }
        //}

        //public static SettingsModel GetCommonSettings()
        //{
        //    List<SettingsModel> slideBarModels = new List<SettingsModel>();
        //    try
        //    {
        //        string queryCMD = "SELECT * FROM Settings";
        //        DataTable dt = SQLiteHelper.GetTableData(queryCMD);
        //        if (dt.Rows.Count > 0)
        //        {
        //            slideBarModels = dt.ToList<SettingsModel>();
        //        }
        //        return slideBarModels[0];
        //    }
        //    catch (Exception ex)
        //    {
        //        SQLiteHelper.SaveToLog(ex.Message, "clsHandleQuerySqlite", ex.ToString());
        //        return new SettingsModel();
        //    }
        //}

        //public static SlideBarModel GetSlideBarByID(string id)
        //{
        //    SlideBarModel model = new SlideBarModel();
        //    try
        //    {
        //        string queryCMD = $"SELECT * FROM SideBar WHERE ID = {id}";
        //        DataTable dt = SQLiteHelper.GetTableData(queryCMD);
        //        if (dt.Rows.Count == 1) {
        //            model = dt.ToList<SlideBarModel>()[0];
        //        }
        //        return model;
        //    }
        //    catch (Exception ex)
        //    {
        //        SQLiteHelper.SaveToLog(ex.Message, "clsHandleQuerySqlite", ex.ToString());
        //        return model;
        //    }
        //}
    }
}
