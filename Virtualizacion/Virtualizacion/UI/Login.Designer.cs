namespace Virtualizacion.UI
{
    partial class Login
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
            this.textBox_usuario = new System.Windows.Forms.TextBox();
            this.textBox_contrasenia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_iniciar_sesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(74, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // textBox_usuario
            // 
            this.textBox_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBox_usuario.Location = new System.Drawing.Point(175, 41);
            this.textBox_usuario.Name = "textBox_usuario";
            this.textBox_usuario.Size = new System.Drawing.Size(237, 26);
            this.textBox_usuario.TabIndex = 1;
            // 
            // textBox_contrasenia
            // 
            this.textBox_contrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBox_contrasenia.Location = new System.Drawing.Point(175, 85);
            this.textBox_contrasenia.Name = "textBox_contrasenia";
            this.textBox_contrasenia.Size = new System.Drawing.Size(237, 26);
            this.textBox_contrasenia.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(74, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña:";
            // 
            // button_iniciar_sesion
            // 
            this.button_iniciar_sesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button_iniciar_sesion.Location = new System.Drawing.Point(78, 146);
            this.button_iniciar_sesion.Name = "button_iniciar_sesion";
            this.button_iniciar_sesion.Size = new System.Drawing.Size(334, 33);
            this.button_iniciar_sesion.TabIndex = 4;
            this.button_iniciar_sesion.Text = "Iniciar sesión";
            this.button_iniciar_sesion.UseVisualStyleBackColor = true;
            this.button_iniciar_sesion.Click += new System.EventHandler(this.button_iniciar_sesion_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 208);
            this.Controls.Add(this.button_iniciar_sesion);
            this.Controls.Add(this.textBox_contrasenia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_usuario);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_usuario;
        private System.Windows.Forms.TextBox textBox_contrasenia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_iniciar_sesion;
    }
}