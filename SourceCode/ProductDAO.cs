using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCode
{
    class ProductDAO
    {
        public static List<Product> getLista()
        {
            string sql = "select * from PRODUCT";

            DataTable dt = ConnectionBD.ExecuteQuery(sql);

            List<Product> lista = new List<Product>();
            foreach (DataRow fila in dt.Rows)
            {
                Product pr = new Product();
                pr.IdProduct = Convert.ToInt32(fila[0].ToString());
                pr.IdBusiness = Convert.ToInt32(fila[1].ToString());
                pr.Name = fila[2].ToString();
              

                lista.Add(pr);
            }
            return lista;
        }

    }
}
