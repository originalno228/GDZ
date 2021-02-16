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
        public Label labelPrice;//цена
        public Label labelName;//название на форме (отоброжается)
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



            //eda[0].picture = pictureBox1;
            //("../../../Продукты/бургер.txt");
            //eda[0].label2 = "a";
            eda[0].name = "овощи";
            eda[0].price = 100;

            eda[1].name = "фастфуд";
            eda[1].price = 50;

            eda[2].name = "Огурец";
            eda[2].price = 1000;

            eda[3].name = "Томат";
            eda[3].price = 9;

            eda[4].name = "Мороженное";
            eda[4].price = 75;

            //время
            label1.Text = DateTime.Now.ToString("");
          
            for (int i = 0; i < 5; i++)
            {
                //--------------Картинка--------------------------------------
                eda[i].picture = new PictureBox();
                eda[i].picture.Location = new Point(10 + 180 * i, 10);
                eda[i].picture.SizeMode = PictureBoxSizeMode.Zoom;

                eda[i].picture.Size = new Size(150, 150);
                try//попытка загрузить картинку либо jpj либо png либо до связи
                {
                    eda[i].picture.Load("../../../Продукты/" + eda[i].name + ".jpg");
                }
                catch (Exception)
                {
                    try
                    {
                        eda[i].picture.Load("../../../Продукты/" + eda[i].name + ".png");
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
                panel1.Controls.Add(eda[i].picture);

                //--------------Цена--------------------------------------

                eda[i].labelPrice = new Label();
                eda[i].labelPrice.Location = new Point(130 + 180 * i, 160);
                //eda[i].label.Location = new Point(300 * i, 200);

                eda[i].labelPrice.Size = new Size(150, 30);
                eda[i].labelPrice.Text = eda[i].price.ToString();
                panel1.Controls.Add(eda[i].labelPrice);

                //-----------------название----------------------------------------------

                eda[i].labelName = new Label();
                eda[i].labelName.Location = new Point(200 * i, 180);

                eda[i].labelName.Size = new Size(100, 30);
                eda[i].labelName.Text = eda[i].name;
                panel1.Controls.Add(eda[i].labelName);

                //Point(1000, 3000)
               /* if (Point(x) > 1000):
                {
                    Point = Point(0, y + 400)
                }*/
                


                //----------------------------------------------------------------

            }
        }

        //сортировка по цене и названию
        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {

                eda[i].picture.Visible = true;

                if (name.Text != "" &&
                    !eda[i].name.ToUpper().Contains(name.Text.ToUpper()))//по названию
                    eda[i].picture.Visible = false;

                try
                {
                    if (price.Text != "" &&
                    Convert.ToInt32(price.Text) <= eda[i].price)//по цене
                        eda[i].picture.Visible = false;
                }
                catch (Exception) { }

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
