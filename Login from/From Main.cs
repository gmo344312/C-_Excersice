﻿using System;
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
    public partial class From_Main : Form
    {
        public From_Main()
        {
            InitializeComponent();
        }

        private void From_Main_Load(object sender, EventArgs e)
        {
            FrmLogin frm_Login = new FrmLogin();
            frm_Login.ShowDialog();
       }
    }
}
