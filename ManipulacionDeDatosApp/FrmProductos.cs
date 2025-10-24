using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManipulacionDeDatosApp
{
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();
            LoadComboBoxes();
        }

        private void LoadComboBoxes()
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-KC4QIBA;Initial Catalog=PracticaBD;Integrated Security=True;"))
            {
                connection.Open();

                // Load Categorias
                string queryCategorias = "SELECT CategoriaID, NombreCategoria FROM Categorias;";
                using (SqlCommand cmd = new SqlCommand(queryCategorias, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    cbCategoria1.DataSource = dt;
                    cbCategoria1.DisplayMember = "NombreCategoria";
                    cbCategoria1.ValueMember = "CategoriaID";
                    cbCategoria2.DataSource = dt.Copy();
                    cbCategoria2.DisplayMember = "NombreCategoria";
                    cbCategoria2.ValueMember = "CategoriaID";
                }

                // Load Proveedores
                string queryProveedores = "SELECT ProveedorID, NombreProveedor FROM Proveedores;";
                using (SqlCommand cmd = new SqlCommand(queryProveedores, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    cbProveedor1.DataSource = dt;
                    cbProveedor1.DisplayMember = "NombreProveedor";
                    cbProveedor1.ValueMember = "ProveedorID";
                    cbProveedor2.DataSource = dt.Copy();
                    cbProveedor2.DisplayMember = "NombreProveedor";
                    cbProveedor2.ValueMember = "ProveedorID";
                }
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-KC4QIBA;Initial Catalog=PracticaBD;Integrated Security=True;"))
            {
                connection.Open();
                string queryProductos = "SELECT * FROM Productos;";

                using (SqlCommand cmd = new SqlCommand(queryProductos, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgProductos.DataSource = dt;
                }
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId2.Text))
            {
                MessageBox.Show("Por favor, ingrese el ProductoID a actualizar.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNombre2.Text))
            {
                MessageBox.Show("Por favor, complete el Nombre.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPrecio2.Text))
            {
                MessageBox.Show("Por favor, complete el Precio.");
                return;
            }
            if (cbCategoria2.SelectedValue == null)
            {
                MessageBox.Show("Por favor, seleccione una Categoría.");
                return;
            }
            if (cbProveedor2.SelectedValue == null)
            {
                MessageBox.Show("Por favor, seleccione un Proveedor.");
                return;
            }
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-KC4QIBA;Initial Catalog=PracticaBD;Integrated Security=True;"))
            {
                connection.Open();
                string updateQuery = "UPDATE Productos SET NombreProducto = @NombreProducto, Precio = @Precio, CategoriaID = @CategoriaID, ProveedorID = @ProveedorID WHERE ProductoID = @ProductoID;";
                using (SqlCommand cmd = new SqlCommand(updateQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@ProductoID", txtId2.Text);
                    cmd.Parameters.AddWithValue("@NombreProducto", txtNombre2.Text);
                    cmd.Parameters.AddWithValue("@Precio", decimal.Parse(txtPrecio2.Text));
                    cmd.Parameters.AddWithValue("@CategoriaID", cbCategoria2.SelectedValue);
                    cmd.Parameters.AddWithValue("@ProveedorID", cbProveedor2.SelectedValue);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
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
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId3.Text))
            {
                MessageBox.Show("Por favor, ingrese el ProductoID a eliminar.");
                return;
            }
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-KC4QIBA;Initial Catalog=PracticaBD;Integrated Security=True;"))
            {
                connection.Open();
                string deleteQuery = "DELETE FROM Productos WHERE ProductoID = @ProductoID;";
                using (SqlCommand cmd = new SqlCommand(deleteQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@ProductoID", txtId3.Text);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
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
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre1.Text))
            {
                MessageBox.Show("Por favor, complete el Nombre.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPrecio1.Text))
            {
                MessageBox.Show("Por favor, complete el Precio.");
                return;
            }
            if (cbCategoria1.SelectedValue == null)
            {
                MessageBox.Show("Por favor, seleccione una Categoría.");
                return;
            }
            if (cbProveedor1.SelectedValue == null)
            {
                MessageBox.Show("Por favor, seleccione un Proveedor.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-KC4QIBA;Initial Catalog=PracticaBD;Integrated Security=True;"))
            {
                connection.Open();

                // Obtener el próximo ProductoID
                string maxIdQuery = "SELECT ISNULL(MAX(ProductoID), 0) + 1 FROM Productos;";
                int nextId;
                using (SqlCommand maxCmd = new SqlCommand(maxIdQuery, connection))
                {
                    nextId = (int)maxCmd.ExecuteScalar();
                }

                string insertQuery = "INSERT INTO Productos (ProductoID, NombreProducto, Precio, CategoriaID, ProveedorID) VALUES (@ProductoID, @NombreProducto, @Precio, @CategoriaID, @ProveedorID);";
                using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@ProductoID", nextId);
                    cmd.Parameters.AddWithValue("@NombreProducto", txtNombre1.Text);
                    cmd.Parameters.AddWithValue("@Precio", decimal.Parse(txtPrecio1.Text));
                    cmd.Parameters.AddWithValue("@CategoriaID", cbCategoria1.SelectedValue);
                    cmd.Parameters.AddWithValue("@ProveedorID", cbProveedor1.SelectedValue);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Producto agregado exitosamente.");
                    // Limpiar los campos después de insertar
                    txtNombre1.Text = "";
                    txtPrecio1.Text = "";
                    cbCategoria1.SelectedIndex = -1;
                    cbProveedor1.SelectedIndex = -1;
                    // Recargar los datos en el DataGridView
                    btnCargar_Click(sender, e);
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {

        }

        private void cbCategoria1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbProveedor2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
