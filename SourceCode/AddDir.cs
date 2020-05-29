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
    public partial class AddDir : UserControl
    {
        User currentUser = new User();
        private User logged;

        public AddDir()
        {
            InitializeComponent();
            //currentUser = use;
            

        }

        public AddDir(User logged)
        {
            this.logged = logged;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
            {
                MessageBox.Show("Necesita una dirección");
            }
            else
            {
                try
                {
                    ConnectionBD.ExecuteNonQuery($"INSERT INTO ADDRESS(idUser, address) " +
                        $"VALUES({currentUser.IdUser}, '{textBox1.Text})");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
        }

        private int PoblarId()
        {
            var dt = ConnectionBD.ExecuteQuery("SELECT iduser FROM appuser WHERE username='{us}'");
            var dri = dt.Rows[0];
            string auxstr = dri[0].ToString();
            int auxid = Convert.ToInt16(auxstr);
            return auxid;
        }
    }
}
