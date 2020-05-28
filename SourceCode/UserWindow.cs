using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SourceCode
{
    public partial class UserWindow : Form
    {
        private UserControl us = null;
        public UserWindow()
        {
            InitializeComponent();

            us = addDir1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(us);
            us = new AddDir();
            tableLayoutPanel1.Controls.Add(us, 0, 1);
            tableLayoutPanel1.SetRowSpan(us, 2);
            tableLayoutPanel1.SetColumnSpan(us, 3);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(us);
            us = new ModDir();
            tableLayoutPanel1.Controls.Add(us, 0, 1);
            tableLayoutPanel1.SetRowSpan(us, 2);
            tableLayoutPanel1.SetColumnSpan(us, 3);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(us);
            us = new DeleteDir();
            tableLayoutPanel1.Controls.Add(us, 0, 1);
            tableLayoutPanel1.SetRowSpan(us, 2);
            tableLayoutPanel1.SetColumnSpan(us, 3);

        }
    }
}
