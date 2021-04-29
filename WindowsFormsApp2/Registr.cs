using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Registr : Form
    {
        public static List<Food> Pismo = new List<Food>();
        public static string Login = "";
        public static string Parol = "";

        List<string> Users = new List<string>();

        public Registr()
        {
            InitializeComponent();
            Users = new List<string>();
            Users.Add("Админ"); Users.Add("Админ");
            Users.Add("1"); Users.Add("1");
           
        }
      

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://vk.com/mihmet");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            { 
            Login = textBox1.Text;
            Parol = textBox2.Text;
            Close();
            }
            else
            {
                checkBox1.ForeColor = Color.Red;
            }
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            if (textBox2.UseSystemPasswordChar == true)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //отправка на почту
        string mail = "Semerochka228@gmail.com";
        private void button2_Click(object sender, EventArgs e)
        {
            MailAddress fromMailAddress = new MailAddress(mail, "Заказчик");//c какого адреса
            MailAddress toAddress = new MailAddress(mail);//на какой
            MailMessage mailMessage = new MailMessage(fromMailAddress, toAddress);
            SmtpClient smtpClient = new SmtpClient();

            mailMessage.Subject = "Покупатель Семерочки";
            //mailMessage.IsBodyHtml = true;

            //mailMessage.Body = "В твоём проекте ошибка: " + textBox3.Text + ", а еще ты лох";
            //Environment.NewLine + ", а еще ты лох";

            mailMessage.Body = "Ваша корзина ";
            //Environment.NewLine + "";
            foreach (KeyValuePair<Food, int> eda1 in  Продукты.korz228)
            {
                Food eda = eda1.Key;

                mailMessage.Body += 
                    Environment.NewLine + "Продукт - s" + eda.name + "Цена - " + eda.price.ToString() + "количество:";
            }
            


           

            mailMessage.IsBodyHtml = true;
           // mailMessage.Body = File.ReadAllText("Письмо.txt");

            smtpClient.Host = "smtp.gmail.com";
            smtpClient.Port = 587;
            smtpClient.EnableSsl = true;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.Credentials = new NetworkCredential(fromMailAddress.Address, "Parol228");
            
            smtpClient.Send(mailMessage);
            MessageBox.Show("Письмо отправлено на " + mail, mail);
        }
    }
}
