namespace Virtualizacion.UI
{
    partial class EstablecerConexionSQL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EstablecerConexionSQL));
            this.label1 = new System.Windows.Forms.Label();
            this.button_usar_base_de_datos_predeterminada = new System.Windows.Forms.Button();
            this.button_usar_bd_default_pregunta = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_host_base_de_datos = new System.Windows.Forms.TextBox();
            this.textBox_nombre_base_de_datos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_usuario_base_de_datos = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_contrasenia_base_de_datos = new System.Windows.Forms.TextBox();
            this.button_probar_conexion = new System.Windows.Forms.Button();
            this.button_usar_conexion = new System.Windows.Forms.Button();
            this.label_conexion_personalizada = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conexión a la base de datos";
            // 
            // button_usar_base_de_datos_predeterminada
            // 
            this.button_usar_base_de_datos_predeterminada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(5)))), ((int)(((byte)(109)))));
            this.button_usar_base_de_datos_predeterminada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_usar_base_de_datos_predeterminada.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_usar_base_de_datos_predeterminada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_usar_base_de_datos_predeterminada.ForeColor = System.Drawing.Color.White;
            this.button_usar_base_de_datos_predeterminada.Location = new System.Drawing.Point(12, 51);
            this.button_usar_base_de_datos_predeterminada.Name = "button_usar_base_de_datos_predeterminada";
            this.button_usar_base_de_datos_predeterminada.Size = new System.Drawing.Size(282, 29);
            this.button_usar_base_de_datos_predeterminada.TabIndex = 1;
            this.button_usar_base_de_datos_predeterminada.Text = "Utilizar la base de datos predeterminada";
            this.button_usar_base_de_datos_predeterminada.UseVisualStyleBackColor = false;
            this.button_usar_base_de_datos_predeterminada.Click += new System.EventHandler(this.button_usar_base_de_datos_predeterminada_Click);
            // 
            // button_usar_bd_default_pregunta
            // 
            this.button_usar_bd_default_pregunta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(5)))), ((int)(((byte)(109)))));
            this.button_usar_bd_default_pregunta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_usar_bd_default_pregunta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_usar_bd_default_pregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.button_usar_bd_default_pregunta.ForeColor = System.Drawing.Color.White;
            this.button_usar_bd_default_pregunta.Location = new System.Drawing.Point(300, 51);
            this.button_usar_bd_default_pregunta.Name = "button_usar_bd_default_pregunta";
            this.button_usar_bd_default_pregunta.Size = new System.Drawing.Size(30, 29);
            this.button_usar_bd_default_pregunta.TabIndex = 2;
            this.button_usar_bd_default_pregunta.Text = "?";
            this.button_usar_bd_default_pregunta.UseVisualStyleBackColor = false;
            this.button_usar_bd_default_pregunta.Click += new System.EventHandler(this.button_usar_bd_default_pregunta_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label2.Location = new System.Drawing.Point(8, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(500, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "_________________________________________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(10, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Host de la base de datos:";
            // 
            // textBox_host_base_de_datos
            // 
            this.textBox_host_base_de_datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textBox_host_base_de_datos.Location = new System.Drawing.Point(13, 142);
            this.textBox_host_base_de_datos.Name = "textBox_host_base_de_datos";
            this.textBox_host_base_de_datos.Size = new System.Drawing.Size(319, 23);
            this.textBox_host_base_de_datos.TabIndex = 5;
            // 
            // textBox_nombre_base_de_datos
            // 
            this.textBox_nombre_base_de_datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textBox_nombre_base_de_datos.Location = new System.Drawing.Point(13, 187);
            this.textBox_nombre_base_de_datos.Name = "textBox_nombre_base_de_datos";
            this.textBox_nombre_base_de_datos.Size = new System.Drawing.Size(319, 23);
            this.textBox_nombre_base_de_datos.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(10, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nombre de la base de datos:";
            // 
            // textBox_usuario_base_de_datos
            // 
            this.textBox_usuario_base_de_datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textBox_usuario_base_de_datos.Location = new System.Drawing.Point(13, 234);
            this.textBox_usuario_base_de_datos.Name = "textBox_usuario_base_de_datos";
            this.textBox_usuario_base_de_datos.Size = new System.Drawing.Size(319, 23);
            this.textBox_usuario_base_de_datos.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label7.Location = new System.Drawing.Point(10, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Usuario:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label8.Location = new System.Drawing.Point(10, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Contraseña:";
            // 
            // textBox_contrasenia_base_de_datos
            // 
            this.textBox_contrasenia_base_de_datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textBox_contrasenia_base_de_datos.Location = new System.Drawing.Point(13, 283);
            this.textBox_contrasenia_base_de_datos.Name = "textBox_contrasenia_base_de_datos";
            this.textBox_contrasenia_base_de_datos.Size = new System.Drawing.Size(319, 23);
            this.textBox_contrasenia_base_de_datos.TabIndex = 13;
            // 
            // button_probar_conexion
            // 
            this.button_probar_conexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(5)))), ((int)(((byte)(109)))));
            this.button_probar_conexion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_probar_conexion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_probar_conexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.button_probar_conexion.ForeColor = System.Drawing.Color.White;
            this.button_probar_conexion.Location = new System.Drawing.Point(12, 333);
            this.button_probar_conexion.Name = "button_probar_conexion";
            this.button_probar_conexion.Size = new System.Drawing.Size(131, 29);
            this.button_probar_conexion.TabIndex = 14;
            this.button_probar_conexion.Text = "Probar conexión";
            this.button_probar_conexion.UseVisualStyleBackColor = false;
            this.button_probar_conexion.Click += new System.EventHandler(this.button_probar_conexion_Click);
            // 
            // button_usar_conexion
            // 
            this.button_usar_conexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(5)))), ((int)(((byte)(109)))));
            this.button_usar_conexion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_usar_conexion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_usar_conexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.button_usar_conexion.ForeColor = System.Drawing.Color.White;
            this.button_usar_conexion.Location = new System.Drawing.Point(149, 333);
            this.button_usar_conexion.Name = "button_usar_conexion";
            this.button_usar_conexion.Size = new System.Drawing.Size(181, 29);
            this.button_usar_conexion.TabIndex = 15;
            this.button_usar_conexion.Text = "Usar conexión";
            this.button_usar_conexion.UseVisualStyleBackColor = false;
            this.button_usar_conexion.Click += new System.EventHandler(this.button_usar_conexion_Click);
            // 
            // label_conexion_personalizada
            // 
            this.label_conexion_personalizada.AutoSize = true;
            this.label_conexion_personalizada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_conexion_personalizada.Location = new System.Drawing.Point(9, 94);
            this.label_conexion_personalizada.Name = "label_conexion_personalizada";
            this.label_conexion_personalizada.Size = new System.Drawing.Size(255, 20);
            this.label_conexion_personalizada.TabIndex = 16;
            this.label_conexion_personalizada.Text = "Establecer conexión personalizada";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label_conexion_personalizada);
            this.panel1.Controls.Add(this.button_usar_conexion);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBox_usuario_base_de_datos);
            this.panel1.Controls.Add(this.textBox_nombre_base_de_datos);
            this.panel1.Controls.Add(this.textBox_contrasenia_base_de_datos);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button_probar_conexion);
            this.panel1.Controls.Add(this.textBox_host_base_de_datos);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button_usar_bd_default_pregunta);
            this.panel1.Controls.Add(this.button_usar_base_de_datos_predeterminada);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 374);
            this.panel1.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(300, -218);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1142, 1078);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // EstablecerConexionSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 374);
            this.Controls.Add(this.panel1);
            this.Name = "EstablecerConexionSQL";
            this.Text = "Conexion a la base de datos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_usar_base_de_datos_predeterminada;
        private System.Windows.Forms.Button button_usar_bd_default_pregunta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_host_base_de_datos;
        private System.Windows.Forms.TextBox textBox_nombre_base_de_datos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_usuario_base_de_datos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_contrasenia_base_de_datos;
        private System.Windows.Forms.Button button_probar_conexion;
        private System.Windows.Forms.Button button_usar_conexion;
        private System.Windows.Forms.Label label_conexion_personalizada;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}