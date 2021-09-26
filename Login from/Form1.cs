using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_from
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        //khai báo user
        private User_admin _user; 
        private void Form1_Load(object sender, EventArgs e)
        {
            Usertxt.Focus(); //chỉ trỏ chuột vào ô điền user
            _user = new User_admin(); //khởi tạo ds user
            lblErr.Text = "UserName/Password = admin";

        }
        private void Loginbtn_click(object sender, EventArgs e)
        {
            //kiem tra 2 txtbox co nhap hay khong
            if (!string.IsNullOrEmpty(Usertxt.Text))
            {
                if (!string.IsNullOrEmpty(Passtxt.Text))
                {
                    //kiem tra xem txt vua nhap co trung voi username va pass hay khong--> if...else...

                    if (KiemTraDangNhap(Usertxt.Text, Passtxt.Text))
                    {
                        //Kiem tra bien nho
                        _user.user.Remember = Remembertick.Checked;
                        Cls_Main._staticUser = _user.user;
                        this.Close();
                    }
                    else
                    {
                        lblErr.Text = "UserName or Password wrong";
                    }
                }
            }
        }
        //ktra chuổi nhập vào có trùng với ds user kh
        private bool KiemTraDangNhap(string userName, string passWord)
        {
            if (_user.user.UserName.Equals(userName) && _user.user.PassWord.Equals(passWord))
            {
                return true;
            }
            return false;
        }
        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (_user.user.Remember)
            {
                Remembertick.Checked = true;

                Passtxt.Text = _user.user.PassWord;
                Loginbtn.Focus();
            }
        }

        private void Btn_Registerclick(object sender, EventArgs e)
        {
            From_Register frm_Reg = new From_Register();
            frm_Reg.ShowDialog();
        }
    }
}
