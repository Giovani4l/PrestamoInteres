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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
