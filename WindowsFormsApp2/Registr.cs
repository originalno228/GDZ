using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Registr : Form
    {
        public static string Login = "";
        public static string Parol = "";

        List<string> Users = new List<string>();

        public Registr()
        {
            InitializeComponent();
            Users = new List<string>();
            Users.Add("Админ"); Users.Add("Админ");
            Users.Add("1"); Users.Add("1");
           
        }
      

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://vk.com/mihmet");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*
            bool a = false;

            for (int i = 0; i < Users.Count; i += 2)
            {
                if (textBox1.Text == Users[i])
                {
                    Login = textBox1.Text;
                    Close();
                    a = true;
                }
            }

            if (!a)
                MessageBox.Show("Офигел?!");
            */

            if (checkBox1.Checked == true)
            { 
            Login = textBox1.Text;
            Parol = textBox2.Text;
            Close();
            }
            else
            {
                checkBox1.ForeColor = Color.Red;
            }
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            if (textBox2.UseSystemPasswordChar == true)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
