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

namespace MantisChew
{
    public partial class Form1 : Form
    {

        private List<TimeTrack> DatosArchivo = new List<TimeTrack>();
        private DataTable dtHorasxFecha = new DataTable();
        private DataTable dtHorasxMantis = new DataTable();
        private Equipo EquipoActivo = new Equipo();

        private Dictionary<int, DataTable> JirasBuscados = new Dictionary<int, DataTable>();

        Jira.SDK.Jira jira = new Jira.SDK.Jira();


        public Form1()
        {
            InitializeComponent();
            CargarEquipo();

            jira.Connect("https://baufest.atlassian.net", "mmosquera@baufest.com", "Ab123456");
        }

        private void CargarEquipo()
        {
            //EquipoActivo.Usuarios = new List<string>() {
            //"Marcos Guaymas Javier", "Marcelo Mosquera", "Carlos Enrique Yanez",
            //"Nicolas Ramirez","Marco Paredes Reccio", "Julian Di Riso",
            //"Javier Campa", "Rodriguez, Emanuel", "Facundo Yuffrida" };
            //EquipoActivo.MantisInternos = new List<int>() {
            //24452, 24188, 24453, 24612 };
            EquipoActivo.Usuarios.AddRange(Properties.Settings.Default.Usuarios.Split('|'));
            EquipoActivo.MantisInternos.AddRange(Properties.Settings.Default.MantisInternos.Split('|').Select(x => int.Parse(x)));

        }
        private void CargarUsuarios()
        {
            var usuarios = DatosArchivo.Select(tt => tt.Usuario).Distinct();
            clstUsuarios.Items.Clear();
            clstUsuarios.Items.AddRange(usuarios.ToArray());
        }

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


        private void CargarDGVHorasxMantis()
        {
            CrearDTHorasxMantis();
            CargarHorasxMantis();

            dgvHorasxMantis.DataSource = dtHorasxMantis;
            dgvHorasxMantis.Refresh();
        }

        private void CrearDTHorasxMantis()
        {
            var usuarios = new List<string>();
            foreach (var chkUsuario in clstUsuarios.CheckedItems)
                usuarios.Add(chkUsuario.ToString());

            dtHorasxMantis = new DataTable();
            dtHorasxMantis.Columns.Add(new DataColumn("Nro", typeof(int)));
            dtHorasxMantis.Columns.Add(new DataColumn("Mantis", typeof(string)));
            dtHorasxMantis.Columns.Add(new DataColumn("Total", typeof(decimal)));
            foreach (var chkUsuario in clstUsuarios.CheckedItems)
                dtHorasxMantis.Columns.Add(new DataColumn(chkUsuario.ToString(), typeof(decimal)));

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
                var row = dtHorasxMantis.NewRow();
                row["Nro"] = mnt.Mantis;
                row["Mantis"] = mnt.Descripcion;

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
                row["Total"] = total.ToString();
                dtHorasxMantis.Rows.Add(row);
            }

           
        }
        private void CargarDGVHorasxJira(int mantis)
        {
            dgvHorasxJira.DataSource = JirasBuscados.ContainsKey(mantis) ?
                        JirasBuscados[mantis] :
                        CargarHorasxJira(CrearDTHorasxJira(), mantis);
            dgvHorasxJira.Refresh();
        }

        private DataTable CrearDTHorasxJira()
        {
            var usuarios = new List<string>();
            foreach (var chkUsuario in clstUsuarios.CheckedItems)
                usuarios.Add(chkUsuario.ToString());

            var dtHorasxJira = new DataTable();
            dtHorasxJira.Columns.Add(new DataColumn("Nro", typeof(string)));
            dtHorasxJira.Columns.Add(new DataColumn("Summary", typeof(string)));
            dtHorasxJira.Columns.Add(new DataColumn("Hrs", typeof(decimal)));
            return dtHorasxJira;
        }

        private DataTable CargarHorasxJira(DataTable dtHorasxJira, int mantis)
        {
            List<Issue> issues = BuscarEnJira(mantis);
            foreach (var issue in issues)
            {
                var row = dtHorasxJira.NewRow();
                row["Nro"] = issue.Key;
                row["Summary"] = issue.Summary;
                row["Hrs"] = issue.TimeTracking.TimeSpentSeconds / 60 / 60;
                dtHorasxJira.Rows.Add(row);
            }
            JirasBuscados.Add(mantis, dtHorasxJira); 
            return dtHorasxJira;
        }

        private List<Issue> BuscarEnJira(int mantis)
        {
            //Gets all of the projects configured in your jira instance
            //List<Project> projects = jira.GetProjects();
            return jira.SearchIssues(string.Format(@"text~""{0}""", mantis));
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                DatosArchivo = FileParser.Parse(openFileDialog1.FileName);
                CargarUsuarios();
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

        private void dgvHorasxFecha_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex >= 1 && (e.Value.ToString() != "8"))
            {
                dgvHorasxFecha.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Coral;
            }
        }

        private void dgvHorasxMantis_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            var mantis = (int)dgvHorasxMantis.Rows[e.RowIndex].Cells[0].Value;
            if (EquipoActivo.MantisInternos.Contains(mantis))
                dgvHorasxMantis.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightBlue;
            
        }

        private void btnBuscarEnJira_Click(object sender, EventArgs e)
        {
            if(dgvHorasxMantis.SelectedCells.Count > 0)
            {
                var mantis = (int)dgvHorasxMantis.Rows[dgvHorasxMantis.SelectedCells[0].RowIndex].Cells[0].Value;
                CargarDGVHorasxJira(mantis);
            }
        }

        private void btnBuscarTodosJira_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in dtHorasxMantis.Rows)
            {
                var mantis = (int)row[0];
                CargarDGVHorasxJira(mantis);
            }
        }
    }
}
 