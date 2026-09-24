namespace pryGerbaudoPabloSP3
{
    partial class Repuestos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Repuestos));
            lblTitulo = new Label();
            lstRespuestos = new ListBox();
            tbCargadeRepuesto = new TabControl();
            tbpCarga = new TabPage();
            btnGuardar = new Button();
            lblPrecio = new Label();
            lblDescripcion = new Label();
            lblNumero = new Label();
            lblOrigen = new Label();
            lblMarca = new Label();
            cmbOrigen = new ComboBox();
            cmbMarca = new ComboBox();
            txtPrecio = new TextBox();
            txtDescripcion = new TextBox();
            txtNumResp = new TextBox();
            tbpBusqueda = new TabPage();
            btnBuscar = new Button();
            groupBox1 = new GroupBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            comboBox1 = new ComboBox();
            label1 = new Label();
            tbCargadeRepuesto.SuspendLayout();
            tbpCarga.SuspendLayout();
            tbpBusqueda.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(85, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(343, 47);
            lblTitulo.TabIndex = 5;
            lblTitulo.Text = "Venta de Repuestos";
            // 
            // lstRespuestos
            // 
            lstRespuestos.FormattingEnabled = true;
            lstRespuestos.Location = new Point(0, 198);
            lstRespuestos.Name = "lstRespuestos";
            lstRespuestos.Size = new Size(487, 49);
            lstRespuestos.TabIndex = 12;
            // 
            // tbCargadeRepuesto
            // 
            tbCargadeRepuesto.Controls.Add(tbpCarga);
            tbCargadeRepuesto.Controls.Add(tbpBusqueda);
            tbCargadeRepuesto.Location = new Point(2, 74);
            tbCargadeRepuesto.Name = "tbCargadeRepuesto";
            tbCargadeRepuesto.SelectedIndex = 0;
            tbCargadeRepuesto.Size = new Size(495, 299);
            tbCargadeRepuesto.TabIndex = 14;
            // 
            // tbpCarga
            // 
            tbpCarga.Controls.Add(btnGuardar);
            tbpCarga.Controls.Add(lblPrecio);
            tbpCarga.Controls.Add(lblDescripcion);
            tbpCarga.Controls.Add(lstRespuestos);
            tbpCarga.Controls.Add(lblNumero);
            tbpCarga.Controls.Add(lblOrigen);
            tbpCarga.Controls.Add(lblMarca);
            tbpCarga.Controls.Add(cmbOrigen);
            tbpCarga.Controls.Add(cmbMarca);
            tbpCarga.Controls.Add(txtPrecio);
            tbpCarga.Controls.Add(txtDescripcion);
            tbpCarga.Controls.Add(txtNumResp);
            tbpCarga.Location = new Point(4, 24);
            tbpCarga.Name = "tbpCarga";
            tbpCarga.Padding = new Padding(3);
            tbpCarga.Size = new Size(487, 271);
            tbpCarga.TabIndex = 0;
            tbpCarga.Text = "Carga de repuesto";
            tbpCarga.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(347, 148);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(140, 47);
            btnGuardar.TabIndex = 16;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrecio.Location = new Point(166, 78);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(77, 30);
            lblPrecio.TabIndex = 21;
            lblPrecio.Text = "Precio:";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescripcion.Location = new Point(34, 112);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(129, 30);
            lblDescripcion.TabIndex = 20;
            lblDescripcion.Text = "Descripción:";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumero.Location = new Point(3, 76);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(97, 30);
            lblNumero.TabIndex = 19;
            lblNumero.Text = "Número:";
            // 
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrigen.Location = new Point(77, 40);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(83, 30);
            lblOrigen.TabIndex = 18;
            lblOrigen.Text = "Origen:";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMarca.Location = new Point(81, 4);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(77, 30);
            lblMarca.TabIndex = 17;
            lblMarca.Text = "Marca:";
            // 
            // cmbOrigen
            // 
            cmbOrigen.FormattingEnabled = true;
            cmbOrigen.Items.AddRange(new object[] { "NACIONAL", "IMPORTADO" });
            cmbOrigen.Location = new Point(162, 47);
            cmbOrigen.Name = "cmbOrigen";
            cmbOrigen.Size = new Size(137, 23);
            cmbOrigen.TabIndex = 11;
            cmbOrigen.SelectedIndexChanged += cmbOrigen_SelectedIndexChanged;
            // 
            // cmbMarca
            // 
            cmbMarca.FormattingEnabled = true;
            cmbMarca.Items.AddRange(new object[] { "PEUGEOT", "FIAT", "RENAULT" });
            cmbMarca.Location = new Point(162, 13);
            cmbMarca.Name = "cmbMarca";
            cmbMarca.Size = new Size(137, 23);
            cmbMarca.TabIndex = 12;
            cmbMarca.SelectedIndexChanged += cmbMarca_SelectedIndexChanged;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(106, 83);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(50, 23);
            txtPrecio.TabIndex = 13;
            txtPrecio.TextChanged += txtPrecio_TextChanged;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(169, 119);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(144, 49);
            txtDescripcion.TabIndex = 15;
            txtDescripcion.TextChanged += txtDescripcion_TextChanged;
            // 
            // txtNumResp
            // 
            txtNumResp.Location = new Point(249, 83);
            txtNumResp.Name = "txtNumResp";
            txtNumResp.Size = new Size(50, 23);
            txtNumResp.TabIndex = 14;
            txtNumResp.TextChanged += txtNumResp_TextChanged;
            // 
            // tbpBusqueda
            // 
            tbpBusqueda.Controls.Add(btnBuscar);
            tbpBusqueda.Controls.Add(groupBox1);
            tbpBusqueda.Controls.Add(label1);
            tbpBusqueda.Location = new Point(4, 24);
            tbpBusqueda.Name = "tbpBusqueda";
            tbpBusqueda.Padding = new Padding(3);
            tbpBusqueda.Size = new Size(487, 271);
            tbpBusqueda.TabIndex = 1;
            tbpBusqueda.Text = "Búsqueda de repuesto";
            tbpBusqueda.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(347, 224);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(140, 47);
            btnBuscar.TabIndex = 17;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Location = new Point(6, 52);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(291, 75);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(168, 37);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(28, 19);
            radioButton1.TabIndex = 16;
            radioButton1.TabStop = true;
            radioButton1.Text = "I";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(168, 12);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(34, 19);
            radioButton2.TabIndex = 15;
            radioButton2.TabStop = true;
            radioButton2.Text = "N";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "F", "P", "R" });
            comboBox1.Location = new Point(8, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(137, 23);
            comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 3);
            label1.Name = "label1";
            label1.Size = new Size(314, 37);
            label1.TabIndex = 15;
            label1.Text = "Búsqueda de repuestos";
            // 
            // Repuestos
            // 
            AcceptButton = btnGuardar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 386);
            Controls.Add(tbCargadeRepuesto);
            Controls.Add(lblTitulo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Repuestos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Repuestos";
            tbCargadeRepuesto.ResumeLayout(false);
            tbpCarga.ResumeLayout(false);
            tbpCarga.PerformLayout();
            tbpBusqueda.ResumeLayout(false);
            tbpBusqueda.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTitulo;
        private ListBox lstRespuestos;
        private TabControl tbCargadeRepuesto;
        private TabPage tbpCarga;
        private Button btnGuardar;
        private Label lblPrecio;
        private Label lblDescripcion;
        private Label lblNumero;
        private Label lblOrigen;
        private Label lblMarca;
        private ComboBox cmbOrigen;
        private ComboBox cmbMarca;
        private TextBox txtPrecio;
        private TextBox txtDescripcion;
        private TextBox txtNumResp;
        private TabPage tbpBusqueda;
        private GroupBox groupBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private ComboBox comboBox1;
        private Label label1;
        private Button btnBuscar;
    }
}
