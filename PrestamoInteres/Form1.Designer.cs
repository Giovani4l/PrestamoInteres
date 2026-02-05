namespace PrestamoInteres
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
            txtMonto = new TextBox();
            txtInteres = new TextBox();
            txtPlazo = new TextBox();
            btnCalcular = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(312, 132);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(125, 27);
            txtMonto.TabIndex = 0;
            // 
            // txtInteres
            // 
            txtInteres.Location = new Point(312, 198);
            txtInteres.Name = "txtInteres";
            txtInteres.Size = new Size(125, 27);
            txtInteres.TabIndex = 1;
            // 
            // txtPlazo
            // 
            txtPlazo.Location = new Point(312, 265);
            txtPlazo.Name = "txtPlazo";
            txtPlazo.Size = new Size(125, 27);
            txtPlazo.TabIndex = 2;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(330, 355);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(124, 139);
            label1.Name = "label1";
            label1.Size = new Size(147, 20);
            label1.TabIndex = 4;
            label1.Text = "Monto del Préstamo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(124, 205);
            label2.Name = "label2";
            label2.Size = new Size(177, 20);
            label2.TabIndex = 5;
            label2.Text = "Tasa de Interés Anual (%):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(124, 272);
            label3.Name = "label3";
            label3.Size = new Size(113, 20);
            label3.TabIndex = 6;
            label3.Text = "Plazo en Meses:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCalcular);
            Controls.Add(txtPlazo);
            Controls.Add(txtInteres);
            Controls.Add(txtMonto);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMonto;
        private TextBox txtInteres;
        private TextBox txtPlazo;
        private Button btnCalcular;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
