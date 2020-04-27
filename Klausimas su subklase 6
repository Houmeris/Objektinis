using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Martyno_Džiugio_6_laboratorinis_darbas
{
    public partial class Form1 : Form
    {
        class Masyvas
        {

            public const int l = 5;
            public object[] atsakymas = new object[l];
        }
        class Testas : Masyvas
        {
            public decimal klausimas;
            public string[] klaus = new string[3];
            public Testas(NumericUpDown num)
            {
                klausimas = num.Value;
            }
            public void Klausimai(Label q)
            {
                klaus[0] = "Kokioje šalyje yra miestas Berlynas?";
                klaus[1] = "Kiek yra 10*5";
                klaus[2] = "Kiek bitu yra viename baite";
                q.Text = klaus[Convert.ToInt32(klausimas-1)];
            }
            public void Atsakymai(CheckedListBox box)
            {
                if(klausimas==1)
                {
                    atsakymas[0] = "Austrija";
                    atsakymas[1] = "Vokietija";
                    atsakymas[2] = "Lietuva";
                    atsakymas[3] = "Rusija";
                    atsakymas[4] = "Kinija";
                }
                if (klausimas==2)
                {
                    atsakymas[0] = "15";
                    atsakymas[1] = "25";
                    atsakymas[2] = "30";
                    atsakymas[3] = "50";
                    atsakymas[4] = "55";
                }
                if (klausimas==3)
                {
                    atsakymas[0] = "2 bitai";
                    atsakymas[1] = "1 bitas;";
                    atsakymas[2] = "4 bitai";
                    atsakymas[3] = "8 bitai";
                    atsakymas[4] = "16 bitai";
                }     
                for (int i=0; i<5; i++)
                {
                    box.Items.Add(atsakymas[i]);
                }
            }
            public void Galutinis_Atsakymas(CheckedListBox box, Label lab, Label l1, Label l2, Label l3)
            {
                    lab.Text = " ";
                    if (!box.GetItemChecked(1) && klausimas == 1)
                    {
                        lab.Text = "Neteisingai atsakymas yra Vokietija";
                        l1.Dispose();
                    }
                    else if (box.GetItemChecked(1) && klausimas == 1 && box.CheckedItems.Count == 1)
                    {
                        lab.Text = "Teisingai";
                        l1.Dispose();
                    }
                    if (!box.GetItemChecked(3) && klausimas == 2)
                    {
                        lab.Text = "Neteisingai atsakymas yra 50";
                        l2.Dispose();
                    }
                    else if (box.GetItemChecked(3) && klausimas == 2 && box.CheckedItems.Count == 1)
                    {
                        lab.Text = "Teisingai";
                        l2.Dispose();
                    }
                    if (!box.GetItemChecked(3) && klausimas == 3)
                    {
                        lab.Text = "Neteisingai Atsakymas yra 8 bitai";
                        l3.Dispose();
                    }
                    else if (box.GetItemChecked(3) && klausimas == 3 && box.CheckedItems.Count == 1)
                    {
                        lab.Text = "Teisingai";
                        l3.Dispose();
                    }
                    if (box.CheckedItems.Count > 1)
                    {
                        lab.Text = "Rinkites tiktais 1 atsakyma";
                    }
                
            }

        }
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        int z = 0, k = 0;
        double o = 0;
        private void Ivesti_Click(object sender, EventArgs e)
        {
            z++;
            checkedListBox1.Items.Clear();
            Testas p = new Testas(numericUpDown1);
            p.Klausimai(question);
            p.Atsakymai(checkedListBox1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Testas p = new Testas(numericUpDown1);     
            if(z>0)
            {
                p.Galutinis_Atsakymas(checkedListBox1, label6, label3, label4, label5);
                if(label6.Text == "Teisingai")
                {
                o = o + 3.33;
                    if (o == 9.99 || o>10) o = 10;
                label6.Text = label6.Text + " " + o.ToString();
                }
            }

        }
    }
}
