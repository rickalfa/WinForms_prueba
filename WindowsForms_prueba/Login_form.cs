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
using WindowsForms_prueba.forms_admin;


namespace WindowsForms_prueba
{
    public partial class Login_form : Form
    {
        public Home_form HomeForm;

     
        public Login_form()
        {
            InitializeComponent();


            HomeForm = new Home_form();
        


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            String newname =  textBox1.Text;
            ///
            ///  System.Console.WriteLine(newname);
            ///
            ///  this.HomeForm.SetUserame(newname);
            ///
            ///  this.HomeForm.Show();
            ///  

            Plaza_estacionamiento_Form FormPlazeEst = new Plaza_estacionamiento_Form();

            FormPlazeEst.Show();

            Hide();

        }

        private void Login_form_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
