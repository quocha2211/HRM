namespace HRMSystem.Controls
{
    partial class ucBaseMasterDetail
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
            this.Navigator.Controls.Add(this.pageDetail);
            this.Navigator.Controls.Add(this.pageMaster);
            this.Navigator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Navigator.Location = new System.Drawing.Point(0, 0);
            this.Navigator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Navigator.Name = "Navigator";
            this.Navigator.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.pageMaster,
            this.pageDetail});
            this.Navigator.SelectedPage = this.pageMaster;
            this.Navigator.Size = new System.Drawing.Size(908, 500);
            this.Navigator.TabIndex = 0;
            this.Navigator.Text = "navigationFrame1";
            // 
            // pageMaster
            // 
            this.pageMaster.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pageMaster.Name = "pageMaster";
            this.pageMaster.Size = new System.Drawing.Size(605, 325);
            // 
            // pageDetail
            // 
            this.pageDetail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pageDetail.Name = "pageDetail";
            this.pageDetail.Size = new System.Drawing.Size(605, 325);
            // 
            // ucEmployeeMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Navigator);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ucEmployeeMaster";
            this.Size = new System.Drawing.Size(908, 500);
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
