namespace PrestamoInteres
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public class Prestamo
        {
            // Atributos / Propiedades
            public double Monto { get; set; }
            public double TasaInteresAnual { get; set; }
            public int PlazoMeses { get; set; }

            // Método para calcular la cuota mensual
            public double CalcularCuota()
            {
                double tasaMensual = (TasaInteresAnual / 100) / 12;
                double cuota = Monto * (tasaMensual * Math.Pow(1 + tasaMensual, PlazoMeses)) /
                               (Math.Pow(1 + tasaMensual, PlazoMeses) - 1);
                return Math.Round(cuota, 2);
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // ERROR POTENCIAL: Si no selecciona nada en el ComboBox
                if (cmbInteres.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor selecciona una tasa de interés.");
                    return;
                }

                Prestamo miPrestamo = new Prestamo();
                miPrestamo.Monto = double.Parse(txtMonto.Text);
                miPrestamo.PlazoMeses = int.Parse(txtPlazo.Text);

                // Limpiamos el texto "18%" para quedarnos solo con el número 18
                string valorCombo = cmbInteres.Text.Replace("%", "");
                miPrestamo.TasaInteresAnual = double.Parse(valorCombo);

                FormDetalle ventana = new FormDetalle(miPrestamo);
                ventana.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Revisa que el monto y los meses sean números válidos.");
            }
        }
    }
}
