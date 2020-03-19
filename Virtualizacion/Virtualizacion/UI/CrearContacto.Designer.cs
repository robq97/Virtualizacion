namespace Virtualizacion.UI
{
    partial class CrearContacto
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
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.button_guardar_contacto = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_apellido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_telefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_correo = new System.Windows.Forms.TextBox();
            this.button_volver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBox_nombre.Location = new System.Drawing.Point(97, 60);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(239, 26);
            this.textBox_nombre.TabIndex = 1;
            // 
            // button_guardar_contacto
            // 
            this.button_guardar_contacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button_guardar_contacto.Location = new System.Drawing.Point(16, 274);
            this.button_guardar_contacto.Name = "button_guardar_contacto";
            this.button_guardar_contacto.Size = new System.Drawing.Size(320, 32);
            this.button_guardar_contacto.TabIndex = 2;
            this.button_guardar_contacto.Text = "Guardar nuevo contacto";
            this.button_guardar_contacto.UseVisualStyleBackColor = true;
            this.button_guardar_contacto.Click += new System.EventHandler(this.button_guardar_contacto_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Agregar nuevo contacto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(12, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Apellido";
            // 
            // textBox_apellido
            // 
            this.textBox_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBox_apellido.Location = new System.Drawing.Point(97, 118);
            this.textBox_apellido.Name = "textBox_apellido";
            this.textBox_apellido.Size = new System.Drawing.Size(239, 26);
            this.textBox_apellido.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(12, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Teléfono";
            // 
            // textBox_telefono
            // 
            this.textBox_telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBox_telefono.Location = new System.Drawing.Point(97, 171);
            this.textBox_telefono.Name = "textBox_telefono";
            this.textBox_telefono.Size = new System.Drawing.Size(239, 26);
            this.textBox_telefono.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label6.Location = new System.Drawing.Point(12, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Correo";
            // 
            // textBox_correo
            // 
            this.textBox_correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBox_correo.Location = new System.Drawing.Point(97, 220);
            this.textBox_correo.Name = "textBox_correo";
            this.textBox_correo.Size = new System.Drawing.Size(239, 26);
            this.textBox_correo.TabIndex = 9;
            // 
            // button_volver
            // 
            this.button_volver.Location = new System.Drawing.Point(16, 312);
            this.button_volver.Name = "button_volver";
            this.button_volver.Size = new System.Drawing.Size(320, 23);
            this.button_volver.TabIndex = 11;
            this.button_volver.Text = "Volver al menu";
            this.button_volver.UseVisualStyleBackColor = true;
            this.button_volver.Click += new System.EventHandler(this.button_volver_Click);
            // 
            // CrearContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 346);
            this.Controls.Add(this.button_volver);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_correo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_telefono);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_apellido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_guardar_contacto);
            this.Controls.Add(this.textBox_nombre);
            this.Name = "CrearContacto";
            this.Text = "CrearContacto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.Button button_guardar_contacto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_apellido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_telefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_correo;
        private System.Windows.Forms.Button button_volver;
    }
}