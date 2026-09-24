namespace pryGerbaudoPabloSP3
{
    public partial class Repuestos : Form
    {
        public Repuestos()
        {
            InitializeComponent();
        }
        string Marca;
        string Origen;
        string precio;
        string num;
        string Descripcion;
        int Numero;
        int Precio;
        string[] VecRepuesto = new string[5];
        string Repuesto;


        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            Marca = cmbMarca.Text;
        }
        private void cmbOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            Origen = cmbOrigen.Text;
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            precio = txtPrecio.Text;
            Precio = Convert.ToInt16(precio);
        }

        private void txtNumResp_TextChanged(object sender, EventArgs e)
        {
            num = txtNumResp.Text;
            Numero = Convert.ToInt16(num);
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            Descripcion = txtDescripcion.Text;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            for (int Indice = 0; Indice <= 5; Indice++)
            {

                VecRepuesto[Indice] = (Marca + Origen + precio + num + Descripcion);
                Repuesto = Marca + Origen + precio + num + Descripcion;
                lstRespuestos.Items.Add(Repuesto);
            }
        }
    }
}
