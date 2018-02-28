using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Jira.SDK;
using Jira.SDK.Domain;
using System.Net.Http;
using HtmlAgilityPack;
using System.Text.RegularExpressions;

namespace MantisChew
{
    public partial class Form1 : Form
    {

        private dsDatos Datos = new dsDatos();
        private List<TimeTrack> DatosArchivo = new List<TimeTrack>();
        private DataTable dtHorasxFecha = new DataTable();
        private Equipo EquipoActivo = new Equipo();

        //private Dictionary<int, DataTable> JirasBuscados = new Dictionary<int, DataTable>();

        private Jira.SDK.Jira jira = new Jira.SDK.Jira();

        private string JiraUrl = "";
        private string MantisUrl = "";

        #region "StartUp"

        public Form1()
        {
            InitializeComponent();
            CargarEquipo();
            ConectarJira();
            this.MantisUrl = Properties.Settings.Default.MantisUrlBase;
            this.toolStripStatusLabel1.Text = "";
            dgvMantisEstado.DataSource = Datos.MantisEstado;
        }

        private void CargarEquipo()
        {
            EquipoActivo.Usuarios.AddRange(Properties.Settings.Default.Usuarios.Split('|'));
            EquipoActivo.MantisInternos.AddRange(Properties.Settings.Default.MantisInternos.Split('|').Select(x => int.Parse(x)));
        }
        private void CargarUsuarios()
        {
            var usuarios = DatosArchivo.Select(tt => tt.Usuario).Distinct();
            clstUsuarios.Items.Clear();
            clstUsuarios.Items.AddRange(usuarios.ToArray());
        }
        private void ConectarJira()
        {
            try
            {
                this.JiraUrl = Properties.Settings.Default.JiraURL;
                jira.Connect(this.JiraUrl, 
                    Properties.Settings.Default.JiraUser, 
                    Properties.Settings.Default.JiraPass);
            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudo conectar a Jira" + e.Message);
            }
        }

        #endregion
        #region "Horas x Fecha"

        private void CargarDGVHorasxFecha()
        {
            CrearDTHorasxFecha();
            CargarHorasxFecha();

            dgvHorasxFecha.DataSource = dtHorasxFecha;
            for (int i = 1; i < dgvHorasxFecha.Columns.Count; i++)
            {
                dgvHorasxFecha.Columns[i].Width = 20;
            }
            dgvHorasxFecha.Refresh();
        }

        private void CrearDTHorasxFecha()
        {
            var minDate = DatosArchivo.Select(tt => tt.Fecha).Min();
            var maxDate = DatosArchivo.Select(tt => tt.Fecha).Max();

            dtHorasxFecha = new DataTable();
            dtHorasxFecha.Columns.Add(new DataColumn("Usuario", typeof(string)));

            for (DateTime day = minDate; day <= maxDate; day = day.AddDays(1))
            {
                if (!(day.DayOfWeek == DayOfWeek.Saturday || day.DayOfWeek == DayOfWeek.Sunday))
                    dtHorasxFecha.Columns.Add(new DataColumn(day.ToString("dd/MM"), typeof(string)));
            }
        }
 
        private void CargarHorasxFecha()
        {
            foreach (var chkUsuario in clstUsuarios.CheckedItems)
            {
                var usuario = chkUsuario.ToString();

                var row = dtHorasxFecha.NewRow();
                row["Usuario"] = usuario;

                var datosUsuario =DatosArchivo.Where(tt => tt.Usuario == usuario)
                    .GroupBy(l => l.Fecha)
                    .Select(cl => new { Fecha = cl.First().Fecha.ToString("dd/MM"), SumHrs = cl.Sum(tt => tt.Horas)}).ToList();
                foreach (var datoUsuario in datosUsuario)
                {
                    try
                    {
                        row[datoUsuario.Fecha] = datoUsuario.SumHrs.ToString();
                    }
                    catch (Exception)
                    {
                    }
                }

                dtHorasxFecha.Rows.Add(row);
            }
        }
        private void dgvHorasxFecha_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex >= 1 && (e.Value.ToString() != "8"))
            {
                dgvHorasxFecha.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Coral;
            }
        }

        #endregion

        private void CargarDGVHorasxMantis()
        {
            CrearDTHorasxMantis();
            CargarHorasxMantis();

            dgvHorasxMantis.DataSource = Datos.Mantis;
            dgvHorasxMantis.Refresh();
        }

        private void CrearDTHorasxMantis()
        {
            var usuarios = new List<string>();
            foreach (var chkUsuario in clstUsuarios.CheckedItems)
            {
                usuarios.Add(chkUsuario.ToString());
                Datos.Mantis.Columns.Add(new DataColumn(chkUsuario.ToString(), typeof(decimal)));
            }
        }

        private void CargarHorasxMantis()
        {
            var usuarios = new List<string>();
            foreach (var chkUsuario in clstUsuarios.CheckedItems)
                usuarios.Add(chkUsuario.ToString());

            var mantis = DatosArchivo
                    .Where(tt => usuarios.Contains(tt.Usuario))
                    .Select(tt=> new { tt.Descripcion, tt.Mantis })
                    .Distinct();
            foreach (var mnt in mantis)
            {
                var row = Datos.Mantis.NewMantisRow();
                row.Nro = mnt.Mantis;
                row.Mantis = mnt.Descripcion;

                var datosMantis = DatosArchivo.Where(tt => tt.Mantis == mnt.Mantis)
                    .GroupBy(l => l.Usuario)
                    .Select(cl => new {
                        Usuario = cl.First().Usuario,
                        SumHrs = cl.Sum(tt => tt.Horas)
                    }).ToList();

                decimal total = 0;
                foreach (var datoMantis in datosMantis)
                {
                    try
                    {
                        row[datoMantis.Usuario] = datoMantis.SumHrs.ToString();
                        total += datoMantis.SumHrs;
                    } catch (Exception) { }
                }
                row.HrsMantis = total;
                Datos.Mantis.Rows.Add(row);
            }

           
        }
        private void CargarDGVHorasxJira(int mantis)
        {
            dgvHorasxJira.DataSource = Datos.Jiras;
            Datos.Jiras.DefaultView.RowFilter = string.Format("NroMantis = '{0}'", mantis);
            dgvHorasxJira.Refresh();
        }

        private void CargarHorasxJira( int mantis)
        {
            List<Issue> issues = BuscarEnJira(mantis);
            foreach (var issue in issues)
            {
                var row = Datos.Jiras.NewJirasRow();
                row.Nro = issue.Key;
                row.Summary = issue.Summary;
                row.Hrs = issue.TimeTracking.TimeSpentSeconds / 60 / 60;
                row.Asignado = issue.Assignee?.Name;
                row.Estado = issue.Status.Name;
                row.NroMantis = mantis;
                Datos.Jiras.AddJirasRow(row);
            }
        }

        private List<Issue> BuscarEnJira(int mantis)
        {
            //Gets all of the projects configured in your jira instance
            //List<Project> projects = jira.GetProjects();
            return jira.SearchIssues(string.Format(@"text~""{0}"" and project=""Cencosud - Super NET"" and issuetype in (Sub-task) and Sprint in openSprints()", mantis));
        }

        private DataTable CrearDTDetalleMantis()
        {
            var usuarios = new List<string>();
            foreach (var chkUsuario in clstUsuarios.CheckedItems)
                usuarios.Add(chkUsuario.ToString());

            var dtDetalleMantis = new DataTable();
            dtDetalleMantis.Columns.Add(new DataColumn("Mantis", typeof(int)));
            dtDetalleMantis.Columns.Add(new DataColumn("Descripcion", typeof(string)));
            dtDetalleMantis.Columns.Add(new DataColumn("Hrs", typeof(decimal)));
            return dtDetalleMantis;
        }
        private DataTable CargarDetalleMantis(DataTable dtDetalleMantis, string usuario, string strFecha)
        {
            var fecha = DateTime.ParseExact(strFecha, "dd/MM", null);
            var mantis = DatosArchivo.Where(m=> m.Usuario == usuario && m.Fecha == fecha);

            foreach (var mnt in mantis)
            {
                var row = dtDetalleMantis.NewRow();
                row["Mantis"] = mnt.Mantis;
                row["Descripcion"] = mnt.Descripcion;
                row["Hrs"] = mnt.Horas;
                dtDetalleMantis.Rows.Add(row);
            }
            return dtDetalleMantis;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Datos = new dsDatos();
                //JirasBuscados = new Dictionary<int, DataTable>();
                DatosArchivo = new List<TimeTrack>();
                DatosArchivo = FileParser.Parse(openFileDialog1.FileName);
                CargarUsuarios();
                btnEquipo_Click(sender, e);
            }
        }
        private void btnRefrescarDias_Click(object sender, EventArgs e)
        {
            CargarDGVHorasxFecha();
            CargarDGVHorasxMantis();
        }
        private void btnEquipo_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clstUsuarios.Items.Count; i++)
                clstUsuarios.SetItemChecked(i, (EquipoActivo.Usuarios.Contains(clstUsuarios.Items[i].ToString())));
            CargarDGVHorasxFecha();
            CargarDGVHorasxMantis();
        }


        private void dgvHorasxMantis_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            var mantis = GetMantis(e.RowIndex);
            if (EquipoActivo.MantisInternos.Contains(mantis))
                dgvHorasxMantis.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightBlue;

        }
        private void dgvHorasxMantis_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var mantis = GetMantis(e.RowIndex);
            if (!EquipoActivo.MantisInternos.Contains(mantis))
            {
                //dgvHorasxMantis.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightBlue;

                if (dgvHorasxMantis.Columns[e.ColumnIndex].Name == "HrsJira")
                    if (e.Value == DBNull.Value)
                        dgvHorasxMantis.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Coral;
                    else
                        dgvHorasxMantis.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White;

                if ((dgvHorasxMantis.Columns[e.ColumnIndex].Name == "Diferencia") && (e.Value != DBNull.Value))
                {
                    var val = (decimal)e.Value;
                    if (val > 0)
                        dgvHorasxMantis.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Coral;
                    else if (val < 0)
                        dgvHorasxMantis.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Gold;
                    else
                        dgvHorasxMantis.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White;
                }
            }
        }

        private void btnBuscarEnJira_Click(object sender, EventArgs e)
        {
            if (dgvHorasxMantis.SelectedCells.Count > 0)
            {
                var mantis = GetMantis(null);
                CargarDGVHorasxJira(mantis);
            }
        }

        private void btnBuscarTodosJira_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Buscando en Jira";
            toolStripProgressBar1.Value = 0;
            toolStripProgressBar1.Maximum = Datos.Mantis.Rows.Count;
            for (int i = 0; i < Datos.Mantis.Rows.Count; i++)
            {
                var mantis = GetMantis(i);

                toolStripProgressBar1.Value++;
                toolStripStatusLabel1.Text = $"Buscando en Jira el mantis: {mantis}";
                Refresh();

                CargarHorasxJira(mantis);
                var unJira = Datos.Jiras.FirstOrDefault(j => j.NroMantis == mantis);
                if (unJira != null)
                {
                    var mantisRow = Datos.Mantis.First(m => m.Nro == mantis);
                    mantisRow.HrsJira = unJira.Hrs;
                    mantisRow.Diferencia = mantisRow.HrsMantis - mantisRow.HrsJira;
                }
            }

            toolStripStatusLabel1.Text = "";
            toolStripProgressBar1.Value = 0;
        }

        private void btnIrAJira_Click(object sender, EventArgs e)
        {
            if (dgvHorasxJira.SelectedCells.Count > 0)
            {
                var key = (string)dgvHorasxJira.Rows[dgvHorasxJira.SelectedCells[0].RowIndex].Cells[0].Value;
                System.Diagnostics.Process.Start(
                    this.JiraUrl + string.Format("/browse/{0}", key));
            }
        }

        private void dgvHorasxMantis_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHorasxMantis.SelectedCells.Count > 0)
            {
                var mantis = GetMantis(null);
                CargarDGVHorasxJira(mantis);
            }
        }

        private void btnIrAMantis_Click(object sender, EventArgs e)
        {
            if (dgvHorasxMantis.SelectedCells.Count > 0)
            {
                var mantis = GetMantis(null);
                System.Diagnostics.Process.Start(
                    this.MantisUrl + mantis.ToString());
            }
        }

        private void dgvHorasxFecha_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHorasxFecha.SelectedCells.Count > 0 && dgvHorasxFecha.SelectedCells[0].ColumnIndex > 0)
            {
                var fecha = dgvHorasxFecha.Columns[dgvHorasxFecha.SelectedCells[0].ColumnIndex].HeaderText; 
                var usuario = dgvHorasxFecha.Rows[dgvHorasxFecha.SelectedCells[0].RowIndex].Cells[0].Value.ToString();

                dgvDetalleMantis.DataSource = CargarDetalleMantis(CrearDTDetalleMantis(), usuario, fecha);
                dgvDetalleMantis.Refresh();

            }
        }

      
        private decimal CalcularDiferenciaHoraria()
        {
            decimal result = 0;
            if (estanGrillasSeleccionadas() )
            {
                decimal hsMantis = GetMantisRow(null).HrsMantis;

                decimal hsJira = GetJiraRow(null).Hrs;

                result = hsMantis - hsJira;
            }
            return result;
        }

        private bool estanGrillasSeleccionadas()
        {
            return (dgvHorasxMantis.SelectedCells.Count > 0) && (dgvHorasxJira.SelectedCells.Count > 0);
        }

        private void dgvHorasxJira_SelectionChanged(object sender, EventArgs e)
        {
            var diff = CalcularDiferenciaHoraria();
            btnCargarDiferenciaEnJira.Enabled = diff > 0;
            btnCargarDiferenciaEnJira.Text = $"Cargar {diff} hrs en Jira";

            GetMantisRow(null).Diferencia = diff;
        }

        private void btnCargarDiferenciaEnJira_Click(object sender, EventArgs e)
        {
            var diff = CalcularDiferenciaHoraria();
            if (MessageBox.Show($"Cargar {diff} hrs en Jira?", "Cargar en Jira", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var jiraKey = GetJiraRow(null).Nro;//GetSelectedString(dgvHorasxJira, (int)HorasxJiraColunms.Nro);

                var crearResponse = WorkLog.Crear(jiraKey, diff);
                if (crearResponse.StatusCode == HttpStatusCode.Created)
                {
                    MessageBox.Show("Creado");
                    var mantis = GetMantis(null);
                    CargarHorasxJira(mantis);
                    var unJira = Datos.Jiras.FirstOrDefault(j => j.NroMantis == mantis);
                    if (unJira != null)
                    {
                        var mantisRow = Datos.Mantis.First(m => m.Nro == mantis);
                        mantisRow.HrsJira = unJira.Hrs;
                        mantisRow.Diferencia = mantisRow.HrsMantis - mantisRow.HrsJira;
                    }
                    dgvHorasxJira.Refresh();
                }
                else
                {
                    MessageBox.Show(crearResponse.ToString());
                }
            }
        }

        private string GetSelectedString(DataGridView dgv, int col)
        {
            return (string)dgv.Rows[dgv.SelectedCells[0].RowIndex].Cells[col].Value;
        }
        private int GetSelectedInt(DataGridView dgv, int col)
        {
            int value = 0;
            int.TryParse(dgv.Rows[dgv.SelectedCells[0].RowIndex].Cells[col].Value.ToString(), out value);
            return value;
        }

        private int GetMantis(int? rowIndex)
        {
            dsDatos.MantisRow row = GetMantisRow(rowIndex);
            return row.Nro;
        }

        private dsDatos.MantisRow GetMantisRow(int? rowIndex)
        {
            DataRowView currentDataRowView = (DataRowView)dgvHorasxMantis.Rows[rowIndex ?? dgvHorasxMantis.SelectedCells[0].RowIndex].DataBoundItem;
            return (dsDatos.MantisRow)currentDataRowView.Row;
        }
        private dsDatos.JirasRow GetJiraRow(int? rowIndex)
        {
            DataRowView currentDataRowView = (DataRowView)dgvHorasxJira.Rows[rowIndex ?? dgvHorasxJira.SelectedCells[0].RowIndex].DataBoundItem;
            return (dsDatos.JirasRow)currentDataRowView.Row;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (Properties.Settings.Default.MantisUser == "")
            {
                var f = new FrmLogin();
                if (f.ShowDialog() == DialogResult.Cancel) return;
                Properties.Settings.Default.MantisUser = f.User;
                Properties.Settings.Default.MantisPass = f.Pass;
                Properties.Settings.Default.Save();
            }

            Datos.MantisEstado.Clear();

            var mantisAProc = Datos.Mantis.Where(m => !EquipoActivo.MantisInternos.Contains(m.Nro)).ToList();

            toolStripStatusLabel1.Text = "Buscando en Mantis";
            toolStripProgressBar1.Value = 0;
            toolStripProgressBar1.Maximum = mantisAProc.Count;

            using (var mantisInfo = new MantisInfo())
            {
                foreach (var row in mantisAProc)
                {
                    toolStripProgressBar1.Value++;
                    toolStripStatusLabel1.Text = $"Buscando en mantis: {row.Nro}  {toolStripProgressBar1.Value}/{toolStripProgressBar1.Maximum}";
                    Refresh();

                    var newMantisEstadoRow = Datos.MantisEstado.NewMantisEstadoRow();
                    newMantisEstadoRow.Nro = row.Nro;
                    mantisInfo.Download(newMantisEstadoRow);
                    Datos.MantisEstado.AddMantisEstadoRow(newMantisEstadoRow);
                }
            }
            dgvMantisEstado.DataSource = Datos.MantisEstado;
            dgvMantisEstado.Refresh();

            CargarDGVEstadoAgrupado();

            toolStripStatusLabel1.Text = "";
            toolStripProgressBar1.Value = 0;

        }

        private void CargarDGVEstadoAgrupado()
        {
            var datos = Datos.MantisEstado
                .Where(m=> m?.Estado == "entregado")
                .GroupBy(m => m.Proyecto)
                .Select(m => new
                {
                    Proyecto = m.First().Proyecto,
                    Mantis = string.Join(", ", m.Select(i => i.Nro)),
                    Horas = m.Sum(c => int.Parse(c.HrsTotal))
                })
                .ToList();
            dgvEstadoAgrupado.DataSource = datos;
            dgvEstadoAgrupado.Refresh();
        }

        private void btnLoginMantis_Click(object sender, EventArgs e)
        {
            var f = new FrmLogin();
            if (f.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.MantisUser = f.User;
                Properties.Settings.Default.MantisPass = f.Pass;
                Properties.Settings.Default.Save();
            }
        }
    }
}
 