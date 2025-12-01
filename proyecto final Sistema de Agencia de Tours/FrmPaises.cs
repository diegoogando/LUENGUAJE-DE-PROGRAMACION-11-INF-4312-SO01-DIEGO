using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;
// (sin usings adicionales de prueba de DB)

namespace proyecto_final_Sistema_de_Agencia_de_Tours
{
    public partial class FrmPaises : Form
    {
        public FrmPaises()
        {
            InitializeComponent();
        }

        private void FrmPaises_Load(object sender, EventArgs e)
        {
            // Attach DataError handler to avoid default exception dialog
            dgvPaises.DataError -= dgvPaises_DataError;
            dgvPaises.DataError += dgvPaises_DataError;
            LoadData();
        }

        // (Se eliminó el chequeo temporal de conexión a la base de datos)

        private void LoadData()
        {
            try
            {
                using (var db = new AgenciaToursDBEntities())
                {
                    var list = db.Pais.AsNoTracking().ToList();
                    System.Diagnostics.Debug.WriteLine($"[FrmPaises] Paises loaded: {list.Count}");

                    // Clear previous binding and columns to avoid stale state
                    dgvPaises.DataSource = null;
                    dgvPaises.Columns.Clear();

                    // Create explicit columns to avoid lazy-loading navigation properties
                    dgvPaises.AutoGenerateColumns = false;
                    var colId = new DataGridViewTextBoxColumn
                    {
                        Name = "PaisId",
                        HeaderText = "País ID",
                        DataPropertyName = "PaisId",
                        ReadOnly = true
                    };
                    var colNombre = new DataGridViewTextBoxColumn
                    {
                        Name = "Nombre",
                        HeaderText = "Nombre",
                        DataPropertyName = "Nombre",
                        ReadOnly = false
                    };
                    dgvPaises.Columns.Add(colId);
                    dgvPaises.Columns.Add(colNombre);

                    var bs = new BindingSource();
                    bs.DataSource = list;
                    dgvPaises.DataSource = bs;
                    dgvPaises.Refresh();

                    // Log to file for debugging
                    DgvLog($"LoadData: Paises loaded={list.Count}");
                    if (list.Count > 0)
                    {
                        var first = list[0];
                        DgvLog($"First item type: {first.GetType().FullName}");
                        DgvLog($"First item PaisId={first.PaisId}, Nombre={first.Nombre}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputs()
        {
            txtPaisId.Clear();
            txtNombre.Clear();
        }

        private void dgvPaises_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvPaises.SelectedRows.Count == 0) return;

                DataGridViewRow selectedRow = dgvPaises.SelectedRows[0];
                if (selectedRow == null || selectedRow.IsNewRow) return;

                string paisIdText = null;
                string nombreText = null;

                // Try by column name first (if auto-generated columns exist)
                if (dgvPaises.Columns.Contains("PaisId") && selectedRow.Cells["PaisId"].Value != null)
                    paisIdText = selectedRow.Cells["PaisId"].Value.ToString();

                if (dgvPaises.Columns.Contains("Nombre") && selectedRow.Cells["Nombre"].Value != null)
                    nombreText = selectedRow.Cells["Nombre"].Value.ToString();

                // If not available via cells, try the DataBoundItem's properties via reflection
                if ((paisIdText == null || nombreText == null) && selectedRow.DataBoundItem != null)
                {
                    var item = selectedRow.DataBoundItem;
                    var t = item.GetType();

                    if (paisIdText == null)
                    {
                        var prop = t.GetProperty("PaisId");
                        if (prop != null)
                        {
                            var val = prop.GetValue(item);
                            if (val != null) paisIdText = val.ToString();
                        }
                    }

                    if (nombreText == null)
                    {
                        var prop = t.GetProperty("Nombre");
                        if (prop != null)
                        {
                            var val = prop.GetValue(item);
                            if (val != null) nombreText = val.ToString();
                        }
                    }
                }

                if (!string.IsNullOrEmpty(paisIdText)) txtPaisId.Text = paisIdText; else txtPaisId.Clear();
                if (!string.IsNullOrEmpty(nombreText)) txtNombre.Text = nombreText; else txtNombre.Clear();

                // Log selection details
                DgvLog($"SelectionChanged: PaisId={paisIdText ?? "(null)"}, Nombre={nombreText ?? "(null)"}, RowIndex={selectedRow.Index}");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error en SelectionChanged: " + ex.Message);
                DgvLog("SelectionChanged Exception: " + ex.ToString());
            }
        }

        private void dgvPaises_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Log the detailed exception to file and suppress the default dialog
            try
            {
                DgvLog("DataError Exception: " + (e.Exception?.ToString() ?? "(null)"));
            }
            catch { }
            e.ThrowException = false;
        }

        // Append debug lines about DataGridView to a file in the app folder
        private void DgvLog(string message)
        {
            try
            {
                var path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dgv_debug.txt");
                var line = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {message}\r\n";
                System.IO.File.AppendAllText(path, line);
            }
            catch
            {
                // ignore logging failures
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese el nombre del país.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var db = new AgenciaToursDBEntities())
                {
                    var nombrePais = txtNombre.Text.Trim();
                    if (db.Pais.Any(p => p.Nombre.Equals(nombrePais, StringComparison.OrdinalIgnoreCase)))
                    {
                        MessageBox.Show("Ya existe un país con ese nombre.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var pais = new Pais { Nombre = nombrePais };
                    db.Pais.Add(pais);
                    db.SaveChanges();
                }
                LoadData();
                ClearInputs();
                MessageBox.Show("País agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar país: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPaisId.Text))
            {
                MessageBox.Show("Seleccione un país para actualizar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese el nombre del país.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var db = new AgenciaToursDBEntities())
                {
                    int paisId = int.Parse(txtPaisId.Text);
                    var pais = db.Pais.Find(paisId);
                    if (pais != null)
                    {
                        pais.Nombre = txtNombre.Text.Trim();
                        db.SaveChanges();
                    }
                }
                LoadData();
                ClearInputs();
                MessageBox.Show("País actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar país: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPaisId.Text))
            {
                MessageBox.Show("Seleccione un país para eliminar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Está seguro de eliminar este país?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (var db = new AgenciaToursDBEntities())
                    {
                        int paisId = int.Parse(txtPaisId.Text);
                        var pais = db.Pais.Find(paisId);
                        if (pais != null)
                        {
                            db.Pais.Remove(pais);
                            db.SaveChanges();
                        }
                    }
                    LoadData();
                    ClearInputs();
                    MessageBox.Show("País eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar país: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            try
            {
                var saveFileDialog = new SaveFileDialog { Filter = "CSV files (*.csv)|*.csv", FileName = "Paises.csv" };
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (var writer = new StreamWriter(saveFileDialog.FileName))
                    using (var db = new AgenciaToursDBEntities())
                    {
                        writer.WriteLine("PaisId,Nombre");
                        foreach (var pais in db.Pais.ToList())
                        {
                            writer.WriteLine($"{pais.PaisId},{pais.Nombre}");
                        }
                    }
                    MessageBox.Show("Datos exportados exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}