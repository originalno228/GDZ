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
    public partial class Korzina : Form
    {

        void translate(Dictionary<string, string> Words)
        {
            label1.Text = Words["Общая цена"] + ":";
            button2.Text = Words["Оплатить и выйти"];
            //label6.Text = Words["Бюджет"];
        }
        public Korzina()
        {

            InitializeComponent();

            if (Продукты.Language == "Английский")
                translate(Продукты.Eng_word);
            if (Продукты.Language == "Русский")
                translate(Продукты.Ru_word);

            //время
            label3.Text = DateTime.Now.ToString("");

            int prices = 0;
            int x = 0;
            int y = 0;
            //foreach (Food eda in Продукты.aue)
            foreach (KeyValuePair<Food, int> eda1 in Продукты.korz228)
            {
                Food eda = eda1.Key;
                int count = eda1.Value;

                

                PictureBox picture = new PictureBox();
                picture.Location = new Point(x, y);
                picture.SizeMode = PictureBoxSizeMode.Zoom;
                picture.Tag = eda.name;

               

                Label lablecount = new Label();
                lablecount.Location = new Point(x, y + 160);
                lablecount.Size = new Size(100, 30);
                lablecount.Text = eda.name + " (" + count.ToString() + ")";
                lablecount.Font = new Font("Tahoma", 9, FontStyle.Bold);
                //MessageBox.Show(eda.name + " (" + count.ToString() + ")");

                picture.Size = new Size(150, 150);

                
                try//попытка загрузить картинку либо jpj либо png либо до связи
                {
                    picture.Load("../../../Продукты/" + eda.name + ".jpg");
                }
                catch (Exception)
                {
                    try
                    {
                        picture.Load("../../../Продукты/" + eda.name + ".png");
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }

                PictureBox minus = new PictureBox();
                minus.Location = new Point(x + 120, y + 150);
                minus.Size = new Size(30, 30);
                minus.SizeMode = PictureBoxSizeMode.Zoom;
                minus.Tag = eda.name;
                minus.Load("../../../pictures/минус.png");


                // picture.Click += new EventHandler(Продукты.pictureBox1_Click);

                panel1.Controls.Add(minus);
                panel1.Controls.Add(picture);
                panel1.Controls.Add(lablecount);
                prices += eda.price * count; //подсчет итоговой цены
                

                x = x + 160;
                if (x + 120 > Width)
                {
                    y = y + 180;
                    x = 10;
                }
            }

            label2.Text = prices.ToString();

        }

        private void Korzina_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();//закрыть все
        }

        private void Button_Eng_Click(object sender, EventArgs e)
        {
            translate(Продукты.Eng_word);
        }

        private void Button_Ru_Click(object sender, EventArgs e)
        {
            translate(Продукты.Ru_word);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                BackColor = colorDialog1.Color;
            }
        }
    }
}
