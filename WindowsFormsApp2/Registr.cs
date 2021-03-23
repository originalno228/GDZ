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
        public Registr()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" || textBox2.Text != "")
            {
                Program.LOGIN = "aue";
                //Admin newForm = new Admin();
                //newForm.Show();
            }
            else
                MessageBox.Show("Введите хоть что-то ну епт");

            if (textBox1.Text == "1" && textBox2.Text == "1");
            {
                //Продукты newForm = new Продукты();
                //newForm.Show();
                this.Close();
                Продукты.akkaunt = "Админ";
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://vk.com/mihmet");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {   

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
