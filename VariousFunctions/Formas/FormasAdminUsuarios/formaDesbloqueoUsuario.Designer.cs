namespace VariousFunctions.Formas.FormasAdminUsuarios
{
    partial class formaDesbloqueoUsuario
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
            this.bajaBoton = new System.Windows.Forms.Button();
            this.fillBaja = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bajaBoton
            // 
            this.bajaBoton.Location = new System.Drawing.Point(12, 171);
            this.bajaBoton.Name = "bajaBoton";
            this.bajaBoton.Size = new System.Drawing.Size(90, 34);
            this.bajaBoton.TabIndex = 9;
            this.bajaBoton.Text = "Desbloquear";
            this.bajaBoton.UseVisualStyleBackColor = true;
            this.bajaBoton.Click += new System.EventHandler(this.bajaBoton_Click);
            // 
            // fillBaja
            // 
            this.fillBaja.Location = new System.Drawing.Point(12, 133);
            this.fillBaja.Name = "fillBaja";
            this.fillBaja.Size = new System.Drawing.Size(226, 20);
            this.fillBaja.TabIndex = 8;
            this.fillBaja.TextChanged += new System.EventHandler(this.fillBaja_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Escriba la cuenta a desbloquear";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "Desbloqueo de usuarios";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // formaDesbloqueoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 476);
            this.Controls.Add(this.bajaBoton);
            this.Controls.Add(this.fillBaja);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "formaDesbloqueoUsuario";
            this.Text = "formaDesbloqueoUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bajaBoton;
        private System.Windows.Forms.TextBox fillBaja;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}