using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace Email
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void mail()
        {
            try
            {

                MailMessage msg = new MailMessage();
                msg.From = new MailAddress("nguyen.pham.giotto@gmail.com");
                msg.To.Add(textBox1.Text.ToString());
                msg.Subject = "Hello";
                msg.Body = "Hello";

                SmtpClient smt = new SmtpClient();
                smt.Host = "smtp.gmail.com";
                System.Net.NetworkCredential ntcd = new NetworkCredential();
                ntcd.UserName = "nguyen.pham.giotto@gmail.com";
                ntcd.Password = "giotto2015.py";
                smt.Credentials = ntcd;
                smt.EnableSsl = true;
                smt.Port = 587;
                smt.Send(msg);

                MessageBox.Show("Your Mail is sended");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            mail();
        }
    }
}
