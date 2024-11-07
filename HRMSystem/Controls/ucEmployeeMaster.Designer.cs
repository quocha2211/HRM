namespace HRMSystem.Controls
{
    partial class ucEmployeeMaster
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Navigator = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.pageMaster = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.pageDetail = new DevExpress.XtraBars.Navigation.NavigationPage();
            ((System.ComponentModel.ISupportInitialize)(this.Navigator)).BeginInit();
            this.Navigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // Navigator
            // 
            this.Navigator.Controls.Add(this.pageMaster);
            this.Navigator.Controls.Add(this.pageDetail);
            this.Navigator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Navigator.Location = new System.Drawing.Point(0, 0);
            this.Navigator.Name = "Navigator";
            this.Navigator.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.pageMaster,
            this.pageDetail});
            this.Navigator.SelectedPage = this.pageMaster;
            this.Navigator.Size = new System.Drawing.Size(1362, 770);
            this.Navigator.TabIndex = 0;
            this.Navigator.Text = "navigationFrame1";
            // 
            // pageMaster
            // 
            this.pageMaster.Name = "pageMaster";
            this.pageMaster.Size = new System.Drawing.Size(1362, 770);
            // 
            // pageDetail
            // 
            this.pageDetail.Caption = "pageDetail";
            this.pageDetail.Name = "pageDetail";
            this.pageDetail.Size = new System.Drawing.Size(1362, 770);
            // 
            // ucEmployeeMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Navigator);
            this.Name = "ucEmployeeMaster";
            this.Size = new System.Drawing.Size(1362, 770);
            this.Load += new System.EventHandler(this.ucEmployeeMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Navigator)).EndInit();
            this.Navigator.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.NavigationFrame Navigator;
        private DevExpress.XtraBars.Navigation.NavigationPage pageMaster;
        private DevExpress.XtraBars.Navigation.NavigationPage pageDetail;
    }
}
