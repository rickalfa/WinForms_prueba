using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using WindowsForms_prueba.models;

namespace WindowsForms_prueba
{
    public partial class Home_form : Form
    {

        private UserModel User;

        public Home_form()
        {
            InitializeComponent();

            this.User = new UserModel("unknow", "passunknow");

            

        }

        public Home_form(String name = "unknow", String password = "passunknow")
        {

            InitializeComponent();

            this.User = new UserModel(name, password);


         
        }


        public string getUsername()
        {

            return this.User.GetName();

        }



        public void SetUserame(String newname)
        {

            this.User.SetName(newname);

            this.refresh_Dates_form();

        }



        private void button2_Click(object sender, EventArgs e)
        {

            Close();


        }

        private void UserName_Click(object sender, EventArgs e)
        {




        }

        private void button1_Click(object sender, EventArgs e)
        {


            this.LabelUserName.Text = this.User.GetName();


        }


        private void refresh_Dates_form() 
        {

            this.LabelUserName.Text = this.User.GetName();


        }



    }
}
