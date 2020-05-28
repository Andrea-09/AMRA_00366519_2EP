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
    public partial class ChangePssw : UserControl
    {
        User currentUser = new User();

       

        public ChangePssw(User use)
        {
            InitializeComponent();
            currentUser = use;
         
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Equals(""))
                {
                    MessageBox.Show("No se pueden dejar campos vacios");
                }
                else
                {
                    
                    string sql = $"UPDATE APPUSER SET password = '{textBox1.Text}' WHERE idUser = {currentUser.IdUser}";
                    ConnectionBD.ExecuteNonQuery(sql);
                    MessageBox.Show("Se ha cambiado su contraseña");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }

        }
    }
}
