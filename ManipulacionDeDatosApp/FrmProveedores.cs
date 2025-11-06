using System;
using System.Linq;
using System.Runtime.Versioning;
using System.Windows.Forms;
using ManipulacionDeDatosApp.Models;

namespace ManipulacionDeDatosApp
{
    [SupportedOSPlatform("windows")]
    public partial class FrmProveedores : Form
    {
        private readonly PracticaBDContext _context;

        public FrmProveedores()
        {
            InitializeComponent();
            _context = new PracticaBDContext();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            var proveedores = _context.Proveedores.ToList();
            dgProveedores.DataSource = proveedores;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId2.Text) ||
                string.IsNullOrWhiteSpace(txtNombre2.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo2.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono2.Text) ||
                string.IsNullOrWhiteSpace(txtDireccion2.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            if (!int.TryParse(txtId2.Text, out int id))
            {
                MessageBox.Show("Por favor, ingrese un ID de proveedor válido.");
                return;
            }
            var proveedor = _context.Proveedores.Find(id);
            if (proveedor != null)
            {
                proveedor.NombreProveedor = txtNombre2.Text;
                proveedor.CorreoElectronico = txtCorreo2.Text;
                proveedor.Telefono = txtTelefono2.Text;
                proveedor.Direccion = txtDireccion2.Text;
                _context.SaveChanges();
                MessageBox.Show("Proveedor actualizado exitosamente.");
                // Limpiar los campos después de actualizar
                txtId2.Text = "";
                txtNombre2.Text = "";
                txtCorreo2.Text = "";
                txtTelefono2.Text = "";
                txtDireccion2.Text = "";
                // Recargar los datos en el DataGridView
                btnCargar_Click(sender, e);
            }
            else
            {
                MessageBox.Show("No se encontró un proveedor con ese ProveedorID.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId3.Text))
            {
                MessageBox.Show("Por favor, ingrese el ProveedorID a eliminar.");
                return;
            }

            if (!int.TryParse(txtId3.Text, out int id))
            {
                MessageBox.Show("Por favor, ingrese un ID de proveedor válido.");
                return;
            }
            var proveedor = _context.Proveedores.Find(id);
            if (proveedor != null)
            {
                _context.Proveedores.Remove(proveedor);
                _context.SaveChanges();
                MessageBox.Show("Proveedor eliminado exitosamente.");
                // Limpiar el campo después de eliminar
                txtId3.Text = "";
                // Recargar los datos en el DataGridView
                btnCargar_Click(sender, e);
            }
            else
            {
                MessageBox.Show("No se encontró un proveedor con ese ProveedorID.");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre1.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo1.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono1.Text) ||
                string.IsNullOrWhiteSpace(txtDireccion1.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            // Calcular el siguiente ID disponible
            int nextId = _context.Proveedores.Any()
                ? _context.Proveedores.Max(p => p.ProveedorId) + 1
                : 1;

            var proveedor = new Proveedore
            {
                ProveedorId = nextId,
                NombreProveedor = txtNombre1.Text,
                CorreoElectronico = txtCorreo1.Text,
                Telefono = txtTelefono1.Text,
                Direccion = txtDireccion1.Text
            };

            _context.Proveedores.Add(proveedor);
            _context.SaveChanges();

            MessageBox.Show("Proveedor agregado exitosamente.");
            // Limpiar los campos después de insertar
            txtNombre1.Text = "";
            txtCorreo1.Text = "";
            txtTelefono1.Text = "";
            txtDireccion1.Text = "";
            // Recargar los datos en el DataGridView
            btnCargar_Click(sender, e);
        }

        private void FrmProveedores_Load(object sender, EventArgs e)
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
