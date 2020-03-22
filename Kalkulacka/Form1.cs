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

        private void funkciaNaVyuzitie ()
        {
            DisplayedM.ForeColor = Color.Black;
        }

        private void length (char d)
        {
            if (textBox1.Text.Contains("-") && textBox1.Text.Contains(","))
            {
                if (textBox1.Text.Length > 10)
                {

                }
                else{
                    textBox1.Text = textBox1.Text + d;
                }
            }
            else if (textBox1.Text.Contains("-") || textBox1.Text.Contains(",")) { 
            
                if (textBox1.Text.Length > 9)
                {

                }
                else
                {
                    textBox1.Text = textBox1.Text + d;
                }

            }
            else if (textBox1.Text.Length > 9)
            {
              

            }
            else
            {
                textBox1.Text = textBox1.Text + d;
            }
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listPanel.Add(shiftUnclickedPanel);
            listPanel.Add(shiftClickedPanel);
            listPanel[index].BringToFront();
        }

        private void shiftClicked_Click(object sender, EventArgs e)
        {
            if (index > 0)
                listPanel[--index].BringToFront();
        }

        private void shiftUnclicked_Click(object sender, EventArgs e)
        {
            if (index < listPanel.Count - 1)
                listPanel[++index].BringToFront();
        }

     
        
        private void off_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void off_shift_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void num0_Click(object sender, EventArgs e)
        {
            length('0');
        }

        private void num1_Click(object sender, EventArgs e)
        {
            length('1');
        }

        private void num2_Click(object sender, EventArgs e)
        {
            length('2');
        }

        private void num3_Click(object sender, EventArgs e)
        {
            length('3');
        }

        private void num4_Click(object sender, EventArgs e)
        {
            length('4');
        }

        private void num5_Click(object sender, EventArgs e)
        {
            length('5');
        }

        private void num6_Click(object sender, EventArgs e)
        {
            length('6');
        }

        private void num7_Click(object sender, EventArgs e)
        {
            length('7');
        }

        private void num8_Click(object sender, EventArgs e)
        {
            length('8');
        }

        private void num9_Click(object sender, EventArgs e)
        {
            length('9');
        }

        private void decPoint_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Contains(",")) {

            }
            else if (textBox1.Text == "" || textBox1.Text == "-")
            {
                textBox1.Text = textBox1.Text + "0,";
            }
            else if (textBox1.Text.Contains("-"))
            {
                if (textBox1.Text.Length > 8)
                {
                    textBox1.Text = textBox1.Text + ",";
                }
                else
                {
                    textBox1.Text = textBox1.Text + ",";
                }
            }
            else if (textBox1.Text.Length > 7)
            {

            }
            else
            {
                textBox1.Text = textBox1.Text + ",";
            }

          
        }

        private void del_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void subtraction_Click(object sender, EventArgs e)
        {
            if ( textBox1.Text == "")
            {
                textBox1.Text = "-";
            }
        }
    }
}
