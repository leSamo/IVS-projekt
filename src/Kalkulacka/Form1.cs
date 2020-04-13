/**
* @file
*/

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
        bool shiftClicked = false;
        string operationPerformed = "";
        decimal firstNum = 0;
        decimal secondNum = 0;
        decimal MEM = 0;
        decimal ans = 0;
        bool erase = false;
        bool repeatEq = false;
        //private object txt_Result;


        public Form1()
        {
            InitializeComponent();
        }

        /**
         * @brief Function for memory
         */
        private void funkciaNaVyuzitie ()
        {
            DisplayedM.ForeColor = Color.Black;
        }

        /**
         * @brief Function chcecking length 
         * @param[in] char d (clicked number or character)
         */
        private void length (char d)
        {   
            if (textBox1.Text.Contains("-") && textBox1.Text.Contains(","))
            {
                if(textBox1.Text.Length <= 10)
                {
                    textBox1.Text = textBox1.Text + d;
                }
            }
            else if (textBox1.Text.Contains("-") || textBox1.Text.Contains(","))
            {
                if (textBox1.Text.Length <= 9)
                {
                    textBox1.Text = textBox1.Text + d;
                }
            }
            else if (textBox1.Text.Length <= 8)
            {
                textBox1.Text = textBox1.Text + d;
            }
        }

        /**
         * @brief Panel function
         * for extended functions of calculator
         */
        private void Form1_Load(object sender, EventArgs e)
        {
            listPanel.Add(shiftUnclickedPanel);
            listPanel.Add(shiftClickedPanel);
            listPanel[0].BringToFront();
            DisplayedM.Visible = false;
            textBox1.SelectionStart = textBox1.Text.Length;
        }

        /**
         * @brief Function for switching panel
         * after click on SHIFT the panel will change
         */
        private void shift_Click(object sender, EventArgs e)
        {
            if (shiftClicked)
            {
                listPanel[0].BringToFront();
                shift.BackColor = MRC.BackColor = Mplus.BackColor = Mminus.BackColor = off.BackColor = Color.FromArgb(115, 0, 3);
                shift.FlatAppearance.MouseOverBackColor = MRC.FlatAppearance.MouseOverBackColor = Mplus.FlatAppearance.MouseOverBackColor = Mminus.FlatAppearance.MouseOverBackColor = off.FlatAppearance.MouseOverBackColor = Color.FromArgb(68, 0, 2);
                shiftClicked = false;
            }
            else
            {
                listPanel[1].BringToFront();
                shift.BackColor = MRC.BackColor = Mplus.BackColor = Mminus.BackColor = off.BackColor = Color.FromArgb(68, 0, 2);
                shift.FlatAppearance.MouseOverBackColor = MRC.FlatAppearance.MouseOverBackColor = Mplus.FlatAppearance.MouseOverBackColor = Mminus.FlatAppearance.MouseOverBackColor = off.FlatAppearance.MouseOverBackColor = Color.FromArgb(115, 0, 3);
                shiftClicked = true;
            }
        }

        /**
         * @brief Function of switching off the application
         * @return close of calculator
         */
        private void off_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /**
         * @brief Function for cliked number
         * chcecking length
         * @return number in TextBox
         */
        private void Number_click(object sender, EventArgs e)
        {
            repeatEq = false;
            if (erase)
            {
                ZeroClear();
                erase = false;
            }

            if (textBox1.Text == "0")
            {
                Clear();
            }
            
            Button button = (Button)sender;
            string btnName = button.Name;

            switch (btnName)
            {
                case "num0":
                    length('0');
                    break;
                case "num1":
                    length('1');
                    break;
                case "num2":
                    length('2');
                    break;
                case "num3":
                    length('3');
                    break;
                case "num4":
                    length('4');
                    break;
                case "num5":
                    length('5');
                    break;
                case "num6":
                    length('6');
                    break;
                case "num7":
                    length('7');
                    break;
                case "num8":
                    length('8');
                    break;
                case "num9":
                    length('9');
                    break;
            }
        }

        /**
         * @brief Function for Decimal point
         * only one allowed
         */
        private void decPoint_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(","))
            {
                if (textBox1.Text == "" || textBox1.Text == "-")
                {
                    textBox1.Text = textBox1.Text + "0,";
                }
                else if (textBox1.Text.Contains("-"))
                {
                    if (textBox1.Text.Length <= 9)
                    {
                        textBox1.Text = textBox1.Text + ",";
                    }
                }
                else if (textBox1.Text.Length <= 8)
                {
                    textBox1.Text = textBox1.Text + ",";
                }
            }
          
        }

        /**
         * @brief Function for negative numbers if text box contains only zero
         * @brief Function for subctraction of numbers
         */
        private void subtraction_Click(object sender, EventArgs e)
        {
            bool convValid;
            if (textBox1.Text == "0")
            {
                textBox1.Text = "-";
            }
            else
            {
                convValid = decimal.TryParse(textBox1.Text, out firstNum);
                erase = true;
                operationPerformed = "substraction";
            }
        }

        /**
         * uprav popis, lebo nemam ani sajny
         */
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

        /**
         * @brief Function for checking successful result
         * @return result if everything is good
         */
        public void Valid_Chk((bool, decimal) result)                //Funkce pro kontrolu úspěšného dokončení výpočtu a případného vypsání výsledku
        {
            if (result.Item1)
            {
                textBox1.Text = "Error";
                //TODO error handler
            }
            else
            {
                textBox1.Text = result.Item2.ToString();
                firstNum = ans = result.Item2;
                erase = true;

            }
        }

        /**
         * @brief Function for  setting the right operation
         * save input
         * erase textbox
         */
        private void operation_Click(object sender, EventArgs e)    //Určení stisknuté operace, uložení vstupu, vymazání textboxu
        {
            bool convValid;
            Button button = (Button)sender;
            operationPerformed = button.Name;
            if (textBox1.Text != "" && firstNum == 0)
            {
                convValid = decimal.TryParse(textBox1.Text, out firstNum);
                erase = true;
            }
            else if (textBox1.Text != "" && firstNum != 0)
            {
                Valid_Chk(Calculate());
                erase = true;
            }
        }

        /**
         * nemam šajnu
         */
        private void InstantOp_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string instantOp = button.Name;
            (bool, decimal) result = (true, 0);
            bool checkNeeded = false;
            bool parseCheck = decimal.TryParse(textBox1.Text, out decimal input);
            if (erase)
            {
                ZeroClear();
                erase = false;
            }

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
                        if (textBox1.Text == "" || textBox1.Text == "Erro")
                        {
                            ZeroClear();
                        }
                    }
                    break;
                case "AC":
                    ZeroClear();
                    break;
                case "equals":
                    if (firstNum != 0)
                    {
                        Valid_Chk(Calculate());
                        repeatEq = true;
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
                    // result = newMath.constPI;
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
                    //result = newMath.constE;
                    break;
            }
            if (instantOp != "del" && firstNum != 0)
            {
                erase = true;
            }
            if (checkNeeded)
            {
                Valid_Chk(result);
            }
        }

        /**
         * @brief Function for ????
         */
        public (bool, decimal) Calculate()
        {
            bool convValid;
            (bool, decimal) result = (true, 0);
            if (!repeatEq)
            {
                convValid = decimal.TryParse(textBox1.Text, out secondNum);
            }

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

        /**
         * @brief Function for addition
         * if memory is empty do nieco
         */
        private void Mplus_Click(object sender, EventArgs e)
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
            erase = true;
        }

        /**
         * Function for saving to memory
         */
        private void MRC_Click(object sender, EventArgs e)
        {
            textBox1.Text = MEM.ToString();
            erase = true;
        }

        /**
         * @brief Function for substitute
         * if memory is empty, do nieco
         */
        private void Mminus_Click(object sender, EventArgs e)
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
            erase = true;
        }

        /**
         * zero always at start
         */
        public void ZeroClear()
        {
            textBox1.Text = "0";
        }

        /**
         * neviem
         */
        public void Clear()
        {
            textBox1.Text = "";
        }
    }
}
