namespace FormularioClase
{
    partial class FormsAgregar
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            comboBox1 = new ComboBox();
            botonAgregar = new Button();
            BotonSalir = new Button();
            errorProvider1 = new ErrorProvider(components);
            comboBox2 = new ComboBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 60);
            label1.Name = "label1";
            label1.Size = new Size(122, 20);
            label1.TabIndex = 0;
            label1.Text = "Medida del Lado";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(207, 60);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // botonAgregar
            // 
            botonAgregar.Image = Properties.Resources.check_circle__1_;
            botonAgregar.Location = new Point(503, 35);
            botonAgregar.Name = "botonAgregar";
            botonAgregar.Size = new Size(192, 76);
            botonAgregar.TabIndex = 2;
            botonAgregar.Text = "Agregar";
            botonAgregar.TextImageRelation = TextImageRelation.ImageAboveText;
            botonAgregar.UseVisualStyleBackColor = true;
            botonAgregar.Click += botonAgregar_Click;
            // 
            // BotonSalir
            // 
            BotonSalir.Image = Properties.Resources.log_out__1_;
            BotonSalir.Location = new Point(503, 159);
            BotonSalir.Name = "BotonSalir";
            BotonSalir.Size = new Size(192, 76);
            BotonSalir.TabIndex = 3;
            BotonSalir.Text = "Salir";
            BotonSalir.TextImageRelation = TextImageRelation.ImageAboveText;
            BotonSalir.UseVisualStyleBackColor = true;
            BotonSalir.Click += BotonSalir_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(207, 137);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 140);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 5;
            label2.Text = "Color";
            label2.Click += label2_Click;
            // 
            // FormsAgregar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 288);
            Controls.Add(label2);
            Controls.Add(comboBox2);
            Controls.Add(BotonSalir);
            Controls.Add(botonAgregar);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Name = "FormsAgregar";
            Text = "Agregar";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private Button botonAgregar;
        private Button BotonSalir;
        private ErrorProvider errorProvider1;
        private Label label2;
        private ComboBox comboBox2;
    }
}