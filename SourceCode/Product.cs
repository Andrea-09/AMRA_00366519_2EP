using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCode
{
    class Product
    {
        private int idProduct;
        private int idBusiness;
        private string name;

        public Product()
        {
        }

        public Product(int idProduct, int idBusiness, string name)
        {
            this.idProduct = idProduct;
            this.idBusiness = idBusiness;
            this.name = name;
        }

        public int IdProduct
        {
            get => idProduct;
            set => idProduct = value;
        }

        public int IdBusiness
        {
            get => idBusiness;
            set => idBusiness = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }
    }
}
