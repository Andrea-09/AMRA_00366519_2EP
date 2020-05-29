using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SourceCode
{
    public partial class CreateOrder : UserControl
    {
        private UserControl usee = null;
        public CreateOrder()
        {
            InitializeComponent();
            usee = newOrdercs1;
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(usee);
            usee = new NewOrdercs();
            tableLayoutPanel1.Controls.Add(usee, 0, 1);
            tableLayoutPanel1.SetRowSpan(usee, 2);
            tableLayoutPanel1.SetColumnSpan(usee, 3);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(usee);
            usee = new DeleteOrder();
            tableLayoutPanel1.Controls.Add(usee, 0, 1);
            tableLayoutPanel1.SetRowSpan(usee, 2);
            tableLayoutPanel1.SetColumnSpan(usee, 3);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(usee);
            usee = new ViewOrder();
            tableLayoutPanel1.Controls.Add(usee, 0, 1);
            tableLayoutPanel1.SetRowSpan(usee, 2);
            tableLayoutPanel1.SetColumnSpan(usee, 3);

        }

       
    }
}
