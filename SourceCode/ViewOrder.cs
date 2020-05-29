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
        //static UserWindow uw = new UserWindow();
        User user = new User();
        public ViewOrder(User usu)
        {
            InitializeComponent();
            user = usu;
            MessageBox.Show("Llamado: " + user.IdUser);
        }

        public ViewOrder()
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // mensaje de prueba
            //MessageBox.Show(user.IdUser.ToString());
            //iduser = Convert.ToInt32(uw.ToString());
            //MessageBox.Show(iduser.ToString());
            var dt2 = ConnectionBD.ExecuteQuery($"SELECT ao.idOrder, ao.createDate, pr.name, au.fullname, ad.address " +
                $"FROM APPORDER ao, ADDRESS ad, PRODUCT pr, APPUSER au WHERE ao.idProduct = pr.idProduct " +
                $"AND ao.idAddress = ad.idAddress " +
                $"AND ad.idUser = au.idUser AND au.idUser = '{user.IdUser}'; ");
            dataGridView1.DataSource = dt2;

            MessageBox.Show("Datos obtenidos exitosamente");
        }
    }
}
