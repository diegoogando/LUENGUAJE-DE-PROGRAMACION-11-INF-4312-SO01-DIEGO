using System;
using System.Linq;
using System.Runtime.Versioning;
using System.Windows.Forms;
using ManipulacionDeDatosApp.Models;

namespace ManipulacionDeDatosApp
{
    [SupportedOSPlatform("windows")]
    public partial class FrmClientes : Form
    {
        private readonly PracticaBDContext _context;

        public FrmClientes()
        {
            InitializeComponent();
            _context = new PracticaBDContext();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            var clientes = _context.Clientes.ToList();
            dgClientes.DataSource = clientes;
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            btnCargar_Click(sender, e);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            // Calcular el siguiente ID disponible
            int nextId = _context.Clientes.Any()
                ? _context.Clientes.Max(c => c.ClienteId) + 1
                : 1;

            var cliente = new Cliente
            {
                ClienteId = nextId,
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Email = txtCorreo.Text,
                Telefono = txtTelefono.Text,
                Direccion = txtDireccion.Text
            };

            _context.Clientes.Add(cliente);
            _context.SaveChanges();

            MessageBox.Show("Cliente guardado exitosamente.");
            // Limpiar los campos después de guardar
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            // Recargar los datos en el DataGridView
            btnCargar_Click(sender, e);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Por favor, ingrese el ClienteID a eliminar.");
                return;
            }

            if (!int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show("Por favor, ingrese un ID de cliente válido.");
                return;
            }
            var cliente = _context.Clientes.Find(id);
            if (cliente != null)
            {
                _context.Clientes.Remove(cliente);
                _context.SaveChanges();
                MessageBox.Show("Cliente eliminado exitosamente.");
                // Limpiar el campo después de eliminar
                txtId.Text = "";
                // Recargar los datos en el DataGridView
                btnCargar_Click(sender, e);
            }
            else
            {
                MessageBox.Show("No se encontró un cliente con ese ClienteID.");
            }
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
                MessageBox.Show("Por favor, ingrese un ID de cliente válido.");
                return;
            }
            var cliente = _context.Clientes.Find(id);
            if (cliente != null)
            {
                cliente.Nombre = txtNombre2.Text;
                cliente.Apellido = txtApellido2.Text;
                cliente.Email = txtCorreo2.Text;
                cliente.Telefono = txtTelefono2.Text;
                cliente.Direccion = txtDireccion2.Text;
                _context.SaveChanges();
                MessageBox.Show("Cliente actualizado exitosamente.");
                // Limpiar los campos después de actualizar
                txtId2.Text = "";
                txtNombre2.Text = "";
                txtApellido2.Text = "";
                txtCorreo2.Text = "";
                txtTelefono2.Text = "";
                txtDireccion2.Text = "";
                // Recargar los datos en el DataGridView
                btnCargar_Click(sender, e);
            }
            else
            {
                MessageBox.Show("No se encontró un cliente con ese ClienteID.");
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _context.Dispose();
            base.OnFormClosed(e);
        }
    }
}