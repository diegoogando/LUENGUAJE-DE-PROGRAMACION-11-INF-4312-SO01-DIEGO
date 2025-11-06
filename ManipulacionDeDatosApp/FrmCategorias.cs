using ManipulacionDeDatosApp.Models;
using System;
using System.Linq;
using System.Runtime.Versioning;
using System.Windows.Forms;

namespace ManipulacionDeDatosApp
{
    [SupportedOSPlatform("windows")]
    public partial class FrmCategorias : Form
    {
        private readonly PracticaBDContext _context;

        public FrmCategorias()
        {
            InitializeComponent();
            _context = new PracticaBDContext();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            var categorias = _context.Categorias.ToList();
            dgCategorias.DataSource = categorias;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId2.Text))
            {
                MessageBox.Show("Por favor, ingrese la CategoriasID a actualizar.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNombre2.Text))
            {
                MessageBox.Show("Por favor, complete el Nombre.");
                return;
            }

            if (!int.TryParse(txtId2.Text, out int id))
            {
                MessageBox.Show("Por favor, ingrese un ID de categoría válido.");
                return;
            }

            var categoria = _context.Categorias.Find(id);
            if (categoria != null)
            {
                categoria.NombreCategoria = txtNombre2.Text;
                _context.SaveChanges();
                MessageBox.Show("Categoría actualizada exitosamente.");
                // Limpiar los campos después de actualizar
                txtId2.Text = "";
                txtNombre2.Text = "";
                // Recargar los datos en el DataGridView
                btnCargar_Click(sender, e);
            }
            else
            {
                MessageBox.Show("No se encontró una categoría con ese CategoriaID.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId3.Text))
            {
                MessageBox.Show("Por favor, ingrese la CategoriasID a eliminar.");
                return;
            }

            if (!int.TryParse(txtId3.Text, out int id))
            {
                MessageBox.Show("Por favor, ingrese un ID de categoría válido.");
                return;
            }
            var categoria = _context.Categorias.Find(id);
            if (categoria != null)
            {
                _context.Categorias.Remove(categoria);
                _context.SaveChanges();
                MessageBox.Show("Categoría eliminada exitosamente.");
                // Limpiar el campo después de eliminar
                txtId3.Text = "";
                // Recargar los datos en el DataGridView
                btnCargar_Click(sender, e);
            }
            else
            {
                MessageBox.Show("No se encontró una categoría con ese CategoriaID.");
            }
        }

       private void btnGuardar_Click(object sender, EventArgs e)
{
    if (string.IsNullOrWhiteSpace(txtNombre1.Text))
    {
        MessageBox.Show("Por favor, complete el Nombre.");
        return;
    }

    try
    {
        // Calcular el siguiente ID disponible
        int nextId = _context.Categorias.Any()
            ? _context.Categorias.Max(c => c.CategoriaId) + 1
            : 1;

        // Crear la nueva categoría
        var categoria = new Categoria
        {
            CategoriaId = nextId,
            NombreCategoria = txtNombre1.Text
        };

        // Agregar y guardar
        _context.Categorias.Add(categoria);
        _context.SaveChanges();

        MessageBox.Show("Categoría agregada exitosamente.");

        // Limpiar el campo después de insertar
        txtNombre1.Text = "";

        // Recargar los datos en el DataGridView
        btnCargar_Click(sender, e);
    }
    catch (Exception ex)
    {
        MessageBox.Show($"Ocurrió un error al guardar la categoría: {ex.Message}");
    }
}

        private void FrmCategorias_Load(object sender, EventArgs e)
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