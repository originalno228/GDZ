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
            if (textBox1.Text != "" || textBox2.Text != "")
            {
                Program.LOGIN = "aue";
                Admin newForm = new Admin();
                newForm.Show();
            }
            else
                MessageBox.Show("Введите хоть что-то ну епт");
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
            //if (textBox1.Text == '1')

            this.Close();
            MainForm form2 = new MainForm();
            this.Visible = false;
            form2.Show();
            this.Visible = true;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://vk.com/mihmet");
        }
    }
}
