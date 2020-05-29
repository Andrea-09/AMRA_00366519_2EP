using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SourceCode
{
    public partial class AdminWindow : Form
    {
        private UserControl newUser = null;
        
     
        public AdminWindow()
        {
            InitializeComponent();
            newUser = addBusiness1;
           
               
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(newUser);
            newUser = new AddBusiness();
            tableLayoutPanel1.Controls.Add(newUser, 0, 1);
            tableLayoutPanel1.SetRowSpan(newUser, 2);
            tableLayoutPanel1.SetColumnSpan(newUser, 3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(newUser);
            newUser = new DeleteBusiness();
            tableLayoutPanel1.Controls.Add(newUser, 0, 1);
            tableLayoutPanel1.SetRowSpan(newUser, 2);
            tableLayoutPanel1.SetColumnSpan(newUser, 2);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(newUser);
            newUser = new AddProduct();
            tableLayoutPanel1.Controls.Add(newUser, 0, 1);
            tableLayoutPanel1.SetRowSpan(newUser, 2);
            tableLayoutPanel1.SetColumnSpan(newUser, 2);


        }

        private void button4_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(newUser);
            newUser = new  DeleteProduct();
            tableLayoutPanel1.Controls.Add(newUser, 0, 1);
            tableLayoutPanel1.SetRowSpan(newUser, 2);
            tableLayoutPanel1.SetColumnSpan(newUser, 3);




        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                var dt = ConnectionBD.ExecuteQuery($"SELECT ao.idOrder, ao.createDate, pr.name, au.fullname, ad.address " +
                    $"FROM APPORDER ao, ADDRESS ad, PRODUCT pr, APPUSER au " +
                    $"WHERE ao.idProduct = pr.idProduct " +
                    $"AND ao.idAddress = ad.idAddress " +
                    $"AND ad.idUser = au.idUser; ");

                dataGridView1.DataSource = dt;

                MessageBox.Show("Datos obtenidos exitosamente!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un problema!");
            }
        }

        private void userAdmin1_Load(object sender, EventArgs e)
        {

        }
    }
}
