using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Svaz : Form
    {
        public Svaz()
        {
            InitializeComponent();

            comboBox1.SelectedIndex = 1;
        }

        readonly string mail = "Semerochka228@gmail.com";
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Укажите тему");
                return;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("Укажите почту");
                return;
            }

            MailAddress fromMailAddress = new MailAddress(mail, "Заказчик");//c какого адреса
            MailAddress toAddress = new MailAddress("beavisabra@yandex.ru");//на какой
            MailMessage mailMessage = new MailMessage(fromMailAddress, toAddress);
            SmtpClient smtpClient = new SmtpClient();

            mailMessage.Subject = "Проект 7-ка " + comboBox1.Text;
            mailMessage.Body = textBox1.Text +
                Environment.NewLine +
                Environment.NewLine + "Контакт: " + textBox2.Text;
            progressBar1.Value = 30;

            if (address != "")
            {
                Attachment att = new Attachment(address);
                att.Name = "1.jpg";
                mailMessage.Attachments.Add(att);
            }

            progressBar1.Value = 50;
            smtpClient.Host = "smtp.gmail.com";
            smtpClient.Port = 587;
            smtpClient.EnableSsl = true;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.Credentials = new NetworkCredential(fromMailAddress.Address, "Parol228");

            progressBar1.Value = 80;
            smtpClient.Send(mailMessage);
            progressBar1.Value = 100;
            MessageBox.Show("Письмо отправлено на " + mail, mail);
        }

        string address = "";
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                address = openFileDialog1.FileName;
                pictureBox1.Load(address);
            }
        }

    }
}
