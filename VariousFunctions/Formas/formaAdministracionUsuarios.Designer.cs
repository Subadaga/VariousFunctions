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
            this.button9 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelAltaUsuarios = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelBajaUsuarios = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelAltaUsuarios.SuspendLayout();
            this.panelBajaUsuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(12, 12);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 8;
            this.button9.Text = "button9";
            this.button9.UseVisualStyleBackColor = true;
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
            this.panelAltaUsuarios.Controls.Add(this.label2);
            this.panelAltaUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelAltaUsuarios.Location = new System.Drawing.Point(15, 99);
            this.panelAltaUsuarios.Name = "panelAltaUsuarios";
            this.panelAltaUsuarios.Size = new System.Drawing.Size(660, 250);
            this.panelAltaUsuarios.TabIndex = 11;
            this.panelAltaUsuarios.TabStop = false;
            this.panelAltaUsuarios.Text = "Alta de usuarios";
            this.panelAltaUsuarios.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "TESTING";
            // 
            // panelBajaUsuarios
            // 
            this.panelBajaUsuarios.Controls.Add(this.label3);
            this.panelBajaUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelBajaUsuarios.Location = new System.Drawing.Point(12, 99);
            this.panelBajaUsuarios.Name = "panelBajaUsuarios";
            this.panelBajaUsuarios.Size = new System.Drawing.Size(660, 250);
            this.panelBajaUsuarios.TabIndex = 12;
            this.panelBajaUsuarios.TabStop = false;
            this.panelBajaUsuarios.Text = "Baja de usuarios";
            this.panelBajaUsuarios.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "TESTING";
            // 
            // formaAdministracionUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.panelBajaUsuarios);
            this.Controls.Add(this.panelAltaUsuarios);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button9);
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
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox panelAltaUsuarios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox panelBajaUsuarios;
        private System.Windows.Forms.Label label3;
    }
}