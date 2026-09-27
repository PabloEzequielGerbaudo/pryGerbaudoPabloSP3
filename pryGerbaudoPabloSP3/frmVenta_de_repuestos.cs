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
        int Indice = 0;
        string[] VecRepuesto = new string[5];
        string Repuesto;


        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMarca.SelectedIndex != -1)
            {
                Marca = cmbMarca.Text;
                cmbOrigen.Enabled = true;
            }

        }
        private void cmbOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOrigen.SelectedIndex != -1)
            {
                Origen = cmbOrigen.Text;
                txtPrecio.Enabled = true;
            }
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            if (txtPrecio.Text != "")
            {
                precio = txtPrecio.Text;
                Precio = Convert.ToInt16(precio);
                txtNumResp.Enabled = true;
            }
            else 
            { 
                txtNumResp.Enabled = false; 
            }

        }

        private void txtNumResp_TextChanged(object sender, EventArgs e)
        {
            if (txtNumResp.Text != "")
            {
                num = txtNumResp.Text;
                Numero = Convert.ToInt16(num);
                txtDescripcion.Enabled = true;
            }
            else 
            {
                txtDescripcion.Enabled = false;
            }
            
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            if (txtDescripcion.Text != "")
            {
                Descripcion = txtDescripcion.Text;
                btnGuardar.Enabled = true;
            }
            else
            {
                btnGuardar.Enabled = false;
            }
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
         Indice = Indice + 1;
            if (Indice > 5)
            {
                MessageBox.Show ("Lista completa");
            }
            else
            {
                VecRepuesto[Indice] = (Marca + Origen + precio + num + Descripcion);
                Repuesto = Marca + " " + Origen + " " + precio + " " + num + " " + Descripcion;
                lstRespuestos.Items.Add(Repuesto);
                cmbMarca.SelectedIndex = -1;
                cmbMarca.Focus();
                cmbOrigen.SelectedIndex = -1;
                txtPrecio.Clear();
                txtNumResp.Clear();
                txtDescripcion.Clear();
            }
        }
    }
}
