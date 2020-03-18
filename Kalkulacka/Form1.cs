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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
