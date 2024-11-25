using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.Preview;
using HRMSystem.Models;
using HRMSystem.Report;
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
    public partial class ucReportTemp : DevExpress.XtraEditors.XtraUserControl
    {
        

        public object Source;


        public ucReportTemp()
        {
            InitializeComponent();
        }
      
  

        private void ucReportTemp_Load(object sender, EventArgs e)
        {
           
        }

        private void documentViewer1_Load(object sender, EventArgs e)
        {
            documentViewer1.DocumentSource = Source;
            this.documentViewerBarManager1.DocumentViewer = this.documentViewer1;
        }
    }
}
