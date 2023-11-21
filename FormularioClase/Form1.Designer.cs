namespace FormularioClase
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
            toolStrip1 = new ToolStrip();
            tsbAgregar = new ToolStripButton();
            tsbEditar = new ToolStripButton();
            tsbBorrar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbFiltrar = new ToolStripButton();
            tsbActualizar = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            tsbSalir = new ToolStripButton();
            panel1 = new Panel();
            panel2 = new Panel();
            dgvFormularioPrincipal = new DataGridView();
            colLado = new DataGridViewTextBoxColumn();
            colPerimetro = new DataGridViewTextBoxColumn();
            colSuperficie = new DataGridViewTextBoxColumn();
            toolStrip1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFormularioPrincipal).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbAgregar, tsbEditar, tsbBorrar, toolStripSeparator1, tsbFiltrar, tsbActualizar, toolStripSeparator2, tsbSalir });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 47);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbAgregar
            // 
            tsbAgregar.Image = Properties.Resources.file_plus__1_;
            tsbAgregar.ImageTransparentColor = Color.Magenta;
            tsbAgregar.Name = "tsbAgregar";
            tsbAgregar.Size = new Size(67, 44);
            tsbAgregar.Text = "Agregar";
            tsbAgregar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbAgregar.Click += toolStripButton1_Click;
            // 
            // tsbEditar
            // 
            tsbEditar.Image = Properties.Resources.edit;
            tsbEditar.ImageTransparentColor = Color.Magenta;
            tsbEditar.Name = "tsbEditar";
            tsbEditar.Size = new Size(52, 44);
            tsbEditar.Text = "Editar";
            tsbEditar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbEditar.Click += toolStripButton2_Click;
            // 
            // tsbBorrar
            // 
            tsbBorrar.Image = Properties.Resources.trash_2;
            tsbBorrar.ImageTransparentColor = Color.Magenta;
            tsbBorrar.Name = "tsbBorrar";
            tsbBorrar.Size = new Size(54, 44);
            tsbBorrar.Text = "Borrar";
            tsbBorrar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbBorrar.Click += toolStripButton3_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 47);
            // 
            // tsbFiltrar
            // 
            tsbFiltrar.Image = Properties.Resources.filter;
            tsbFiltrar.ImageTransparentColor = Color.Magenta;
            tsbFiltrar.Name = "tsbFiltrar";
            tsbFiltrar.Size = new Size(51, 44);
            tsbFiltrar.Text = "Filtrar";
            tsbFiltrar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbFiltrar.Click += toolStripButton4_Click;
            // 
            // tsbActualizar
            // 
            tsbActualizar.Image = Properties.Resources.refresh_cw;
            tsbActualizar.ImageTransparentColor = Color.Magenta;
            tsbActualizar.Name = "tsbActualizar";
            tsbActualizar.Size = new Size(79, 44);
            tsbActualizar.Text = "Actualizar";
            tsbActualizar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbActualizar.Click += toolStripButton5_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 47);
            // 
            // tsbSalir
            // 
            tsbSalir.Image = Properties.Resources.log_out;
            tsbSalir.ImageTransparentColor = Color.Magenta;
            tsbSalir.Name = "tsbSalir";
            tsbSalir.Size = new Size(42, 44);
            tsbSalir.Text = "Salir";
            tsbSalir.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbSalir.Click += toolStripButton6_Click;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 325);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 125);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvFormularioPrincipal);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 47);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 278);
            panel2.TabIndex = 2;
            // 
            // dgvFormularioPrincipal
            // 
            dgvFormularioPrincipal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFormularioPrincipal.Columns.AddRange(new DataGridViewColumn[] { colLado, colPerimetro, colSuperficie });
            dgvFormularioPrincipal.Dock = DockStyle.Fill;
            dgvFormularioPrincipal.Location = new Point(0, 0);
            dgvFormularioPrincipal.MultiSelect = false;
            dgvFormularioPrincipal.Name = "dgvFormularioPrincipal";
            dgvFormularioPrincipal.RowHeadersWidth = 51;
            dgvFormularioPrincipal.RowTemplate.Height = 29;
            dgvFormularioPrincipal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFormularioPrincipal.Size = new Size(800, 278);
            dgvFormularioPrincipal.TabIndex = 0;
            dgvFormularioPrincipal.CellContentClick += dgvFormularioPrincipal_CellContentClick;
            // 
            // colLado
            // 
            colLado.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colLado.HeaderText = "Lado";
            colLado.MinimumWidth = 6;
            colLado.Name = "colLado";
            // 
            // colPerimetro
            // 
            colPerimetro.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colPerimetro.HeaderText = "Perimetro";
            colPerimetro.MinimumWidth = 6;
            colPerimetro.Name = "colPerimetro";
            // 
            // colSuperficie
            // 
            colSuperficie.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colSuperficie.HeaderText = "Area";
            colSuperficie.MinimumWidth = 6;
            colSuperficie.Name = "colSuperficie";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(toolStrip1);
            Name = "Form1";
            Text = "Formulario Principal";
            Load += Form1_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvFormularioPrincipal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton tsbAgregar;
        private ToolStripButton tsbEditar;
        private ToolStripButton tsbBorrar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsbFiltrar;
        private ToolStripButton tsbActualizar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton tsbSalir;
        private Panel panel1;
        private Panel panel2;
        private DataGridView dgvFormularioPrincipal;
        private DataGridViewTextBoxColumn colLado;
        private DataGridViewTextBoxColumn colPerimetro;
        private DataGridViewTextBoxColumn colSuperficie;
    }
}