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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            label1.Text = "Hello " + Program.LOGIN;

            if (Program.LOGIN == "Навальный")
            {
                button1.Visible = true;
                label1.Visible = false;
            }
            else
            {
                label1.Visible = true;
                button1.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Пентагон взломан" + Text);
        }


    }

   
    }

