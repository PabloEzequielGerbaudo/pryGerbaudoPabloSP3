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
            txtNumResp = new TextBox();
            txtDescripcion = new TextBox();
            txtPrecio = new TextBox();
            cmbMarca = new ComboBox();
            cmbOrigen = new ComboBox();
            lblTitulo = new Label();
            lblMarca = new Label();
            lblOrigen = new Label();
            lblNumero = new Label();
            lblDescripcion = new Label();
            lblPrecio = new Label();
            btnGuardar = new Button();
            lstRespuestos = new ListBox();
            lblTitulo2 = new Label();
            cmbMarca2 = new ComboBox();
            rbNacional = new RadioButton();
            rbImportado = new RadioButton();
            grbOpcion = new GroupBox();
            grbOpcion.SuspendLayout();
            SuspendLayout();
            // 
            // txtNumResp
            // 
            txtNumResp.Location = new Point(225, 250);
            txtNumResp.Name = "txtNumResp";
            txtNumResp.Size = new Size(50, 23);
            txtNumResp.TabIndex = 5;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(225, 214);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(122, 23);
            txtDescripcion.TabIndex = 4;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(225, 178);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(50, 23);
            txtPrecio.TabIndex = 3;
            // 
            // cmbMarca
            // 
            cmbMarca.FormattingEnabled = true;
            cmbMarca.Items.AddRange(new object[] { "I", "N" });
            cmbMarca.Location = new Point(222, 142);
            cmbMarca.Name = "cmbMarca";
            cmbMarca.Size = new Size(137, 23);
            cmbMarca.TabIndex = 2;
            // 
            // cmbOrigen
            // 
            cmbOrigen.FormattingEnabled = true;
            cmbOrigen.Items.AddRange(new object[] { "F", "P", "R" });
            cmbOrigen.Location = new Point(222, 106);
            cmbOrigen.Name = "cmbOrigen";
            cmbOrigen.Size = new Size(137, 23);
            cmbOrigen.TabIndex = 1;
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
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMarca.Location = new Point(137, 99);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(77, 30);
            lblMarca.TabIndex = 6;
            lblMarca.Text = "Marca:";
            // 
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrigen.Location = new Point(133, 135);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(83, 30);
            lblOrigen.TabIndex = 7;
            lblOrigen.Text = "Origen:";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumero.Location = new Point(119, 171);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(97, 30);
            lblNumero.TabIndex = 8;
            lblNumero.Text = "Número:";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescripcion.Location = new Point(90, 207);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(129, 30);
            lblDescripcion.TabIndex = 9;
            lblDescripcion.Text = "Descripción:";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrecio.Location = new Point(142, 243);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(77, 30);
            lblPrecio.TabIndex = 10;
            lblPrecio.Text = "Precio:";
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(369, 294);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(140, 47);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // lstRespuestos
            // 
            lstRespuestos.FormattingEnabled = true;
            lstRespuestos.Location = new Point(2, 358);
            lstRespuestos.Name = "lstRespuestos";
            lstRespuestos.Size = new Size(519, 49);
            lstRespuestos.TabIndex = 12;
            // 
            // lblTitulo2
            // 
            lblTitulo2.AutoSize = true;
            lblTitulo2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo2.Location = new Point(2, 410);
            lblTitulo2.Name = "lblTitulo2";
            lblTitulo2.Size = new Size(314, 37);
            lblTitulo2.TabIndex = 13;
            lblTitulo2.Text = "Busqueda de repuestos";
            // 
            // cmbMarca2
            // 
            cmbMarca2.FormattingEnabled = true;
            cmbMarca2.Items.AddRange(new object[] { "F", "P", "R" });
            cmbMarca2.Location = new Point(8, 12);
            cmbMarca2.Name = "cmbMarca2";
            cmbMarca2.Size = new Size(137, 23);
            cmbMarca2.TabIndex = 0;
            // 
            // rbNacional
            // 
            rbNacional.AutoSize = true;
            rbNacional.Location = new Point(168, 12);
            rbNacional.Name = "rbNacional";
            rbNacional.Size = new Size(34, 19);
            rbNacional.TabIndex = 15;
            rbNacional.TabStop = true;
            rbNacional.Text = "N";
            rbNacional.UseVisualStyleBackColor = true;
            // 
            // rbImportado
            // 
            rbImportado.AutoSize = true;
            rbImportado.Location = new Point(168, 37);
            rbImportado.Name = "rbImportado";
            rbImportado.Size = new Size(28, 19);
            rbImportado.TabIndex = 16;
            rbImportado.TabStop = true;
            rbImportado.Text = "I";
            rbImportado.UseVisualStyleBackColor = true;
            // 
            // grbOpcion
            // 
            grbOpcion.Controls.Add(rbImportado);
            grbOpcion.Controls.Add(rbNacional);
            grbOpcion.Controls.Add(cmbMarca2);
            grbOpcion.Location = new Point(4, 447);
            grbOpcion.Name = "grbOpcion";
            grbOpcion.Size = new Size(291, 75);
            grbOpcion.TabIndex = 7;
            grbOpcion.TabStop = false;
            // 
            // Repuestos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 570);
            Controls.Add(grbOpcion);
            Controls.Add(lblTitulo2);
            Controls.Add(lstRespuestos);
            Controls.Add(btnGuardar);
            Controls.Add(lblPrecio);
            Controls.Add(lblDescripcion);
            Controls.Add(lblNumero);
            Controls.Add(lblOrigen);
            Controls.Add(lblMarca);
            Controls.Add(lblTitulo);
            Controls.Add(cmbOrigen);
            Controls.Add(cmbMarca);
            Controls.Add(txtPrecio);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNumResp);
            Name = "Repuestos";
            Text = "Repuestos";
            grbOpcion.ResumeLayout(false);
            grbOpcion.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumResp;
        private TextBox txtDescripcion;
        private TextBox txtPrecio;
        private ComboBox cmbMarca;
        private ComboBox cmbOrigen;
        private Label lblTitulo;
        private Label lblMarca;
        private Label lblOrigen;
        private Label lblNumero;
        private Label lblDescripcion;
        private Label lblPrecio;
        private Button btnGuardar;
        private ListBox lstRespuestos;
        private Label lblTitulo2;
        private ComboBox cmbMarca2;
        private RadioButton rbNacional;
        private RadioButton rbImportado;
        private GroupBox grbOpcion;
    }
}
