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
    public partial class FrmCategorias : Form
    {
        public FrmCategorias()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-KC4QIBA;Initial Catalog=PracticaBD;Integrated Security=True;"))
            {
                connection.Open();
                string queryClientes = "SELECT * FROM Categorias;";

                using (SqlCommand cmd = new SqlCommand(queryClientes, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgCategorias.DataSource = dt;
                }
            }

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
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-KC4QIBA;Initial Catalog=PracticaBD;Integrated Security=True;"))
            {
                connection.Open();
                string updateQuery = "UPDATE Categorias SET NombreCategoria = @NombreCategoria WHERE CategoriaID = @CategoriaID;";
                using (SqlCommand cmd = new SqlCommand(updateQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@CategoriaID", txtId2.Text);
                    cmd.Parameters.AddWithValue("@NombreCategoria", txtNombre2.Text);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
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
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId3.Text))
            {
                MessageBox.Show("Por favor, ingrese la CategoriasID a eliminar.");
                return;
            }
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-KC4QIBA;Initial Catalog=PracticaBD;Integrated Security=True;"))
            {
                connection.Open();
                string deleteQuery = "DELETE FROM Categorias WHERE CategoriaID = @CategoriaID;";
                using (SqlCommand cmd = new SqlCommand(deleteQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@CategoriaID", txtId3.Text);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
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

                // Obtener el próximo CategoriaID
                string maxIdQuery = "SELECT ISNULL(MAX(CategoriaID), 0) + 1 FROM Categorias;";
                int nextId;
                using (SqlCommand maxCmd = new SqlCommand(maxIdQuery, connection))
                {
                    nextId = (int)maxCmd.ExecuteScalar();
                }

                string insertQuery = "INSERT INTO Categorias (CategoriaID, NombreCategoria) VALUES (@CategoriaID, @NombreCategoria);";
                using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@CategoriaID", nextId);
                    cmd.Parameters.AddWithValue("@NombreCategoria", txtNombre1.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Categoría agregada exitosamente.");
                    // Limpiar el campo después de insertar
                    txtNombre1.Text = "";
                    // Recargar los datos en el DataGridView
                    btnCargar_Click(sender, e);
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {

        }
    }
}

