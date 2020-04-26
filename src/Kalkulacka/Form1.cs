/**********
* IVS - project 2 - Calculator
* Team Orient Express
* Ac. y. 2019/20
***********
* @file Form1.cs
* @author Emma Krompaščíková
* @author Filip Kružík
* @brief File responsible for handling calculator UI and integrating functions from math lib
*/

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Kalkulacka
{
    public partial class Form1 : Form
    {
        private List<Panel> listPanel = new List<Panel>();
        private MathComponentsNS.MathComponents newMath = new MathComponentsNS.MathComponents();
        private bool shiftClicked = false;
        private string operationPerformed = "";
        private decimal firstNum = 0;
        private decimal secondNum = 0;
        private decimal MEM = 0;
        private decimal ans = 0;
        private decimal tempSecondNum = 0;
        private bool erase = false;
        private bool repeatEq = false;
        private bool opClick = false;
        private bool useAns = false;
        //private object txt_Result;

        public Form1()
        {
            InitializeComponent();
        }

        /**
         * @brief Init function for UI setup
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
         * @brief Checks length and appends char if possible
         * @param[in] char d (character to be appended)
         */
        private void length(char d)
        {
            if (textBox1.Text.Contains("-") && textBox1.Text.Contains(","))
            {
                if (textBox1.Text.Length <= 10)
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
         * @brief Switches panel after pressing SHIFT
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
         * @brief Turns off the application
         */
        private void off_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /**
         * @brief Digit button press handler
         */
        private void Number_click(object sender, EventArgs e)
        {
            repeatEq = false;
            opClick = false;
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
         * @brief Decimal point button handler
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
         * @brief Function to check if there is enough space in textbox for applying pressed key (WIP)
         */
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*Char chr = e.KeyChar;
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
                    if (!Char.IsDigit(chr) && chr != 8)
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
                    if (!Char.IsDigit(chr) && chr != 8 && chr != ',')
                    {
                        e.Handled = true;
                    }
                }
            }
            else if (textBox1.Text.Contains(","))
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
         * @brief Checking validity of result
         * Sets text box to result if all correct or to "Error" if not
         */
        public void Valid_Chk(decimal? result)
        {
            if (result == null)
            {
                textBox1.Text = "Error";
                //TODO error handler
                erase = true;
            }
            else
            {
                decimal resultt = result ?? 0;
                textBox1.Text = resultt.ToString(System.Globalization.CultureInfo.CreateSpecificCulture("tr-tr"));
                ans = resultt;
                firstNum = 0;
                useAns = true;
                erase = true;
            }
        }

        /**
         * @brief Operation button press handler
         */
        private void operation_Click(object sender, EventArgs e)    //Určení stisknuté operace, uložení vstupu, vymazání textboxu
        {
            bool convValid;
            Button button = (Button)sender;
            repeatEq = false;

            if (useAns)
            {
                firstNum = ans;
            }
            if ((textBox1.Text != "" && firstNum == 0) || opClick)
            {
                convValid = decimal.TryParse(textBox1.Text.Replace(',', '.'), out firstNum);
                erase = true;
            }
            else if (textBox1.Text != "" && firstNum != 0)
            {
                Valid_Chk(Calculate());
                erase = true;
                useAns = true;
            }
            operationPerformed = button.Name;
            opClick = true;
        }

        /**
         * @brief Unary operations handler
         * Integrated with math lib
         */

        private void InstantOp_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string instantOp = button.Name;
            decimal? result = 0;
            decimal resultt = 0;
            bool skipCheck = false;
            bool parseCheck = decimal.TryParse(textBox1.Text.Replace(',', '.'), out decimal input);
            /*if (erase)
            {
                ZeroClear();
                erase = false;
            }*/

            switch (instantOp)
            {
                case "ANS":
                    textBox1.Text = ans.ToString();
                    skipCheck = true;
                    break;

                case "RAND":
                    result = newMath.Random();
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
                    skipCheck = true;
                    break;

                case "AC":
                    ZeroClear();
                    useAns = false;
                    skipCheck = true;
                    operationPerformed = "";
                    break;

                case "equals":
                    if (useAns)
                    {
                        firstNum = ans;
                    }
                    if (firstNum != 0)
                    {
                        Valid_Chk(Calculate());
                        repeatEq = true;
                    }
                    else if (repeatEq)
                    {
                        parseCheck = decimal.TryParse(textBox1.Text.Replace(',', '.'), out firstNum);
                        Valid_Chk(Calculate());
                    }
                    skipCheck = true;
                    useAns = false;
                    break;

                case "sin":
                    result = newMath.Sin(input);
                    break;

                case "cos":
                    result = newMath.Cos(input);
                    break;

                case "tan":
                    result = newMath.Tan(input);
                    break;

                case "factorial":
                    result = newMath.Factorial(input);
                    break;

                case "log":
                    result = newMath.Logarithm(input, 10);
                    break;

                case "Power2":
                    result = newMath.Exponentiate(input, 2);
                    break;

                case "root2":
                    result = newMath.Root(2, input);
                    break;

                case "ln":
                    result = newMath.Logarithm(input, newMath.constE);
                    break;

                case "arcsin":
                    result = newMath.Arcsin(input);
                    break;

                case "arccos":
                    result = newMath.Arccos(input);
                    break;

                case "arctan":
                    result = newMath.Arctan(input);
                    break;

                case "PowerXMinus1":
                    result = newMath.Exponentiate(input, -1);
                    break;

                case "Power3":
                    result = newMath.Exponentiate(input, 3);
                    break;

                case "root3":
                    result = newMath.Root(3, input);
                    break;

                case "euler":
                    result = newMath.Exponentiate(newMath.constE, input);
                    break;

                case "negate":
                    if (textBox1.Text != "0" && !opClick && textBox1.Text != "Error")
                    {
                        if (!textBox1.Text.Contains("-"))
                        {
                            if ((textBox1.Text.Contains(",") && textBox1.Text.Length <= 10) || textBox1.Text.Length <= 9)
                            {
                                textBox1.Text = textBox1.Text.Insert(0, "-");
                            }
                        }
                        else
                        {
                            textBox1.Text = textBox1.Text.Remove(0, 1);
                        }
                    }
                    useAns = false;
                    skipCheck = true;
                    break;
            }
            if (instantOp != "del" && instantOp != "pi" && firstNum != 0 && instantOp != "negate")
            {
                erase = true;
                //firstNum = 0;
            }
            if (!skipCheck)
            {
                if (result != null)
                {
                    resultt = result ?? 0;
                    textBox1.Text = resultt.ToString(System.Globalization.CultureInfo.CreateSpecificCulture("tr-tr"));
                    ans = resultt;
                }
                else
                {
                    textBox1.Text = "Error";
                    erase = true;
                }
            }
        }

        /**
         * @brief Binary operations handler
         * Integrated with math lib
         */
        public decimal? Calculate()
        {
            bool convValid;
            decimal? result = 0;
            
            if (repeatEq)
            {
                secondNum = tempSecondNum;
            }
            else
            {
                convValid = decimal.TryParse(textBox1.Text.Replace(',', '.'), out secondNum);
            }

            switch (operationPerformed)
            {
                case "addition":
                    result = newMath.Add(firstNum, secondNum);
                    break;

                case "subtraction":
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

                case "logDec":
                    result = newMath.Logarithm(firstNum, secondNum);
                    break;

                case "root":
                    result = newMath.Root(secondNum, firstNum);
                    break;

                default:
                    result = firstNum;
                    break;
            }
            if (secondNum != 0)
            {
                tempSecondNum = secondNum;
                secondNum = 0;
            }
            return result;
        }

        /**
         * @brief Addition to memory handler
         * Controls memory icon
         */
        private void Mplus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                MEM += decimal.Parse(textBox1.Text.Replace(',', '.'));
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
         * @brief Memory recall handler
         */
        private void MRC_Click(object sender, EventArgs e)
        {
            textBox1.Text = MEM.ToString(System.Globalization.CultureInfo.CreateSpecificCulture("tr-tr"));
            erase = true;
        }

        /**
         * @brief Subtracts memory
         * Memory icon control
         */
        private void Mminus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                MEM -= decimal.Parse(textBox1.Text.Replace(',', '.'));
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
         * @brief Clears output to 0
         */
        public void ZeroClear()
        {
            textBox1.Text = "0";
        }

        /**
         * @brief Clears output to NULL
         */
        public void Clear()
        {
            textBox1.Text = "";
        }

        /**
         * @brief pi button click handler
         */
        private void PI_Click(object sender, EventArgs e)
        {
            decimal pii = newMath.TruncateToFit(newMath.constPI) ?? 0;
            textBox1.Text = pii.ToString(System.Globalization.CultureInfo.CreateSpecificCulture("tr-tr"));
            opClick = false;
        }

        /**
         * @brief Opens new window with help
         */
        private void question_Click(object sender, EventArgs e)
        {
            Info openForm = new Info();
            openForm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
