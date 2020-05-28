using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCode
{
    class Business
    {
        private int idBusiness;
        private string name;
	    private string description;

        public Business()
        {
        }

        public Business(int idBusiness, string name, string description)
        {
            this.idBusiness = idBusiness;
            this.name = name;
            this.description = description;
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

        public string Description
        {
            get => description;
            set => description = value;
        }
    }
}
