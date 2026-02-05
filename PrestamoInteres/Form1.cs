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
                //Instanciamos la clase con los datos capturados
                Prestamo miPrestamo = new Prestamo
                {
                    Monto = double.Parse(txtMonto.Text),
                    TasaInteresAnual = double.Parse(txtInteres.Text),
                    PlazoMeses = int.Parse(txtPlazo.Text)
                };

                //Abrimos el segundo formulario pasando el objeto
                FormDetalle frmDetalle = new FormDetalle(miPrestamo);
                frmDetalle.ShowDialog(); // Lo abrimos como ventana emergente
            }
            catch (Exception ex)
            {
                //Para que no se cierre el programa si hay espacios vacios y le dan a calcular
                MessageBox.Show("Por favor, ingresa valores numéricos válidos.");
            }
        }
    }
}
