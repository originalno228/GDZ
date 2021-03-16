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

            int x = 0;
            int y = 0;
            foreach (Food eda in Продукты.aue)
            {
                PictureBox picture = new PictureBox();
                picture.Location = new Point(x, y);
                picture.SizeMode = PictureBoxSizeMode.Zoom;
                picture.Tag = eda.name;


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
                Controls.Add(picture);


                x = x + 160;
                if (x + 120 > Width)
                {
                    y = y + 180;
                    x = 10;
                }
            }
        }
    }
}
