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
        private User logged;

        public NewOrdercs()
        {
            InitializeComponent();

        }

        private void NewOrdercs_Load(object sender, EventArgs e)
        {
            PoblarControles1();
            PoblarControles2();
            //PoblarControles3();
            //PoblarControles4();

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
                    DateTime d = DateTime.Now;
                    ConnectionBD.ExecuteNonQuery($"INSERT INTO APPORDER(createDate, idProduct, idAddress) " +
                        $"VALUES('{d}', '{comboBox1.SelectedValue}', '{comboBox2.SelectedValue}'); ");
                    
                 

                    MessageBox.Show("Se ha procesado su orden");
                }


                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
            }
        private void PoblarControles2()
        {
            comboBox2.DataSource = null;
            comboBox2.ValueMember = "idAddress";
            comboBox2.DisplayMember = "address";
            comboBox2.DataSource = AddressDAO.getLista();
        }

        private void PoblarControles1()
        {
            comboBox1.DataSource = null;
            comboBox1.ValueMember = "idProduct";
            comboBox1.DisplayMember = "name";
            comboBox1.DataSource = ProductDAO.getLista();
        }

       /* private void PoblarControles3()
        {
            comboBox2.DataSource = null;
            comboBox2.ValueMember = "idBusiness";
            comboBox2.DisplayMember = "name";
            comboBox1.DataSource = BusinessDAO.getLista();
        }

        private void PoblarControles4()
        {
            comboBox2.DataSource = null;
            comboBox2.ValueMember = "idOrder";
            comboBox2.DisplayMember = "idOrder";
            comboBox1.DataSource = PedidoDAO.getLista();
        }*/

    }

    }

