using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using WindowsForms_prueba.models;




namespace WindowsForms_prueba
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {


            listaDinamica();



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login_form());


        }

        public static void listaDinamica()
        {

            const int dateinput = 3;
           
            List <String> ListaT;


            ArrayList Lista = new ArrayList();
           
            //Console.WriteLine("por favor ingresa la cantidad de elementos que de la Lista : ");
           
            //dateinput = Console.ReadLine();



            string[,] ListaUser = new string[dateinput, 2] { { "andres", "123" }, { "miguel", "123" }, { "Alejandro", "123" } };

            int countList = ListaUser.Length;

            Console.WriteLine("largo de la Lista  {0} : ", countList);


            for (int i = 0; i <= dateinput -1; i++) 
            {

                Console.WriteLine("ingrese un elemento en la posicion {0} : ", i);

                string nameUser = Convert.ToString( ListaUser[i, 0]);

                Console.WriteLine("nombre del usuario n- {0} : {1}  password : {2}", i, nameUser, ListaUser[i, 1]);

                UserModel usuario = new UserModel(ListaUser[i, 0], "password");

                Lista.Add(usuario);


            }


            foreach(UserModel Objt in Lista) 
            {

                Console.WriteLine(" objt de la Lisra : {0}", Objt.GetName());


            }




        }

    }
}
