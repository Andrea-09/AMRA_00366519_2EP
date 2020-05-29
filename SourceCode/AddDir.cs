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
            
            //currentUser = use;
            

        }

        public AddDir(User logged)
        {
            InitializeComponent();
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
                        $"VALUES('{logged.IdUser}', '{textBox1.Text}')");

                    MessageBox.Show("Se ha agregado la direccion");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
        }

    }
}
