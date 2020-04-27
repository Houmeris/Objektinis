using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace antras_labaratorinis_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int did = 0;
            string skaiciai = textBox1.Text;
            Regex reg = new Regex("[*'\",_&#^@]");
            skaiciai = reg.Replace(skaiciai, string.Empty);
            skaiciai = Regex.Replace(skaiciai, @"[^\d]", " ");   //Panaikiname raides
            RegexOptions options = RegexOptions.None;
            Regex regex = new Regex("[ ]{2,}", options);   //Panaikiname tarpus kurių yra per daug
            skaiciai = regex.Replace(skaiciai, " ");
            while (skaiciai.Substring(skaiciai.Length - 1) == " ")
            {
                skaiciai = skaiciai.Remove(skaiciai.Length - 1);     //Panaikiname tarpus pačiame gale
            }
            if ( skaiciai.Substring(0,1)== " ")
            {
               skaiciai= "0" + skaiciai.Remove(0, 1);   //Panaikiname tarpus pradžioje
            }
            
            int[] masyvas = skaiciai.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            int kiek = masyvas.Count();
            if (skaiciai.Substring(0,1)==" ")
            {
                masyvas[0] = did;
            }
            else
            {
               masyvas[1] = did;
            }
            for (int i = 0; i <kiek; i++)
            {
                if(did<masyvas[i])
                {
                    did = masyvas[i];
                }
            }
            int p = 500;
            while(p>0)
            {
                label1.Text = did.ToString();
                p--;
            }
            
        }

    }
}
