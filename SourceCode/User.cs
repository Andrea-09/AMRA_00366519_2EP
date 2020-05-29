using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCode
{
    public class User
    {
        private int idUser;
        private string fullName;
        private string userName;
        private string password;
        private bool userType;

        public User()
        {
        }

      /*  public User(int idUser, string fullName, string userName, string password, bool userType)
        {
            this.idUser = idUser;
            this.fullName = fullName;
            this.userName = userName;
            this.password = password;
            this.userType = userType;
        }*/



        public int IdUser { 
            get => idUser;
            set => idUser = value;
        }

        public string FullName
        {
            get => fullName;
            set => fullName = value;
        }

        public string UserName
        {
            get => userName;
            set => userName = value;
        }

        public string Password
        {
            get => password;
            set => password = value;
        }

        public bool UserType
        {
            get => userType;
            set => userType = value;
        }



    }
}
