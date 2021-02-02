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
        //string predmet;
        public MainForm()//string predmet1)
        {
            InitializeComponent();
            //predmet = predmet1;
            //InitializeComponent();

            //pictureBox1.Load("../../Resources/" + predmet + ".jpg");
            //label1.Text =
                //File.ReadAllText("../../Resources/" + predmet + ".txt");

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EnglishForm newForm = new EnglishForm("Английский язык");
            newForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EnglishForm newForm = new EnglishForm("Русский язык");
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EnglishForm newForm = new EnglishForm("Алгебра");
            newForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EnglishForm newForm = new EnglishForm("Геометрия");
            newForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EnglishForm newForm = new EnglishForm("География");
            newForm.Show();
           // Image.
        }

        private void button6_Click(object sender, EventArgs e)
        {
            EnglishForm newForm = new EnglishForm("Физика");
            newForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            EnglishForm newForm = new EnglishForm("Химия");
            newForm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            EnglishForm newForm = new EnglishForm("История");
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
    }
}
