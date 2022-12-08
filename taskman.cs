using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace taskman
{
    public partial class taskman : Form
    {
        public taskman()
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
    }
}
