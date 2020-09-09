using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hexaDecimalCalculator
{
    public partial class Form1 : Form
    {
        List<string> rakamlar = new List<string>();
        List<string> islemler = new List<string>();
        List<string> sayilar = new List<string>();
        
        public Form1()
        {
            InitializeComponent();
        }

        public void rakam(object sender)
        {
            Button button = sender as Button;
            rakamlar.Add(button.Text);
            label1.Text += button.Text;
            button1.Enabled = true;
            bolu.Enabled = true;
            carpi.Enabled = true;
            eksi.Enabled = true;
            arti.Enabled = true;
                       


        }

        public void islem(object sender)
        {
            Button islembutton = sender as Button;
            string a = "";
            for (int i = 0; i < rakamlar.Count; i++)
            {
                a += rakamlar[i];
            }
            rakamlar.Clear();
            label1.Text = "";
            button1.Enabled = false;
            bolu.Enabled = false;
            carpi.Enabled = false;
            eksi.Enabled = false;
            arti.Enabled = false;
            sayilar.Add(a);
            islemler.Add(islembutton.Text);



        }
        public void sonuc(object sender)
        {
            for (int i = 0; i < sayilar.Count; i++)
            {
                string a = sayilar[i];

                for (int j = a.Count(); j == 0; j--)
                {

                }
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            rakam(sender);          
        }

        private void arti_Click(object sender, EventArgs e)
        {
            islem(sender);
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
