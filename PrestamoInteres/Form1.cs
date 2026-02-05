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
    }
}
