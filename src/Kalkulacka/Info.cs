/**
 * @file Info.cs
 * @author Emma Krompaščíková
 * @brief File responsible for showing informations about calculator
 */

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Kalkulacka
{
    public partial class Info : Form
    {
        List<Panel> listPanel = new List<Panel>();
        int index;

        public Info()
        {
            InitializeComponent();
        }

        private void Info_Load_1(object sender, EventArgs e)
        {
            listPanel.Add(panel_info_1);
            listPanel.Add(panel_info_2);
            listPanel.Add(panel_info_3);
            listPanel.Add(panel_info_4);
            listPanel[index].BringToFront();
        }
        private void panel_info_1_Paint(object sender, PaintEventArgs e)
        {

        }

        /**
         * @brief After click, the next panel will be shown
         */
        private void NEXT_Click(object sender, EventArgs e)
        {
            if (index < listPanel.Count - 1 )
                listPanel[++index].BringToFront();
        }

        /**
         * @brief After click, the next panel will be shown
         */
        private void NEXT2_Click(object sender, EventArgs e)
        {
            if (index < listPanel.Count - 1)
                listPanel[++index].BringToFront();
        }

        //vymazat
        private void button1_Click(object sender, EventArgs e)
        {

        }

        /**
         * @brief After click, the previous panel will be shown
         */
        private void BACK_Click(object sender, EventArgs e)
        {
            if (index > 0)
                listPanel[--index].BringToFront();
        }

        //vymazat
        private void panel_info_2_Paint(object sender, PaintEventArgs e)
        {

        }

        //vymazat
        private void panel_info_3_Paint(object sender, PaintEventArgs e)
        {

        }

        /**
         * @brief After click, the previous panel will be shown
         */
        private void BACK2_Click(object sender, EventArgs e)
        {
            if (index > 0)
                listPanel[--index].BringToFront();
        }

        /**
         * @brief After click, the previous panel will be shown
         */
        private void BACK3_Click(object sender, EventArgs e)
        {
            if (index > 0)
                listPanel[--index].BringToFront();
        }

        /**
         * @brief After click, the next panel will be shown
         */
        private void NEXT3_Click(object sender, EventArgs e)
        {
            if (index < listPanel.Count - 1)
                listPanel[++index].BringToFront();
        }

        /**
         * @brief After click, the form will be closed
         */
        private void CLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
