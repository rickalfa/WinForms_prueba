using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_prueba.forms_admin
{
    public partial class Users_form : Form
    {

        private String titulo;

        public Users_form() 
        {

            InitializeComponent();

        }

    

        public Users_form(String _titulo, List<Object> Dates = null)
        {
            InitializeComponent();

            this.titulo = _titulo;

            Users_form_Load();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void TITULO_Click(object sender, EventArgs e)
        {

        }

        private void Users_form_Load()
        {

            this.Titulo_form.Text = this.titulo;

        }

        private void Users_form_Load(object sender, EventArgs e)
        {

        }
    }
}
