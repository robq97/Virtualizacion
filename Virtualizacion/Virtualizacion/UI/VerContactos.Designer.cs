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
            this.listBox_lista_contactos = new System.Windows.Forms.ListBox();
            this.button_volver = new System.Windows.Forms.Button();
            this.button_boton_editar = new System.Windows.Forms.Button();
            this.button_boton_borrar = new System.Windows.Forms.Button();
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
            this.button_volver.Location = new System.Drawing.Point(24, 366);
            this.button_volver.Name = "button_volver";
            this.button_volver.Size = new System.Drawing.Size(75, 23);
            this.button_volver.TabIndex = 1;
            this.button_volver.Text = "Volver";
            this.button_volver.UseVisualStyleBackColor = true;
            this.button_volver.Click += new System.EventHandler(this.button_volver_Click);
            // 
            // button_boton_editar
            // 
            this.button_boton_editar.Location = new System.Drawing.Point(168, 366);
            this.button_boton_editar.Name = "button_boton_editar";
            this.button_boton_editar.Size = new System.Drawing.Size(75, 23);
            this.button_boton_editar.TabIndex = 2;
            this.button_boton_editar.Text = "Editar";
            this.button_boton_editar.UseVisualStyleBackColor = true;
            // 
            // button_boton_borrar
            // 
            this.button_boton_borrar.Location = new System.Drawing.Point(265, 366);
            this.button_boton_borrar.Name = "button_boton_borrar";
            this.button_boton_borrar.Size = new System.Drawing.Size(75, 23);
            this.button_boton_borrar.TabIndex = 3;
            this.button_boton_borrar.Text = "Borrar";
            this.button_boton_borrar.UseVisualStyleBackColor = true;
            // 
            // VerContactos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 401);
            this.Controls.Add(this.button_boton_borrar);
            this.Controls.Add(this.button_boton_editar);
            this.Controls.Add(this.button_volver);
            this.Controls.Add(this.listBox_lista_contactos);
            this.Name = "VerContactos";
            this.Text = "VerContactos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_lista_contactos;
        private System.Windows.Forms.Button button_volver;
        private System.Windows.Forms.Button button_boton_editar;
        private System.Windows.Forms.Button button_boton_borrar;
    }
}