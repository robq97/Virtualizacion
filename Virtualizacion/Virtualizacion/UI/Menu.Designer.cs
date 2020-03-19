namespace Virtualizacion.UI
{
    partial class Menu
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
            this.button_crear_nuevo_contacto = new System.Windows.Forms.Button();
            this.button_ver_contactos = new System.Windows.Forms.Button();
            this.button_cerrar_sesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu";
            // 
            // button_crear_nuevo_contacto
            // 
            this.button_crear_nuevo_contacto.Location = new System.Drawing.Point(35, 63);
            this.button_crear_nuevo_contacto.Name = "button_crear_nuevo_contacto";
            this.button_crear_nuevo_contacto.Size = new System.Drawing.Size(197, 23);
            this.button_crear_nuevo_contacto.TabIndex = 1;
            this.button_crear_nuevo_contacto.Text = "Crear nuevo contacto";
            this.button_crear_nuevo_contacto.UseVisualStyleBackColor = true;
            this.button_crear_nuevo_contacto.Click += new System.EventHandler(this.button_crear_nuevo_contacto_Click);
            // 
            // button_ver_contactos
            // 
            this.button_ver_contactos.Location = new System.Drawing.Point(35, 103);
            this.button_ver_contactos.Name = "button_ver_contactos";
            this.button_ver_contactos.Size = new System.Drawing.Size(197, 23);
            this.button_ver_contactos.TabIndex = 2;
            this.button_ver_contactos.Text = "Ver contactos";
            this.button_ver_contactos.UseVisualStyleBackColor = true;
            this.button_ver_contactos.Click += new System.EventHandler(this.button_ver_contactos_Click);
            // 
            // button_cerrar_sesion
            // 
            this.button_cerrar_sesion.Location = new System.Drawing.Point(35, 149);
            this.button_cerrar_sesion.Name = "button_cerrar_sesion";
            this.button_cerrar_sesion.Size = new System.Drawing.Size(197, 23);
            this.button_cerrar_sesion.TabIndex = 3;
            this.button_cerrar_sesion.Text = "Cerrar sesión";
            this.button_cerrar_sesion.UseVisualStyleBackColor = true;
            this.button_cerrar_sesion.Click += new System.EventHandler(this.button_cerrar_sesion_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 192);
            this.Controls.Add(this.button_cerrar_sesion);
            this.Controls.Add(this.button_ver_contactos);
            this.Controls.Add(this.button_crear_nuevo_contacto);
            this.Controls.Add(this.label1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_crear_nuevo_contacto;
        private System.Windows.Forms.Button button_ver_contactos;
        private System.Windows.Forms.Button button_cerrar_sesion;
    }
}