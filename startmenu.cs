using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace taskman
{
    public partial class startmenu : Form
    {
        int comp = 2;
        public startmenu()
        {
            
            InitializeComponent();
        }

        private void okbutt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancelbutt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void compin2_CheckedChanged(object sender, EventArgs e)
        {
            comp = 2;
        }
        private void compin1_CheckedChanged(object sender, EventArgs e)
        {
            comp = 1;
        }
        private void compin0_CheckedChanged(object sender, EventArgs e)
        {
            comp = 0;
        }
    }
}
