using EntidadesCuadrado;

namespace FormularioClase
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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FormsAgregar frmAgregar = new FormsAgregar() { Text = " Agregar Exagono " };
            DialogResult drAgregar = frmAgregar.ShowDialog(this);

            if (drAgregar == DialogResult.Cancel)
            {
                return;
            }

            Exagono cuadrado = frmAgregar.getCuadrado();

            DataGridViewRow r = ConstruirFila();

            setearFila(r, cuadrado);
            agregarFila(r);

            MessageBox.Show("Registro Agregado ", "Mensaje ", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void agregarFila(DataGridViewRow r)
        {
            dgvFormularioPrincipal.Rows.Add(r);
        }

        private void setearFila(DataGridViewRow r, Exagono cuadrado)
        {
            r.Cells[colLado.Index].Value = cuadrado.getLado();
            r.Cells[colSuperficie.Index].Value = cuadrado.getArea();
            r.Cells[colPerimetro.Index].Value = cuadrado.getPerimetro();

            r.Tag = cuadrado;
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r = new DataGridViewRow();

            r.CreateCells(dgvFormularioPrincipal);
            return r;

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (dgvFormularioPrincipal.SelectedRows.Count == 0)
            {
                return;

            }

            var filaSeleccionada = dgvFormularioPrincipal.SelectedRows[0];

            Exagono cuadrado = (Exagono)filaSeleccionada.Tag;

            FormsAgregar frm = new FormsAgregar() { Text = " Editar Exagono " };

            frm.setCuadrado(cuadrado);

            DialogResult dr = frm.ShowDialog(this);

            if (dr == DialogResult.Cancel)
            {
                return;

            }

            cuadrado = frm.getCuadrado();
            setearFila(filaSeleccionada, cuadrado);
            MessageBox.Show("Registro Editado ", "Mensaje ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (dgvFormularioPrincipal.SelectedCells.Count == 0)
            {
                return;
            }

            DialogResult dr = MessageBox.Show(" Estas Seguro de Querer Eliminiar lo Selecionado? ", "Confirmar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (dr == DialogResult.No)
            {
                return;
            }

            quitarFila(dgvFormularioPrincipal.SelectedRows[0]);

            MessageBox.Show("Registro Borrado ", "Mensaje ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void quitarFila(DataGridViewRow r)
        {
            dgvFormularioPrincipal.Rows.Remove(r);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvFormularioPrincipal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}