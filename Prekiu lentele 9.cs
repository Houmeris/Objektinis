using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M.D_9_laboratorinis_5_uzduotis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Taibe
        {
            public int dydis, kiekis;
            public string[] p, p2, p3, pard, pard2, pard3;
            public Taibe(int n)
            {
                kiekis = 0;
                p = new string[dydis = n];
                p2 = new string[dydis];
                p3 = new string[dydis];
                pard = new string[dydis];
                pard2 = new string[dydis];
                pard3 = new string[dydis];
            }
            public void papildyk(string x, Label label4, string z, string c)
            {
                try
                {
                    p[kiekis] = x;
                    p2[kiekis] = z;
                    p3[kiekis] = c;
                    kiekis++;
                }
                catch
                {
                    label4.Text = "Aibe perpildita";
                }
            }
            public void Rodyk(DataGridView lentele, Label label5)
            {
                label5.Text = "Prekes";
                lentele.Rows.Clear();
                pard = p.Distinct().ToArray();
                pard2 = p2.Distinct().ToArray();
                pard3 = p3.Distinct().ToArray();
                string[][] o = new string[kiekis][];
                int n = 0;
                for (int i=0; i<kiekis; i++)
                {
                    o[i] = new string[3];
                }
                try
                {

                    for (int i = 0; i < kiekis; i++)
                    {
                        if (pard[i] == pard2[i] && pard2[i] == pard3[i] && pard[i] == pard3[i])
                        {
                            o[i][0] = pard[i];
                            lentele.Rows.Add(o[i]);
                            n++;
                        }
                        if (pard[i] == pard2[i] && pard[i] != pard3[i] && pard[i] != string.Empty)
                        {
                            o[i][1] = pard[i];
                            lentele.Rows.Add(o[i]);
                            n++;
                        }
                        if (pard2[i] == pard3[i] && pard2[i] != pard[i] && pard2[i] != string.Empty)
                        {
                            o[i][1] = pard2[i];
                            lentele.Rows.Add(o[i]);
                            n++;
                        }
                        if (pard[i] == pard3[i] && pard[i] != pard2[i] && pard3[i] != string.Empty)
                        {
                            o[i][1] = pard[i];
                            lentele.Rows.Add(o[i]);
                            n++;
                        }
                        if (pard[i] != pard2[i] && pard[i] != pard3[i] && pard[i] != string.Empty)
                        {
                            o[i][2] = pard[i];
                            lentele.Rows.Add(o[i]);
                            n++;
                        }
                        if (pard2[i] != pard[i] && pard2[i] != pard3[i] && pard2[i] != string.Empty)
                        {
                            o[i][2] = pard2[i];
                            lentele.Rows.Add(o[i]);
                            n++;
                        }
                        if (pard3[i] != pard2[i] && pard3[i] != pard[i] && pard3[i] != string.Empty)
                        {
                            o[i][2] = pard3[i];
                            lentele.Rows.Add(o[i]);
                            n++;
                        }
                    }

                }
                catch
                {
                    label5.Text = "Klaida! per daug pridejote tos pacios prekes";
                }
                List<string> po = new List<string>();
                List<string> po2 = new List<string>();
                List<string> po3 = new List<string>();

                foreach (DataGridViewRow row in lentele.Rows)
                    {
                    if (row.Cells["Column1"].Value != null)
                        po.Add(row.Cells["Column1"].Value.ToString());
                    else
                        po.Add(" ");
                    if (row.Cells["Column2"].Value != null)
                        po2.Add(row.Cells["Column2"].Value.ToString());
                    else
                        po2.Add(" ");
                    if (row.Cells["Column3"].Value != null)
                        po3.Add(row.Cells["Column3"].Value.ToString());
                    else
                        po3.Add(" ");
                    }
                lentele.Rows.Clear();
                po = po.OrderByDescending(c => c).ToList();
                po2 = po2.OrderByDescending(c => c).ToList();
                po3 = po3.OrderByDescending(c => c).ToList();
                for (int i=0; i<n; i++)
                {
                    lentele.Rows.Add(po[i], po2[i], po3[i]);
                }
                string remove = lentele.Rows[0].Cells[1].Value.ToString();
                for (int i=1; i<lentele.Rows.Count; i++)
                {
                    if(lentele.Rows[i].Cells[1].Value.ToString() == remove)
                    {
                        lentele.Rows[i].Cells[1].Value = " ";
                    }
                    else
                    {
                        remove = lentele.Rows[i].Cells[1].Value.ToString();
                    }
                }
                for(int i=0; i<lentele.Rows.Count; i++)
                {
                    if(string.IsNullOrWhiteSpace(lentele.Rows[i].Cells[0].Value.ToString()) && string.IsNullOrWhiteSpace(lentele.Rows[i].Cells[1].Value.ToString()) && string.IsNullOrWhiteSpace(lentele.Rows[i].Cells[2].Value.ToString()))
                    {
                        lentele.Rows.RemoveAt(i);
                    }
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Taibe x = new Taibe(20);
        private void button4_Click(object sender, EventArgs e)
        {
            x.papildyk(textBox1.Text, label4, textBox2.Text, textBox3.Text) ;
            x.Rodyk(dataGridView1, label5);
        }

    }
}
