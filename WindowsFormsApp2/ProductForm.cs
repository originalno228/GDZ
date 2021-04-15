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
  
    public partial class ProductForm : Form
    {
        string predmet;
        Food vybrannaja_eda;
        //Uchebnik[] uchebniks = new Uchebnik[3];  

        //время        label7.Text = DateTime.Now.ToString("");

    

        private static Point MouseDownLocation;//движения pictureBox1 за мышкой
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                pictureBox1.Left = e.X + pictureBox1.Left - MouseDownLocation.X;
                pictureBox1.Top = e.Y + pictureBox1.Top - MouseDownLocation.Y;
            }
        }
        void translate(Dictionary<string, string> Words)
        {
            try
            {
                label6.Text = Words["Успешно отправлено"];
                label6.Text = Words["Описание"] + ":";
                button1.Text = Words["Темная тема"];
                button3.Text = Words["Добавить в корзину"];
                button2.Text = Words["Интерфейс"];
                Button_Ru.Text = Words["Рус"];
                Button_Eng.Text = Words["Англ"];

                label6.Text = Words["Бюджет"];
            }
            catch (Exception e) 
            {
                string s = e.Message;
            }
        }

        Food food;
        public ProductForm(string name)
        {
            InitializeComponent();

            //Font = new Font("Microsoft Sans Serif", 20);
            Font = new Font("Microsoft Sans Serif", Convert.ToInt32(kolvo.Text));

            label7.Text = DateTime.Now.ToString("");

            if (Продукты.Language == "Английский")
                translate(Продукты.Eng_word);
            if (Продукты.Language == "Русский")
                translate(Продукты.Ru_word);

            foreach (Food food1 in Продукты.aue)
            {
                if (food.name == name)
                {
                    food = food1;
                }
            }

            predmet = name;

            Text = name;
            
            foreach (Food food in Продукты.eda)
            {
                //vybrannaja_eda = food.price * kolvo.Value;
                //прилетает цена с другой формы
                if (food.name == name)
                {
                    vybrannaja_eda = food;
                    label2.Text = "Цена: " + food.price.ToString();
                    label5.Text = (vybrannaja_eda.price * kolvo.Value).ToString();
                }
            }

            pictureBox1.Image = vybrannaja_eda.picture.Image;   
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //vybrannaja_eda = Продукты.eda[i].price * kolvo.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Черная тема включена!");
            BackColor = Color.Black;
            ForeColor = Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // button2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //button3.Location = new Point(button3.Location.X + 5, button2.Location.Y);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            
            label5.Text = (vybrannaja_eda.price * kolvo.Value).ToString();
            Font = new Font("Microsoft Sans Serif", Convert.ToInt32(kolvo.Text));
        }

        
        private void pictureBox2_Click_2(object sender, EventArgs e)
        {
            Продукты.aue.Add(vybrannaja_eda);

            if (!Продукты.korz228.ContainsKey(vybrannaja_eda))
                Продукты.korz228.Add(vybrannaja_eda, 1);
            else
                Продукты.korz228[vybrannaja_eda] = Продукты.korz228[vybrannaja_eda] + 1;

            label1.Visible = true;
            //PictureBox pb = (PictureBox)sender;
            //Korzina newForm = new Korzina();
            //newForm.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        { 

            Продукты.aue.Add(vybrannaja_eda);

            if (!Продукты.korz228.ContainsKey(vybrannaja_eda))
                Продукты.korz228.Add(vybrannaja_eda, 1);
            else
                Продукты.korz228[vybrannaja_eda] = Продукты.korz228[vybrannaja_eda] + 1;

            label1.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                BackColor = colorDialog1.Color;
            }
        }

        private void Button_Ru_Click(object sender, EventArgs e)
        {
            translate(Продукты.Ru_word);
        }

        private void Button_Eng_Click(object sender, EventArgs e)
        {
            translate(Продукты.Eng_word);
        }
    }
}
