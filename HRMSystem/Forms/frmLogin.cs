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
           using(var context = new AppDbContext())
            {
               var user = context.NguoiDungs.FirstOrDefault(x=> x.TenDangNhap == textBox2.Text.Trim() && x.MatKhau == textBox1.Text.Trim());
                if(user == null)
                {
                    MessageBox.Show("Tài khoản mật khẩu không chính xác! ");
                    return;
                }
               MainForm frm = new MainForm();
               frm.ShowDialog();
               this.Close();

            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
