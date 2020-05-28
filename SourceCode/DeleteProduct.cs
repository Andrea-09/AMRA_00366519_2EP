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
    public partial class DeleteProduct : UserControl
    {
        public DeleteProduct()
        {
            InitializeComponent();
        }

        private void DeleteProduct_Load(object sender, EventArgs e)
        {
            PoblarControles();
        }

        private void PoblarControles()
        {
            comboBox1.DataSource = null;
            comboBox1.ValueMember = "idProduct";
            comboBox1.DisplayMember = "name";
            comboBox1.DataSource = ProductDAO.getLista();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("No se ha escogido un producto");
                }
                else
                {
                    ConnectionBD.ExecuteNonQuery($"DELETE FROM PRODUCT WHERE idProduct = '{comboBox1.SelectedValue}'");
                    MessageBox.Show("Se ha eliminado el producto");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }
    }
}
