using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace YT_Downloader
{
    public partial class Donate : Form
    {
        public Donate()
        {
            InitializeComponent();
        }

        private void donate_Load(object sender, EventArgs e)
        {

        }

        private void btc_bt_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1Pjz9dzPsLkbfDdvjqSxeqgJCLZSGxJJ2f");
            MessageBox.Show("Copied to clipboard!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
