
namespace Tarea
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtAbrir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnINsertar = new System.Windows.Forms.Button();
            this.Matricula = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.ListArreglo = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtAbrir
            // 
            this.txtAbrir.Location = new System.Drawing.Point(535, 383);
            this.txtAbrir.Name = "txtAbrir";
            this.txtAbrir.Size = new System.Drawing.Size(110, 55);
            this.txtAbrir.TabIndex = 0;
            this.txtAbrir.Text = "Abrir";
            this.txtAbrir.UseVisualStyleBackColor = true;
            this.txtAbrir.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(663, 383);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(110, 55);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar ";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnINsertar
            // 
            this.btnINsertar.Location = new System.Drawing.Point(125, 121);
            this.btnINsertar.Name = "btnINsertar";
            this.btnINsertar.Size = new System.Drawing.Size(110, 55);
            this.btnINsertar.TabIndex = 2;
            this.btnINsertar.Text = "Insertar";
            this.btnINsertar.UseVisualStyleBackColor = true;
            this.btnINsertar.Click += new System.EventHandler(this.button3_Click);
            // 
            // Matricula
            // 
            this.Matricula.AutoSize = true;
            this.Matricula.Location = new System.Drawing.Point(95, 43);
            this.Matricula.Name = "Matricula";
            this.Matricula.Size = new System.Drawing.Size(53, 13);
            this.Matricula.TabIndex = 3;
            this.Matricula.Text = "Matricula:";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(223, 43);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(100, 20);
            this.txtMatricula.TabIndex = 4;
            this.txtMatricula.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(95, 70);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(47, 13);
            this.Nombre.TabIndex = 5;
            this.Nombre.Text = "Nombre:";
            this.Nombre.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(223, 70);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // ListArreglo
            // 
            this.ListArreglo.FormattingEnabled = true;
            this.ListArreglo.Location = new System.Drawing.Point(482, 12);
            this.ListArreglo.Name = "ListArreglo";
            this.ListArreglo.Size = new System.Drawing.Size(306, 355);
            this.ListArreglo.TabIndex = 7;
            this.ListArreglo.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListArreglo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.Matricula);
            this.Controls.Add(this.btnINsertar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtAbrir);
            this.Name = "Form1";
            this.Text = "Archivo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button txtAbrir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnINsertar;
        private System.Windows.Forms.Label Matricula;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ListBox ListArreglo;
    }
}

