﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCode
{
    class Pedido
    {

        private int idOrder;
        private DateTime createDate;
        private int idProduct;
        private int idAddress;

        public Pedido()
        {
        }

        public int IdOrder
        {
            get => idOrder;
            set => idOrder = value;
        }

        public DateTime CreateDate
        {
            get => createDate;
            set => createDate = value;
        }

        public int IdProduct
        {
            get => idProduct;
            set => idProduct = value;
        }

        public int IdAddress
        {
            get => idAddress;
            set => idAddress = value;
        }
    }
}
