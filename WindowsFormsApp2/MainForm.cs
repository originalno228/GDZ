using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
         

            if (Program.LOGIN == "aue")
            {
                label1.Visible = true;
                //button1.Visible = true;
                //label1.Visible = false;
            }
            else
            {
                label1.Visible = false;
               // button1.Visible = false;
            }
         
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductForm newForm = new ProductForm("Английский язык");
            newForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ProductForm newForm = new ProductForm("Русский язык");
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductForm newForm = new ProductForm("Алгебра");
            newForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProductForm newForm = new ProductForm("Геометрия");
            newForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ProductForm newForm = new ProductForm("География");
            newForm.Show();
           // Image.
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ProductForm newForm = new ProductForm("Физика");
            newForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ProductForm newForm = new ProductForm(button7.Text);
            newForm.Show();
        }

        private void OpenPrdemet(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            ProductForm newForm = new ProductForm(btn.Text);
            newForm.Show();
        }



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            label1.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://vk.com/mihmet");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Registr form2 = new Registr();
            form2.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://web-online24.ru/vologda-web-camera-online-dodo-pitstsa"); 
        }
    }
}
