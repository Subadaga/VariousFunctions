namespace VariousFunctions
{
    partial class formaMenuPrincipal
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
            this.archivoBoton = new System.Windows.Forms.Button();
            this.menuBoton = new System.Windows.Forms.Button();
            this.menu2Boton = new System.Windows.Forms.Button();
            this.accionBoton = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.cachafasTexto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // archivoBoton
            // 
            this.archivoBoton.Location = new System.Drawing.Point(15, 13);
            this.archivoBoton.Name = "archivoBoton";
            this.archivoBoton.Size = new System.Drawing.Size(75, 23);
            this.archivoBoton.TabIndex = 0;
            this.archivoBoton.Text = "Archivo";
            this.archivoBoton.UseVisualStyleBackColor = true;
            // 
            // menuBoton
            // 
            this.menuBoton.Location = new System.Drawing.Point(96, 13);
            this.menuBoton.Name = "menuBoton";
            this.menuBoton.Size = new System.Drawing.Size(75, 23);
            this.menuBoton.TabIndex = 1;
            this.menuBoton.Text = "Menú 1";
            this.menuBoton.UseVisualStyleBackColor = true;
            // 
            // menu2Boton
            // 
            this.menu2Boton.Location = new System.Drawing.Point(177, 13);
            this.menu2Boton.Name = "menu2Boton";
            this.menu2Boton.Size = new System.Drawing.Size(75, 23);
            this.menu2Boton.TabIndex = 2;
            this.menu2Boton.Text = "Menú 2";
            this.menu2Boton.UseVisualStyleBackColor = true;
            // 
            // accionBoton
            // 
            this.accionBoton.Location = new System.Drawing.Point(258, 13);
            this.accionBoton.Name = "accionBoton";
            this.accionBoton.Size = new System.Drawing.Size(75, 23);
            this.accionBoton.TabIndex = 3;
            this.accionBoton.Text = "Accion";
            this.accionBoton.UseVisualStyleBackColor = true;
            this.accionBoton.Click += new System.EventHandler(this.accionBoton_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(339, 13);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(125, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Cambio de contraseña";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(470, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(121, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "Admon Usuarios";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(597, 12);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 6;
            this.button7.Text = "Salir";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // cachafasTexto
            // 
            this.cachafasTexto.AutoSize = true;
            this.cachafasTexto.Font = new System.Drawing.Font("Kristen ITC", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cachafasTexto.Location = new System.Drawing.Point(73, 139);
            this.cachafasTexto.Name = "cachafasTexto";
            this.cachafasTexto.Size = new System.Drawing.Size(537, 51);
            this.cachafasTexto.TabIndex = 7;
            this.cachafasTexto.Text = "Dentro del sistema cachafas";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.cachafasTexto);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.accionBoton);
            this.Controls.Add(this.menu2Boton);
            this.Controls.Add(this.menuBoton);
            this.Controls.Add(this.archivoBoton);
            this.Name = "Form2";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button archivoBoton;
        private System.Windows.Forms.Button menuBoton;
        private System.Windows.Forms.Button menu2Boton;
        private System.Windows.Forms.Button accionBoton;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label cachafasTexto;
    }
}