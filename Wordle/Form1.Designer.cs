namespace Wordle
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnInicio = new System.Windows.Forms.Button();
            this.txtPalabra = new System.Windows.Forms.TextBox();
            this.lstUsuarios = new System.Windows.Forms.ListBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnInicio
            // 
            this.btnInicio.Location = new System.Drawing.Point(63, 38);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(75, 23);
            this.btnInicio.TabIndex = 0;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // txtPalabra
            // 
            this.txtPalabra.Location = new System.Drawing.Point(63, 104);
            this.txtPalabra.MaxLength = 5;
            this.txtPalabra.Name = "txtPalabra";
            this.txtPalabra.ReadOnly = true;
            this.txtPalabra.Size = new System.Drawing.Size(100, 20);
            this.txtPalabra.TabIndex = 1;
            // 
            // lstUsuarios
            // 
            this.lstUsuarios.FormattingEnabled = true;
            this.lstUsuarios.Location = new System.Drawing.Point(63, 178);
            this.lstUsuarios.Name = "lstUsuarios";
            this.lstUsuarios.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstUsuarios.Size = new System.Drawing.Size(120, 95);
            this.lstUsuarios.TabIndex = 2;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(63, 323);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lstUsuarios);
            this.Controls.Add(this.txtPalabra);
            this.Controls.Add(this.btnInicio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.TextBox txtPalabra;
        private System.Windows.Forms.ListBox lstUsuarios;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Timer timer1;
    }
}

