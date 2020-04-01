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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearContacto));
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.button_guardar_contacto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(5)))), ((int)(((byte)(109)))));
            this.button_guardar_contacto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_guardar_contacto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_guardar_contacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_guardar_contacto.ForeColor = System.Drawing.Color.White;
            this.button_guardar_contacto.Location = new System.Drawing.Point(12, 263);
            this.button_guardar_contacto.Name = "button_guardar_contacto";
            this.button_guardar_contacto.Size = new System.Drawing.Size(165, 32);
            this.button_guardar_contacto.TabIndex = 2;
            this.button_guardar_contacto.Text = "Guardar nuevo contacto";
            this.button_guardar_contacto.UseVisualStyleBackColor = false;
            this.button_guardar_contacto.Click += new System.EventHandler(this.button_guardar_contacto_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Agregar nuevo contacto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Apellido:";
            // 
            // textBox_apellido
            // 
            this.textBox_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBox_apellido.Location = new System.Drawing.Point(97, 104);
            this.textBox_apellido.Name = "textBox_apellido";
            this.textBox_apellido.Size = new System.Drawing.Size(239, 26);
            this.textBox_apellido.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Teléfono:";
            // 
            // textBox_telefono
            // 
            this.textBox_telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBox_telefono.Location = new System.Drawing.Point(97, 148);
            this.textBox_telefono.Name = "textBox_telefono";
            this.textBox_telefono.Size = new System.Drawing.Size(239, 26);
            this.textBox_telefono.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Correo:";
            // 
            // textBox_correo
            // 
            this.textBox_correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBox_correo.Location = new System.Drawing.Point(97, 193);
            this.textBox_correo.Name = "textBox_correo";
            this.textBox_correo.Size = new System.Drawing.Size(239, 26);
            this.textBox_correo.TabIndex = 9;
            // 
            // button_volver
            // 
            this.button_volver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(5)))), ((int)(((byte)(109)))));
            this.button_volver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_volver.ForeColor = System.Drawing.Color.White;
            this.button_volver.Location = new System.Drawing.Point(204, 263);
            this.button_volver.Name = "button_volver";
            this.button_volver.Size = new System.Drawing.Size(132, 32);
            this.button_volver.TabIndex = 11;
            this.button_volver.Text = "Volver al menú";
            this.button_volver.UseVisualStyleBackColor = false;
            this.button_volver.Click += new System.EventHandler(this.button_volver_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.textBox_correo);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBox_telefono);
            this.panel1.Controls.Add(this.button_volver);
            this.panel1.Controls.Add(this.textBox_apellido);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button_guardar_contacto);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 319);
            this.panel1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(133, -24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(395, 496);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // CrearContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 319);
            this.Controls.Add(this.textBox_nombre);
            this.Controls.Add(this.panel1);
            this.Name = "CrearContacto";
            this.Text = "Crear contacto";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}