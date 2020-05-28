using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCode
{
    class PedidoDAO
    {
        public static List<Pedido> getLista()
        {
            string sql = "select * from APPORDER";

            DataTable dt = ConnectionBD.ExecuteQuery(sql);

            List<Pedido> lista = new List<Pedido>();
            foreach (DataRow fila in dt.Rows)
            {
                Pedido ped = new Pedido();
                User u = new User();
                ped.IdOrder = Convert.ToInt32(fila[0].ToString());
                ped.CreateDate = Convert.ToDateTime(fila[1].ToString());
                ped.IdProduct = ped.IdOrder = Convert.ToInt32(fila[2].ToString());
                ped.IdAddress = Convert.ToInt32(fila[3].ToString());


                lista.Add(ped);
            }
            return lista;
        }
    }
}
