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
        User Logged = new User();
        int idUsu = 0;

        public UserWindow()
        {
        }

        public UserWindow(User usu)
        {
            InitializeComponent();
            Logged = usu;
            us = addDir1;
            MessageBox.Show(Logged.IdUser.ToString());
            idUsu = Logged.IdUser;
            MessageBox.Show(idUsu.ToString());
          
        }

        public User id()
        {
            return Logged;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            tableLayoutPanel3.Controls.Remove(us);
            us = new AddDir(Logged);
            tableLayoutPanel3.Controls.Add(us, 0, 0);
            tableLayoutPanel3.SetRowSpan(us, 2);
            tableLayoutPanel3.SetColumnSpan(us, 2);
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tableLayoutPanel3.Controls.Remove(us);
            us = new ModDir(Logged);
            tableLayoutPanel3.Controls.Add(us, 0, 0);
            tableLayoutPanel3.SetRowSpan(us, 2);
            tableLayoutPanel3.SetColumnSpan(us, 2);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            tableLayoutPanel3.Controls.Remove(us);
            us = new DeleteDir(Logged);
            tableLayoutPanel3.Controls.Add(us, 0, 0);
            tableLayoutPanel3.SetRowSpan(us, 2);
            tableLayoutPanel3.SetColumnSpan(us, 2);

        }

        private void viewOrder1_Load(object sender, EventArgs e)
        {
            
            tableLayoutPanel2.Controls.Remove(us);
            us = new ViewOrder(Logged);
            tableLayoutPanel2.Controls.Add(us, 0, 0);
            tableLayoutPanel2.SetRowSpan(us, 2);
            tableLayoutPanel2.SetColumnSpan(us, 2);
        }
    }

      

        
    }

