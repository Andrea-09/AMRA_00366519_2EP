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
    public partial class DeleteDir : UserControl
    {
        public DeleteDir()
        {
            InitializeComponent();
        }

        private void DeleteDir_Load(object sender, EventArgs e)
        {
            PoblarControles();
        }

        private void PoblarControles()
        {
            comboBox1.DataSource = null;
            comboBox1.ValueMember = "idAddress";
            comboBox1.DisplayMember = "address";
            comboBox1.DataSource = AddressDAO.getLista();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Escoga una dirección");
                }
                else
                {
                    ConnectionBD.ExecuteNonQuery($"DELETE FROM ADDRESS WHERE idAddress = '{comboBox1.SelectedValue}'");
                    PoblarControles();
                    MessageBox.Show("Se ha eliminado la direccion");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }
    }

}
