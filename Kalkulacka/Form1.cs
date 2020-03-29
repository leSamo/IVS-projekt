﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Kalkulacka
{
    public partial class Form1 : Form
    {
        List<Panel> listPanel = new List<Panel>();
        MathComponentsNS.MathComponents newMath = new MathComponentsNS.MathComponents();
        int index;
        string operationPerformed = "";
        double firstNum = 0;
        double MEM = 0;
        double ans = 0;
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
            else if (textBox1.Text.Contains("-") || textBox1.Text.Contains(","))
            { 
                if (textBox1.Text.Length > 9)
                {

                }
                else
                {
                    textBox1.Text = textBox1.Text + d;
                }
            }
            else if (textBox1.Text.Length > 8)
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
            DisplayedM.Visible = false;
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

            if (textBox1.Text.Contains(","))
            {

            }
            else if (textBox1.Text == "" || textBox1.Text == "-")
            {
                textBox1.Text = textBox1.Text + "0,";
            }
            else if (textBox1.Text.Contains("-"))
            {
                if (textBox1.Text.Length > 9)
                {
                    
                }
                else
                {
                    textBox1.Text = textBox1.Text + ",";
                }
            }
            else if (textBox1.Text.Length > 8)
            {

            }
            else
            {
                textBox1.Text = textBox1.Text + ",";
            }

          
        }

        private void subtraction_Click(object sender, EventArgs e)
        {
            bool convValid;
            if ( textBox1.Text == "")
            {
                textBox1.Text = "-";
            }
            else
            {
                convValid = double.TryParse(textBox1.Text, out firstNum);
                textBox1.Text = "";
                operationPerformed = "substraction";
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

           /* Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8 && chr != ',' && chr != '-')
            {
                e.Handled = true;
            }*/

            if (textBox1.Text.Contains("-") && textBox1.Text.Contains(","))
            {
                if (textBox1.Text.Length > 10)
                {

                }
                else
                {
                    Char chr = e.KeyChar;
                    if (!Char.IsDigit(chr) && chr != 8 )
                    {
                        e.Handled = true;
                    }
                }
            }
            else if (textBox1.Text.Contains("-"))
            {
                if (textBox1.Text.Length > 9)
                {

                }
                else
                {
                    Char chr = e.KeyChar;
                    if (!Char.IsDigit(chr) && chr != 8 && chr !=',')
                    {
                        e.Handled = true;
                    }
                }
            }
            else if ( textBox1.Text.Contains(","))
            {
                if (textBox1.Text.Length > 9)
                {
                    Char chr = e.KeyChar;
                    if (!Char.IsDigit(chr) && chr != 8)
                    {
                        e.Handled = false;
                    }
                }
                else
                {
                    Char chr = e.KeyChar;
                    if (!Char.IsDigit(chr) && chr != 8 && chr != '-')
                    {
                        e.Handled = true;
                    }
                }
            }
            else if (textBox1.Text.Length > 8)
            {
                Char chr = e.KeyChar;
                if (!Char.IsDigit(chr) && chr != 8 && chr != ',' && chr != '-')
                {
                    e.Handled = false;
                }
            }
            else
            {
                Char chr = e.KeyChar;
                if (!Char.IsDigit(chr) && chr != 8 && chr != ',' && chr != '-')
                {
                    e.Handled = true;
                }
            }
        }

        public void Valid_Chk((bool, double) result)                //Funkce pro kontrolu úspěšného dokončení výpočtu a případného vypsání výsledku
        {
            if (result.Item1)
            {
                textBox1.Text = "CHYBA!";
                //TODO error handler
            }
            else
            {
                textBox1.Text = result.Item2.ToString();
                firstNum = ans = result.Item2;

            }
        }

        private void operation_Click(object sender, EventArgs e)    //Určení stisknuté operace, uložení vstupu, vymazání textboxu
        {
            bool convValid;
            Button button = (Button)sender;
            operationPerformed = button.Name;
            if (textBox1.Text != "" && firstNum == 0)
            {
                convValid = double.TryParse(textBox1.Text, out firstNum);           //TODO vyřešit multiinput
                textBox1.Text = "";
            }
            else if (textBox1.Text != "" && firstNum != 0)
            {
                Valid_Chk(Calculate());
                textBox1.Text = "";
            }
        }

        private void InstantOp_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string instantOp = button.Name;

            switch (instantOp)
            {
                case "ANS":
                    textBox1.Text = ans.ToString();
                    break;
                case "RAND":
                    textBox1.Text = newMath.Random().Item2.ToString();
                    break;
                case "del":
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                    break;
                case "AC":
                    textBox1.Text = "";
                    break;
                case "equals":
                    if (firstNum != 0)
                    {
                        Valid_Chk(Calculate());
                        operationPerformed = "";
                        firstNum = 0;
                    }
                    break;
            }
        }

        public (bool, double) Calculate()
        {
            bool convValid;
            (bool, double) result = (true, 0);
            convValid = double.TryParse(textBox1.Text, out double secondNum);

            switch (operationPerformed)
            {
                case "addition":
                    result = newMath.Add(firstNum, secondNum);
                    break;
                case "substraction":
                    result = newMath.Subtract(firstNum, secondNum);
                    break;
                case "multiplication":
                    result = newMath.Multiply(firstNum, secondNum);
                    break;
                case "division":
                    result = newMath.Divide(firstNum, secondNum);
                    break;
                default:
                    break;
            }
            return result;
        }

        private void Mplus_Click(object sender, EventArgs e)
        {
            MplusShift_Click(sender, e);
        }

        private void MplusShift_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                MEM += double.Parse(textBox1.Text);
                if (MEM == 0)
                {
                    DisplayedM.Visible = false;
                }
                else
                {
                    DisplayedM.Visible = true;
                }
            }
        }

        private void MRCShift_Click(object sender, EventArgs e)
        {
            MRC_Click(sender, e);
        }

        private void MRC_Click(object sender, EventArgs e)
        {
            textBox1.Text = MEM.ToString();
        }

        private void Mminus_Click(object sender, EventArgs e)
        {
            MminusShift_Click(sender, e);
        }

        private void MminusShift_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                MEM -= double.Parse(textBox1.Text);
                if (MEM == 0)
                {
                    DisplayedM.Visible = false;
                }
                else
                {
                    DisplayedM.Visible = true;
                }
            }
        }
    }
}
