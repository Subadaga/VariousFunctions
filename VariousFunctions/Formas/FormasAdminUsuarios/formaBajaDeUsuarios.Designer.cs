namespace VariousFunctions.Formas.FormasAdminUsuarios
{
    partial class formaBajaDeUsuarios
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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.fillBaja = new System.Windows.Forms.TextBox();
            this.bajaBoton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Baja de usuarios";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Escriba la cuenta a ser dada de baja";
            // 
            // fillBaja
            // 
            this.fillBaja.Location = new System.Drawing.Point(18, 121);
            this.fillBaja.Name = "fillBaja";
            this.fillBaja.Size = new System.Drawing.Size(226, 20);
            this.fillBaja.TabIndex = 3;
            // 
            // bajaBoton
            // 
            this.bajaBoton.Location = new System.Drawing.Point(18, 147);
            this.bajaBoton.Name = "bajaBoton";
            this.bajaBoton.Size = new System.Drawing.Size(90, 34);
            this.bajaBoton.TabIndex = 4;
            this.bajaBoton.Text = "Dar de baja";
            this.bajaBoton.UseVisualStyleBackColor = true;
            this.bajaBoton.Click += new System.EventHandler(this.bajaBoton_Click);
            // 
            // formaBajaDeUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 362);
            this.Controls.Add(this.bajaBoton);
            this.Controls.Add(this.fillBaja);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "formaBajaDeUsuarios";
            this.Text = "formaBajaDeUsuarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fillBaja;
        private System.Windows.Forms.Button bajaBoton;
    }
}