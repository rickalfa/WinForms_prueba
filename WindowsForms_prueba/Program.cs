using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms_prueba.controllers;
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

            UserController UsersList = new UserController();

            UsersList.get();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login_form());


        }

        public static void listaDinamica()
        {

            const int dateinput = 4;
           
            List <String> ListaT;

            /// creamos la lsita que contendra los datos del ModeUser
            List<UserModel> ListUserModel = new List<UserModel>();

            ArrayList Lista = new ArrayList();
           
            //Console.WriteLine("por favor ingresa la cantidad de elementos que de la Lista : ");
           
            //dateinput = Console.ReadLine();



            string[,] ListaUser = new string[dateinput, 2] 
            {
                { "andres", "987123" },
                { "miguel", "1534223" },
                { "Alejandro", "9876123" },
                { "estefania", "986785343" }
            };

            int countList = ListaUser.Length;

            Console.WriteLine("largo de la Lista  {0} : ", countList);


            ///**
            ///
            /// for para crear objetos UserModel con los Datos e incresarlo a la lista ListaUser 
            /// 
            /// 
            ///*****

            for (int i = 0; i <= dateinput -1; i++) 
            {

                Console.WriteLine("ingrese un elemento en la posicion {0} : ", i);

                string nameUser = Convert.ToString( ListaUser[i, 0]);

                //Console.WriteLine("nombre del usuario n- {0} : {1}  password : {2}", i, nameUser, ListaUser[i, 1]);

                UserModel usuario = new UserModel(2 , ListaUser[i, 0], "password");

                ListUserModel.Add(usuario);

            }


            ///*
            ///*********************************************************************
            ///
            /// Lectura de ArrayList 
            /// 
            /// 

           // foreach(UserModel Objt in ListUserModel) 
           // {
           //
           //     Console.WriteLine(" objt de la Lisra : {0}", Objt.GetName());
           //
           // }


        }

    }
}
