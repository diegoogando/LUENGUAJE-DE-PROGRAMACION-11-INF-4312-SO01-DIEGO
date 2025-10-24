using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ManipulacionDeDatosApp
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-KC4QIBA;Initial Catalog=PracticaBD;Integrated Security=True;"))
            {
                connection.Open();
                string queryClientes = "SELECT * FROM Clientes;";

                using (SqlCommand cmd = new SqlCommand(queryClientes, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgClientes.DataSource = dt;
                }
            }

        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Por favor, complete el Nombre.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                MessageBox.Show("Por favor, complete el Correo.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Por favor, complete el Teléfono.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("Por favor, complete la Dirección.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-KC4QIBA;Initial Catalog=PracticaBD;Integrated Security=True;"))
            {
                connection.Open();

                // Obtener el próximo ID disponible
                string maxIdQuery = "SELECT ISNULL(MAX(ClienteID), 0) + 1 FROM Clientes;";
                int newId;
                using (SqlCommand maxIdCmd = new SqlCommand(maxIdQuery, connection))
                {
                    newId = (int)maxIdCmd.ExecuteScalar();
                }

                string insertQuery = "INSERT INTO Clientes (ClienteID, NombreCompleto, CorreoElectronico, Telefono, Direccion) " +
                    "VALUES (@ClienteID, @NombreCompleto, @CorreoElectronico, @Telefono, @Direccion);";

                using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@ClienteID", newId);
                    cmd.Parameters.AddWithValue("@NombreCompleto", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@CorreoElectronico", txtCorreo.Text);
                    cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
                    cmd.Parameters.AddWithValue("@Direccion", txtDireccion.Text);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cliente guardado exitosamente.");
                        // Limpiar los campos después de guardar
                        txtNombre.Text = "";
                        txtCorreo.Text = "";
                        txtTelefono.Text = "";
                        txtDireccion.Text = "";
                        // Recargar los datos en el DataGridView
                        btnCargar_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Error al guardar el cliente.");
                    }
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Por favor, ingrese el ClienteID a eliminar.");
                return;
            }
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-KC4QIBA;Initial Catalog=PracticaBD;Integrated Security=True;"))
            {
                connection.Open();
                string deleteQuery = "DELETE FROM Clientes WHERE ClienteID = @ClienteID;";
                using (SqlCommand cmd = new SqlCommand(deleteQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@ClienteID", txtId.Text);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
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
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId2.Text))
            {
                MessageBox.Show("Por favor, ingrese el ClienteID a actualizar.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNombre2.Text))
            {
                MessageBox.Show("Por favor, complete el Nombre.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtCorreo2.Text))
            {
                MessageBox.Show("Por favor, complete el Correo.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtTelefono2.Text))
            {
                MessageBox.Show("Por favor, complete el Teléfono.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtDireccion2.Text))
            {
                MessageBox.Show("Por favor, complete la Dirección.");
                return;
            }
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-KC4QIBA;Initial Catalog=PracticaBD;Integrated Security=True;"))
            {
                connection.Open();
                string updateQuery = "UPDATE Clientes SET NombreCompleto = @NombreCompleto, CorreoElectronico = @CorreoElectronico, " +
                    "Telefono = @Telefono, Direccion = @Direccion WHERE ClienteID = @ClienteID;";
                using (SqlCommand cmd = new SqlCommand(updateQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@ClienteID", txtId2.Text);
                    cmd.Parameters.AddWithValue("@NombreCompleto", txtNombre2.Text);
                    cmd.Parameters.AddWithValue("@CorreoElectronico", txtCorreo2.Text);
                    cmd.Parameters.AddWithValue("@Telefono", txtTelefono2.Text);
                    cmd.Parameters.AddWithValue("@Direccion", txtDireccion2.Text);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cliente actualizado exitosamente.");
                        // Limpiar los campos después de actualizar
                        txtId.Text = "";
                        txtNombre.Text = "";
                        txtCorreo.Text = "";
                        txtTelefono.Text = "";
                        txtDireccion.Text = "";
                        // Recargar los datos en el DataGridView
                        btnCargar_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("No se encontró un cliente con ese ClienteID.");
                    }
                }
            }
    }
}
}

