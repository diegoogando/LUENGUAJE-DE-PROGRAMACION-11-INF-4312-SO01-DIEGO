using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace proyecto_final_Sistema_de_Agencia_de_Tours
{
    public partial class FrmDestinos : Form
    {
        public FrmDestinos()
        {
            InitializeComponent();
        }

        private void FrmDestinos_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using (var db = new AgenciaToursDBEntities())
                {
                    // Cargar Países en ComboBox
                    var paises = db.Pais.ToList();
                    System.Diagnostics.Debug.WriteLine($"[FrmDestinos] Paises loaded: {paises.Count}");
                    cmbPais.DataSource = paises;
                    cmbPais.DisplayMember = "Nombre";
                    cmbPais.ValueMember = "PaisId";

                    // Cargar Destinos en DataGridView (proyección a objetos simples)
                    var destinos = db.Destino.Include(d => d.Pais).Select(d => new
                    {
                        d.DestinoId,
                        d.Nombre,
                        Pais = d.Pais != null ? d.Pais.Nombre : "",
                        d.DuracionDias,
                        d.DuracionHoras,
                        d.PaisId // Oculto, para uso interno
                    }).ToList();
                    System.Diagnostics.Debug.WriteLine($"[FrmDestinos] Destinos loaded: {destinos.Count}");
                    
                    // Prepare explicit columns to avoid lazy-loading via proxies
                    dgvDestinos.DataSource = null;
                    dgvDestinos.Columns.Clear();
                    dgvDestinos.AutoGenerateColumns = false;

                    var cId = new DataGridViewTextBoxColumn { Name = "DestinoId", HeaderText = "ID", DataPropertyName = "DestinoId", ReadOnly = true };
                    var cNombre = new DataGridViewTextBoxColumn { Name = "Nombre", HeaderText = "Nombre", DataPropertyName = "Nombre" };
                    var cPais = new DataGridViewTextBoxColumn { Name = "Pais", HeaderText = "País", DataPropertyName = "Pais" };
                    var cDias = new DataGridViewTextBoxColumn { Name = "DuracionDias", HeaderText = "Días", DataPropertyName = "DuracionDias" };
                    var cHoras = new DataGridViewTextBoxColumn { Name = "DuracionHoras", HeaderText = "Horas", DataPropertyName = "DuracionHoras" };
                    var cPaisId = new DataGridViewTextBoxColumn { Name = "PaisId", HeaderText = "PaisId", DataPropertyName = "PaisId", Visible = false };

                    dgvDestinos.Columns.AddRange(new DataGridViewColumn[] { cId, cNombre, cPais, cDias, cHoras, cPaisId });

                    var bs = new BindingSource();
                    bs.DataSource = destinos;
                    dgvDestinos.DataSource = bs;
                    dgvDestinos.Refresh();

                    System.IO.File.AppendAllText(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dgv_debug_destinos.txt"), $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] LoadData: Destinos loaded={destinos.Count}\r\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputs()
        {
            txtDestinoId.Clear();
            txtNombre.Clear();
            cmbPais.SelectedIndex = -1;
            nudDuracionDias.Value = 0;
            nudDuracionHoras.Value = 0;
        }

        private void dgvDestinos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvDestinos.SelectedRows.Count > 0)
                {
                    var selectedRow = dgvDestinos.SelectedRows[0];

                    if (selectedRow.Cells["DestinoId"].Value != null)
                        txtDestinoId.Text = selectedRow.Cells["DestinoId"].Value.ToString();

                    if (selectedRow.Cells["Nombre"].Value != null)
                        txtNombre.Text = selectedRow.Cells["Nombre"].Value.ToString();

                    // Pais comes from a separate column 'Pais' in the grid
                    if (selectedRow.Cells["Pais"].Value != null)
                    {
                        var paisNombre = selectedRow.Cells["Pais"].Value.ToString();
                        // try to set cmbPais by matching the name
                        for (int i = 0; i < cmbPais.Items.Count; i++)
                        {
                            var item = cmbPais.Items[i];
                            var prop = item.GetType().GetProperty("Nombre");
                            if (prop != null)
                            {
                                var val = prop.GetValue(item)?.ToString();
                                if (val == paisNombre)
                                {
                                    cmbPais.SelectedIndex = i;
                                    break;
                                }
                            }
                        }
                    }

                    if (selectedRow.Cells["DuracionDias"].Value != null)
                        nudDuracionDias.Value = Convert.ToDecimal(selectedRow.Cells["DuracionDias"].Value);

                    if (selectedRow.Cells["DuracionHoras"].Value != null)
                        nudDuracionHoras.Value = Convert.ToDecimal(selectedRow.Cells["DuracionHoras"].Value);

                    System.IO.File.AppendAllText(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dgv_debug_destinos.txt"), $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] SelectionChanged: RowIndex={selectedRow.Index}, DestinoId={txtDestinoId.Text}\r\n");
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error en SelectionChanged: " + ex.Message);
                System.IO.File.AppendAllText(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dgv_debug_destinos.txt"), $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] SelectionChanged Exception: {ex}\r\n");
            }
        }

        private void dgvDestinos_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Log the error and suppress the default dialog
            System.Diagnostics.Debug.WriteLine($"DataError at ({e.RowIndex}, {e.ColumnIndex}): {e.Exception}");
            System.IO.File.AppendAllText(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dgv_debug_destinos.txt"), $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] DataError at ({e.RowIndex}, {e.ColumnIndex}): {e.Exception}\r\n");
            e.ThrowException = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || cmbPais.SelectedItem == null)
            {
                MessageBox.Show("Ingrese el nombre del destino y seleccione un país.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (nudDuracionDias.Value == 0 && nudDuracionHoras.Value == 0)
            {
                MessageBox.Show("La duración no puede ser cero. Especifique días u horas.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var db = new AgenciaToursDBEntities())
                {
                    var nombreDestino = txtNombre.Text.Trim();
                    int paisId = (int)cmbPais.SelectedValue;

                    if (db.Destino.Any(d => d.Nombre.Equals(nombreDestino, StringComparison.OrdinalIgnoreCase) && d.PaisId == paisId))
                    {
                        MessageBox.Show("Ya existe un destino con ese nombre en el país seleccionado.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var destino = new Destino
                    {
                        Nombre = nombreDestino,
                        PaisId = paisId,
                        DuracionDias = (int)nudDuracionDias.Value,
                        DuracionHoras = (int)nudDuracionHoras.Value
                    };

                    db.Destino.Add(destino);
                    db.SaveChanges();
                }
                LoadData();
                ClearInputs();
                MessageBox.Show("Destino agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar destino: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDestinoId.Text))
            {
                MessageBox.Show("Seleccione un destino para actualizar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Otras validaciones
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || cmbPais.SelectedItem == null)
            {
                MessageBox.Show("Complete todos los campos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (nudDuracionDias.Value == 0 && nudDuracionHoras.Value == 0)
            {
                MessageBox.Show("La duración no puede ser cero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var db = new AgenciaToursDBEntities())
                {
                    int destinoId = int.Parse(txtDestinoId.Text);
                    var destino = db.Destino.Find(destinoId);
                    if (destino != null)
                    {
                        destino.Nombre = txtNombre.Text.Trim();
                        destino.PaisId = (int)cmbPais.SelectedValue;
                        destino.DuracionDias = (int)nudDuracionDias.Value;
                        destino.DuracionHoras = (int)nudDuracionHoras.Value;
                        db.SaveChanges();
                    }
                }
                LoadData();
                ClearInputs();
                MessageBox.Show("Destino actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar destino: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDestinoId.Text))
            {
                MessageBox.Show("Seleccione un destino para eliminar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Está seguro de eliminar este destino?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (var db = new AgenciaToursDBEntities())
                    {
                        int destinoId = int.Parse(txtDestinoId.Text);
                        var destino = db.Destino.Find(destinoId);
                        if (destino != null)
                        {
                            db.Destino.Remove(destino);
                            db.SaveChanges();
                        }
                    }
                    LoadData();
                    ClearInputs();
                    MessageBox.Show("Destino eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar destino: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            try
            {
                var saveFileDialog = new SaveFileDialog { Filter = "CSV files (*.csv)|*.csv", FileName = "Destinos.csv" };
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (var writer = new StreamWriter(saveFileDialog.FileName))
                    using (var db = new AgenciaToursDBEntities())
                    {
                        writer.WriteLine("DestinoId,Nombre,Pais,DuracionDias,DuracionHoras");
                        foreach (var destino in db.Destino.Include(d => d.Pais).ToList())
                        {
                            writer.WriteLine($"{destino.DestinoId},{destino.Nombre},{destino.Pais.Nombre},{destino.DuracionDias},{destino.DuracionHoras}");
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