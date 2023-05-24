using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForms_prueba.models;

namespace WindowsForms_prueba.controllers
{
    class UserController : Controller
    {
        public List<UserModel> UsersList;



        public UserController()
        {

            this.UsersList = new List<UserModel>();

            const int dateinput = 4;

            ArrayList Lista = new ArrayList();

            string[,] ListaUser = new string[dateinput, 3]
            {
                {"1", "andres", "987123" },
                {"2", "miguel", "1534223" },
                {"7", "Alejandro", "9876123" },
                {"4", "estefania", "986785343" }
            };

            int countList = ListaUser.Length;

            Console.WriteLine("largo de la Lista  {0} : ", countList);


            ///*******************************
            ///
            /// for para crear objetos UserModel con los Datos e incresarlo a la lista ListaUser 
            /// 
            /// 
            ///*****

            for (int i = 0; i <= dateinput - 1; i++)
            {

                string nameUser = Convert.ToString(ListaUser[i, 1]);
                int id_user = Int32.Parse(ListaUser[i, 0]);

                Console.WriteLine("n-{0}  id del usuario : {1} nombre del usuario  : {2}  password : {3}", i+1, id_user, nameUser, ListaUser[i, 2]);

                

                UserModel usuario = new UserModel(id_user, ListaUser[i, 1], "password");

                this.UsersList.Add(usuario);



            }


            string datesUser = this.UsersList.ToString();

            Console.WriteLine("linea en string :");
            Console.WriteLine(datesUser);





        }

        public override void create(List<Object> ListDates)
        {
           // UserModel Userdates = new UserModel();

            int countList = ListDates.Count();

            foreach (UserModel Userdates in ListDates)
            {

                 this.UsersList.Add(Userdates);

            }


            //this.UsersList.Add();

        }

        public override void delete(int _id)
        {
            throw new NotImplementedException();
        }

        public override ArrayList get(int _id = 0)
        {


            ArrayList Userdates = new ArrayList();

            string id_user = Convert.ToString(_id);

            if (_id != 0)
            {

                UserModel UserM = new UserModel(_id, "", "");

                bool user_find = this.UsersList.Contains(UserM);


                if (user_find)
                {

                    int indexfound = this.UsersList.IndexOf(UserM);

                    Console.WriteLine(" elemento encontrado con id : {0} index de la List es : {1}", id_user, indexfound);

                    Userdates.Add(this.UsersList[indexfound]);


                    return Userdates;


                }
                else{

                    Console.WriteLine(" elemento No encontrado  ");

                    return Userdates;
                }


             

            }
            else {

                foreach (UserModel User in this.UsersList)
                {

                    Console.WriteLine(" impresion del metodo get");
                    Console.WriteLine(User);

                    Userdates.Add(User);

                }


                return Userdates;    

            }

        }

        public override void update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
