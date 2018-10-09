using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalDemo
{
    public partial class Signin : Form
    {
        public Signin()
        {
            InitializeComponent();
        }

      

        private void password_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Signin_Load(object sender, EventArgs e)
        {
            
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (username.Text == "admin" && password.Text == "123")
                return;

            else if (username.Text == "" || password.Text == "")
            {
                MessageBox.Show("Khong duoc de trong username hoac password");
            }
            else
                MessageBox.Show("Nhap sai usernam hoac password");
        }
    }
}
