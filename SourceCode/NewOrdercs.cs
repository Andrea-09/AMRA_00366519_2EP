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
    public partial class NewOrdercs : UserControl
    {
        public NewOrdercs()
        {
            InitializeComponent();
        }

        private void NewOrdercs_Load(object sender, EventArgs e)
        {
            PoblarControles1();
            PoblarControles2();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Llene los campos");
            }
            else
            {
                try
                {
                    string query = $"INSERT INTO APPORDER(createDate, idProduct, idAddress) " +
                           $"VALUES('{DateTime.Now}', {comboBox2.SelectedValue}, {comboBox1.SelectedValue});";
                    ConnectionBD.ExecuteNonQuery(query);

                    MessageBox.Show("Se ha realizado su compra");
                }


                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
            }
        private void PoblarControles1()
        {
            comboBox1.DataSource = null;
            comboBox1.ValueMember = "idAddress";
            comboBox1.DisplayMember = "address";
            comboBox1.DataSource = AddressDAO.getLista();
        }

        private void PoblarControles2()
        {
            comboBox2.DataSource = null;
            comboBox2.ValueMember = "idProduct";
            comboBox2.DisplayMember = "name";
            comboBox1.DataSource = ProductDAO.getLista();
        }

    }

    }

