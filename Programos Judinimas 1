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
        }

        int x, y, a, p;
        int a2, p2, x2, y2;
            private void Form1_Load(object sender, EventArgs e)
        {
           
            x = this.Left;
            y = this.Top;
            a = this.Width;
            p = this.Height;
            a2 = a;
            p2 = p;
            x2 = x;
            y2 = y;
        }

        private void Mazinti_Click(object sender, EventArgs e)
        {
            p = p - 50;
            SetDesktopBounds(x, y, a, p);
        }

        private void Desine_Click(object sender, EventArgs e)
        {
            while(x>0)
            {
                x = x - 1;
                SetDesktopLocation(x, y);
            }
        }

        private void des_Click(object sender, EventArgs e)
        {
            while(x< (Screen.PrimaryScreen.WorkingArea.Width - this.Width))
            {
                x = x + 1;
                SetDesktopLocation(x, y);
            }
        }

        private void Virsu_Click(object sender, EventArgs e)
        {
            while(y>0)
            {
                y = y - 1;
                SetDesktopLocation(x, y);
            }
        }

        private void Zemyn_Click(object sender, EventArgs e)
        {
            while(y< (Screen.PrimaryScreen.WorkingArea.Height - this.Height))
            {
                y = y + 1;
                SetDesktopLocation(x, y);
            }
        }

        private void Centras_Click(object sender, EventArgs e)
        {
            x = x2;
            y = y2;
            SetDesktopLocation(x, y);
        }

        private void ilgis_Click(object sender, EventArgs e)
        {
            a = a + 50;
            SetDesktopBounds(x, y, a, p);
        }

        private void Ilgiszem_Click(object sender, EventArgs e)
        {
            a = a - 50;
            SetDesktopBounds(x, y, a, p);
        }

        private void Centas_Click(object sender, EventArgs e)
        {
            a = a2;
            p = p2;
            SetDesktopBounds(x, y, a, p);
        }

        private void aukstin_Click(object sender, EventArgs e)
        {
            p = p + 50;
            SetDesktopBounds(x, y, a, p);
        }

    }
}
