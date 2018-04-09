using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantisChew
{
    partial class Form1
    {

        private DataTable CrearDTConfig()
        {
            var dtConfig = new DataTable();
            dtConfig.Columns.Add(new DataColumn("Clave", typeof(string)));
            dtConfig.Columns.Add(new DataColumn("Valor", typeof(string)));
            return dtConfig;
        }

        private DataTable CrearDetalleConfig(DataTable dtConfig)
        {
            foreach (SettingsProperty currentProperty in Properties.Settings.Default.Properties)
            {
                dtConfig.Rows.Add(currentProperty.Name, Properties.Settings.Default[currentProperty.Name]);
            }
            return dtConfig;
        }
        private void btnCargarConfig_Click(object sender, EventArgs e)
        {
            CargarConfig();
        }
        private void btnGuardarConfig_Click(object sender, EventArgs e)
        {
            GuardarConfig();
        }
        private void CargarConfig()
        {
            dgvConfig.DataSource = CrearDetalleConfig(CrearDTConfig());
            dgvConfig.Refresh();
        }
        private void GuardarConfig()
        {
            var dt = (DataTable)dgvConfig.DataSource;
            foreach (DataRow row in dt.Rows)
            {
                var name = (string)row[0];
                var value = (string)row[1];
                Properties.Settings.Default[name] = value;
            }
            Properties.Settings.Default.Save();
        }
    }
}
