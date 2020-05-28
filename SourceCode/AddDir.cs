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
        public AddDir()
        {
            InitializeComponent();
            

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
    }
}
