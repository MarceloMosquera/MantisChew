using Jira.SDK.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MantisChew
{
    public partial class Form1 : Form
    {
        private void btnBuscarMantis_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.MantisUser == "")
            {
                var f = new FrmLogin();
                if (f.ShowDialog() == DialogResult.Cancel) return;
                Properties.Settings.Default.MantisUser = f.User;
                Properties.Settings.Default.MantisPass = f.Pass;
                Properties.Settings.Default.Save();
            }

            Dictionary<string, string> dicIssueTypes = CargarIssueTypes();
            Dictionary<string, string> dicComponents = CargarComponents();

            var mantisAProc = Datos.Mantis.Where(m => !EquipoActivo.MantisInternos.Contains(m.Nro)).ToList();

            setStatusText("Buscando en Mantis");
            toolStripProgressBar1.Value = 0;
            toolStripProgressBar1.Maximum = 1;

            var nroMantis = int.Parse(txtNroMantis.Text);
            var newMantisEstadoRow = Datos.MantisEstado.NewMantisEstadoRow();
            newMantisEstadoRow.Nro = nroMantis;

            using (var mantisInfo = new MantisInfo())
            {
                if (mantisInfo.LoginOK)
                {
                    setStatusText($"Buscando en mantis: {nroMantis}");
                    Refresh();

                    mantisInfo.Download(newMantisEstadoRow);
                }
                else
                {
                    MessageBox.Show("Error en el login de Mantis");
                    newMantisEstadoRow = null;
                }
            }
            setStatusText("");
            toolStripProgressBar1.Value = 0;

            if (newMantisEstadoRow == null)
                lblDatosMantis.Text = "Mantis no encontrado";
            else
            {
                cmbComponent.Items.Clear();
                cmbComponent.Items.AddRange(
                    jira.GetProject(txtProjectKey.Text).Components.Select(c => c.Name).ToArray());

                if (cmbIssueType.Items.Count == 0)
                    cmbIssueType.Items.AddRange(dicIssueTypes.Values.ToArray());

                lblDatosMantis.Text = $"{newMantisEstadoRow.Resumen} - {newMantisEstadoRow.Tipo} - {newMantisEstadoRow.Proyecto}";

                cmbIssueType.SelectedItem = dicIssueTypes.ContainsKey(newMantisEstadoRow.Tipo) ? dicIssueTypes[newMantisEstadoRow.Tipo] : "Task";
                var componente = dicComponents.ContainsKey(newMantisEstadoRow.Proyecto) ? dicComponents[newMantisEstadoRow.Proyecto] : newMantisEstadoRow.Proyecto;
                cmbComponent.SelectedItem = componente;

                txtSummary.Text =
                    nroMantis.ToString() + " - [" + componente + "] - " +
                    newMantisEstadoRow.Resumen.Substring(8);
                txtDescription.Text = txtSummary.Text;
                txtComment.Text = Properties.Settings.Default.MantisUrlBase + Properties.Settings.Default.MantisUrlView + nroMantis.ToString();
                txtLabel.Text = newMantisEstadoRow.Tipo;
            }



        }

        private static Dictionary<string, string> CargarComponents()
        {
            var dicComponents = new Dictionary<string, string>();
            foreach (var item in Properties.Settings.Default.JiraComponentConvert.Split('|').Select(x => x.Split(',')))
            {
                dicComponents.Add(item[0], item[1]);
            }

            return dicComponents;
        }

        private static Dictionary<string, string> CargarIssueTypes()
        {
            var dicIssueTypes = new Dictionary<string, string>();
            foreach (var item in Properties.Settings.Default.JiraIssueTypeConvert.Split('|').Select(x => x.Split(',')))
            {
                dicIssueTypes.Add(item[0], item[1]);
            }

            return dicIssueTypes;
        }

        private void btnBuscarJira_Click(object sender, EventArgs e)
        {
            setStatusText( "Buscando en Jira");
            toolStripProgressBar1.Value = 0;
            toolStripProgressBar1.Maximum = 1;

            var nroMantis = int.Parse(txtNroMantis.Text);

            setStatusText($"Buscando en Jira : {nroMantis}");
            Refresh();

            List<Issue> issues = BuscarEnJira(nroMantis, false);

            setStatusText("");
            toolStripProgressBar1.Value = 0;

            if (!issues.Any())
                lblDatosJira.Text = "Mantis no encontrado";
            else
            {
                lblDatosJira.Text = $"{issues.FirstOrDefault().Summary} - {issues.FirstOrDefault().Description} - {issues.FirstOrDefault().IssueType.Name} - {issues.FirstOrDefault().Fields.Components?[0].Name}";
            }

        }


        private void btnCrearEnJira_Click(object sender, EventArgs e)
        {

            var issueToCreate = new IssueToCreate()
            {
                Project = txtProjectKey.Text,
                Summary = txtSummary.Text,
                Description = txtDescription.Text,
                IssueType = cmbIssueType.Text,
                Component = cmbComponent.Text,
                Comment = txtComment.Text,
                NroExterno = txtNroMantis.Text,
                Label = txtLabel.Text
            };

            try
            {
                var res = IssueCreator.Crear(issueToCreate);
                lblCreateResult.Text = "Jira creado";
                lnkNewJira.Text = Properties.Settings.Default.JiraUrlBase +
                    Properties.Settings.Default.JiraUrlView +
                    res.key;
            }
            catch (ApplicationException ae)
            {
                lblCreateResult.Text = ae.Message;
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lblDatosJira.Text =   "------";
            lblDatosMantis.Text = "------";
            txtDescription.Text = "";
            txtSummary.Text = "";
            cmbComponent.Text = "";
            cmbIssueType.Text = "";
            lnkNewJira.Text = "";
            txtProjectKey.Text = Properties.Settings.Default.JiraProject;

        }

        private void lnkNewJira_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(lnkNewJira.Text);
        }

    }
}
