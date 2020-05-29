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
    public partial class DeleteOrder : UserControl
    {
        private User logged;


        public DeleteOrder()
        {
            InitializeComponent();
           
        }

        private void DeleteOrder_Load(object sender, EventArgs e)
        {
            PoblarControles();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectionBD.ExecuteNonQuery($"DELETE FROM APPORDER WHERE idOrder = '{comboBox1.SelectedValue}'");
            
            MessageBox.Show("Orden eliminada");
        }

        private void PoblarControles()
        {
            comboBox1.DataSource = null;
            comboBox1.ValueMember = "idOrder";
            comboBox1.DisplayMember = "idOrder";
            comboBox1.DataSource = PedidoDAO.getLista();
        }
    }
}
