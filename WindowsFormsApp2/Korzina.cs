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
        public Korzina()
        {
            InitializeComponent();

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
               // picture.Click += new EventHandler(Продукты.pictureBox1_Click);
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
    }
}
