using EntidadesCuadrado;

namespace FormularioClase
{
    public partial class FormsAgregar : Form
    {
        public FormsAgregar()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (cuadrado != null)
            {
                comboBox1.Text = cuadrado.getLado().ToString();
            }
        }
        private void BotonSalir_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void botonAgregar_Click(object sender, EventArgs e)
        {
            if (validacionDatos())
            {
                if (cuadrado == null)
                {
                    cuadrado = new Exagono();
                }

                cuadrado.setLado(int.Parse(comboBox1.Text));

                DialogResult = DialogResult.OK;

            }
        }

        private bool validacionDatos()
        {
            bool Validar = true;
            errorProvider1.Clear();

            if (!int.TryParse(comboBox1.Text, out int lado))
            {
                Validar = false;
                errorProvider1.SetError(comboBox1, "Numero Mal Ingresado, Ingrese un Numero valido");

            }
            else if (lado <= 0)
            {
                Validar = false;
                errorProvider1.SetError(comboBox1, "El Valor Ingresado Es Erroneo o Menor A 0");
            }


            return Validar;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private Exagono cuadrado;

        public Exagono getCuadrado()
        {
            return cuadrado;
        }

        public void setCuadrado(Exagono? cuadrado)
        {
            this.cuadrado = cuadrado;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
