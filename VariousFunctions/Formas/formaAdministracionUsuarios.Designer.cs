namespace VariousFunctions.Formas
{
    partial class formaAdministracionUsuarios
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
            this.botonRegresar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelAltaUsuarios = new System.Windows.Forms.GroupBox();
            this.panelBajaUsuarios = new System.Windows.Forms.GroupBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.inputNombre = new System.Windows.Forms.TextBox();
            this.labelApellido = new System.Windows.Forms.Label();
            this.inputApellido = new System.Windows.Forms.TextBox();
            this.labelPuesto = new System.Windows.Forms.Label();
            this.inputPuesto = new System.Windows.Forms.TextBox();
            this.labelPerfil = new System.Windows.Forms.Label();
            this.inputPerfil = new System.Windows.Forms.TextBox();
            this.labelCuenta = new System.Windows.Forms.Label();
            this.labelContraseña = new System.Windows.Forms.Label();
            this.inputContrasena = new System.Windows.Forms.TextBox();
            this.inputCuenta = new System.Windows.Forms.TextBox();
            this.labelBajaMensaje = new System.Windows.Forms.Label();
            this.inputCuentaBaja = new System.Windows.Forms.TextBox();
            this.botonBaja = new System.Windows.Forms.Button();
            this.panelAltaUsuarios.SuspendLayout();
            this.panelBajaUsuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // botonRegresar
            // 
            this.botonRegresar.Location = new System.Drawing.Point(12, 12);
            this.botonRegresar.Name = "botonRegresar";
            this.botonRegresar.Size = new System.Drawing.Size(75, 23);
            this.botonRegresar.TabIndex = 8;
            this.botonRegresar.Text = "Regresar";
            this.botonRegresar.UseVisualStyleBackColor = true;
            this.botonRegresar.Click += new System.EventHandler(this.botonRegresar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Alta de usuarios",
            "Baja de usuarios",
            "Cambios de usuario",
            "Reseteo de contraseña",
            "Definición de parámetros",
            "Generación de lista de usuarios",
            "Bitácoras"});
            this.comboBox1.Location = new System.Drawing.Point(12, 72);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(190, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Seleccione una opción";
            // 
            // panelAltaUsuarios
            // 
            this.panelAltaUsuarios.Controls.Add(this.inputCuenta);
            this.panelAltaUsuarios.Controls.Add(this.inputContrasena);
            this.panelAltaUsuarios.Controls.Add(this.labelContraseña);
            this.panelAltaUsuarios.Controls.Add(this.labelCuenta);
            this.panelAltaUsuarios.Controls.Add(this.inputPerfil);
            this.panelAltaUsuarios.Controls.Add(this.labelPerfil);
            this.panelAltaUsuarios.Controls.Add(this.inputPuesto);
            this.panelAltaUsuarios.Controls.Add(this.labelPuesto);
            this.panelAltaUsuarios.Controls.Add(this.inputApellido);
            this.panelAltaUsuarios.Controls.Add(this.labelApellido);
            this.panelAltaUsuarios.Controls.Add(this.inputNombre);
            this.panelAltaUsuarios.Controls.Add(this.labelNombre);
            this.panelAltaUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelAltaUsuarios.Location = new System.Drawing.Point(15, 99);
            this.panelAltaUsuarios.Name = "panelAltaUsuarios";
            this.panelAltaUsuarios.Size = new System.Drawing.Size(660, 250);
            this.panelAltaUsuarios.TabIndex = 11;
            this.panelAltaUsuarios.TabStop = false;
            this.panelAltaUsuarios.Text = "Alta de usuarios";
            this.panelAltaUsuarios.Visible = false;
            // 
            // panelBajaUsuarios
            // 
            this.panelBajaUsuarios.Controls.Add(this.botonBaja);
            this.panelBajaUsuarios.Controls.Add(this.inputCuentaBaja);
            this.panelBajaUsuarios.Controls.Add(this.labelBajaMensaje);
            this.panelBajaUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelBajaUsuarios.Location = new System.Drawing.Point(15, 99);
            this.panelBajaUsuarios.Name = "panelBajaUsuarios";
            this.panelBajaUsuarios.Size = new System.Drawing.Size(660, 250);
            this.panelBajaUsuarios.TabIndex = 12;
            this.panelBajaUsuarios.TabStop = false;
            this.panelBajaUsuarios.Text = "Baja de usuarios";
            this.panelBajaUsuarios.Visible = false;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(6, 39);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(62, 18);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre";
            // 
            // inputNombre
            // 
            this.inputNombre.Location = new System.Drawing.Point(9, 60);
            this.inputNombre.Name = "inputNombre";
            this.inputNombre.Size = new System.Drawing.Size(137, 24);
            this.inputNombre.TabIndex = 1;
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Location = new System.Drawing.Point(6, 100);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(59, 18);
            this.labelApellido.TabIndex = 2;
            this.labelApellido.Text = "Apellido";
            // 
            // inputApellido
            // 
            this.inputApellido.Location = new System.Drawing.Point(9, 121);
            this.inputApellido.Name = "inputApellido";
            this.inputApellido.Size = new System.Drawing.Size(137, 24);
            this.inputApellido.TabIndex = 3;
            // 
            // labelPuesto
            // 
            this.labelPuesto.AutoSize = true;
            this.labelPuesto.Location = new System.Drawing.Point(194, 39);
            this.labelPuesto.Name = "labelPuesto";
            this.labelPuesto.Size = new System.Drawing.Size(55, 18);
            this.labelPuesto.TabIndex = 4;
            this.labelPuesto.Text = "Puesto";
            // 
            // inputPuesto
            // 
            this.inputPuesto.Location = new System.Drawing.Point(197, 60);
            this.inputPuesto.Name = "inputPuesto";
            this.inputPuesto.Size = new System.Drawing.Size(136, 24);
            this.inputPuesto.TabIndex = 5;
            // 
            // labelPerfil
            // 
            this.labelPerfil.AutoSize = true;
            this.labelPerfil.Location = new System.Drawing.Point(194, 100);
            this.labelPerfil.Name = "labelPerfil";
            this.labelPerfil.Size = new System.Drawing.Size(41, 18);
            this.labelPerfil.TabIndex = 6;
            this.labelPerfil.Text = "Perfil";
            // 
            // inputPerfil
            // 
            this.inputPerfil.Location = new System.Drawing.Point(197, 121);
            this.inputPerfil.Name = "inputPerfil";
            this.inputPerfil.Size = new System.Drawing.Size(136, 24);
            this.inputPerfil.TabIndex = 7;
            // 
            // labelCuenta
            // 
            this.labelCuenta.AutoSize = true;
            this.labelCuenta.Location = new System.Drawing.Point(369, 39);
            this.labelCuenta.Name = "labelCuenta";
            this.labelCuenta.Size = new System.Drawing.Size(55, 18);
            this.labelCuenta.TabIndex = 8;
            this.labelCuenta.Text = "Cuenta";
            // 
            // labelContraseña
            // 
            this.labelContraseña.AutoSize = true;
            this.labelContraseña.Location = new System.Drawing.Point(372, 104);
            this.labelContraseña.Name = "labelContraseña";
            this.labelContraseña.Size = new System.Drawing.Size(85, 18);
            this.labelContraseña.TabIndex = 9;
            this.labelContraseña.Text = "Contraseña";
            // 
            // inputContrasena
            // 
            this.inputContrasena.Location = new System.Drawing.Point(375, 125);
            this.inputContrasena.Name = "inputContrasena";
            this.inputContrasena.Size = new System.Drawing.Size(121, 24);
            this.inputContrasena.TabIndex = 10;
            // 
            // inputCuenta
            // 
            this.inputCuenta.Location = new System.Drawing.Point(375, 63);
            this.inputCuenta.Name = "inputCuenta";
            this.inputCuenta.Size = new System.Drawing.Size(121, 24);
            this.inputCuenta.TabIndex = 11;
            // 
            // labelBajaMensaje
            // 
            this.labelBajaMensaje.AutoSize = true;
            this.labelBajaMensaje.Location = new System.Drawing.Point(6, 39);
            this.labelBajaMensaje.Name = "labelBajaMensaje";
            this.labelBajaMensaje.Size = new System.Drawing.Size(249, 18);
            this.labelBajaMensaje.TabIndex = 1;
            this.labelBajaMensaje.Text = "Introduzca cuenta a ser dada de baja";
            // 
            // inputCuentaBaja
            // 
            this.inputCuentaBaja.Location = new System.Drawing.Point(6, 63);
            this.inputCuentaBaja.Name = "inputCuentaBaja";
            this.inputCuentaBaja.Size = new System.Drawing.Size(178, 24);
            this.inputCuentaBaja.TabIndex = 2;
            // 
            // botonBaja
            // 
            this.botonBaja.Location = new System.Drawing.Point(6, 99);
            this.botonBaja.Name = "botonBaja";
            this.botonBaja.Size = new System.Drawing.Size(140, 32);
            this.botonBaja.TabIndex = 3;
            this.botonBaja.Text = "Dar de baja";
            this.botonBaja.UseVisualStyleBackColor = true;
            // 
            // formaAdministracionUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.botonRegresar);
            this.Controls.Add(this.panelBajaUsuarios);
            this.Controls.Add(this.panelAltaUsuarios);
            this.Name = "formaAdministracionUsuarios";
            this.Text = "formaAdministracionUsuarios";
            this.panelAltaUsuarios.ResumeLayout(false);
            this.panelAltaUsuarios.PerformLayout();
            this.panelBajaUsuarios.ResumeLayout(false);
            this.panelBajaUsuarios.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button botonRegresar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox panelAltaUsuarios;
        private System.Windows.Forms.GroupBox panelBajaUsuarios;
        private System.Windows.Forms.TextBox inputCuenta;
        private System.Windows.Forms.TextBox inputContrasena;
        private System.Windows.Forms.Label labelContraseña;
        private System.Windows.Forms.Label labelCuenta;
        private System.Windows.Forms.TextBox inputPerfil;
        private System.Windows.Forms.Label labelPerfil;
        private System.Windows.Forms.TextBox inputPuesto;
        private System.Windows.Forms.Label labelPuesto;
        private System.Windows.Forms.TextBox inputApellido;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.TextBox inputNombre;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox inputCuentaBaja;
        private System.Windows.Forms.Label labelBajaMensaje;
        private System.Windows.Forms.Button botonBaja;
    }
}