using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            trackBar1.Maximum = 100000;
            trackBar1.Minimum = 1000;
            trackBar2.Maximum = 72;
            trackBar2.Minimum = 12;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            const string Format = @"D:\";
            string path = string.Format(Format, textBox1.Text, textBox2.Text);

            string tekst = "Dane klienta : \r\n";
            tekst += "Imię : " + textBox1.Text + " Nazwisko : " + textBox2.Text + " \r\n";
            tekst += "Dane Kontaktowe : \r\n";
            tekst += "Telefon : " + textBox3.Text + " E-Mail : " + textBox4.Text + " \r\n";
            tekst += "Kwota Kredytu : " + textBox6.Text + " Okres Kredytowania : " + textBox5.Text + " \r\n";
            tekst += "Godzina Kontaktu : " + comboBox1.Text + " \r\n";
            tekst += "Zgoda na przetwarzanie danych osobowych: " + ((checkBox1.Checked) ? "TAK" : "NIE") + "\r\n";
            tekst += "Zgoda na przetwarzanie danych handlowych: " + ((checkBox2.Checked) ? "TAK" : "NIE") + "\r\n";
            tekst += "Złożono : " + DateTime.Now.ToString("F") + " \r\n";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            textBox5.Text = "" + trackBar2.Value + " m-cy";
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox6.Text = "" + trackBar1.Value + " zł";
        }
    }
}
