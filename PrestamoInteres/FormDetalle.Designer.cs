namespace PrestamoInteres
{
    partial class FormDetalle
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
            lblCuota = new Label();
            dgvAmortizacion = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvAmortizacion).BeginInit();
            SuspendLayout();
            // 
            // lblCuota
            // 
            lblCuota.AutoSize = true;
            lblCuota.Location = new Point(12, 199);
            lblCuota.Name = "lblCuota";
            lblCuota.Size = new Size(50, 20);
            lblCuota.TabIndex = 0;
            lblCuota.Text = "label1";
            // 
            // dgvAmortizacion
            // 
            dgvAmortizacion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAmortizacion.Location = new Point(393, 12);
            dgvAmortizacion.Name = "dgvAmortizacion";
            dgvAmortizacion.RowHeadersWidth = 51;
            dgvAmortizacion.Size = new Size(395, 426);
            dgvAmortizacion.TabIndex = 1;
            // 
            // FormDetalle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvAmortizacion);
            Controls.Add(lblCuota);
            Name = "FormDetalle";
            Text = "FormDetalle";
            Load += FormDetalle_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAmortizacion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCuota;
        private DataGridView dgvAmortizacion;
    }
}