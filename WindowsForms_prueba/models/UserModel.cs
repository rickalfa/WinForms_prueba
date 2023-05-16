using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_prueba.models
{
    class UserModel
    {

        private string name;
        private string password;

     
        public UserModel(string name, string Password)
        {
            this.name = name;
            this.password = Password;
        }

        public UserModel() 
        {

           


        }

     
        public string GetName() 
        {

            return this.name;

        }

        public string GetPassword() 
        {

            return this.password;

        }

        public void SetName(string newname)
        {

            this.name = newname;

        }

        public void SetPassword(string newpassword)
        {

            this.password = newpassword;

        }


    }
}
