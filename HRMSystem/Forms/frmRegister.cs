using DevExpress.XtraEditors;
using DocumentFormat.OpenXml.Spreadsheet;
using HRMSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HRMSystem.Forms
{
    public partial class frmRegister : Form
    {
        public int MaNV;
        public int MaND;

        public frmRegister()
        {
            InitializeComponent();
           
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (MaND == 0)
                Register(textBox2.Text.Trim(), textBox1.Text.Trim(), textBox3.Text.Trim());
            else
                ChangePass(textBox1.Text.Trim(), textBox3.Text.Trim());
        }

        public void Register(string username, string pass, string rePass)
        {

            try
            {
                if (pass != rePass)
                {
                    MessageBox.Show("Mật khẩu không khớp vui lòng kiểm tra lại ! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (pass.Length < 6)
                {
                    MessageBox.Show("Mật khẩu tổi thiểu 6 ký tự ! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (var context = new AppDbContext())
                {
                    var user = context.NguoiDungs.FirstOrDefault(x => x.TenDangNhap == username);
                    if (user != null)
                    {
                        MessageBox.Show("Tài khoản đã được sử dụng ! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    var newAcc = new User();
                    newAcc.MaNV = MaNV;
                    newAcc.TenDangNhap = username;
                    newAcc.MatKhau = PasswordHelper.HashPassword(pass);
                    newAcc.Quyen = "User";
                    context.NguoiDungs.Add(newAcc);
                    context.SaveChanges();

                }

                DialogResult = MessageBox.Show("Thông tin đã được lưu thành công.");

                this.Close();
            }
            catch (Exception ex)
            {

            }

        }

        public void ChangePass(string pass, string rePass)
        {

            try
            {
                if (pass != rePass)
                {
                    MessageBox.Show("Mật khẩu không khớp vui lòng kiểm tra lại ! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (pass.Length < 6)
                {
                    MessageBox.Show("Mật khẩu tổi thiểu 6 ký tự ! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (var context = new AppDbContext())
                {
                    var user = context.NguoiDungs.FirstOrDefault(x => x.MaND == MaND);
                    if (user == null)
                    {
                        MessageBox.Show("Không tìm thấy tài khoản ! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    user.MatKhau = PasswordHelper.HashPassword(pass);
                    context.NguoiDungs.AddOrUpdate(user);
                    context.SaveChanges();

                }
            }
            catch (Exception ex)
            {

            }

        }



        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            if (MaND > 0)
            {
                label2.Text = "Mật khẩu cũ";
                label3.Text = "Mật khẩu mới";
                textBox2.Enabled = false;

                using (var context = new AppDbContext())
                {
                    var user = context.NguoiDungs.FirstOrDefault(x => x.MaND == MaND);
                    if (user == null)
                    {
                        return;
                    }
                    textBox2.Text = user.TenDangNhap;

                }
            }    
        }
    }
}
