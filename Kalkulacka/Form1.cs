using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulacka
{
    public partial class Form1 : Form
    {
        List<Panel> listPanel = new List<Panel>();
        int index;
        //private object txt_Result;
        

        public Form1()
        {
            InitializeComponent();
            
        }

        private void shift_kliknuty_Click(object sender, EventArgs e)
        {
            if (index > 0)
                listPanel[--index].BringToFront();
        }

        private void shift_nekliknuty_Click(object sender, EventArgs e)
        {
            if (index < listPanel.Count - 1)
                listPanel[++index].BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listPanel.Add(unclicked_shift);
            listPanel.Add(clicked_shift);
            listPanel[index].BringToFront();
        }

        private void off_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void off_shift_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cislo_nula_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 8)
            {
                textBox1.Text = textBox1.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void cislo_jeden_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 8)
            {
                textBox1.Text = textBox1.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void cislo_dva_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 8)
            {
                textBox1.Text = textBox1.Text ;
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void cislo_tri_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 8)
            {
                textBox1.Text = textBox1.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void cislo_styri_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 8)
            {
                textBox1.Text = textBox1.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void cislo_pat_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 8)
            {
                textBox1.Text = textBox1.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void cislo_sest_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 8)
            {
                textBox1.Text = textBox1.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void cislo_sedem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 8)
            {
                textBox1.Text = textBox1.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void cislo_osem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 8)
            {
                textBox1.Text = textBox1.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void cislo_devat_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 8)
            {
                textBox1.Text = textBox1.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void ciarka_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 8)
            {
                textBox1.Text = textBox1.Text;
            }


            else if (textBox1.Text.Contains(","))
            {
                textBox1.Text = textBox1.Text;
            }

            else if (textBox1.Text == "")
            {
                textBox1.Text = textBox1.Text + "0,";
            }
            else
            {
                textBox1.Text = textBox1.Text + ",";
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void del_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
