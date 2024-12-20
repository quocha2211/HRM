﻿using DocumentFormat.OpenXml.Wordprocessing;
using HRMSystem.Controls;
using HRMSystem.Interfaces;
using HRMSystem.Models;
using HRMSystem.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMSystem.Controller
{
    public class EmployeeController : IucControlController
    {
        private ucEmployee View;
        public void Initialize(UserControl _view)
        {
            View = _view as ucEmployee;
            View.Load += View_Load;

            View.DeleteButtonClick += MasterForm_DeleteButtonClick; 

            View.ReLoadButtonClick += MasterForm_ReLoadButtonClick; 
        }

        private void MasterForm_DeleteButtonClick(object sender, EventArgs e)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var model = context.NhanViens.Find(Convert.ToInt32(View.GetPrimaryKey("MaNV")));

                    if (model != null)
                    {
                        context.NhanViens.Remove(model);

                        context.SaveChanges();

                        LoadData();
                    }

                }
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "ExpertiseController", ex.ToString()); }
            finally {  }
        }

        private void MasterForm_ReLoadButtonClick(object sender, EventArgs e)
        {
            LoadData();
        }


        private void LoadData()
        {
            try
            {
                var query =   SQLHelper.GetDataTableFromSP("GetDanhSachNhanVien", new string[] { }, new object[] { });
                View.SetTitle("Quản lý Danh Sách Nhân Viên");
                View.SetDataSource(query, clsInitialGridColumn.InitialEmployee());
                View.SetSpecialGridProperties();
             
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "ExpertiseController", ex.ToString()); }
            finally { }
           

        }

        private void View_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData();
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "EmployeeController", ex.ToString()); }
            finally { clsCommon.CloseWaitingForm(); }
        }
    }
}
