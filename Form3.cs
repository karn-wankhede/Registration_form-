using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username, password;
            username=textBox1.Text;
            password=textBox2.Text;
            if (password == "Karan@123"&& username=="Karan")
            {
                Form4 obj = new Form4();
                obj.Show();
            }
            else {
                MessageBox.Show("Invlalid Cred!!");
                    }
        }
    }
}
