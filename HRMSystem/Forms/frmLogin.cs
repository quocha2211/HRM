using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HRMSystem.Forms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBox2.Text.Trim()) || string.IsNullOrEmpty(textBox1.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin ! ", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return ;
            }

            bool isAuthenticated = AuthenticateUser(textBox2.Text.Trim(), textBox1.Text.Trim());

            if (isAuthenticated)
            {
                MainForm frm = new MainForm();
                frm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tài khoản mật khẩu không chính xác! ", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public bool AuthenticateUser(string username, string password)
        {
            try
            {
                string hashPass = PasswordHelper.HashPassword(password);
                using (var context = new AppDbContext())
                {
                    var user = context.NguoiDungs.FirstOrDefault(x => x.TenDangNhap == username && x.MatKhau == hashPass);

                    if (user == null)
                    {
                        return false;
                    }

                    UserSession.CurrentUserRole = (UserRole)Enum.Parse(typeof(UserRole), user.Quyen);

                    return true; 
                }
            }
            catch (Exception ex)
            {
                return false;
                throw;
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
