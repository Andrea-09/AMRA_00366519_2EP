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
    public partial class UserAdmin : UserControl
    {
        private UserControl current = null;
        private User use;
        
        public UserAdmin()
        {
            InitializeComponent();
            current = createUser1;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new CreateUser();
            tableLayoutPanel1.Controls.Add(current, 0, 1);
            tableLayoutPanel1.SetRowSpan(current, 3);
            tableLayoutPanel1.SetColumnSpan(current, 4);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new ChangePssw(use);
            tableLayoutPanel1.Controls.Add(current, 0, 1);
            tableLayoutPanel1.SetRowSpan(current, 3);
            tableLayoutPanel1.SetColumnSpan(current, 4);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new DeleteUser();
            tableLayoutPanel1.Controls.Add(current, 0, 1);
            tableLayoutPanel1.SetRowSpan(current, 3);
            tableLayoutPanel1.SetColumnSpan(current, 4);

        }
    }
}
