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

    public struct Food
    {
        public PictureBox picture;
        public Label label;
        public string name;
        public string str;
        public int price;

    }

    public partial class Продукты : Form
    {
        Food[] eda = new Food[500];
        public Продукты()
        {
            InitializeComponent();

            //("../../../Продукты/бургер.txt");
            eda[0].label = label1;
            eda[0].name = "овощи";
            eda[0].picture = pictureBox1;
            eda[0].price = 100;

            eda[1].label = label2;
            eda[1].name = "фастфуд";
            eda[1].price = 50;
            eda[1].picture = pictureBox2;

            eda[2].label = label3;
            eda[2].name = "вкусно";
            eda[2].picture = pictureBox3;
            eda[2].price = 1000;

            eda[3].label = label5;
            eda[3].name = "Томат";
            eda[3].picture = pictureBox4;
            eda[3].price = 9;

            eda[4].label = label4;
            eda[4].name = "Мороженное";
            eda[4].picture = pictureBox5;
            eda[4].price = 75;

            for (int i = 0; i < 5; i++)
            {
                eda[i].label.Text = eda[i].price.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {

                eda[i].picture.Visible = true;

                if (name.Text != "" &&
                    !eda[i].name.ToUpper().Contains(name.Text.ToUpper()))
                    eda[i].picture.Visible = false;

                if (price.Text != "" &&
                    Convert.ToInt32(price.Text) >= eda[i].price)
                    eda[i].picture.Visible = false;

                //eda[i].picture.Visible = false;
                //if (!eda[i].name.Contains(textBox1.Text))
                    
                   // eda[i].picture.Visible = true;

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            EnglishForm newForm = new EnglishForm("Овощи");
            newForm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            EnglishForm newForm = new EnglishForm("Фастфуд");
            newForm.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            EnglishForm newForm = new EnglishForm("ДА");
            newForm.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            
        }
    }
}
