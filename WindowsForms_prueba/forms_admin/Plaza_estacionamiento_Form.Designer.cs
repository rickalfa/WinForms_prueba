
namespace WindowsForms_prueba.forms_admin
{
    partial class Plaza_estacionamiento_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelChild = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Crear_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonVehiculo = new System.Windows.Forms.Button();
            this.buttonEstaPlaza = new System.Windows.Forms.Button();
            this.buttonEst = new System.Windows.Forms.Button();
            this.buttonUsers = new System.Windows.Forms.Button();
            this.panelChild.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelChild
            // 
            this.panelChild.Controls.Add(this.label1);
            this.panelChild.Controls.Add(this.button3);
            this.panelChild.Controls.Add(this.button2);
            this.panelChild.Controls.Add(this.button1);
            this.panelChild.Controls.Add(this.Crear_button);
            this.panelChild.Controls.Add(this.dataGridView1);
            this.panelChild.Location = new System.Drawing.Point(143, 12);
            this.panelChild.Name = "panelChild";
            this.panelChild.Size = new System.Drawing.Size(782, 541);
            this.panelChild.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(267, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "TITULO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(657, 204);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Actualizar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Cornsilk;
            this.button2.Location = new System.Drawing.Point(26, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 25);
            this.button2.TabIndex = 3;
            this.button2.Text = "volver";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(657, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Crear_button
            // 
            this.Crear_button.Location = new System.Drawing.Point(657, 255);
            this.Crear_button.Name = "Crear_button";
            this.Crear_button.Size = new System.Drawing.Size(75, 23);
            this.Crear_button.TabIndex = 1;
            this.Crear_button.Text = "Crear";
            this.Crear_button.UseVisualStyleBackColor = true;
            this.Crear_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(565, 374);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.MenuText;
            this.panel1.Controls.Add(this.buttonVehiculo);
            this.panel1.Controls.Add(this.buttonEstaPlaza);
            this.panel1.Controls.Add(this.buttonEst);
            this.panel1.Controls.Add(this.buttonUsers);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(137, 619);
            this.panel1.TabIndex = 1;
            // 
            // buttonVehiculo
            // 
            this.buttonVehiculo.BackColor = System.Drawing.SystemColors.InfoText;
            this.buttonVehiculo.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonVehiculo.FlatAppearance.BorderSize = 0;
            this.buttonVehiculo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVehiculo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonVehiculo.Location = new System.Drawing.Point(0, 111);
            this.buttonVehiculo.Name = "buttonVehiculo";
            this.buttonVehiculo.Size = new System.Drawing.Size(137, 37);
            this.buttonVehiculo.TabIndex = 3;
            this.buttonVehiculo.Text = "Vehiculos";
            this.buttonVehiculo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonVehiculo.UseVisualStyleBackColor = false;
            this.buttonVehiculo.Click += new System.EventHandler(this.button7_Click);
            // 
            // buttonEstaPlaza
            // 
            this.buttonEstaPlaza.BackColor = System.Drawing.SystemColors.InfoText;
            this.buttonEstaPlaza.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonEstaPlaza.FlatAppearance.BorderSize = 0;
            this.buttonEstaPlaza.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonEstaPlaza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEstaPlaza.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEstaPlaza.Location = new System.Drawing.Point(0, 74);
            this.buttonEstaPlaza.Name = "buttonEstaPlaza";
            this.buttonEstaPlaza.Size = new System.Drawing.Size(137, 37);
            this.buttonEstaPlaza.TabIndex = 2;
            this.buttonEstaPlaza.Text = "Esta. Plazas";
            this.buttonEstaPlaza.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEstaPlaza.UseVisualStyleBackColor = false;
            // 
            // buttonEst
            // 
            this.buttonEst.BackColor = System.Drawing.SystemColors.InfoText;
            this.buttonEst.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonEst.FlatAppearance.BorderSize = 0;
            this.buttonEst.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonEst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEst.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEst.Location = new System.Drawing.Point(0, 37);
            this.buttonEst.Name = "buttonEst";
            this.buttonEst.Size = new System.Drawing.Size(137, 37);
            this.buttonEst.TabIndex = 1;
            this.buttonEst.Text = "Estacionamiento";
            this.buttonEst.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEst.UseVisualStyleBackColor = false;
            // 
            // buttonUsers
            // 
            this.buttonUsers.BackColor = System.Drawing.SystemColors.InfoText;
            this.buttonUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonUsers.FlatAppearance.BorderSize = 0;
            this.buttonUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUsers.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonUsers.Location = new System.Drawing.Point(0, 0);
            this.buttonUsers.Name = "buttonUsers";
            this.buttonUsers.Size = new System.Drawing.Size(137, 37);
            this.buttonUsers.TabIndex = 0;
            this.buttonUsers.Text = "Usuarios";
            this.buttonUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUsers.UseVisualStyleBackColor = false;
            this.buttonUsers.Click += new System.EventHandler(this.button4_Click);
            // 
            // Plaza_estacionamiento_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(937, 619);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelChild);
            this.MinimumSize = new System.Drawing.Size(650, 600);
            this.Name = "Plaza_estacionamiento_Form";
            this.Text = "Plaza_estacionamiento_Form";
            this.Load += new System.EventHandler(this.Plaza_estacionamiento_Form_Load);
            this.panelChild.ResumeLayout(false);
            this.panelChild.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelChild;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Crear_button;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonUsers;
        private System.Windows.Forms.Button buttonVehiculo;
        private System.Windows.Forms.Button buttonEstaPlaza;
        private System.Windows.Forms.Button buttonEst;
        private System.Windows.Forms.Label label1;
    }
}