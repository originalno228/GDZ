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

    public struct Uchebnik
    {
        public PictureBox picture;
        public Label label;
        public string name;
        public string str;

    }

    public partial class Продукты : Form
    {
        Uchebnik[] uchebniks = new Uchebnik[3];
        public Продукты()
        {
            InitializeComponent();

            //("../../../Продукты/бургер.txt");
            uchebniks[0].label = label1;
            uchebniks[0].name = "бургер";
            uchebniks[0].picture = pictureBox1;
            uchebniks[1].label = label2;
            uchebniks[1].name = "овощи";
            uchebniks[1].picture = pictureBox2;
            uchebniks[2].label = label3;
            uchebniks[2].name = "овощи";
            uchebniks[2].picture = pictureBox3;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                uchebniks[i].picture.Visible = false;
                if (!uchebniks[i].name.Contains(textBox1.Text))
                    
                    uchebniks[i].picture.Visible = true;

            }
        }
    }
}
