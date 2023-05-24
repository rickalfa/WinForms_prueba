using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using WindowsForms_prueba.controllers;
using WindowsForms_prueba.models;

namespace WindowsForms_prueba
{
    public partial class Home_form : Form
    {

        private UserModel User;
        private UserController UsersDates;

        public Home_form()
        {

            this.Load += new EventHandler(Home_form_Load);

            this.User = new UserModel(0 ,"unknow", "passunknow");

            this.UsersDates = new UserController();


            InitializeComponent();




        }

        public Home_form(int _id,String name = "unknow", String password = "passunknow")
        {

            InitializeComponent();

            this.User = new UserModel(_id, name, password);


         
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Home_form_Load(object sender, EventArgs e)
        {
            List<UserModel> Userlist = new List<UserModel>();


            dataGridView1.ColumnCount = 4;
            dataGridView1.Size = new Size(500, 300);

            //// hacemos que la data gridView sea solo de lectura 
            ///
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;

            dataGridView1.Name = "data table Users ";

            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;

            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Single;

            dataGridView1.RowHeadersVisible = false;

            dataGridView1.Columns[0].Name = "id";
            dataGridView1.Columns[1].Name = "name";
            dataGridView1.Columns[2].Name = "email";
            dataGridView1.Columns[3].Name = "status";
           

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridView1.MultiSelect = false;

            // dataGridView1.Dock = DockStyle.Fill;


           


            foreach (UserModel User in this.UsersDates.UsersList)
            {

                string id_str = Convert.ToString(User.GetHashCode());

                string[] row0 = { id_str, User.GetName(), "Revolution 9",
                 "Beatles" };

                dataGridView1.Rows.Add(row0);

              
            }




        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<UserModel> Userlist = new List<UserModel>();

            foreach (UserModel User in this.UsersDates.UsersList)
            {

                Userlist.Add(User);


            }

            dataGridView1.DataSource = Userlist;
        }
    }
}
