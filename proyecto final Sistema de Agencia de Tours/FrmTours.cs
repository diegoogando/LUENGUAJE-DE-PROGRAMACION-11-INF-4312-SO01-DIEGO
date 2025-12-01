using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace proyecto_final_Sistema_de_Agencia_de_Tours
{
    public partial class FrmTours : Form
    {
        public FrmTours()
        {
            InitializeComponent();
        }

        private void FrmTours_Load(object sender, EventArgs e)
        {
            LoadInitialData();
            LoadToursGrid();
        }

        private void LoadInitialData()
        {
            try
            {
                using (var db = new AgenciaToursDBEntities())
                {
                    var paises = db.Pais.ToList();
                    System.Diagnostics.Debug.WriteLine($"[FrmTours] Paises loaded: {paises.Count}");
                    cmbPais.DataSource = paises;
                    cmbPais.DisplayMember = "Nombre";
                    cmbPais.ValueMember = "PaisId";
                    cmbPais.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos iniciales: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbPais.SelectedValue == null)
                {
                    cmbDestino.DataSource = null;
                    return;
                }

                // Safe parse SelectedValue to int (it may be a DataRowView or other type during binding)
                if (!int.TryParse(cmbPais.SelectedValue.ToString(), out int paisId))
                {
                    cmbDestino.DataSource = null;
                    return;
                }

                using (var db = new AgenciaToursDBEntities())
                {
                    cmbDestino.DataSource = db.Destino.Where(d => d.PaisId == paisId).ToList();
                    cmbDestino.DisplayMember = "Nombre";
                    cmbDestino.ValueMember = "DestinoId";
                    cmbDestino.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar destinos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadToursGrid()
        {
            try
            {
                using (var db = new AgenciaToursDBEntities())
                {
                    var tours = db.Tour.Include(t => t.Pais).Include(t => t.Destino).ToList();

                    var displayTours = tours.Where(t => t.Destino != null && t.Pais != null).Select(t =>
                    {
                        var duracion = $"{t.Destino.DuracionDias}d {t.Destino.DuracionHoras}h";
                        var fechaInicio = t.Fecha.Add(t.Hora);
                        var fechaFin = fechaInicio.AddDays(t.Destino.DuracionDias).AddHours(t.Destino.DuracionHoras);
                        var estado = DateTime.Now < fechaFin ? "Vigente" : "No Vigente";

                        return new
                        {
                            t.TourId,
                            t.Nombre,
                            Pais = t.Pais.Nombre,
                            Destino = t.Destino.Nombre,
                            FechaInicio = fechaInicio,
                            Precio = t.Precio,
                            ITBIS = t.Precio * 0.18m,
                            Duracion = duracion,
                            FechaFin = fechaFin,
                            Estado = estado,
                            // Campos ocultos para la selección
                            t.PaisId,
                            t.DestinoId,
                            t.Fecha,
                            t.Hora
                        };
                    }).ToList();

                    System.Diagnostics.Debug.WriteLine($"[FrmTours] Tours prepared for display: {displayTours.Count}");

                    // Prepare explicit columns to avoid lazy-loading via proxies
                    dgvTours.DataSource = null;
                    dgvTours.Columns.Clear();
                    dgvTours.AutoGenerateColumns = false;

                    var cTourId = new DataGridViewTextBoxColumn { Name = "TourId", HeaderText = "ID", DataPropertyName = "TourId", ReadOnly = true };
                    var cNombre = new DataGridViewTextBoxColumn { Name = "Nombre", HeaderText = "Nombre", DataPropertyName = "Nombre" };
                    var cPais = new DataGridViewTextBoxColumn { Name = "Pais", HeaderText = "País", DataPropertyName = "Pais" };
                    var cDestino = new DataGridViewTextBoxColumn { Name = "Destino", HeaderText = "Destino", DataPropertyName = "Destino" };
                    var cFechaInicio = new DataGridViewTextBoxColumn { Name = "FechaInicio", HeaderText = "Inicio", DataPropertyName = "FechaInicio" };
                    var cPrecio = new DataGridViewTextBoxColumn { Name = "Precio", HeaderText = "Precio", DataPropertyName = "Precio" };
                    var cITBIS = new DataGridViewTextBoxColumn { Name = "ITBIS", HeaderText = "ITBIS", DataPropertyName = "ITBIS" };
                    var cDuracion = new DataGridViewTextBoxColumn { Name = "Duracion", HeaderText = "Duración", DataPropertyName = "Duracion" };
                    var cFechaFin = new DataGridViewTextBoxColumn { Name = "FechaFin", HeaderText = "Fin", DataPropertyName = "FechaFin" };
                    var cEstado = new DataGridViewTextBoxColumn { Name = "Estado", HeaderText = "Estado", DataPropertyName = "Estado" };
                    var cPaisId = new DataGridViewTextBoxColumn { Name = "PaisId", HeaderText = "PaisId", DataPropertyName = "PaisId", Visible = false };
                    var cDestinoId = new DataGridViewTextBoxColumn { Name = "DestinoId", HeaderText = "DestinoId", DataPropertyName = "DestinoId", Visible = false };
                    var cFecha = new DataGridViewTextBoxColumn { Name = "Fecha", HeaderText = "Fecha", DataPropertyName = "Fecha", Visible = false };
                    var cHora = new DataGridViewTextBoxColumn { Name = "Hora", HeaderText = "Hora", DataPropertyName = "Hora", Visible = false };

                    dgvTours.Columns.AddRange(new DataGridViewColumn[] { cTourId, cNombre, cPais, cDestino, cFechaInicio, cPrecio, cITBIS, cDuracion, cFechaFin, cEstado, cPaisId, cDestinoId, cFecha, cHora });

                    var bs = new BindingSource();
                    bs.DataSource = displayTours;
                    dgvTours.DataSource = bs;
                    dgvTours.Refresh();

                    System.IO.File.AppendAllText(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dgv_debug_tours.txt"), $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] LoadToursGrid: Tours loaded={displayTours.Count}\r\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar tours: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvTours_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvTours.SelectedRows.Count > 0)
                {
                    var selectedRow = dgvTours.SelectedRows[0];
                    if (selectedRow.IsNewRow) return;
                    
                    if (selectedRow.Cells["TourId"].Value != null)
                        txtTourId.Text = selectedRow.Cells["TourId"].Value.ToString();
                    
                    if (selectedRow.Cells["Nombre"].Value != null)
                        txtNombre.Text = selectedRow.Cells["Nombre"].Value.ToString();
                    
                    if (selectedRow.Cells["PaisId"].Value != null)
                        cmbPais.SelectedValue = selectedRow.Cells["PaisId"].Value;
                    
                    if (selectedRow.Cells["DestinoId"].Value != null)
                        cmbDestino.SelectedValue = selectedRow.Cells["DestinoId"].Value;
                    
                    if (selectedRow.Cells["Fecha"].Value != null)
                        dtpFecha.Value = (DateTime)selectedRow.Cells["Fecha"].Value;
                    
                    if (selectedRow.Cells["Hora"].Value != null)
                        dtpHora.Value = DateTime.Today.Add((TimeSpan)selectedRow.Cells["Hora"].Value);
                    
                    if (selectedRow.Cells["Precio"].Value != null)
                        nudPrecio.Value = (decimal)selectedRow.Cells["Precio"].Value;
                    
                    System.IO.File.AppendAllText(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dgv_debug_tours.txt"), $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] SelectionChanged: TourId={txtTourId.Text}\r\n");
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error en SelectionChanged: " + ex.Message);
                System.IO.File.AppendAllText(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dgv_debug_tours.txt"), $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] SelectionChanged Exception: {ex}\r\n");
            }
        }

        private void dgvTours_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Log the error and suppress the default dialog
            System.Diagnostics.Debug.WriteLine($"DataError at ({e.RowIndex}, {e.ColumnIndex}): {e.Exception}");
            System.IO.File.AppendAllText(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dgv_debug_tours.txt"), $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] DataError at ({e.RowIndex}, {e.ColumnIndex}): {e.Exception}\r\n");
            e.ThrowException = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            try
            {
                using (var db = new AgenciaToursDBEntities())
                {
                    string tourId = txtTourId.Text.Trim();
                    if (db.Tour.Any(t => t.TourId.Equals(tourId, StringComparison.OrdinalIgnoreCase)))
                    {
                        MessageBox.Show("Ya existe un tour con ese ID.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var tour = CreateTourFromInputs();
                    db.Tour.Add(tour);
                    db.SaveChanges();
                }
                LoadToursGrid();
                ClearInputs();
                MessageBox.Show("Tour agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar tour: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTourId.Text))
            {
                MessageBox.Show("Seleccione un tour para actualizar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!ValidateInputs(isUpdate: true)) return;

            try
            {
                using (var db = new AgenciaToursDBEntities())
                {
                    string tourId = txtTourId.Text.Trim();
                    var tour = db.Tour.Find(tourId);
                    if (tour != null)
                    {
                        UpdateTourFromInputs(tour);
                        db.SaveChanges();
                    }
                }
                LoadToursGrid();
                ClearInputs();
                MessageBox.Show("Tour actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar tour: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTourId.Text))
            {
                MessageBox.Show("Seleccione un tour para eliminar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Está seguro de eliminar este tour?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (var db = new AgenciaToursDBEntities())
                    {
                        string tourId = txtTourId.Text;
                        var tour = db.Tour.Find(tourId);
                        if (tour != null)
                        {
                            db.Tour.Remove(tour);
                            db.SaveChanges();
                        }
                    }
                    LoadToursGrid();
                    ClearInputs();
                    MessageBox.Show("Tour eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar tour: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            try
            {
                var saveFileDialog = new SaveFileDialog { Filter = "CSV files (*.csv)|*.csv", FileName = "Tours.csv" };
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (var writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        writer.WriteLine("TourId,Nombre,Pais,Destino,FechaInicio,Precio,ITBIS,Duracion,FechaFin,Estado");
                        var gridData = (dynamic)dgvTours.DataSource;
                        foreach (var row in gridData)
                        {
                            writer.WriteLine($"{row.TourId},{row.Nombre},{row.Pais},{row.Destino},{row.FechaInicio},{row.Precio},{row.ITBIS},{row.Duracion},{row.FechaFin},{row.Estado}");
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

        private bool ValidateInputs(bool isUpdate = false)
        {
            if (string.IsNullOrWhiteSpace(txtTourId.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                cmbPais.SelectedValue == null ||
                cmbDestino.SelectedValue == null ||
                nudPrecio.Value <= 0)
            {
                MessageBox.Show("Complete todos los campos. El precio debe ser mayor a cero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (dtpFecha.Value.Date < DateTime.Today)
            {
                MessageBox.Show("La fecha del tour no puede ser en el pasado.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private Tour CreateTourFromInputs()
        {
            var destino = (Destino)cmbDestino.SelectedItem;
            var fechaInicio = dtpFecha.Value.Date.Add(dtpHora.Value.TimeOfDay);
            var fechaFin = fechaInicio.AddDays(destino.DuracionDias).AddHours(destino.DuracionHoras);

            return new Tour
            {
                TourId = txtTourId.Text.Trim(),
                Nombre = txtNombre.Text.Trim(),
                PaisId = (int)cmbPais.SelectedValue,
                DestinoId = (int)cmbDestino.SelectedValue,
                Fecha = dtpFecha.Value.Date,
                Hora = dtpHora.Value.TimeOfDay,
                Precio = nudPrecio.Value,
                ITBIS = nudPrecio.Value * 0.18m,
                DuracionDias = destino.DuracionDias,
                DuracionHoras = destino.DuracionHoras,
                FechaHoraFin = fechaFin,
                Estado = DateTime.Now < fechaFin ? "Vigente" : "No Vigente"
            };
        }

        private void UpdateTourFromInputs(Tour tour)
        {
            var destino = (Destino)cmbDestino.SelectedItem;
            var fechaInicio = dtpFecha.Value.Date.Add(dtpHora.Value.TimeOfDay);
            var fechaFin = fechaInicio.AddDays(destino.DuracionDias).AddHours(destino.DuracionHoras);

            tour.Nombre = txtNombre.Text.Trim();
            tour.PaisId = (int)cmbPais.SelectedValue;
            tour.DestinoId = (int)cmbDestino.SelectedValue;
            tour.Fecha = dtpFecha.Value.Date;
            tour.Hora = dtpHora.Value.TimeOfDay;
            tour.Precio = nudPrecio.Value;
            tour.ITBIS = nudPrecio.Value * 0.18m;
            tour.DuracionDias = destino.DuracionDias;
            tour.DuracionHoras = destino.DuracionHoras;
            tour.FechaHoraFin = fechaFin;
            tour.Estado = DateTime.Now < fechaFin ? "Vigente" : "No Vigente";
        }

        private void ClearInputs()
        {
            txtTourId.Clear();
            txtNombre.Clear();
            cmbPais.SelectedIndex = -1;
            cmbDestino.DataSource = null;
            dtpFecha.Value = DateTime.Now;
            dtpHora.Value = DateTime.Now;
            nudPrecio.Value = 0;
        }
    }
}