using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Treciasis_laboratorinis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        decimal p, o;
        decimal x, g, l;
        decimal a, b, c, y;
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            p++;
            x = numericUpDown1.Value;
            a = numericUpDown2.Value;
            b = numericUpDown3.Value;
            c = numericUpDown4.Value;
            g = x * -2;
            g = g + x + 1;         
            if (p<=1)
            {
                
            while (x != g)
            {
                a = a * x * x;
                b = b * x;
                y = a + b + c;
                chart1.Series["Parabolė1"].Points.AddXY(x, y);
                x++;
                a = numericUpDown2.Value;
                b = numericUpDown3.Value;
                c = numericUpDown4.Value;

            }

            }


        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            o++;
            x = numericUpDown1.Value;
            a = numericUpDown2.Value;
            b = numericUpDown3.Value;
            c = numericUpDown4.Value;
            l = x * -2;
            l = l + x + 1;
            if (o<=1)
            { 

            while (x != l)
            {
                a = a * x * x;
                b = b * x;
                y = a + b + c;
                chart1.Series["Parabolė2"].Points.AddXY(x, y);
                x++;
                a = numericUpDown2.Value;
                b = numericUpDown3.Value;
                c = numericUpDown4.Value;
            }

            }

            }


        }
    }
