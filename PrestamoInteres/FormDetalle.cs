using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PrestamoInteres.Form1;

namespace PrestamoInteres
{
    public partial class FormDetalle : Form
    {
        public FormDetalle()
        {
            InitializeComponent();
        }

        private void FormDetalle_Load(object sender, EventArgs e)
        {

        }
        private Prestamo prestamoRecibido;
        private void CargarDatos()
        {
            double cuota = prestamoRecibido.CalcularCuota();
            lblCuota.Text = $"Tu cuota mensual es de: ${cuota}";

            // Configurar columnas del DataGridView
            dgvAmortizacion.Columns.Add("Mes", "Mes");
            dgvAmortizacion.Columns.Add("Cuota", "Cuota");
            dgvAmortizacion.Columns.Add("Saldo", "Saldo Restante");

            double saldoRestante = prestamoRecibido.Monto;

            // For para llenar la tabla mes a mes
            for (int i = 1; i <= prestamoRecibido.PlazoMeses; i++)
            {
                saldoRestante -= (cuota - (saldoRestante * (prestamoRecibido.TasaInteresAnual / 100 / 12)));
                dgvAmortizacion.Rows.Add(i, cuota, Math.Max(0, Math.Round(saldoRestante, 2)));
            }
        }
        public FormDetalle(Prestamo p)
        {
            InitializeComponent();
            this.prestamoRecibido = p;
            CargarDatos();
        }
    }
}
