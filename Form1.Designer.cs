namespace Conjuntos
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtConjuntoA = new System.Windows.Forms.TextBox();
            this.txtConjuntoB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResultados = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUnion = new System.Windows.Forms.Button();
            this.btnDiferencia = new System.Windows.Forms.Button();
            this.btnDiferenciaSimetrica = new System.Windows.Forms.Button();
            this.btnInterseccion = new System.Windows.Forms.Button();
            this.txtUniverso = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnComplemento = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAleatorios = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnPruebas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conjunto A";
            // 
            // txtConjuntoA
            // 
            this.txtConjuntoA.BackColor = System.Drawing.Color.Black;
            this.txtConjuntoA.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtConjuntoA.ForeColor = System.Drawing.Color.Lime;
            this.txtConjuntoA.Location = new System.Drawing.Point(84, 158);
            this.txtConjuntoA.Multiline = true;
            this.txtConjuntoA.Name = "txtConjuntoA";
            this.txtConjuntoA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConjuntoA.Size = new System.Drawing.Size(865, 108);
            this.txtConjuntoA.TabIndex = 1;
            // 
            // txtConjuntoB
            // 
            this.txtConjuntoB.BackColor = System.Drawing.Color.Black;
            this.txtConjuntoB.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtConjuntoB.ForeColor = System.Drawing.Color.Lime;
            this.txtConjuntoB.Location = new System.Drawing.Point(85, 272);
            this.txtConjuntoB.Multiline = true;
            this.txtConjuntoB.Name = "txtConjuntoB";
            this.txtConjuntoB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConjuntoB.Size = new System.Drawing.Size(865, 108);
            this.txtConjuntoB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(11, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Conjunto B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(85, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valores separador por comas";
            // 
            // txtResultados
            // 
            this.txtResultados.BackColor = System.Drawing.Color.Black;
            this.txtResultados.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtResultados.ForeColor = System.Drawing.Color.Lime;
            this.txtResultados.Location = new System.Drawing.Point(85, 446);
            this.txtResultados.Multiline = true;
            this.txtResultados.Name = "txtResultados";
            this.txtResultados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultados.Size = new System.Drawing.Size(865, 93);
            this.txtResultados.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 449);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Resultados";
            // 
            // btnUnion
            // 
            this.btnUnion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUnion.Location = new System.Drawing.Point(84, 386);
            this.btnUnion.Name = "btnUnion";
            this.btnUnion.Size = new System.Drawing.Size(117, 54);
            this.btnUnion.TabIndex = 3;
            this.btnUnion.Text = "Union";
            this.btnUnion.UseVisualStyleBackColor = true;
            this.btnUnion.Click += new System.EventHandler(this.btnUnion_Click);
            // 
            // btnDiferencia
            // 
            this.btnDiferencia.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDiferencia.Location = new System.Drawing.Point(330, 386);
            this.btnDiferencia.Name = "btnDiferencia";
            this.btnDiferencia.Size = new System.Drawing.Size(137, 54);
            this.btnDiferencia.TabIndex = 5;
            this.btnDiferencia.Text = "Diferencia";
            this.btnDiferencia.UseVisualStyleBackColor = true;
            this.btnDiferencia.Click += new System.EventHandler(this.btnDiferencia_Click);
            // 
            // btnDiferenciaSimetrica
            // 
            this.btnDiferenciaSimetrica.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDiferenciaSimetrica.Location = new System.Drawing.Point(473, 386);
            this.btnDiferenciaSimetrica.Name = "btnDiferenciaSimetrica";
            this.btnDiferenciaSimetrica.Size = new System.Drawing.Size(169, 54);
            this.btnDiferenciaSimetrica.TabIndex = 6;
            this.btnDiferenciaSimetrica.Text = "Diferencia simétrica";
            this.btnDiferenciaSimetrica.UseVisualStyleBackColor = true;
            this.btnDiferenciaSimetrica.Click += new System.EventHandler(this.btnDiferenciaSimetrica_Click);
            // 
            // btnInterseccion
            // 
            this.btnInterseccion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInterseccion.Location = new System.Drawing.Point(207, 386);
            this.btnInterseccion.Name = "btnInterseccion";
            this.btnInterseccion.Size = new System.Drawing.Size(117, 54);
            this.btnInterseccion.TabIndex = 4;
            this.btnInterseccion.Text = "Intersección";
            this.btnInterseccion.UseVisualStyleBackColor = true;
            this.btnInterseccion.Click += new System.EventHandler(this.btnInterseccion_Click);
            // 
            // txtUniverso
            // 
            this.txtUniverso.BackColor = System.Drawing.Color.Black;
            this.txtUniverso.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtUniverso.ForeColor = System.Drawing.Color.Lime;
            this.txtUniverso.Location = new System.Drawing.Point(84, 57);
            this.txtUniverso.Multiline = true;
            this.txtUniverso.Name = "txtUniverso";
            this.txtUniverso.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtUniverso.Size = new System.Drawing.Size(865, 93);
            this.txtUniverso.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(13, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Universo";
            // 
            // btnComplemento
            // 
            this.btnComplemento.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnComplemento.Location = new System.Drawing.Point(648, 386);
            this.btnComplemento.Name = "btnComplemento";
            this.btnComplemento.Size = new System.Drawing.Size(301, 54);
            this.btnComplemento.TabIndex = 7;
            this.btnComplemento.Text = "Complemento de un conjunto";
            this.btnComplemento.UseVisualStyleBackColor = true;
            this.btnComplemento.Click += new System.EventHandler(this.btnComplemento_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(289, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Generar valores aleatorios";
            // 
            // txtAleatorios
            // 
            this.txtAleatorios.Location = new System.Drawing.Point(448, 16);
            this.txtAleatorios.Name = "txtAleatorios";
            this.txtAleatorios.Size = new System.Drawing.Size(116, 23);
            this.txtAleatorios.TabIndex = 14;
            this.txtAleatorios.Text = "50";
            this.txtAleatorios.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGenerar.Location = new System.Drawing.Point(570, 12);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(149, 33);
            this.btnGenerar.TabIndex = 15;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnPruebas
            // 
            this.btnPruebas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPruebas.Location = new System.Drawing.Point(725, 12);
            this.btnPruebas.Name = "btnPruebas";
            this.btnPruebas.Size = new System.Drawing.Size(224, 33);
            this.btnPruebas.TabIndex = 16;
            this.btnPruebas.Text = "Pruebas de algoritmo";
            this.btnPruebas.UseVisualStyleBackColor = true;
            this.btnPruebas.Click += new System.EventHandler(this.btnPruebas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 551);
            this.Controls.Add(this.btnPruebas);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.txtAleatorios);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnComplemento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUniverso);
            this.Controls.Add(this.btnInterseccion);
            this.Controls.Add(this.btnDiferenciaSimetrica);
            this.Controls.Add(this.btnDiferencia);
            this.Controls.Add(this.btnUnion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtResultados);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtConjuntoB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtConjuntoA);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conjuntos Matemáticas Discretas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtConjuntoA;
        private TextBox txtConjuntoB;
        private Label label2;
        private Label label3;
        private TextBox txtResultados;
        private Label label4;
        private Button btnUnion;
        private Button btnDiferencia;
        private Button btnDiferenciaSimetrica;
        private Button btnInterseccion;
        private TextBox txtUniverso;
        private Label label5;
        private Button btnComplemento;
        private Label label6;
        private TextBox txtAleatorios;
        private Button btnGenerar;
        private Button btnPruebas;
    }
}