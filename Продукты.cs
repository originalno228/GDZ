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
        public string category;

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
            eda[0].category = "фрукт";

            eda[3].name = "Томат";
            eda[3].price = 9;
            eda[0].category = "фрукт";

            eda[4].name = "Мороженное";
            eda[4].price = 75;

            eda[5].name = "Банан";
            eda[5].price = 4;
            eda[5].category = "фрукт";

            eda[6].name = "Груша";
            eda[6].price = 4;
            eda[6].category = "фрукт";

            eda[7].name = "Кокос";
            eda[7].price = 400;
            eda[7].category = "фрукт";

            eda[8].name = "Яблоко";
            eda[8].price = 400;
            eda[8].category = "фрукт";

            //время
            label1.Text = DateTime.Now.ToString("");

            int x = 10;
            int y = 10;
            for (int i = 0; i < 9; i++)
            {
                //--------------Картинка--------------------------------------
                eda[i].picture = new PictureBox();
                eda[i].picture.Location = new Point(x, y);
                eda[i].picture.SizeMode = PictureBoxSizeMode.Zoom;
                eda[i].picture.Tag = eda[i].name;

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
                eda[i].picture.Click += new EventHandler(pictureBox1_Click);
                panel1.Controls.Add(eda[i].picture);

                //--------------Цена--------------------------------------

                eda[i].labelPrice = new Label();
                if (eda[i].price <100)
                {
                    eda[i].labelPrice.ForeColor = Color.Red;
                }
                
                eda[i].labelPrice.Location = new Point(eda[i].picture.Location.X + 130, eda[i].picture.Location.Y + 150);
                //eda[i].labelPrice.Location = new Point(eda[i].picture.Location.X, eda[i].picture.y);
                //eda[i].label.Location = new Point(300 * i, 200);

                eda[i].labelPrice.Size = new Size(50, 30);
                eda[i].labelPrice.Text = eda[i].price.ToString();
                panel1.Controls.Add(eda[i].labelPrice);

                //-----------------название----------------------------------------------

                eda[i].labelName = new Label();
                eda[i].labelName.Location = new Point(x + 20, y + 150);

                eda[i].labelName.Size = new Size(100, 30);
                eda[i].labelName.Text = eda[i].name;
                panel1.Controls.Add(eda[i].labelName);

                x = x + 160;//регулируется выход за рамки экрана если еды много
                if (x + 120 > Width)
                {
                    y = y + 180;
                    x = 10;

                    eda[i].labelPrice.Location = new Point(eda[i].picture.Location.X + 130, eda[i].picture.Location.Y + 150);
                }

                //----------------------------------------------------------------

            }
        }

        //сортировка по цене и названию
        private void button2_Click(object sender, EventArgs e)
        {
            int x = 10;
            int y = 10;
            for (int i = 0; i < 5; i++)
            {
                eda[i].picture.Visible = true;

                if (Poisk.Text != "" &&
                    !eda[i].name.ToUpper().Contains(Poisk.Text.ToUpper()))//по названию
                    eda[i].picture.Visible = false;

                try
                {
                    if (price.Text != "" &&
                    Convert.ToInt32(price.Text) <= eda[i].price)//по цене
                        eda[i].picture.Visible = false;
                }
                catch (Exception) { }

                if (eda[i].picture.Visible)
                {
                    eda[i].picture.Location = new Point(x, y);
                    eda[i].labelName.Location = new Point(x, y + 150);
                    eda[i].labelPrice.Location = new Point(x+100, y + 150);
                    x = x + 160;
                    if (x + 120 > Width)
                    {
                        y = y + 180;
                        x = 10;
                    }
                }


                eda[i].labelName.Visible = eda[i].picture.Visible;
                eda[i].labelPrice.Visible = eda[i].picture.Visible;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            ProductForm newForm = new ProductForm(pb.Tag.ToString());
            newForm.Show();
        }
    }
}
