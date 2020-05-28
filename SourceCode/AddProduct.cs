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
    public partial class AddProduct : UserControl
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            PoblarControles();
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
            if (comboBox1.SelectedItem == null)
            {
                throw new NoRestaurantSelected("No se ha seleccionado un restaurante");
            }
            else
            {
                try
                {
                    ConnectionBD.ExecuteNonQuery($"INSERT INTO PRODUCT(idBusiness, name) " +
                        $"VALUES('{comboBox1.SelectedValue}', '{textBox1.Text}');");

                    MessageBox.Show("Se ha agregado el producto");
                }
                catch (NoRestaurantSelected ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error");

                }
                
            }
        }
    }
}
