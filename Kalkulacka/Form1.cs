using System;
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
        decimal firstNum = 0;
        decimal MEM = 0;
        decimal ans = 0;
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
                convValid = decimal.TryParse(textBox1.Text, out firstNum);
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

        public void Valid_Chk((bool, decimal) result)                //Funkce pro kontrolu úspěšného dokončení výpočtu a případného vypsání výsledku
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
                convValid = decimal.TryParse(textBox1.Text, out firstNum);
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
            (bool, decimal) result = (true, 0);
            bool checkNeeded = false;
            bool parseCheck = decimal.TryParse(textBox1.Text, out decimal input);

            switch (instantOp)
            {
                case "ANS":
                    textBox1.Text = ans.ToString();
                    break;
                case "RAND":
                    result = newMath.Random();
                    checkNeeded = true;
                    break;
                case "del":
                    if (textBox1.Text != "")
                    {
                        textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                    }
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
                case "sin":
                    result = newMath.Sin(input);
                    checkNeeded = true;
                    break;
                case "cos":
                    result = newMath.Cos(input);
                    checkNeeded = true;
                    break;
                case "tan":
                    result = newMath.Tan(input);
                    checkNeeded = true;
                    break;
                case "factorial":
                    result = newMath.Factorial(input);
                    checkNeeded = true;
                    break;
                case "pi":
                    //TODO (no access to PI)
                    break;
                case "log":
                    result = newMath.Logarithm(10, input);
                    checkNeeded = true;
                    break;
                case "Power2":
                    result = newMath.Exponentiate(input, 2);
                    checkNeeded = true;
                    break;
                case "root2":
                    result = newMath.Root(2, input);
                    checkNeeded = true;
                    break;
                case "ln":
                    //TODO (no access to e)
                    break;
                case "arcsin":
                    result = newMath.Arcsin(input);
                    checkNeeded = true;
                    break;
                case "arccos":
                    result = newMath.Arccos(input);
                    checkNeeded = true;
                    break;
                case "arctan":
                    result = newMath.Arctan(input);
                    checkNeeded = true;
                    break;
                case "PowerXMinus1":
                    result = newMath.Exponentiate(input, -1);
                    checkNeeded = true;
                    break;
                case "Power3":
                    result = newMath.Exponentiate(input, 3);
                    checkNeeded = true;
                    break;
                case "root3":
                    result = newMath.Root(3, input);
                    checkNeeded = true;
                    break;
                case "euler":
                    //TODO
                    break;
            }
            if (checkNeeded)
            {
                Valid_Chk(result);
            }
        }

        public (bool, decimal) Calculate()
        {
            bool convValid;
            (bool, decimal) result = (true, 0);
            convValid = decimal.TryParse(textBox1.Text, out decimal secondNum);

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
                case "powerX":
                    result = newMath.Exponentiate(firstNum, secondNum);
                    break;
                case "multiplication10":
                    //TODO (missing function in lib for easy solve)
                    break;
                case "logDec":
                    result = newMath.Logarithm(secondNum, firstNum);
                    break;
                case "root":
                    result = newMath.Root(secondNum, firstNum);
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
                MEM += decimal.Parse(textBox1.Text);
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
                MEM -= decimal.Parse(textBox1.Text);
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
