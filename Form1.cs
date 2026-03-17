using System.Text;
using System.Text.Json;

namespace InventarioApp
{
    public partial class Form1 : Form
    {
        private List<Producto> listaProductos = new List<Producto>();

        private readonly string carpetaDatos =
            Path.Combine(Application.StartupPath, "Datos");

        private readonly string archivoJson;
        private readonly string archivoTexto;
        private readonly string archivoBinario;

        public Form1()
        {
            InitializeComponent();
            archivoJson = Path.Combine(carpetaDatos, "productos.json");
            archivoTexto = Path.Combine(carpetaDatos, "productos.txt");
            archivoBinario = Path.Combine(carpetaDatos, "productos.dat");
        }

        private void CrearCarpetaSiNoExiste()
        {
            if (!Directory.Exists(carpetaDatos))
            {
                Directory.CreateDirectory(carpetaDatos);
            }
        }
        private void MostrarDatos()
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = listaProductos.ToList();
        }
        private void CargarDesdeJson()
        {
            if (File.Exists(archivoJson))
            {
                using (FileStream fs = new FileStream(archivoJson, FileMode.Open, FileAccess.Read))
                {
                    var datos = JsonSerializer.Deserialize<List<Producto>>(fs);
                    if (datos != null)
                    {
                        listaProductos = datos;
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CrearCarpetaSiNoExiste();
            CargarDesdeJson();
            MostrarDatos();
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtId.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtPrecio.Text) ||
                string.IsNullOrWhiteSpace(txtCantidad.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return false;
            }

            if (!int.TryParse(txtId.Text, out _))
            {
                MessageBox.Show("El Id debe ser numérico.");
                return false;
            }

            if (!decimal.TryParse(txtPrecio.Text, out _))
            {
                MessageBox.Show("El precio debe ser numérico.");
                return false;
            }

            if (!int.TryParse(txtCantidad.Text, out _))
            {
                MessageBox.Show("La cantidad debe ser numérica.");
                return false;
            }

            return true;
        }

        private Producto ObtenerProductoDesdeFormulario()
        {
            return new Producto
            {
                Id = int.Parse(txtId.Text),
                Nombre = txtNombre.Text,
                Precio = decimal.Parse(txtPrecio.Text),
                Cantidad = int.Parse(txtCantidad.Text)
            };
        }

        private void GuardarEnJson()
        {
            using (FileStream fs = new FileStream(archivoJson, FileMode.Create, FileAccess.Write))
            {
                JsonSerializer.Serialize(fs, listaProductos, new JsonSerializerOptions
                {
                    WriteIndented = true
                });
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            int id = int.Parse(txtId.Text);

            if (listaProductos.Any(p => p.Id == id))
            {
                MessageBox.Show("Ya existe un producto con ese Id.");
                return;
            }

            Producto nuevo = ObtenerProductoDesdeFormulario();
            listaProductos.Add(nuevo);

            GuardarEnJson();
            MostrarDatos();

            LimpiarCampos();

            MessageBox.Show("Producto agregado correctamente.");
        }
        private void LimpiarCampos()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();
            txtCantidad.Clear();
            txtId.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            int id = int.Parse(txtId.Text);

            Producto? existente = listaProductos.FirstOrDefault(p => p.Id == id);

            if (existente == null)
            {
                MessageBox.Show("No se encontró el producto.");
                return;
            }

            existente.Nombre = txtNombre.Text;
            existente.Precio = decimal.Parse(txtPrecio.Text);
            existente.Cantidad = int.Parse(txtCantidad.Text);

            GuardarEnJson();
            MostrarDatos();
            LimpiarCampos();

            MessageBox.Show("Producto editado correctamente.");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show("Ingrese un Id válido para eliminar.");
                return;
            }

            Producto? existente = listaProductos.FirstOrDefault(p => p.Id == id);

            if (existente == null)
            {
                MessageBox.Show("No se encontró el producto.");
                return;
            }

            listaProductos.Remove(existente);

            GuardarEnJson();
            MostrarDatos();
            LimpiarCampos();

            MessageBox.Show("Producto eliminado correctamente.");
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvProductos.Rows[e.RowIndex];

                txtId.Text = fila.Cells["Id"].Value?.ToString();
                txtNombre.Text = fila.Cells["Nombre"].Value?.ToString();
                txtPrecio.Text = fila.Cells["Precio"].Value?.ToString();
                txtCantidad.Text = fila.Cells["Cantidad"].Value?.ToString();
            }
        }

        private void btnExportarTexto_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream(archivoTexto, FileMode.Create, FileAccess.Write))
            using (StreamWriter writer = new StreamWriter(fs))
            {
                writer.WriteLine("REPORTE DE PRODUCTOS");
                writer.WriteLine("---------------------");

                foreach (var producto in listaProductos)
                {
                    writer.WriteLine($"Id: {producto.Id}");
                    writer.WriteLine($"Nombre: {producto.Nombre}");
                    writer.WriteLine($"Precio: {producto.Precio}");
                    writer.WriteLine($"Cantidad: {producto.Cantidad}");
                    writer.WriteLine("---------------------");
                }
            }

            MessageBox.Show("Archivo de texto exportado correctamente.");
        }

        private void btnRespaldoBinario_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream(archivoBinario, FileMode.Create, FileAccess.Write))
            using (BinaryWriter writer = new BinaryWriter(fs))
            {
                writer.Write(listaProductos.Count);

                foreach (var producto in listaProductos)
                {
                    writer.Write(producto.Id);
                    writer.Write(producto.Nombre);
                    writer.Write(producto.Precio);
                    writer.Write(producto.Cantidad);
                }
            }

            MessageBox.Show("Respaldo binario generado correctamente.");
        }

        private void btnVistaPreviaMemoria_Click(object sender, EventArgs e)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                string json = JsonSerializer.Serialize(listaProductos, new JsonSerializerOptions
                {
                    WriteIndented = true
                });

                byte[] datos = Encoding.UTF8.GetBytes(json);
                ms.Write(datos, 0, datos.Length);

                ms.Position = 0;

                using (StreamReader reader = new StreamReader(ms))
                {
                    rtbVistaPrevia.Text = reader.ReadToEnd();
                }
            }
        }
    }

}