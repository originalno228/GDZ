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
  
    public partial class ProductForm : Form
    {
        string predmet;
        //Uchebnik[] uchebniks = new Uchebnik[3];  
    

        private static Point MouseDownLocation;//движения pictureBox1 за мышкой
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                pictureBox1.Left = e.X + pictureBox1.Left - MouseDownLocation.X;
                pictureBox1.Top = e.Y + pictureBox1.Top - MouseDownLocation.Y;
            }
        }

        public ProductForm(string name)
        {
            InitializeComponent();

            predmet = name;
            //InitializeComponent();


            //label5 = kolvo.Value;

            Text = name;
            try
            {
                pictureBox1.Load("../../../Продукты/" + name + ".jpg");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            
            
            string a = "GDZ.Putina по";

            if (name == "Овощи")
            {
                //pictureBox1.Load("../../../Продукты/бургер.txt");
                //pictureBox1.Load("../../../pictures/1.jpg");
                label2.Text = " Овощи, свежие, вкусные, да";
                //Environment.NewLine + 
                //"сложно";


              



            }

            if (name == "Английский язык")
            {
                pictureBox1.Load("../../../Продукты/бургер.txt");
                label2.Text = a + " английскому языку";
                    //Environment.NewLine + 
                    //"сложно";




            }
            if (name == "Русский язык")
            {
                label2.Text = "GDZ.Putinaf по русскому языку" +
                      Environment.NewLine +
                    "платно";

                //this.
                this.BackColor = Color.Green;
                //this.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            }
            if (name == "Алгебра")
            {
                label2.Text = "GDZ.Putina по алгебре" +
                      Environment.NewLine +
                    "Решение уравнений";
                this.BackColor = Color.Yellow;
            }

            if (name == "Геометрия")
            {
                label2.Text = "геометрии" +
                      Environment.NewLine +
                    "7-9 класс, много теорем -__-";
                this.BackColor = Color.Black;
            }

            if (name == "География")
            {
                label2.Text = "GDZ.Putina по географии" +
                      Environment.NewLine +
                    "изучения климата России";
            }
            if (name == "Физика")
            {
                label2.Text = "GDZ.Putina по физике" +
                      Environment.NewLine +
                    "Тепловые явление";
            }

            if (name == "Химия")
            {
                label2.Text = "GDZ.Putina по химии" +
                      Environment.NewLine +
                    "Соли, кислоты, оксиды...";
            }

            if (name == "История")
            {
                label2.Text = "GDZ.Putina по алгебре" +
                      Environment.NewLine +
                    "История России";
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
            MessageBox.Show("Черная тема включена!");
            BackColor = Color.Black;
            ForeColor = Color.White;
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
            if (kolvo.Value == 2)
            {
                pictureBox1.Load("../../../pictures/Химия.jpg");


            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
        
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }
    }
}
