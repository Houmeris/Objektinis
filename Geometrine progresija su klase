using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_Laboratoinis_darbas
{

    public partial class Form1 : Form
    {
        class TGeomProgr
        {
            public decimal pirm, daug, nar, suma;
            public double begaline, begpirm, begdaug;
            public TGeomProgr(decimal a, decimal b, decimal n)
            {
                pirm = a;
                daug = b;
                nar = n;
                suma = a;
                begpirm = Convert.ToDouble(a);
                begdaug = Convert.ToDouble(b);
                begaline = begpirm / (1 - begdaug);
            }
            public void Skaiciuok()
            {
                while (nar>1)
                {
                    nar--;
                    pirm = pirm * daug;
                    suma = suma + pirm;
                }
                while (nar<1)
                {
                    nar++;
                    pirm = pirm * daug;
                    suma = suma + pirm;
                }
            }
            public void Print(Label exd, Label sum, Label begalinis)
            {
                exd.Text = exd.Text + pirm.ToString();
                sum.Text = sum.Text + suma.ToString();
                begalinis.Text = begalinis.Text + begaline.ToString();
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
        int o = 0;
        string m, n, b;
        private void Form1_Load(object sender, EventArgs e)
        {
            m = label4.Text;
            n = label5.Text;
            b = label6.Text;
        }

        private void Ivesti_Click(object sender, EventArgs e)
        {
            label4.Text = m;
            label5.Text = n;
            label6.Text = b;
            TGeomProgr a = new TGeomProgr(Pirmas.Value, Daugiklis.Value, Nariai.Value);
            a.Skaiciuok();
            a.Print(label4, label5, label6);
            o++;

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
