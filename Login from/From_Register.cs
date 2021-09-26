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
    public partial class From_Register : Form
    {
        public From_Register()
        {
            InitializeComponent();
        }
        //khai bao ham user

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public class User_admin
        {
            public User user;
            public User_admin()
            {
                user = new User() { ID = 2, UserName = "", PassWord = "", Remember = true };
            }
        }
        private void Register_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.ToString();
        }
    }
}
