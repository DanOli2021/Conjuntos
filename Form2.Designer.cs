namespace Conjuntos
{
    partial class Form2
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
            this.txtNStart = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnComplemento = new System.Windows.Forms.Button();
            this.btnInterseccion = new System.Windows.Forms.Button();
            this.btnDiferenciaSimetrica = new System.Windows.Forms.Button();
            this.btnDiferencia = new System.Windows.Forms.Button();
            this.btnUnion = new System.Windows.Forms.Button();
            this.txtNEnd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtResultados = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNStart
            // 
            this.txtNStart.Location = new System.Drawing.Point(74, 12);
            this.txtNStart.Name = "txtNStart";
            this.txtNStart.Size = new System.Drawing.Size(116, 23);
            this.txtNStart.TabIndex = 16;
            this.txtNStart.Text = "1";
            this.txtNStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(20, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "n inicial";
            // 
            // btnComplemento
            // 
            this.btnComplemento.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnComplemento.Location = new System.Drawing.Point(536, 54);
            this.btnComplemento.Name = "btnComplemento";
            this.btnComplemento.Size = new System.Drawing.Size(291, 54);
            this.btnComplemento.TabIndex = 21;
            this.btnComplemento.Text = "Complemento de un conjunto";
            this.btnComplemento.UseVisualStyleBackColor = true;
            // 
            // btnInterseccion
            // 
            this.btnInterseccion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInterseccion.Location = new System.Drawing.Point(125, 54);
            this.btnInterseccion.Name = "btnInterseccion";
            this.btnInterseccion.Size = new System.Drawing.Size(107, 54);
            this.btnInterseccion.TabIndex = 18;
            this.btnInterseccion.Text = "Intersección";
            this.btnInterseccion.UseVisualStyleBackColor = true;
            this.btnInterseccion.Click += new System.EventHandler(this.btnInterseccion_Click);
            // 
            // btnDiferenciaSimetrica
            // 
            this.btnDiferenciaSimetrica.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDiferenciaSimetrica.Location = new System.Drawing.Point(371, 54);
            this.btnDiferenciaSimetrica.Name = "btnDiferenciaSimetrica";
            this.btnDiferenciaSimetrica.Size = new System.Drawing.Size(159, 54);
            this.btnDiferenciaSimetrica.TabIndex = 20;
            this.btnDiferenciaSimetrica.Text = "Diferencia simétrica";
            this.btnDiferenciaSimetrica.UseVisualStyleBackColor = true;
            this.btnDiferenciaSimetrica.Click += new System.EventHandler(this.btnDiferenciaSimetrica_Click);
            // 
            // btnDiferencia
            // 
            this.btnDiferencia.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDiferencia.Location = new System.Drawing.Point(238, 54);
            this.btnDiferencia.Name = "btnDiferencia";
            this.btnDiferencia.Size = new System.Drawing.Size(127, 54);
            this.btnDiferencia.TabIndex = 19;
            this.btnDiferencia.Text = "Diferencia";
            this.btnDiferencia.UseVisualStyleBackColor = true;
            this.btnDiferencia.Click += new System.EventHandler(this.btnDiferencia_Click);
            // 
            // btnUnion
            // 
            this.btnUnion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUnion.Location = new System.Drawing.Point(12, 54);
            this.btnUnion.Name = "btnUnion";
            this.btnUnion.Size = new System.Drawing.Size(107, 54);
            this.btnUnion.TabIndex = 17;
            this.btnUnion.Text = "Union";
            this.btnUnion.UseVisualStyleBackColor = true;
            this.btnUnion.Click += new System.EventHandler(this.btnUnion_Click);
            // 
            // txtNEnd
            // 
            this.txtNEnd.Location = new System.Drawing.Point(258, 10);
            this.txtNEnd.Name = "txtNEnd";
            this.txtNEnd.Size = new System.Drawing.Size(116, 23);
            this.txtNEnd.TabIndex = 23;
            this.txtNEnd.Text = "10000";
            this.txtNEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(206, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "n final";
            // 
            // txtResultados
            // 
            this.txtResultados.BackColor = System.Drawing.Color.Black;
            this.txtResultados.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtResultados.ForeColor = System.Drawing.Color.Lime;
            this.txtResultados.Location = new System.Drawing.Point(12, 114);
            this.txtResultados.Multiline = true;
            this.txtResultados.Name = "txtResultados";
            this.txtResultados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultados.Size = new System.Drawing.Size(829, 419);
            this.txtResultados.TabIndex = 24;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 545);
            this.Controls.Add(this.txtResultados);
            this.Controls.Add(this.txtNEnd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnComplemento);
            this.Controls.Add(this.btnInterseccion);
            this.Controls.Add(this.btnDiferenciaSimetrica);
            this.Controls.Add(this.btnDiferencia);
            this.Controls.Add(this.btnUnion);
            this.Controls.Add(this.txtNStart);
            this.Controls.Add(this.label6);
            this.Name = "Form2";
            this.Text = "Pruebas de algoritmos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtNStart;
        private Label label6;
        private Button btnComplemento;
        private Button btnInterseccion;
        private Button btnDiferenciaSimetrica;
        private Button btnDiferencia;
        private Button btnUnion;
        private TextBox txtNEnd;
        private Label label1;
        private TextBox txtResultados;
    }
}