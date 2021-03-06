﻿using System;
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
        void Translate(Dictionary<string, string> Words)
        {
            label1.Text = Words["Общая цена"] + ":";
            button2.Text = Words["Оплатить и выйти"];
            button3.Text = Words["Очистить корзину"];
            Button_Ru.Text = Words["Рус"];
            Button_Eng.Text = Words["Англ"];
            //button3.Text = Words["Интерфейс"];
            //label6.Text = Words["Бюджет"];
        }
        public Korzina()
        {

            InitializeComponent();

            BackColor = Properties.Settings.Default.SaveColor3;
            panel1.BackColor = Properties.Settings.Default.SaveColorPanel2;


            if (Продукты.Language == "Английский")
                Translate(Продукты.Eng_word);
            if (Продукты.Language == "Русский")
                Translate(Продукты.Ru_word);

            int prices = 0;
            int x = 0;
            int y = 0;
            //foreach (Food eda in Продукты.aue)

            foreach (KeyValuePair<Food, int> eda1 in Продукты.korz228)
            {
                Food eda = eda1.Key;
                int count = eda1.Value;

                UserControl1 picture = new UserControl1(eda, count);
                picture.Location = new Point(x, y);
                panel1.Controls.Add(picture);
                
                x = x + 250;
                if (x + 450 > Width)
                {
                    y = y + 250;
                    x = 10;
                }
            }

            //private void numericUpDown2_ValueChanged(object sender, EventArgs e)
            {

                //label2.Text = ( eda.price * count).ToString();
                // Font = new Font("Microsoft Sans Serif", Convert.ToInt32(kolvo.Text));
            }

            int Time1 = 0;
            int Time228 = Environment.TickCount;
            if (Time228 - Time1 > 20)
            {
                // button4.Visible = false;


                foreach (KeyValuePair<Food, int> eda1 in Продукты.korz228)
                {
                    Food eda = eda1.Key;
                    int count = eda1.Value;
                    label2.Text = (eda.price * count).ToString(); //подсчет итоговой цены


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
            
            Продукты.Language = "Английский";
            Translate(Продукты.Eng_word);
        }

        private void Button_Ru_Click(object sender, EventArgs e)
        {
            Продукты.Language = "Русский";
            Translate(Продукты.Ru_word);
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

        private void minus_Click(object sender, EventArgs e)
        {
            // count -= 1;
            //Продукты.korz228[vybrannaja_eda] - 1;
            this.Close();

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {

                BackColor = colorDialog1.Color;
                Properties.Settings.Default.SaveColor3 = BackColor;
                Properties.Settings.Default.Save();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                panel1.BackColor = colorDialog1.Color;
                Properties.Settings.Default.SaveColorPanel2 = panel1.BackColor;
                Properties.Settings.Default.Save();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены", "Вы уверены", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Продукты.korz228.Clear();
                panel1.Controls.Clear();
                label2.Text = 0.ToString();
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
