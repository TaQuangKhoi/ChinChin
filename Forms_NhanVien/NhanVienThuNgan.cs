﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChinChin.Forms_NhanVien
{
    public partial class NhanVienThuNgan : Form
    {
        public NhanVienThuNgan()
        {
            InitializeComponent();
        }
       
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void SignOutButton_Click_1(object sender, EventArgs e)
        {
            SignIn logout = new SignIn();
            logout.Show();
            this.Hide();
        }
    }
}
