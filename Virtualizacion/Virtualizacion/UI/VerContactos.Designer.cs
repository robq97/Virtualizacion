namespace Virtualizacion.UI
{
    partial class VerContactos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerContactos));
            this.listBox_lista_contactos = new System.Windows.Forms.ListBox();
            this.button_volver = new System.Windows.Forms.Button();
            this.button_boton_editar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_boton_borrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_lista_contactos
            // 
            this.listBox_lista_contactos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.listBox_lista_contactos.FormattingEnabled = true;
            this.listBox_lista_contactos.ItemHeight = 20;
            this.listBox_lista_contactos.Location = new System.Drawing.Point(12, 12);
            this.listBox_lista_contactos.Name = "listBox_lista_contactos";
            this.listBox_lista_contactos.Size = new System.Drawing.Size(601, 324);
            this.listBox_lista_contactos.TabIndex = 0;
            // 
            // button_volver
            // 
            this.button_volver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(5)))), ((int)(((byte)(109)))));
            this.button_volver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_volver.ForeColor = System.Drawing.Color.White;
            this.button_volver.Location = new System.Drawing.Point(12, 363);
            this.button_volver.Name = "button_volver";
            this.button_volver.Size = new System.Drawing.Size(75, 30);
            this.button_volver.TabIndex = 1;
            this.button_volver.Text = "Volver";
            this.button_volver.UseVisualStyleBackColor = false;
            this.button_volver.Click += new System.EventHandler(this.button_volver_Click);
            // 
            // button_boton_editar
            // 
            this.button_boton_editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(5)))), ((int)(((byte)(109)))));
            this.button_boton_editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_boton_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_boton_editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_boton_editar.ForeColor = System.Drawing.Color.White;
            this.button_boton_editar.Location = new System.Drawing.Point(456, 363);
            this.button_boton_editar.Name = "button_boton_editar";
            this.button_boton_editar.Size = new System.Drawing.Size(75, 30);
            this.button_boton_editar.TabIndex = 2;
            this.button_boton_editar.Text = "Editar";
            this.button_boton_editar.UseVisualStyleBackColor = false;
            this.button_boton_editar.Click += new System.EventHandler(this.button_boton_editar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, -369);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1136, 1078);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button_boton_borrar);
            this.panel1.Controls.Add(this.button_boton_editar);
            this.panel1.Controls.Add(this.button_volver);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(624, 403);
            this.panel1.TabIndex = 6;
            // 
            // button_boton_borrar
            // 
            this.button_boton_borrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(5)))), ((int)(((byte)(109)))));
            this.button_boton_borrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_boton_borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_boton_borrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_boton_borrar.ForeColor = System.Drawing.Color.White;
            this.button_boton_borrar.Location = new System.Drawing.Point(537, 363);
            this.button_boton_borrar.Name = "button_boton_borrar";
            this.button_boton_borrar.Size = new System.Drawing.Size(75, 30);
            this.button_boton_borrar.TabIndex = 3;
            this.button_boton_borrar.Text = "Borrar";
            this.button_boton_borrar.UseVisualStyleBackColor = false;
            this.button_boton_borrar.Click += new System.EventHandler(this.button_boton_borrar_Click);
            // 
            // VerContactos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 403);
            this.Controls.Add(this.listBox_lista_contactos);
            this.Controls.Add(this.panel1);
            this.Name = "VerContactos";
            this.Text = "Contactos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_lista_contactos;
        private System.Windows.Forms.Button button_volver;
        private System.Windows.Forms.Button button_boton_editar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_boton_borrar;
    }
}