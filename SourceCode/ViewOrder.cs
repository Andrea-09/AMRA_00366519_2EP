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
    public partial class ViewOrder : UserControl
    {
        User u = new User();
        public ViewOrder()
        {
            InitializeComponent();
            //u = user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dt2 = ConnectionBD.ExecuteQuery($"SELECT ao.idOrder, ao.createDate, pr.name, au.fullname, ad.address" +
                $"FROM APPORDER ao, ADDRESS ad, PRODUCT pr, APPUSER au " +
                $"WHERE ao.idProduct = pr.idProduct " +
                $"AND ao.idAddress = ad.idAddress" +
                $"AND ad.idUser = au.idUser AND au.idUser = {u.IdUser};");
            dataGridView1.DataSource = dt2;

            MessageBox.Show("Datos obtenidos exitosamente");
        }
    }
}
