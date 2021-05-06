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
   
    public struct Food
    {
        public PictureBox picture;
        public Label labelPrice;//цена
        public Label labelName;//название на форме (отоброжается)
        public string name;
        public int price;
       
        public string category;

        public Food(string _name, int _price, string _category)
        {
            labelName = new Label();
            labelPrice = new Label();
            picture = new PictureBox();

            category = _category;
            name = _name;
            price = _price;
        }
    }

    public partial class Продукты : Form
    {
        public static List<Food> eda = new List<Food>();
        public int lol;//kolvo

        //public static Korzina[] korz = new Korzina[10];
        /// <summary>
        /// Собираем хавчик пацанам на зону
        /// </summary>
        public static List<Food> aue = new List<Food>();
        //создание словаря полезно
        public static Dictionary<Food, int> korz228 = new Dictionary<Food, int>();
      
        
        public static string akkaunt = "";

        public static Dictionary<string, string> Eng_word = new Dictionary<string, string>();
        public static Dictionary<string, string> Ru_word = new Dictionary<string, string>();
        public static string Language;


        void Translate(Dictionary<string, string> Words)
        {
            label6.Text = Words["Бюджет"];
            button2.Text = Words["Применить"];
            label14.Text = Words["Продукты"];
            label5.Text = Words["Категория"];
            Button_Ru.Text = Words["Рус"];
            Button_Eng.Text = Words["Англ"];
            button3.Text = Words["Интерфейс"];
            button1.Text = Words["Войти"];
            Text = Words["Семерочка"];


           
            /*
            categorys.Items[0] = Words["Фрукты"];
            categorys.Items[1] = Words["Овощи"];
            categorys.Items[2] = Words["Фастфуд"];
            categorys.Items[3] = Words["Соки"];
            */

        }

        private void Button_Eng_Click_1(object sender, EventArgs e)
        {
            Language = "Английский";
            Translate(Eng_word);
        }

        private void Button_Ru_Click_1(object sender, EventArgs e)
        {
            Language = "Русский";
            Translate(Ru_word);
        }
        
        public Продукты()
        {
            InitializeComponent();
            loginLabel.Text = akkaunt + "";

            

           
            // this.WindowState = FormWindowState.Maximized;
            //this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            //this.Height = Screen.PrimaryScreen.WorkingArea.Height;

            //this.FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = System.Windows.Forms.FormWindowState.Maximized;


            //добавление еды из текстового файла:
            string[] lines = File.ReadAllLines("../../../ресы.txt");
            foreach (string line in lines)
            {
                string[] parts = line.Split(new string[] { ", " }, StringSplitOptions.None);
                if (parts.Length > 2)//больше двух элементов в блокноте том...
                {
                    eda.Add(new Food(parts[0], Convert.ToInt32(parts[1]), parts[2]));

                    if (!categorys.Items.Contains(parts[2]))
                        categorys.Items.Add(parts[2]);
                }
            }

            #region Переводчик слов из текстового файла
            lines = File.ReadAllLines("../../../перевод_русский.txt");
            foreach (string line in lines)
            {
                string[] parts = line.Split(new string[] { "; " }, StringSplitOptions.None);
                if (parts.Length > 1)
                Ru_word.Add(parts[0], parts[1]);
            }

            lines = File.ReadAllLines("../../../перевод_английский.txt");
            foreach (string line in lines)
            {
                string[] parts = line.Split(new string[] { "; " }, StringSplitOptions.None);
                Eng_word.Add(parts[0], parts[1]);
            }


            Language = Properties.Settings.Default.Language;
            if (Language == "Английский")
                Translate(Продукты.Eng_word);
            if (Language == "Русский")
                Translate(Продукты.Ru_word);
            #endregion

            //время
          //  label1.Text = DateTime.Now.ToString("");

            int x = 10;
            int y = 10;
            for (int i = 0; i < eda.Count; i++)
            {


                //--------------Картинка--------------------------------------
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
                //if (eda[i].price <100)
                //{
                //    eda[i].labelPrice.ForeColor = Color.Red;
                //}
                eda[i].labelPrice.Location = new Point(x + 110, y + 150);
                //eda[i].labelPrice.Location = new Point(eda[i].picture.Location.X + 130, eda[i].picture.Location.Y + 150);
            

                eda[i].labelPrice.Size = new Size(50, 30);
                eda[i].labelPrice.Text = eda[i].price.ToString();
                panel1.Controls.Add(eda[i].labelPrice);

                //-----------------название----------------------------------------------
                eda[i].labelName.Font = new Font("Tahoma", 9, FontStyle.Bold);

                eda[i].labelName.Location = new Point(x, y + 150);

                eda[i].labelName.Size = new Size(100, 30);
                eda[i].labelName.Text = eda[i].name;
                panel1.Controls.Add(eda[i].labelName);

                x = x + 160;//регулируется выход за рамки экрана если еды много
                if (x + 120 > panel1.Width)
                {
                    y = y + 180;
                    x = 10;

                    eda[i].labelPrice.Location = new Point(eda[i].picture.Location.X + 130, eda[i].picture.Location.Y + 150);
                }

                //------------------------------------------------------------------------------------

            }
        }

        //сортировка по цене и названию
        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string[] yes = { "Rufus", "Bear", "Dakota", "Fido",
                        "Vanya", "Samuel", "Koani", "Volodya",
                        "Prince", "Yiska" };

            int nomer = rnd.Next() % yes.Length;
            button2.Text = yes[nomer];




            if (akkaunt == "Админ")//видимость кнопки "Добавить"
            {
                button4.Visible = true;
            }

            int x = 10;
            int y = 10;
            for (int i = 0; i < eda.Count; i++)
            {
                eda[i].picture.Visible = true;

                if (Poisk.Text != "" &&
                    !eda[i].name.ToUpper().Contains(Poisk.Text.ToUpper()))//по названию
                    eda[i].picture.Visible = false;

                if (x + 120 > panel1.Width)
                {
                    y = y + 180;
                    x = 10;

                    eda[i].labelPrice.Location = new Point(eda[i].picture.Location.X + 130, eda[i].picture.Location.Y + 150);
                }
                
                //-----------------категория(фрукты, овощи)--------------------------------------

                bool categoryExist = false;
                foreach (string cat in categorys.CheckedItems)
                {
                    if (eda[i].category == cat)
                        categoryExist = true;
                }
                if (!categoryExist && categorys.CheckedItems.Count > 0)
                {
                    eda[i].picture.Visible = false;
                }

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

        public static void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            ProductForm newForm = new ProductForm(pb.Tag.ToString());
            newForm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
           // MessageBox.Show("Ты лох?", "Предупреждение", MessageBoxButtons.YesNoCancel);
            Korzina newForm = new Korzina();
            newForm.Show();
        }

       int Time1 = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            Registr newForm = new Registr();
            newForm.ShowDialog();
            loginLabel.Text = akkaunt;
            button4.Visible = true;
            Time1 = Environment.TickCount;

            button4.Visible = (Registr.Login == "Админ" && Registr.Parol == "123");

            loginLabel.Text = Registr.Login;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

            label1.Text = DateTime.Now.ToLongTimeString();            
              int  Time228 = Environment.TickCount;
            if (Time228 - Time1 > 2000)
             {
            // button4.Visible = false;

             }

            if (Продукты.Language == "Английский")
                Translate(Продукты.Eng_word);
            if (Продукты.Language == "Русский")
                Translate(Продукты.Ru_word);

        }

        private void categorys_ItemCheck(object sender, ItemCheckEventArgs e)
        {
        }

       
        private void poisk_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button2_Click(null, null);
        }

        private void categorys_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Продукты_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Language = Language;
            Properties.Settings.Default.Save();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                BackColor = colorDialog1.Color;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //кт newForm = new кт();
            //newForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    panel1.BackColor = colorDialog1.Color;
                }
            
        }

        private void Продукты_Load(object sender, EventArgs e)
        {

        }
    }
}
