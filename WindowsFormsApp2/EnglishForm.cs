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
    public partial class EnglishForm : Form
    {
        public EnglishForm(string name)
        {
            InitializeComponent();
            Text = name;
            if (name == "Английский язык")
            {
                label2.Text = "GDZ.Putina по английскому языку" +
                    Environment.NewLine + 
                    "сложно";
                comboBox1.Items.Clear();
                comboBox1.Items.Add("Афанасьева, Михеева");
                comboBox1.Items.Add("Пушкин");
                comboBox1.Items.Add("Лермонтов");


            }
            if (name == "Русский язык")
            {
                label2.Text = "GDZ.Putina по русскому языку" +
                      Environment.NewLine +
                    "платно";
                comboBox1.Items.Clear();
                comboBox1.Items.Add("Тростнецова");
                comboBox1.Items.Add("213s423541");

                button3.Visible = false;
            }
            if (name == "Алгебра")
            {
                label2.Text = "GDZ.Putina по алгебре" +
                      Environment.NewLine +
                    "вавла";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Да");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Location = new Point(button3.Location.X + 5, button2.Location.Y);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainForm newForm = new MainForm();
            newForm.Show();
        }

        private void EnglishForm_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }
    }
}
