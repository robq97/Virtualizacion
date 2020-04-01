namespace Virtualizacion.UI
{
    partial class Menú
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menú));
            this.label1 = new System.Windows.Forms.Label();
            this.button_crear_nuevo_contacto = new System.Windows.Forms.Button();
            this.button_ver_contactos = new System.Windows.Forms.Button();
            this.button_cerrar_sesion = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(5)))), ((int)(((byte)(109)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(68, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menú";
            // 
            // button_crear_nuevo_contacto
            // 
            this.button_crear_nuevo_contacto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_crear_nuevo_contacto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_crear_nuevo_contacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_crear_nuevo_contacto.Location = new System.Drawing.Point(47, 86);
            this.button_crear_nuevo_contacto.Name = "button_crear_nuevo_contacto";
            this.button_crear_nuevo_contacto.Size = new System.Drawing.Size(150, 35);
            this.button_crear_nuevo_contacto.TabIndex = 1;
            this.button_crear_nuevo_contacto.Text = "Crear nuevo contacto";
            this.button_crear_nuevo_contacto.UseVisualStyleBackColor = true;
            this.button_crear_nuevo_contacto.Click += new System.EventHandler(this.button_crear_nuevo_contacto_Click);
            // 
            // button_ver_contactos
            // 
            this.button_ver_contactos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ver_contactos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_ver_contactos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ver_contactos.Location = new System.Drawing.Point(47, 127);
            this.button_ver_contactos.Name = "button_ver_contactos";
            this.button_ver_contactos.Size = new System.Drawing.Size(150, 35);
            this.button_ver_contactos.TabIndex = 2;
            this.button_ver_contactos.Text = "Ver contactos";
            this.button_ver_contactos.UseVisualStyleBackColor = true;
            this.button_ver_contactos.Click += new System.EventHandler(this.button_ver_contactos_Click);
            // 
            // button_cerrar_sesion
            // 
            this.button_cerrar_sesion.BackColor = System.Drawing.Color.White;
            this.button_cerrar_sesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_cerrar_sesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_cerrar_sesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_cerrar_sesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cerrar_sesion.ForeColor = System.Drawing.Color.Black;
            this.button_cerrar_sesion.Location = new System.Drawing.Point(47, 169);
            this.button_cerrar_sesion.Name = "button_cerrar_sesion";
            this.button_cerrar_sesion.Size = new System.Drawing.Size(150, 35);
            this.button_cerrar_sesion.TabIndex = 3;
            this.button_cerrar_sesion.Text = "Cerrar sesión";
            this.button_cerrar_sesion.UseVisualStyleBackColor = false;
            this.button_cerrar_sesion.Click += new System.EventHandler(this.button_cerrar_sesion_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-128, -167);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(404, 460);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Menú
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 240);
            this.Controls.Add(this.button_cerrar_sesion);
            this.Controls.Add(this.button_ver_contactos);
            this.Controls.Add(this.button_crear_nuevo_contacto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Menú";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_crear_nuevo_contacto;
        private System.Windows.Forms.Button button_ver_contactos;
        private System.Windows.Forms.Button button_cerrar_sesion;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}