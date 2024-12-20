﻿using DevExpress.XtraEditors;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using HRMSystem.Models;
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

namespace HRMSystem.Controls
{
    public partial class ucBangLuong : DevExpress.XtraEditors.XtraUserControl
    {
        public event EventHandler AddButtonClick;
        public event EventHandler EditButtonClick;
        public event EventHandler DeleteButtonClick;
        public event EventHandler ReLoadButtonClick;
        public delegate void SearchButtonClick(int nam, int thang, double tienAn, double bhxh);
        public SearchButtonClick searchDelegate;
        public SearchButtonClick EditClick;

        public void load()
        {

        }

        public ucBangLuong()
        {
            InitializeComponent();
            
         
            txtNam.EditValue = DateTime.Now.Year.ToString();
            txtThang.EditValue = DateTime.Now.Month.ToString();
            txtTienAn.EditValue = 25000;
            txtBHXH.EditValue = 8;
        }
        public void SetTitle(string title)
        {
            lblTitle.Text = title;
        }
        public void SetDataSource(DataTable dt, List<GridColumnModel> lstInitialGridColumn)
        {
            try
            {
                grvData.InitialGridColumn(lstInitialGridColumn);
                grdData.DataSource = dt;
                grvData.SetGridControlProperties();
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, this.Name, ex.ToString()); }
        }
        public void SetDataSource(object dt, List<GridColumnModel> lstInitialGridColumn)
        {
            try
            {
                grvData.InitialGridColumn(lstInitialGridColumn);
                grdData.DataSource = dt;
                grvData.SetGridControlProperties();
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, this.Name, ex.ToString()); }
        }
        public string GetPrimaryKey(string fieldName)
        {
            string pKey = "";
            try
            {

                object cellValue = grvData.GetRowCellValue(grvData.FocusedRowHandle, grvData.FocusedColumn);
                pKey = clsCommon.ToString(grvData.GetFocusedRowCellValue(fieldName));
                return pKey;
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, this.Name, ex.ToString()); }
            return pKey;
        }
        public object GetFocusedColumn()
        {
            return grvData.FocusedColumn;

        }
        public void SetSpecialGridProperties()
        {
            try
            {
                grvData.OptionsView.ColumnAutoWidth = false;
                grvData.BestFitColumns();
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, this.Name, ex.ToString()); }
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddButtonClick?.Invoke(sender, e);
        }
         
        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditButtonClick?.Invoke(sender, e);
        }

        private void grdData_DoubleClick(object sender, EventArgs e)
        {
            EditButtonClick?.Invoke(sender, e);
            int nam = int.Parse(txtNam.EditValue.ToString());
            int thang = int.Parse(txtThang.EditValue.ToString());
            double tienAn = double.Parse(txtTienAn.EditValue.ToString());
            double bhxh = double.Parse(txtBHXH.EditValue.ToString());

            EditClick(nam, thang, tienAn, bhxh);
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xoá không ?", "Câu hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                DeleteButtonClick?.Invoke(sender, e);
            }

        }

        private void btnLoad_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ReLoadButtonClick?.Invoke(sender, e);

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int nam = int.Parse(txtNam.EditValue.ToString());
            int thang = int.Parse(txtThang.EditValue.ToString());
            double tienAn = double.Parse(txtTienAn.EditValue.ToString());
            double bhxh = double.Parse(txtBHXH.EditValue.ToString());

            searchDelegate(nam, thang, tienAn, bhxh);

        }
    }
}
