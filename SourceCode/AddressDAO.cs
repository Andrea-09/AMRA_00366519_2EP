using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCode
{
    class AddressDAO
    {
        public static List<AddressA> getLista()
        {
            string sql = "select * from ADDRESS";

            DataTable dt = ConnectionBD.ExecuteQuery(sql);

            List<AddressA> lista = new List<AddressA>();
            foreach (DataRow fila in dt.Rows)
            {
                AddressA ad = new AddressA();
                ad.IdAddress = Convert.ToInt32(fila[0].ToString());
                ad.IdUser = Convert.ToInt32(fila[1].ToString());
                ad.Address= fila[1].ToString();
            


                lista.Add(ad);
            }
            return lista;
        }

    }
}
