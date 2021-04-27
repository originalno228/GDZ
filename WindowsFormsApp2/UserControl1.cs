using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{

    public partial class UserControl1 : UserControl
    {
        Food eda;
        int count;
        
        public UserControl1(Food eda1, int count1)
        {
            eda = eda1;
            count = count1;
            InitializeComponent();
            label1.Text = eda.name;
            label2.Text = eda.price.ToString();
            pictureBox1.Image = eda.picture.Image;
            kolvo.Value = count;
            pictureBox1.Click += new EventHandler(Продукты.pictureBox1_Click);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Продукты.korz228.Remove(eda);
            this.Parent = null;
        }

        private void kolvo_ValueChanged(object sender, EventArgs e)
        {
            if (count != kolvo.Value)
            {
                Продукты.korz228[eda] = Convert.ToInt32(kolvo.Value);
                count = Convert.ToInt32(kolvo.Value);
            }
        }
    }
}
