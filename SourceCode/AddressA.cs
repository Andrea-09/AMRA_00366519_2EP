using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCode
{
    class AddressA
    {
        private int idAddress;
        private int idUser;
        private string address;

        public AddressA()
        {
        }

        public int IdAddress
        {
            get => idAddress;
            set => idAddress = value;
        }

        public int IdUser
        {
            get => idUser;
            set => idUser = value;
        }

        public string Address
        {
            get => address;
            set => address = value;
        }
    }
}
