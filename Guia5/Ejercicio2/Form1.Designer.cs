namespace Ejercicio2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbNombres = new ListBox();
            btnGenerarListado = new Button();
            SuspendLayout();
            // 
            // lbNombres
            // 
            lbNombres.FormattingEnabled = true;
            lbNombres.ItemHeight = 15;
            lbNombres.Location = new Point(12, 12);
            lbNombres.Name = "lbNombres";
            lbNombres.ScrollAlwaysVisible = true;
            lbNombres.Size = new Size(376, 409);
            lbNombres.TabIndex = 0;
            // 
            // btnGenerarListado
            // 
            btnGenerarListado.Location = new Point(416, 147);
            btnGenerarListado.Name = "btnGenerarListado";
            btnGenerarListado.Size = new Size(96, 63);
            btnGenerarListado.TabIndex = 1;
            btnGenerarListado.Text = "Generar Listado";
            btnGenerarListado.UseVisualStyleBackColor = true;
            btnGenerarListado.Click += btnGenerarListado_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGenerarListado);
            Controls.Add(lbNombres);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button btnGenerarListado;
        public ListBox lbNombres;
    }
}
