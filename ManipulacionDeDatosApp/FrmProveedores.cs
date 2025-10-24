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
    public partial class FrmProveedores : Form
    {
        public FrmProveedores()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-KC4QIBA;Initial Catalog=PracticaBD;Integrated Security=True;"))
            {
                connection.Open();
                string queryProveedores = "SELECT * FROM Proveedores;";

                using (SqlCommand cmd = new SqlCommand(queryProveedores, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgProveedores.DataSource = dt;
                }
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId2.Text))
            {
                MessageBox.Show("Por favor, ingrese el ProveedorID a actualizar.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNombre2.Text))
            {
                MessageBox.Show("Por favor, complete el Nombre.");
                return;
            }
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-KC4QIBA;Initial Catalog=PracticaBD;Integrated Security=True;"))
            {
                connection.Open();
                string updateQuery = "UPDATE Proveedores SET NombreProveedor = @NombreProveedor, CorreoElectronico = @CorreoElectronico, Telefono = @Telefono, Direccion = @Direccion WHERE ProveedorID = @ProveedorID;";
                using (SqlCommand cmd = new SqlCommand(updateQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@ProveedorID", txtId2.Text);
                    cmd.Parameters.AddWithValue("@NombreProveedor", txtNombre2.Text);
                    cmd.Parameters.AddWithValue("@CorreoElectronico", txtCorreo2.Text);
                    cmd.Parameters.AddWithValue("@Telefono", txtTelefono2.Text);
                    cmd.Parameters.AddWithValue("@Direccion", txtDireccion2.Text);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
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
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId3.Text))
            {
                MessageBox.Show("Por favor, ingrese el ProveedorID a eliminar.");
                return;
            }
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-KC4QIBA;Initial Catalog=PracticaBD;Integrated Security=True;"))
            {
                connection.Open();
                string deleteQuery = "DELETE FROM Proveedores WHERE ProveedorID = @ProveedorID;";
                using (SqlCommand cmd = new SqlCommand(deleteQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@ProveedorID", txtId3.Text);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
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
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre1.Text))
            {
                MessageBox.Show("Por favor, complete el Nombre.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-KC4QIBA;Initial Catalog=PracticaBD;Integrated Security=True;"))
            {
                connection.Open();

                // Obtener el próximo ProveedorID
                string maxIdQuery = "SELECT ISNULL(MAX(ProveedorID), 0) + 1 FROM Proveedores;";
                int nextId;
                using (SqlCommand maxCmd = new SqlCommand(maxIdQuery, connection))
                {
                    nextId = (int)maxCmd.ExecuteScalar();
                }

                string insertQuery = "INSERT INTO Proveedores (ProveedorID, NombreProveedor, CorreoElectronico, Telefono, Direccion) VALUES (@ProveedorID, @NombreProveedor, @CorreoElectronico, @Telefono, @Direccion);";
                using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@ProveedorID", nextId);
                    cmd.Parameters.AddWithValue("@NombreProveedor", txtNombre1.Text);
                    cmd.Parameters.AddWithValue("@CorreoElectronico", txtCorreo1.Text);
                    cmd.Parameters.AddWithValue("@Telefono", txtTelefono1.Text);
                    cmd.Parameters.AddWithValue("@Direccion", txtDireccion1.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Proveedor agregado exitosamente.");
                    // Limpiar los campos después de insertar
                    txtNombre1.Text = "";
                    txtCorreo1.Text = "";
                    txtTelefono1.Text = "";
                    txtDireccion1.Text = "";
                    // Recargar los datos en el DataGridView
                    btnCargar_Click(sender, e);
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            
        }
    }
}
