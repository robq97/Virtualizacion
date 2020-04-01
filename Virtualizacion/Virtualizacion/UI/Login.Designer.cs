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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_usuario = new System.Windows.Forms.TextBox();
            this.textBox_contrasenia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_iniciar_sesion = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(5)))), ((int)(((byte)(109)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // textBox_usuario
            // 
            this.textBox_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBox_usuario.Location = new System.Drawing.Point(34, 287);
            this.textBox_usuario.Name = "textBox_usuario";
            this.textBox_usuario.Size = new System.Drawing.Size(237, 26);
            this.textBox_usuario.TabIndex = 1;
            this.textBox_usuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_usuario_KeyDown);
            // 
            // textBox_contrasenia
            // 
            this.textBox_contrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBox_contrasenia.Location = new System.Drawing.Point(34, 344);
            this.textBox_contrasenia.Name = "textBox_contrasenia";
            this.textBox_contrasenia.Size = new System.Drawing.Size(237, 26);
            this.textBox_contrasenia.TabIndex = 3;
            this.textBox_contrasenia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_contrasenia_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(5)))), ((int)(((byte)(109)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña:";
            // 
            // button_iniciar_sesion
            // 
            this.button_iniciar_sesion.BackColor = System.Drawing.Color.White;
            this.button_iniciar_sesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_iniciar_sesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_iniciar_sesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_iniciar_sesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_iniciar_sesion.ForeColor = System.Drawing.Color.Black;
            this.button_iniciar_sesion.Location = new System.Drawing.Point(97, 387);
            this.button_iniciar_sesion.Name = "button_iniciar_sesion";
            this.button_iniciar_sesion.Size = new System.Drawing.Size(102, 33);
            this.button_iniciar_sesion.TabIndex = 4;
            this.button_iniciar_sesion.Text = "Iniciar sesión";
            this.button_iniciar_sesion.UseVisualStyleBackColor = false;
            this.button_iniciar_sesion.Click += new System.EventHandler(this.button_iniciar_sesion_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(5)))), ((int)(((byte)(109)))));
            this.panel1.Controls.Add(this.textBox_contrasenia);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button_iniciar_sesion);
            this.panel1.Controls.Add(this.textBox_usuario);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 461);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(64, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 461);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_usuario;
        private System.Windows.Forms.TextBox textBox_contrasenia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_iniciar_sesion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}