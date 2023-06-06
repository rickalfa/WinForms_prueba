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
    public partial class Plaza_estacionamiento_Form : Form
    {

        private Form ActiveForm = null;

        public Plaza_estacionamiento_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new Users_form());
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void Plaza_estacionamiento_Form_Load(object sender, EventArgs e)
        {

        }


        private void openChildForm(Form childForm)
        {

            if ( this.ActiveForm != null) 
            {
                this.ActiveForm.Close();
            }

            this.ActiveForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            this.panelChild.Controls.Add(childForm);
            this.panelChild.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();



        }



    }
}
