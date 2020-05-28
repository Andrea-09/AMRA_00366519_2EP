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
    public partial class DeleteBusiness : UserControl
    {
        public DeleteBusiness()
        {
            InitializeComponent();
        }

        private void PoblarControles()
        {
            comboBox1.DataSource = null;
            comboBox1.ValueMember = "idBusiness";
            comboBox1.DisplayMember = "name";
            comboBox1.DataSource = BusinessDAO.getLista();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string nonQuery = $"DELETE FROM BUSINESS WHERE idBusiness ={comboBox1.SelectedValue}";
                ConnectionBD.ExecuteNonQuery(nonQuery);

                MessageBox.Show("Se ha eliminado el negocio");

            }
            catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }

        private void DeleteBusiness_Load(object sender, EventArgs e)
        {
            PoblarControles();
        }
    }
}
