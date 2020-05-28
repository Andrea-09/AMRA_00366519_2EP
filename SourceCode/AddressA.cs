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

        public AddressA(int idAddress, int idUser, string address)
        {
            this.idAddress = idAddress;
            this.idUser = idUser;
            this.address = address;
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
