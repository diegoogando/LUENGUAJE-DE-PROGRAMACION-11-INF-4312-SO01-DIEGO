using System;
using System.Linq;
using System.Runtime.Versioning;
using System.Windows.Forms;
using ManipulacionDeDatosApp.Models;

namespace ManipulacionDeDatosApp
{
    [SupportedOSPlatform("windows")]
    public partial class FrmProductos : Form
    {
        private readonly PracticaBDContext _context;

        public FrmProductos()
        {
            InitializeComponent();
            _context = new PracticaBDContext();
            LoadComboBoxes();
        }

        private void LoadComboBoxes()
        {
            // Load Categorias
            var categorias = _context.Categorias.Select(c => new { Id = c.CategoriaId, Name = c.NombreCategoria }).ToList();
            cbCategoria1.DataSource = categorias;
            cbCategoria1.DisplayMember = "Name";
            cbCategoria1.ValueMember = "Id";
            cbCategoria2.DataSource = categorias.ToList();
            cbCategoria2.DisplayMember = "Name";
            cbCategoria2.ValueMember = "Id";

            // Load Proveedores
            var proveedores = _context.Proveedores.Select(p => new { Id = p.ProveedorId, Name = p.NombreProveedor }).ToList();
            cbProveedor1.DataSource = proveedores;
            cbProveedor1.DisplayMember = "Name";
            cbProveedor1.ValueMember = "Id";
            cbProveedor2.DataSource = proveedores.ToList();
            cbProveedor2.DisplayMember = "Name";
            cbProveedor2.ValueMember = "Id";
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            var productos = _context.Productos.ToList();
            dgProductos.DataSource = productos;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId2.Text) ||
                string.IsNullOrWhiteSpace(txtNombre2.Text) ||
                string.IsNullOrWhiteSpace(txtPrecio2.Text) ||
                cbCategoria2.SelectedValue == null ||
                cbProveedor2.SelectedValue == null)
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            if (!int.TryParse(txtId2.Text, out int id))
            {
                MessageBox.Show("Por favor, ingrese un ID de producto válido.");
                return;
            }
            if (!decimal.TryParse(txtPrecio2.Text, out decimal precio))
            {
                MessageBox.Show("Por favor, ingrese un precio válido.");
                return;
            }
            var producto = _context.Productos.Find(id);
            if (producto != null)
            {
                producto.NombreProducto = txtNombre2.Text;
                producto.Precio = decimal.Parse(txtPrecio2.Text);
                producto.CategoriaId = (int)cbCategoria2.SelectedValue;
                producto.ProveedorId = (int)cbProveedor2.SelectedValue;
                _context.SaveChanges();
                MessageBox.Show("Producto actualizado exitosamente.");
                // Limpiar los campos después de actualizar
                txtId2.Text = "";
                txtNombre2.Text = "";
                txtPrecio2.Text = "";
                cbCategoria2.SelectedIndex = -1;
                cbProveedor2.SelectedIndex = -1;
                // Recargar los datos en el DataGridView
                btnCargar_Click(sender, e);
            }
            else
            {
                MessageBox.Show("No se encontró un producto con ese ProductoID.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId3.Text))
            {
                MessageBox.Show("Por favor, ingrese el ProductoID a eliminar.");
                return;
            }

            if (!int.TryParse(txtId3.Text, out int id))
            {
                MessageBox.Show("Por favor, ingrese un ID de producto válido.");
                return;
            }
            var producto = _context.Productos.Find(id);
            if (producto != null)
            {
                _context.Productos.Remove(producto);
                _context.SaveChanges();
                MessageBox.Show("Producto eliminado exitosamente.");
                // Limpiar el campo después de eliminar
                txtId3.Text = "";
                // Recargar los datos en el DataGridView
                btnCargar_Click(sender, e);
            }
            else
            {
                MessageBox.Show("No se encontró un producto con ese ProductoID.");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre1.Text) ||
                string.IsNullOrWhiteSpace(txtPrecio1.Text) ||
                cbCategoria1.SelectedValue == null ||
                cbProveedor1.SelectedValue == null)
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            if (!decimal.TryParse(txtPrecio1.Text, out decimal precio))
            {
                MessageBox.Show("Por favor, ingrese un precio válido.");
                return;
            }

            // Calcular el siguiente ID disponible
            int nextId = _context.Productos.Any()
                ? _context.Productos.Max(p => p.ProductoId) + 1
                : 1;

            var producto = new Producto
            {
                ProductoId = nextId,
                NombreProducto = txtNombre1.Text,
                Precio = precio,
                CategoriaId = (int)cbCategoria1.SelectedValue,
                ProveedorId = (int)cbProveedor1.SelectedValue
            };

            _context.Productos.Add(producto);
            _context.SaveChanges();

            MessageBox.Show("Producto agregado exitosamente.");
            // Limpiar los campos después de insertar
            txtNombre1.Text = "";
            txtPrecio1.Text = "";
            cbCategoria1.SelectedIndex = -1;
            cbProveedor1.SelectedIndex = -1;
            // Recargar los datos en el DataGridView
            btnCargar_Click(sender, e);
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            btnCargar_Click(sender, e);
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _context.Dispose();
            base.OnFormClosed(e);
        }
    }
}