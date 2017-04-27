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
            this.inputCuenta = new System.Windows.Forms.TextBox();
            this.inputContrasena = new System.Windows.Forms.TextBox();
            this.labelContraseña = new System.Windows.Forms.Label();
            this.labelCuenta = new System.Windows.Forms.Label();
            this.inputPerfil = new System.Windows.Forms.TextBox();
            this.labelPerfil = new System.Windows.Forms.Label();
            this.inputPuesto = new System.Windows.Forms.TextBox();
            this.labelPuesto = new System.Windows.Forms.Label();
            this.inputApellido = new System.Windows.Forms.TextBox();
            this.labelApellido = new System.Windows.Forms.Label();
            this.inputNombre = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.panelBajaUsuarios = new System.Windows.Forms.GroupBox();
            this.botonBaja = new System.Windows.Forms.Button();
            this.inputCuentaBaja = new System.Windows.Forms.TextBox();
            this.labelBajaMensaje = new System.Windows.Forms.Label();
            this.panelModificacionUsuarios = new System.Windows.Forms.GroupBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panelAltaUsuarios.SuspendLayout();
            this.panelBajaUsuarios.SuspendLayout();
            this.panelModificacionUsuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // botonRegresar
            // 
            this.botonRegresar.Location = new System.Drawing.Point(32, 29);
            this.botonRegresar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.botonRegresar.Name = "botonRegresar";
            this.botonRegresar.Size = new System.Drawing.Size(200, 55);
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
            this.comboBox1.Location = new System.Drawing.Point(32, 172);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(500, 39);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 44);
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
            this.panelAltaUsuarios.Location = new System.Drawing.Point(40, 236);
            this.panelAltaUsuarios.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panelAltaUsuarios.Name = "panelAltaUsuarios";
            this.panelAltaUsuarios.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panelAltaUsuarios.Size = new System.Drawing.Size(1760, 596);
            this.panelAltaUsuarios.TabIndex = 11;
            this.panelAltaUsuarios.TabStop = false;
            this.panelAltaUsuarios.Text = "Alta de usuarios";
            this.panelAltaUsuarios.Visible = false;
            // 
            // inputCuenta
            // 
            this.inputCuenta.Location = new System.Drawing.Point(1000, 150);
            this.inputCuenta.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.inputCuenta.Name = "inputCuenta";
            this.inputCuenta.Size = new System.Drawing.Size(316, 50);
            this.inputCuenta.TabIndex = 11;
            // 
            // inputContrasena
            // 
            this.inputContrasena.Location = new System.Drawing.Point(1000, 298);
            this.inputContrasena.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.inputContrasena.Name = "inputContrasena";
            this.inputContrasena.Size = new System.Drawing.Size(316, 50);
            this.inputContrasena.TabIndex = 10;
            // 
            // labelContraseña
            // 
            this.labelContraseña.AutoSize = true;
            this.labelContraseña.Location = new System.Drawing.Point(992, 248);
            this.labelContraseña.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelContraseña.Name = "labelContraseña";
            this.labelContraseña.Size = new System.Drawing.Size(216, 44);
            this.labelContraseña.TabIndex = 9;
            this.labelContraseña.Text = "Contraseña";
            // 
            // labelCuenta
            // 
            this.labelCuenta.AutoSize = true;
            this.labelCuenta.Location = new System.Drawing.Point(984, 93);
            this.labelCuenta.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelCuenta.Name = "labelCuenta";
            this.labelCuenta.Size = new System.Drawing.Size(142, 44);
            this.labelCuenta.TabIndex = 8;
            this.labelCuenta.Text = "Cuenta";
            // 
            // inputPerfil
            // 
            this.inputPerfil.Location = new System.Drawing.Point(525, 289);
            this.inputPerfil.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.inputPerfil.Name = "inputPerfil";
            this.inputPerfil.Size = new System.Drawing.Size(356, 50);
            this.inputPerfil.TabIndex = 7;
            // 
            // labelPerfil
            // 
            this.labelPerfil.AutoSize = true;
            this.labelPerfil.Location = new System.Drawing.Point(517, 238);
            this.labelPerfil.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelPerfil.Name = "labelPerfil";
            this.labelPerfil.Size = new System.Drawing.Size(108, 44);
            this.labelPerfil.TabIndex = 6;
            this.labelPerfil.Text = "Perfil";
            // 
            // inputPuesto
            // 
            this.inputPuesto.Location = new System.Drawing.Point(525, 143);
            this.inputPuesto.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.inputPuesto.Name = "inputPuesto";
            this.inputPuesto.Size = new System.Drawing.Size(356, 50);
            this.inputPuesto.TabIndex = 5;
            // 
            // labelPuesto
            // 
            this.labelPuesto.AutoSize = true;
            this.labelPuesto.Location = new System.Drawing.Point(517, 93);
            this.labelPuesto.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelPuesto.Name = "labelPuesto";
            this.labelPuesto.Size = new System.Drawing.Size(138, 44);
            this.labelPuesto.TabIndex = 4;
            this.labelPuesto.Text = "Puesto";
            // 
            // inputApellido
            // 
            this.inputApellido.Location = new System.Drawing.Point(24, 289);
            this.inputApellido.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.inputApellido.Name = "inputApellido";
            this.inputApellido.Size = new System.Drawing.Size(359, 50);
            this.inputApellido.TabIndex = 3;
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Location = new System.Drawing.Point(16, 238);
            this.labelApellido.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(156, 44);
            this.labelApellido.TabIndex = 2;
            this.labelApellido.Text = "Apellido";
            // 
            // inputNombre
            // 
            this.inputNombre.Location = new System.Drawing.Point(24, 143);
            this.inputNombre.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.inputNombre.Name = "inputNombre";
            this.inputNombre.Size = new System.Drawing.Size(359, 50);
            this.inputNombre.TabIndex = 1;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(16, 93);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(156, 44);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre";
            // 
            // panelBajaUsuarios
            // 
            this.panelBajaUsuarios.Controls.Add(this.botonBaja);
            this.panelBajaUsuarios.Controls.Add(this.inputCuentaBaja);
            this.panelBajaUsuarios.Controls.Add(this.labelBajaMensaje);
            this.panelBajaUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelBajaUsuarios.Location = new System.Drawing.Point(40, 236);
            this.panelBajaUsuarios.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panelBajaUsuarios.Name = "panelBajaUsuarios";
            this.panelBajaUsuarios.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panelBajaUsuarios.Size = new System.Drawing.Size(1760, 596);
            this.panelBajaUsuarios.TabIndex = 12;
            this.panelBajaUsuarios.TabStop = false;
            this.panelBajaUsuarios.Text = "Baja de usuarios";
            this.panelBajaUsuarios.Visible = false;
            // 
            // botonBaja
            // 
            this.botonBaja.Location = new System.Drawing.Point(16, 236);
            this.botonBaja.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.botonBaja.Name = "botonBaja";
            this.botonBaja.Size = new System.Drawing.Size(373, 76);
            this.botonBaja.TabIndex = 3;
            this.botonBaja.Text = "Dar de baja";
            this.botonBaja.UseVisualStyleBackColor = true;
            // 
            // inputCuentaBaja
            // 
            this.inputCuentaBaja.Location = new System.Drawing.Point(16, 150);
            this.inputCuentaBaja.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.inputCuentaBaja.Name = "inputCuentaBaja";
            this.inputCuentaBaja.Size = new System.Drawing.Size(468, 50);
            this.inputCuentaBaja.TabIndex = 2;
            // 
            // labelBajaMensaje
            // 
            this.labelBajaMensaje.AutoSize = true;
            this.labelBajaMensaje.Location = new System.Drawing.Point(16, 93);
            this.labelBajaMensaje.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelBajaMensaje.Name = "labelBajaMensaje";
            this.labelBajaMensaje.Size = new System.Drawing.Size(643, 44);
            this.labelBajaMensaje.TabIndex = 1;
            this.labelBajaMensaje.Text = "Introduzca cuenta a ser dada de baja";
            // 
            // panelModificacionUsuarios
            // 
            this.panelModificacionUsuarios.Controls.Add(this.button1);
            this.panelModificacionUsuarios.Controls.Add(this.textBox6);
            this.panelModificacionUsuarios.Controls.Add(this.label7);
            this.panelModificacionUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelModificacionUsuarios.Location = new System.Drawing.Point(40, 236);
            this.panelModificacionUsuarios.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panelModificacionUsuarios.Name = "panelModificacionUsuarios";
            this.panelModificacionUsuarios.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panelModificacionUsuarios.Size = new System.Drawing.Size(1760, 596);
            this.panelModificacionUsuarios.TabIndex = 12;
            this.panelModificacionUsuarios.TabStop = false;
            this.panelModificacionUsuarios.Text = "Modificación de usuario";
            this.panelModificacionUsuarios.Visible = false;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(24, 143);
            this.textBox6.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(359, 50);
            this.textBox6.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 93);
            this.label7.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(340, 44);
            this.label7.TabIndex = 0;
            this.label7.Text = "Cuenta a modificar";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(359, 84);
            this.button1.TabIndex = 2;
            this.button1.Text = "Modificar cuenta";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // formaAdministracionUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1824, 861);
            this.Controls.Add(this.panelModificacionUsuarios);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.botonRegresar);
            this.Controls.Add(this.panelAltaUsuarios);
            this.Controls.Add(this.panelBajaUsuarios);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "formaAdministracionUsuarios";
            this.Text = "formaAdministracionUsuarios";
            this.panelAltaUsuarios.ResumeLayout(false);
            this.panelAltaUsuarios.PerformLayout();
            this.panelBajaUsuarios.ResumeLayout(false);
            this.panelBajaUsuarios.PerformLayout();
            this.panelModificacionUsuarios.ResumeLayout(false);
            this.panelModificacionUsuarios.PerformLayout();
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
        private System.Windows.Forms.GroupBox panelModificacionUsuarios;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
    }
}