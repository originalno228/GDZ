using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class AddProducts : Form
    {
        public AddProducts()
        {
            InitializeComponent();
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            File.AppendAllText("../../../ресы.txt",
               Environment.NewLine +
               textBox1.Text + ", " + kolvo228.Value + ", " + comboBox1.Text);
            MessageBox.Show("...");


            if (address != "")
                File.Copy(address, "../../../Продукты/" + textBox1.Text + ".png");
        }

        string address = "";


        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                address = openFileDialog1.FileName;
                pictureBox1.Load(address);
            }
        }
    }
}
