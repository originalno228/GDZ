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
                pictureBox1.Load("../../../pictures/1.jpg");
                label2.Text = "GDZ.Putina по английскому языку" +
                    Environment.NewLine + 
                    "сложно";
                comboBox1.Items.Clear();
                comboBox1.Items.Add("Афанасьева, Михеева");
                comboBox1.Items.Add("Пушкин");
                comboBox1.Items.Add("Лермонтов");
                if (comboBox1.Text == "Пушкин")
                {
                    pictureBox1.Load("../../../pictures/Химия.jpg");


                }


            }
            if (name == "Русский язык")
            {
                pictureBox1.Load("../../../pictures/русский.jpg");
                label2.Text = "GDZ.Putina по русскому языку" +
                      Environment.NewLine +
                    "платно";
                comboBox1.Items.Clear();
                comboBox1.Items.Add("Тростнецова");
                comboBox1.Items.Add("213s423541");

               
            }
            if (name == "Алгебра")
            {
                label2.Text = "GDZ.Putina по алгебре" +
                      Environment.NewLine +
                    "Решение уравнений";
                pictureBox1.Load("../../../pictures/Алгебра.jpg");
        
            }

            if (name == "Геометрия")
            {
                label2.Text = "GDZ.Putina по алгебре" +
                      Environment.NewLine +
                    "7-9 класс, много теорем -__-";
                pictureBox1.Load("../../../pictures/Геометрия.jpg");

            }

            if (name == "География")
            {
                label2.Text = "GDZ.Putina по география" +
                      Environment.NewLine +
                    "изучения климата России";
                pictureBox1.Load("../../../pictures/География.jpg");

            }
            if (name == "Физика")
            {
                label2.Text = "GDZ.Putina по физике" +
                      Environment.NewLine +
                    "Тепловые явление";
                pictureBox1.Load("../../../pictures/Физика.jpg");

            }

            if (name == "Химия")
            {
                label2.Text = "GDZ.Putina по химии" +
                      Environment.NewLine +
                    "Соли, кислоты, оксиды...";
                pictureBox1.Load("../../../pictures/Химия.jpg");

            }

            if (name == "История")
            {
                label2.Text = "GDZ.Putina по алгебре" +
                      Environment.NewLine +
                    "История России";
                pictureBox1.Load("../../../pictures/История.jpg");

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
           // button2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //button3.Location = new Point(button3.Location.X + 5, button2.Location.Y);
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown2.Value == 2)
            {
                pictureBox1.Load("../../../pictures/Химия.jpg");


            }
        }
    }
}
