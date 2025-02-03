using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstname, lastname, username, gender= "", password = "karan@123", confirmpass = "karan@123", email, phone, address, age, language="", country;

            firstname = textBox1.Text;
            lastname = textBox2.Text;
            username = textBox4.Text;
            
            password = textBox5.Text;
            confirmpass = textBox3.Text;
            email = textBox8.Text;
            phone = textBox7.Text;
            address = textBox11.Text;
            age = textBox10.Text;
            
            country = comboBox2.SelectedItem.ToString();

           

                if (radioButton1.Checked == true)
                {
                    gender =radioButton1.Text;
                }
                else if (radioButton2.Checked == true)
                {
                    gender =radioButton2.Text;
                }
                else
                {
                    MessageBox.Show("please select a Gender");
                }
                if(checkBox1.Checked == true)
            {
                language=checkBox1.Text;
            }
            if (checkBox2.Checked == true)
            {
                language = checkBox2.Text;
            }
            if (checkBox3.Checked == true)
            {
                language = checkBox3.Text;
            }

            if (password == confirmpass)
                {
                SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-4RMOMRJF;Initial Catalog=a1;Integrated Security=True");
                con.Open();
                string query= $"insert into login values('{firstname}','{lastname}','{username}','{gender}','{email}','{phone}','{address}','{age}','{language}','{country}')"; 
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                Form2 obj = new Form2();
                obj.Show();

            }
            else
            {
                MessageBox.Show("invalid cread!!");
            }
              //  MessageBox.Show($"Name: {firstname}\n lastname: {lastname}\n username: {username}\n gender: {gender}\n email:{email}\n phone{phone}\n address{address}\n age{age}\n language{language}\n country{country}");

            

        }

    }
}
