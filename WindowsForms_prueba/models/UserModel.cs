using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_prueba.models
{
    class UserModel : IEquatable<UserModel>
    {

        private int id { get; set; }
        private string name;
        private string email;
        private string password;

     
        public UserModel(int id, string name, string Password)
        {
            this.id = id;
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

        public bool Equals(UserModel other)
        {
            if (other == null) return false;
            return (this.id.Equals(other.id));


        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            UserModel ObjUser = obj as UserModel;
            if (ObjUser == null) return false;
            else return Equals(ObjUser);


        }


        public override string ToString()
        {

            string id_user = Convert.ToString(id);

            return " \n id : " + id_user + "nombre : " + name + " password : " + password;


        }

        public override int GetHashCode()
        {
            return this.id;  
        }

    }
}
