using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            double vize, final, sonuc;
            vize = Convert.ToInt32(textBox1.Text);
            final = Convert.ToInt32(textBox2.Text);
            sonuc = (vize * 0.3) + (final * 0.7);
            if(sonuc<45)
            {
                label3.Text = sonuc+" "+"KALDI".ToString();
                label3.ForeColor = Color.Red;
            }
            else if(sonuc>=45)
            {
                label3.Text = sonuc+" "+"GEÇTİ".ToString();
                label3.ForeColor = Color.Green;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                    txt.Clear();
                }
            }
        }
    }
}
