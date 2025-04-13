namespace Desafio2PED_MO232723
{
    public partial class Form1 : Form
    {
        private TablaHash tablaHash = new TablaHash();
        public Form1()
        {
            InitializeComponent();
        }
        // Insertar
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Llamamos a la funcion para validar si los campos van vacios
            if (!ValidacionCampos())
            {
                return;
            }
            var producto = new Productos
            {
                Codigo = txtCodigo.Text,
                Nombre = txtNombre.Text,
                Categoria = cmbCategoria.Text,
                Precio = decimal.Parse(txtPrecio.Text),
                CantStock = int.Parse(txtCantidad.Text)
            };

            if (tablaHash.AgregarProducto(producto))
            {
                MessageBox.Show("Producto agregado con éxito.");
            }
            else
            {
                MessageBox.Show("El código ya existe. No se puede agregar el producto.");
            }

            LimpiarCampos();
        }
        // Buscar
        private void btnSearch_Click(object sender, EventArgs e)
        {
            var producto = tablaHash.BuscarProducto(txtCodBuscar.Text);
            if (producto != null)
            {
               
                dataGridView1.DataSource = new List<Productos> { producto }; 
                MessageBox.Show("Producto encontrado.");
            }
            else
            {
                MessageBox.Show("Producto no encontrado.");
                dataGridView1.DataSource = null; 
            }

        }
        // Listar
        private void btnList_Click(object sender, EventArgs e)
        {
            var productos = tablaHash.ListarTodosLosProductos();
            dataGridView1.DataSource = productos;
        }
        // Eliminar
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) // Verifica si hay una fila seleccionada
            {
              
                string codigo = dataGridView1.SelectedRows[0].Cells["Codigo"].Value.ToString();

                // Elimina el producto utilizando el código
                if (tablaHash.EliminarProducto(codigo))
                {
                    MessageBox.Show("Producto eliminado con éxito.");
                    // Actualiza la lista del DataGridView
                    dataGridView1.DataSource = tablaHash.ListarTodosLosProductos();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el producto. Verifica nuevamente.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un producto para eliminar.", "Selecciona un Producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        // Funcion para limpiar el form
        private void LimpiarCampos()
        {
            // Limpia los campos
            txtCodigo.Text = string.Empty;
            txtNombre.Text = string.Empty;
            cmbCategoria.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            txtCantidad.Text = string.Empty;
            txtCodBuscar.Text = string.Empty;

            
            if (dataGridView1.DataSource != null)
            {
                dataGridView1.ClearSelection(); 
            }
        }


        // Funcion que valida los campos vacios, valores que se usan
        private bool ValidacionCampos()
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) || string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(cmbCategoria.Text) ||string.IsNullOrWhiteSpace(txtPrecio.Text) ||string.IsNullOrWhiteSpace(txtCantidad.Text))
            {
                MessageBox.Show("Por favor, llenar todos los campos.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txtPrecio.Text, out decimal precio) || !int.TryParse(txtCantidad.Text, out int cantidad))
            {
                MessageBox.Show("Por favor, ingresa valores numéricos válidos.", "Error Interno", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (precio <= 0 || cantidad < 0)
            {
                MessageBox.Show("El Precio debe ser mayor a 0 y la Cantidad no puede ser negativa.", "Valores Inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true; // Todos los campos son válidos

        }

        // Vaciar campo cuando se busque
        private bool ValidarCamposConsulta()
        {
            if (string.IsNullOrWhiteSpace(txtCodBuscar.Text))
            {
                MessageBox.Show("Por favor, ingresa un código para realizar la búsqueda.", "Campo Vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;

        }



    }
}
