namespace VariousFunctions.Formas.FormasAdminUsuarios
{
    partial class modificacionUsuarios
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
            this.label1 = new System.Windows.Forms.Label();
            this.botonRegreso = new System.Windows.Forms.Button();
            this.grupoSeleccionMod = new System.Windows.Forms.GroupBox();
            this.comboBoxMod = new System.Windows.Forms.ComboBox();
            this.botonModificar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.fillUsuarioMod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textoCambiante = new System.Windows.Forms.Label();
            this.nuevoValor = new System.Windows.Forms.TextBox();
            this.grupoSeleccionMod.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modificación de Usuarios";
            // 
            // botonRegreso
            // 
            this.botonRegreso.Location = new System.Drawing.Point(19, 9);
            this.botonRegreso.Name = "botonRegreso";
            this.botonRegreso.Size = new System.Drawing.Size(75, 23);
            this.botonRegreso.TabIndex = 8;
            this.botonRegreso.Text = "Regresar";
            this.botonRegreso.UseVisualStyleBackColor = true;
            this.botonRegreso.Click += new System.EventHandler(this.botonRegreso_Click);
            // 
            // grupoSeleccionMod
            // 
            this.grupoSeleccionMod.Controls.Add(this.nuevoValor);
            this.grupoSeleccionMod.Controls.Add(this.textoCambiante);
            this.grupoSeleccionMod.Controls.Add(this.label2);
            this.grupoSeleccionMod.Controls.Add(this.fillUsuarioMod);
            this.grupoSeleccionMod.Controls.Add(this.label3);
            this.grupoSeleccionMod.Controls.Add(this.botonModificar);
            this.grupoSeleccionMod.Controls.Add(this.comboBoxMod);
            this.grupoSeleccionMod.Location = new System.Drawing.Point(19, 75);
            this.grupoSeleccionMod.Name = "grupoSeleccionMod";
            this.grupoSeleccionMod.Size = new System.Drawing.Size(564, 288);
            this.grupoSeleccionMod.TabIndex = 7;
            this.grupoSeleccionMod.TabStop = false;
            // 
            // comboBoxMod
            // 
            this.comboBoxMod.FormattingEnabled = true;
            this.comboBoxMod.Items.AddRange(new object[] {
            "Nombre",
            "Apellido",
            "Perfil",
            "Puesto"});
            this.comboBoxMod.Location = new System.Drawing.Point(13, 118);
            this.comboBoxMod.Name = "comboBoxMod";
            this.comboBoxMod.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMod.TabIndex = 4;
            this.comboBoxMod.SelectedIndexChanged += new System.EventHandler(this.comboBoxMod_SelectedIndexChanged);
            // 
            // botonModificar
            // 
            this.botonModificar.Location = new System.Drawing.Point(13, 218);
            this.botonModificar.Name = "botonModificar";
            this.botonModificar.Size = new System.Drawing.Size(91, 31);
            this.botonModificar.TabIndex = 3;
            this.botonModificar.Text = "Modificar";
            this.botonModificar.UseVisualStyleBackColor = true;
            this.botonModificar.Click += new System.EventHandler(this.botonModificar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Escriba el atributo a modificar";
            // 
            // fillUsuarioMod
            // 
            this.fillUsuarioMod.Location = new System.Drawing.Point(10, 51);
            this.fillUsuarioMod.Name = "fillUsuarioMod";
            this.fillUsuarioMod.Size = new System.Drawing.Size(169, 20);
            this.fillUsuarioMod.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Escriba el usuario a modificar";
            // 
            // textoCambiante
            // 
            this.textoCambiante.AutoSize = true;
            this.textoCambiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoCambiante.Location = new System.Drawing.Point(10, 151);
            this.textoCambiante.Name = "textoCambiante";
            this.textoCambiante.Size = new System.Drawing.Size(141, 16);
            this.textoCambiante.TabIndex = 6;
            this.textoCambiante.Text = "Escriba el nuevo valor";
            // 
            // nuevoValor
            // 
            this.nuevoValor.Location = new System.Drawing.Point(10, 181);
            this.nuevoValor.Name = "nuevoValor";
            this.nuevoValor.Size = new System.Drawing.Size(169, 20);
            this.nuevoValor.TabIndex = 7;
            // 
            // modificacionUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 375);
            this.Controls.Add(this.botonRegreso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grupoSeleccionMod);
            this.Name = "modificacionUsuarios";
            this.Text = "modificacionUsuarios";
            this.Load += new System.EventHandler(this.modificacionUsuarios_Load);
            this.grupoSeleccionMod.ResumeLayout(false);
            this.grupoSeleccionMod.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonRegreso;
        private System.Windows.Forms.GroupBox grupoSeleccionMod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fillUsuarioMod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button botonModificar;
        private System.Windows.Forms.ComboBox comboBoxMod;
        private System.Windows.Forms.TextBox nuevoValor;
        private System.Windows.Forms.Label textoCambiante;
    }
}