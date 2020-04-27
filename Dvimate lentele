using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M.D_4_laboratorinis_11_užduotis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[][] s=new string[5][];
        int[][] skaicius = new int[5][];
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i=0; i<5; i++)
            {
                this.dataGridView1.Rows.Add("");
            }
        }

        private void Random_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            if (dataGridView1.Rows.Count>0)
            {
                dataGridView1.Rows.Clear();               
            }
           for (int i = 0; i < 5; i++)
            {
                skaicius[i] = new int[5];
                s[i] = new string[5];
                for (int j=0; j<5; j++)
                {
                    skaicius[i][j] = rnd.Next(1, 1000);
                    s[i][j] = skaicius[i][j].ToString();
                }
                this.dataGridView1.Rows.Add(s[i]);
            }           

        }
    }
}
