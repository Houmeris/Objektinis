using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Martyno_Džiugio_7_laboratorinis_darbas
{
    public partial class Form1 : Form
    {
        class Laikas
        {
            public int a = 0, b=0, c=0;
            public Laikas()
            {

            }
            public void Konvertavimas(TextBox min, Label minsek, TextBox val, Label valsek, Label sekund)
            {
                try
                {
                    a = Convert.ToInt32(min.Text);
                    a = a * 60;
                    if(a<0)
                    {
                        minsek.Text = "Veskite teigiama skaiciu arba veskite mazesni skaiciu jeigu ivestas skaicius yra teigiamas";
                        a = 0;
                    }
                    else
                    {
                        minsek.Text = minsek.Text + a.ToString();
                    }
                }
                catch(Exception p)
                {
                    minsek.Text = p.Message;
                }
                try
                {
                    b = Convert.ToInt32(val.Text);
                    b = b * 3600;
                    if(b<0)
                    {
                        valsek.Text = "Veskite teigiama skaiciu arba veskite mazesni skaiciu jeigu ivestas skaicius yra teigiamas";
                        b = 0;
                    }
                    else
                    {
                        valsek.Text = valsek.Text + b.ToString();
                    }
                    
                    
                }
                catch(Exception o)
                {
                    valsek.Text = o.Message;
                }
                c = a + b;
                sekund.Text = sekund.Text + c.ToString();
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
        string min, val, sek;
        private void Form1_Load(object sender, EventArgs e)
        {
            min = minsek.Text;
            val = valsek.Text;
            sek = Sekundes.Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            minsek.Text = min;
            valsek.Text = val;
            Sekundes.Text = sek;
            Laikas x = new Laikas();
            x.Konvertavimas(Minutes, minsek, textBox1, valsek, Sekundes);
        }
    }
}
