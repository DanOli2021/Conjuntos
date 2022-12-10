namespace Conjuntos
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnConjuntos = new System.Windows.Forms.Button();
            this.btnPruebas = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConjuntos
            // 
            this.btnConjuntos.BackColor = System.Drawing.Color.Blue;
            this.btnConjuntos.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConjuntos.ForeColor = System.Drawing.Color.White;
            this.btnConjuntos.Image = ((System.Drawing.Image)(resources.GetObject("btnConjuntos.Image")));
            this.btnConjuntos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConjuntos.Location = new System.Drawing.Point(34, 27);
            this.btnConjuntos.Name = "btnConjuntos";
            this.btnConjuntos.Size = new System.Drawing.Size(742, 98);
            this.btnConjuntos.TabIndex = 0;
            this.btnConjuntos.Text = "Algoritmos de conjuntos";
            this.btnConjuntos.UseVisualStyleBackColor = false;
            this.btnConjuntos.Click += new System.EventHandler(this.btnConjuntos_Click);
            // 
            // btnPruebas
            // 
            this.btnPruebas.BackColor = System.Drawing.Color.Green;
            this.btnPruebas.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPruebas.ForeColor = System.Drawing.Color.White;
            this.btnPruebas.Image = ((System.Drawing.Image)(resources.GetObject("btnPruebas.Image")));
            this.btnPruebas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPruebas.Location = new System.Drawing.Point(34, 131);
            this.btnPruebas.Name = "btnPruebas";
            this.btnPruebas.Size = new System.Drawing.Size(742, 98);
            this.btnPruebas.TabIndex = 1;
            this.btnPruebas.Text = "Pruebas de Algoritmos";
            this.btnPruebas.UseVisualStyleBackColor = false;
            this.btnPruebas.Click += new System.EventHandler(this.btnPruebas_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(34, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(742, 98);
            this.button1.TabIndex = 2;
            this.button1.Text = "Teorema de Bayes";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 355);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPruebas);
            this.Controls.Add(this.btnConjuntos);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnConjuntos;
        private Button btnPruebas;
        private Button button1;
    }
}