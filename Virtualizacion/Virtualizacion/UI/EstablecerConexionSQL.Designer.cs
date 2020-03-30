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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Establecer base de datos";
            // 
            // button_usar_base_de_datos_predeterminada
            // 
            this.button_usar_base_de_datos_predeterminada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.button_usar_base_de_datos_predeterminada.Location = new System.Drawing.Point(17, 41);
            this.button_usar_base_de_datos_predeterminada.Name = "button_usar_base_de_datos_predeterminada";
            this.button_usar_base_de_datos_predeterminada.Size = new System.Drawing.Size(246, 29);
            this.button_usar_base_de_datos_predeterminada.TabIndex = 1;
            this.button_usar_base_de_datos_predeterminada.Text = "Usar base de datos predeterminada";
            this.button_usar_base_de_datos_predeterminada.UseVisualStyleBackColor = true;
            this.button_usar_base_de_datos_predeterminada.Click += new System.EventHandler(this.button_usar_base_de_datos_predeterminada_Click);
            // 
            // button_usar_bd_default_pregunta
            // 
            this.button_usar_bd_default_pregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.button_usar_bd_default_pregunta.Location = new System.Drawing.Point(269, 43);
            this.button_usar_bd_default_pregunta.Name = "button_usar_bd_default_pregunta";
            this.button_usar_bd_default_pregunta.Size = new System.Drawing.Size(30, 27);
            this.button_usar_bd_default_pregunta.TabIndex = 2;
            this.button_usar_bd_default_pregunta.Text = "?";
            this.button_usar_bd_default_pregunta.UseVisualStyleBackColor = true;
            this.button_usar_bd_default_pregunta.Click += new System.EventHandler(this.button_usar_bd_default_pregunta_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label2.Location = new System.Drawing.Point(13, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(500, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "_________________________________________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(17, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Host base de datos";
            // 
            // textBox_host_base_de_datos
            // 
            this.textBox_host_base_de_datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textBox_host_base_de_datos.Location = new System.Drawing.Point(194, 99);
            this.textBox_host_base_de_datos.Name = "textBox_host_base_de_datos";
            this.textBox_host_base_de_datos.Size = new System.Drawing.Size(319, 23);
            this.textBox_host_base_de_datos.TabIndex = 5;
            // 
            // textBox_nombre_base_de_datos
            // 
            this.textBox_nombre_base_de_datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textBox_nombre_base_de_datos.Location = new System.Drawing.Point(194, 135);
            this.textBox_nombre_base_de_datos.Name = "textBox_nombre_base_de_datos";
            this.textBox_nombre_base_de_datos.Size = new System.Drawing.Size(319, 23);
            this.textBox_nombre_base_de_datos.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(17, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nombre base de datos";
            // 
            // textBox_usuario_base_de_datos
            // 
            this.textBox_usuario_base_de_datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textBox_usuario_base_de_datos.Location = new System.Drawing.Point(194, 173);
            this.textBox_usuario_base_de_datos.Name = "textBox_usuario_base_de_datos";
            this.textBox_usuario_base_de_datos.Size = new System.Drawing.Size(319, 23);
            this.textBox_usuario_base_de_datos.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label7.Location = new System.Drawing.Point(17, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Usuario base de datos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label8.Location = new System.Drawing.Point(17, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Contraseña base de datos";
            // 
            // textBox_contrasenia_base_de_datos
            // 
            this.textBox_contrasenia_base_de_datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textBox_contrasenia_base_de_datos.Location = new System.Drawing.Point(194, 217);
            this.textBox_contrasenia_base_de_datos.Name = "textBox_contrasenia_base_de_datos";
            this.textBox_contrasenia_base_de_datos.Size = new System.Drawing.Size(319, 23);
            this.textBox_contrasenia_base_de_datos.TabIndex = 13;
            // 
            // button_probar_conexion
            // 
            this.button_probar_conexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.button_probar_conexion.Location = new System.Drawing.Point(17, 260);
            this.button_probar_conexion.Name = "button_probar_conexion";
            this.button_probar_conexion.Size = new System.Drawing.Size(131, 29);
            this.button_probar_conexion.TabIndex = 14;
            this.button_probar_conexion.Text = "Probar conexión";
            this.button_probar_conexion.UseVisualStyleBackColor = true;
            this.button_probar_conexion.Click += new System.EventHandler(this.button_probar_conexion_Click);
            // 
            // button_usar_conexion
            // 
            this.button_usar_conexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.button_usar_conexion.Location = new System.Drawing.Point(154, 260);
            this.button_usar_conexion.Name = "button_usar_conexion";
            this.button_usar_conexion.Size = new System.Drawing.Size(359, 29);
            this.button_usar_conexion.TabIndex = 15;
            this.button_usar_conexion.Text = "Usar conexión";
            this.button_usar_conexion.UseVisualStyleBackColor = true;
            this.button_usar_conexion.Click += new System.EventHandler(this.button_usar_conexion_Click);
            // 
            // label_conexion_personalizada
            // 
            this.label_conexion_personalizada.AutoSize = true;
            this.label_conexion_personalizada.Location = new System.Drawing.Point(17, 80);
            this.label_conexion_personalizada.Name = "label_conexion_personalizada";
            this.label_conexion_personalizada.Size = new System.Drawing.Size(154, 13);
            this.label_conexion_personalizada.TabIndex = 16;
            this.label_conexion_personalizada.Text = "Estado conexión personalizada";
            // 
            // EstablecerConexionSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 298);
            this.Controls.Add(this.label_conexion_personalizada);
            this.Controls.Add(this.button_usar_conexion);
            this.Controls.Add(this.button_probar_conexion);
            this.Controls.Add(this.textBox_contrasenia_base_de_datos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_usuario_base_de_datos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_nombre_base_de_datos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_host_base_de_datos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_usar_bd_default_pregunta);
            this.Controls.Add(this.button_usar_base_de_datos_predeterminada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EstablecerConexionSQL";
            this.Text = "EstablecerConexionSQL";
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}