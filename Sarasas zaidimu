using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M.D_8_laboratorinio_2_užduotis
{
    public partial class Form1 : Form
    {
        class Zaidimas
        {
            public TextBox zodis;
            public DataGridView lentele;
            public TextBox Salinti;
        }
        class Zaidimu_Sarasas : Zaidimas
        {
            public Zaidimu_Sarasas(TextBox a, DataGridView m, TextBox Sal)
            {
                zodis = a;
                lentele = m;
                Salinti = Sal;
            }
            public void Irasyti()
            {
                if(!string.IsNullOrWhiteSpace(zodis.Text))
                {
                    lentele.Rows.Add(zodis.Text);
                }
                
            }
            public void Rikiuok()
            {
                lentele.Sort(lentele.Columns["column1"], ListSortDirection.Ascending);
            }
            public void Pasalinti()
            {
                for (int i=0; i<lentele.Rows.Count; i++)
                {
                    if (lentele.Rows[i].Cells[0].Value.ToString()==Salinti.Text)
                    {
                        lentele.Rows.RemoveAt(i);
                    }
                }
            }
            public void Istrinti()
            {
                lentele.Rows.Clear();
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Add("Half - Life");
            this.dataGridView1.Rows.Add("Overwatch");
            this.dataGridView1.Rows.Add("Minecraft");
        }

        private void Ivesti_Click(object sender, EventArgs e)
        {
            Zaidimu_Sarasas x = new Zaidimu_Sarasas(Zodis, dataGridView1, textBox1);
            x.Irasyti();
            x.Rikiuok();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Zaidimu_Sarasas x = new Zaidimu_Sarasas(Zodis, dataGridView1, textBox1);
            x.Pasalinti();
            x.Rikiuok();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Zaidimu_Sarasas x = new Zaidimu_Sarasas(Zodis, dataGridView1, textBox1);
            x.Istrinti();
        }
    }
}
