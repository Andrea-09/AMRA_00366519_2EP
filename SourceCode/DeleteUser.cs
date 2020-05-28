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
    public partial class DeleteUser : UserControl
    {
        public DeleteUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string query = $"SELECT idUser FROM APPUSERS WHERE username = '{comboBox1.SelectedItem.ToString()}'";

                var dt = ConnectionBD.ExecuteQuery(query);
                var dr = dt.Rows[0];
                var idUsuario = Convert.ToInt32(dr[0].ToString());

                string nonQuery = $"DELETE FROM APPUSERS WHERE idUser ='{comboBox1.SelectedValue}'";

                ConnectionBD.ExecuteNonQuery(nonQuery);


                MessageBox.Show("Se ha eliminado el usuario");

            }
            catch (Exception exception)
            {
                MessageBox.Show("Ha ocurrido un error!");
            }
        }

        private void DeleteUser_Load(object sender, EventArgs e)
        {
            var name = ConnectionBD.ExecuteQuery("SELECT username FROM APPUSER");
            var nameCombo = new List<string>();

            foreach (DataRow dr in name.Rows)
            {
                nameCombo.Add(dr[0].ToString());
            }

            comboBox1.DataSource = nameCombo;
        }
    }
}
