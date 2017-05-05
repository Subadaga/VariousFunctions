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
            this.label2 = new System.Windows.Forms.Label();
            this.fillUsuarioMod = new System.Windows.Forms.TextBox();
            this.botonModificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modificación de Usuarios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Escriba el usuario a modificar";
            // 
            // fillUsuarioMod
            // 
            this.fillUsuarioMod.Location = new System.Drawing.Point(16, 93);
            this.fillUsuarioMod.Name = "fillUsuarioMod";
            this.fillUsuarioMod.Size = new System.Drawing.Size(169, 20);
            this.fillUsuarioMod.TabIndex = 2;
            // 
            // botonModificar
            // 
            this.botonModificar.Location = new System.Drawing.Point(16, 128);
            this.botonModificar.Name = "botonModificar";
            this.botonModificar.Size = new System.Drawing.Size(91, 31);
            this.botonModificar.TabIndex = 3;
            this.botonModificar.Text = "Modificar";
            this.botonModificar.UseVisualStyleBackColor = true;
            // 
            // modificacionUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 375);
            this.Controls.Add(this.botonModificar);
            this.Controls.Add(this.fillUsuarioMod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "modificacionUsuarios";
            this.Text = "modificacionUsuarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fillUsuarioMod;
        private System.Windows.Forms.Button botonModificar;
    }
}