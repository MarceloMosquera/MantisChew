namespace MantisChew
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnCargar = new System.Windows.Forms.Button();
            this.clstUsuarios = new System.Windows.Forms.CheckedListBox();
            this.btnRefrescarDias = new System.Windows.Forms.Button();
            this.btnEquipo = new System.Windows.Forms.Button();
            this.dgvHorasxMantis = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvHorasxFecha = new System.Windows.Forms.DataGridView();
            this.dgvDetalleMantis = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCargarDiferenciaEnJira = new System.Windows.Forms.Button();
            this.btnIrAMantis = new System.Windows.Forms.Button();
            this.btnIrAJira = new System.Windows.Forms.Button();
            this.btnBuscarTodosJira = new System.Windows.Forms.Button();
            this.dgvHorasxJira = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.btnLoginMantis = new System.Windows.Forms.Button();
            this.dgvMantisEstado = new System.Windows.Forms.DataGridView();
            this.btnCargarMantisInfo = new System.Windows.Forms.Button();
            this.dgvEstadoAgrupado = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtLabel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.cmbComponent = new System.Windows.Forms.ComboBox();
            this.cmbIssueType = new System.Windows.Forms.ComboBox();
            this.lnkNewJira = new System.Windows.Forms.LinkLabel();
            this.lblCreateResult = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSummary = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProjectKey = new System.Windows.Forms.TextBox();
            this.btnCrearEnJira = new System.Windows.Forms.Button();
            this.lblDatosJira = new System.Windows.Forms.Label();
            this.lblDatosMantis = new System.Windows.Forms.Label();
            this.btnBuscarJira = new System.Windows.Forms.Button();
            this.btnBuscarMantis = new System.Windows.Forms.Button();
            this.txtNroMantis = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btnGuardarConfig = new System.Windows.Forms.Button();
            this.btnCargarConfig = new System.Windows.Forms.Button();
            this.dgvConfig = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.btnBajarTimeReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorasxMantis)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorasxFecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleMantis)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorasxJira)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMantisEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadoAgrupado)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConfig)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "\"Mantis|*.XLS;*.xls\";";
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(12, 12);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 1;
            this.btnCargar.Text = "Cargar Archivo";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // clstUsuarios
            // 
            this.clstUsuarios.FormattingEnabled = true;
            this.clstUsuarios.Location = new System.Drawing.Point(12, 41);
            this.clstUsuarios.Name = "clstUsuarios";
            this.clstUsuarios.Size = new System.Drawing.Size(144, 244);
            this.clstUsuarios.TabIndex = 2;
            // 
            // btnRefrescarDias
            // 
            this.btnRefrescarDias.Location = new System.Drawing.Point(12, 292);
            this.btnRefrescarDias.Name = "btnRefrescarDias";
            this.btnRefrescarDias.Size = new System.Drawing.Size(75, 23);
            this.btnRefrescarDias.TabIndex = 4;
            this.btnRefrescarDias.Text = "Refrescar";
            this.btnRefrescarDias.UseVisualStyleBackColor = true;
            this.btnRefrescarDias.Click += new System.EventHandler(this.btnRefrescarDias_Click);
            // 
            // btnEquipo
            // 
            this.btnEquipo.Location = new System.Drawing.Point(12, 321);
            this.btnEquipo.Name = "btnEquipo";
            this.btnEquipo.Size = new System.Drawing.Size(75, 23);
            this.btnEquipo.TabIndex = 5;
            this.btnEquipo.Text = "Equipo";
            this.btnEquipo.UseVisualStyleBackColor = true;
            this.btnEquipo.Click += new System.EventHandler(this.btnEquipo_Click);
            // 
            // dgvHorasxMantis
            // 
            this.dgvHorasxMantis.AllowUserToAddRows = false;
            this.dgvHorasxMantis.AllowUserToDeleteRows = false;
            this.dgvHorasxMantis.AllowUserToOrderColumns = true;
            this.dgvHorasxMantis.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dgvHorasxMantis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHorasxMantis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHorasxMantis.Location = new System.Drawing.Point(0, 0);
            this.dgvHorasxMantis.Name = "dgvHorasxMantis";
            this.dgvHorasxMantis.ReadOnly = true;
            this.dgvHorasxMantis.RowHeadersVisible = false;
            this.dgvHorasxMantis.Size = new System.Drawing.Size(560, 268);
            this.dgvHorasxMantis.TabIndex = 6;
            this.dgvHorasxMantis.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvHorasxMantis_CellFormatting);
            this.dgvHorasxMantis.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvHorasxMantis_RowPrePaint);
            this.dgvHorasxMantis.SelectionChanged += new System.EventHandler(this.dgvHorasxMantis_SelectionChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(162, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(574, 455);
            this.tabControl1.TabIndex = 8;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(566, 429);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Carga de Horas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvHorasxFecha);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvDetalleMantis);
            this.splitContainer1.Size = new System.Drawing.Size(560, 423);
            this.splitContainer1.SplitterDistance = 276;
            this.splitContainer1.TabIndex = 6;
            // 
            // dgvHorasxFecha
            // 
            this.dgvHorasxFecha.AllowUserToAddRows = false;
            this.dgvHorasxFecha.AllowUserToDeleteRows = false;
            this.dgvHorasxFecha.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dgvHorasxFecha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHorasxFecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHorasxFecha.Location = new System.Drawing.Point(0, 0);
            this.dgvHorasxFecha.Name = "dgvHorasxFecha";
            this.dgvHorasxFecha.ReadOnly = true;
            this.dgvHorasxFecha.RowHeadersVisible = false;
            this.dgvHorasxFecha.Size = new System.Drawing.Size(560, 276);
            this.dgvHorasxFecha.TabIndex = 4;
            this.dgvHorasxFecha.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvHorasxFecha_CellFormatting);
            this.dgvHorasxFecha.SelectionChanged += new System.EventHandler(this.dgvHorasxFecha_SelectionChanged);
            // 
            // dgvDetalleMantis
            // 
            this.dgvDetalleMantis.AllowUserToAddRows = false;
            this.dgvDetalleMantis.AllowUserToDeleteRows = false;
            this.dgvDetalleMantis.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dgvDetalleMantis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleMantis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetalleMantis.Location = new System.Drawing.Point(0, 0);
            this.dgvDetalleMantis.Name = "dgvDetalleMantis";
            this.dgvDetalleMantis.ReadOnly = true;
            this.dgvDetalleMantis.RowHeadersVisible = false;
            this.dgvDetalleMantis.Size = new System.Drawing.Size(560, 143);
            this.dgvDetalleMantis.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(566, 429);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Horas x Mantis";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dgvHorasxMantis);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.panel1);
            this.splitContainer2.Panel2.Controls.Add(this.dgvHorasxJira);
            this.splitContainer2.Size = new System.Drawing.Size(560, 423);
            this.splitContainer2.SplitterDistance = 268;
            this.splitContainer2.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCargarDiferenciaEnJira);
            this.panel1.Controls.Add(this.btnIrAMantis);
            this.panel1.Controls.Add(this.btnIrAJira);
            this.panel1.Controls.Add(this.btnBuscarTodosJira);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 31);
            this.panel1.TabIndex = 7;
            // 
            // btnCargarDiferenciaEnJira
            // 
            this.btnCargarDiferenciaEnJira.Location = new System.Drawing.Point(172, 4);
            this.btnCargarDiferenciaEnJira.Name = "btnCargarDiferenciaEnJira";
            this.btnCargarDiferenciaEnJira.Size = new System.Drawing.Size(124, 23);
            this.btnCargarDiferenciaEnJira.TabIndex = 11;
            this.btnCargarDiferenciaEnJira.Text = "Cargar horas en Jira";
            this.btnCargarDiferenciaEnJira.UseVisualStyleBackColor = true;
            this.btnCargarDiferenciaEnJira.Click += new System.EventHandler(this.btnCargarDiferenciaEnJira_Click);
            // 
            // btnIrAMantis
            // 
            this.btnIrAMantis.Location = new System.Drawing.Point(374, 5);
            this.btnIrAMantis.Name = "btnIrAMantis";
            this.btnIrAMantis.Size = new System.Drawing.Size(75, 23);
            this.btnIrAMantis.TabIndex = 10;
            this.btnIrAMantis.Text = "Ir a Mantis";
            this.btnIrAMantis.UseVisualStyleBackColor = true;
            this.btnIrAMantis.Click += new System.EventHandler(this.btnIrAMantis_Click);
            // 
            // btnIrAJira
            // 
            this.btnIrAJira.Location = new System.Drawing.Point(467, 5);
            this.btnIrAJira.Name = "btnIrAJira";
            this.btnIrAJira.Size = new System.Drawing.Size(75, 23);
            this.btnIrAJira.TabIndex = 9;
            this.btnIrAJira.Text = "Ir a Jira";
            this.btnIrAJira.UseVisualStyleBackColor = true;
            this.btnIrAJira.Click += new System.EventHandler(this.btnIrAJira_Click);
            // 
            // btnBuscarTodosJira
            // 
            this.btnBuscarTodosJira.Location = new System.Drawing.Point(3, 5);
            this.btnBuscarTodosJira.Name = "btnBuscarTodosJira";
            this.btnBuscarTodosJira.Size = new System.Drawing.Size(136, 23);
            this.btnBuscarTodosJira.TabIndex = 8;
            this.btnBuscarTodosJira.Text = "Buscar Todos En Jira";
            this.btnBuscarTodosJira.UseVisualStyleBackColor = true;
            this.btnBuscarTodosJira.Click += new System.EventHandler(this.btnBuscarTodosJira_Click);
            // 
            // dgvHorasxJira
            // 
            this.dgvHorasxJira.AllowUserToAddRows = false;
            this.dgvHorasxJira.AllowUserToDeleteRows = false;
            this.dgvHorasxJira.AllowUserToOrderColumns = true;
            this.dgvHorasxJira.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHorasxJira.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dgvHorasxJira.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHorasxJira.Location = new System.Drawing.Point(0, 34);
            this.dgvHorasxJira.Name = "dgvHorasxJira";
            this.dgvHorasxJira.ReadOnly = true;
            this.dgvHorasxJira.RowHeadersVisible = false;
            this.dgvHorasxJira.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHorasxJira.Size = new System.Drawing.Size(560, 120);
            this.dgvHorasxJira.TabIndex = 8;
            this.dgvHorasxJira.SelectionChanged += new System.EventHandler(this.dgvHorasxJira_SelectionChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.splitContainer3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(566, 429);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Estado Mantis";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(3, 3);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.btnLoginMantis);
            this.splitContainer3.Panel1.Controls.Add(this.dgvMantisEstado);
            this.splitContainer3.Panel1.Controls.Add(this.btnCargarMantisInfo);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.dgvEstadoAgrupado);
            this.splitContainer3.Size = new System.Drawing.Size(560, 423);
            this.splitContainer3.SplitterDistance = 332;
            this.splitContainer3.TabIndex = 6;
            // 
            // btnLoginMantis
            // 
            this.btnLoginMantis.Location = new System.Drawing.Point(441, 3);
            this.btnLoginMantis.Name = "btnLoginMantis";
            this.btnLoginMantis.Size = new System.Drawing.Size(114, 23);
            this.btnLoginMantis.TabIndex = 11;
            this.btnLoginMantis.Text = "Login Mantis";
            this.btnLoginMantis.UseVisualStyleBackColor = true;
            this.btnLoginMantis.Click += new System.EventHandler(this.btnLoginMantis_Click);
            // 
            // dgvMantisEstado
            // 
            this.dgvMantisEstado.AllowUserToAddRows = false;
            this.dgvMantisEstado.AllowUserToDeleteRows = false;
            this.dgvMantisEstado.AllowUserToOrderColumns = true;
            this.dgvMantisEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMantisEstado.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dgvMantisEstado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMantisEstado.Location = new System.Drawing.Point(0, 32);
            this.dgvMantisEstado.Name = "dgvMantisEstado";
            this.dgvMantisEstado.ReadOnly = true;
            this.dgvMantisEstado.RowHeadersVisible = false;
            this.dgvMantisEstado.Size = new System.Drawing.Size(560, 298);
            this.dgvMantisEstado.TabIndex = 5;
            // 
            // btnCargarMantisInfo
            // 
            this.btnCargarMantisInfo.Location = new System.Drawing.Point(3, 3);
            this.btnCargarMantisInfo.Name = "btnCargarMantisInfo";
            this.btnCargarMantisInfo.Size = new System.Drawing.Size(114, 23);
            this.btnCargarMantisInfo.TabIndex = 10;
            this.btnCargarMantisInfo.Text = "Cargar Datos";
            this.btnCargarMantisInfo.UseVisualStyleBackColor = true;
            this.btnCargarMantisInfo.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvEstadoAgrupado
            // 
            this.dgvEstadoAgrupado.AllowUserToAddRows = false;
            this.dgvEstadoAgrupado.AllowUserToDeleteRows = false;
            this.dgvEstadoAgrupado.AllowUserToOrderColumns = true;
            this.dgvEstadoAgrupado.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dgvEstadoAgrupado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstadoAgrupado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEstadoAgrupado.Location = new System.Drawing.Point(0, 0);
            this.dgvEstadoAgrupado.Name = "dgvEstadoAgrupado";
            this.dgvEstadoAgrupado.ReadOnly = true;
            this.dgvEstadoAgrupado.RowHeadersVisible = false;
            this.dgvEstadoAgrupado.Size = new System.Drawing.Size(560, 87);
            this.dgvEstadoAgrupado.TabIndex = 6;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.txtLabel);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.txtComment);
            this.tabPage4.Controls.Add(this.cmbComponent);
            this.tabPage4.Controls.Add(this.cmbIssueType);
            this.tabPage4.Controls.Add(this.lnkNewJira);
            this.tabPage4.Controls.Add(this.lblCreateResult);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.btnLimpiar);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.txtDescription);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.txtSummary);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.txtProjectKey);
            this.tabPage4.Controls.Add(this.btnCrearEnJira);
            this.tabPage4.Controls.Add(this.lblDatosJira);
            this.tabPage4.Controls.Add(this.lblDatosMantis);
            this.tabPage4.Controls.Add(this.btnBuscarJira);
            this.tabPage4.Controls.Add(this.btnBuscarMantis);
            this.tabPage4.Controls.Add(this.txtNroMantis);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(566, 429);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Crear Jira";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // txtLabel
            // 
            this.txtLabel.Location = new System.Drawing.Point(349, 250);
            this.txtLabel.Name = "txtLabel";
            this.txtLabel.Size = new System.Drawing.Size(128, 20);
            this.txtLabel.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(128, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Comment";
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(194, 224);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(316, 20);
            this.txtComment.TabIndex = 22;
            // 
            // cmbComponent
            // 
            this.cmbComponent.FormattingEnabled = true;
            this.cmbComponent.Location = new System.Drawing.Point(194, 276);
            this.cmbComponent.Name = "cmbComponent";
            this.cmbComponent.Size = new System.Drawing.Size(149, 21);
            this.cmbComponent.TabIndex = 21;
            // 
            // cmbIssueType
            // 
            this.cmbIssueType.FormattingEnabled = true;
            this.cmbIssueType.Location = new System.Drawing.Point(194, 250);
            this.cmbIssueType.Name = "cmbIssueType";
            this.cmbIssueType.Size = new System.Drawing.Size(149, 21);
            this.cmbIssueType.TabIndex = 20;
            // 
            // lnkNewJira
            // 
            this.lnkNewJira.AutoSize = true;
            this.lnkNewJira.Location = new System.Drawing.Point(128, 346);
            this.lnkNewJira.Name = "lnkNewJira";
            this.lnkNewJira.Size = new System.Drawing.Size(43, 13);
            this.lnkNewJira.TabIndex = 19;
            this.lnkNewJira.TabStop = true;
            this.lnkNewJira.Text = "------------";
            this.lnkNewJira.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkNewJira_LinkClicked);
            // 
            // lblCreateResult
            // 
            this.lblCreateResult.AutoSize = true;
            this.lblCreateResult.Location = new System.Drawing.Point(128, 319);
            this.lblCreateResult.Name = "lblCreateResult";
            this.lblCreateResult.Size = new System.Drawing.Size(43, 13);
            this.lblCreateResult.TabIndex = 18;
            this.lblCreateResult.Text = "------------";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Component";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(410, 16);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 23);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(194, 198);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(316, 20);
            this.txtDescription.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Summary";
            // 
            // txtSummary
            // 
            this.txtSummary.Location = new System.Drawing.Point(194, 172);
            this.txtSummary.Name = "txtSummary";
            this.txtSummary.Size = new System.Drawing.Size(316, 20);
            this.txtSummary.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Project";
            // 
            // txtProjectKey
            // 
            this.txtProjectKey.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::MantisChew.Properties.Settings.Default, "JiraProject", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtProjectKey.Location = new System.Drawing.Point(194, 147);
            this.txtProjectKey.Name = "txtProjectKey";
            this.txtProjectKey.Size = new System.Drawing.Size(128, 20);
            this.txtProjectKey.TabIndex = 6;
            this.txtProjectKey.Text = global::MantisChew.Properties.Settings.Default.JiraProject;
            // 
            // btnCrearEnJira
            // 
            this.btnCrearEnJira.Location = new System.Drawing.Point(16, 170);
            this.btnCrearEnJira.Name = "btnCrearEnJira";
            this.btnCrearEnJira.Size = new System.Drawing.Size(100, 23);
            this.btnCrearEnJira.TabIndex = 5;
            this.btnCrearEnJira.Text = "Crear en Jira";
            this.btnCrearEnJira.UseVisualStyleBackColor = true;
            this.btnCrearEnJira.Click += new System.EventHandler(this.btnCrearEnJira_Click);
            // 
            // lblDatosJira
            // 
            this.lblDatosJira.AutoSize = true;
            this.lblDatosJira.Location = new System.Drawing.Point(128, 92);
            this.lblDatosJira.Name = "lblDatosJira";
            this.lblDatosJira.Size = new System.Drawing.Size(43, 13);
            this.lblDatosJira.TabIndex = 4;
            this.lblDatosJira.Text = "------------";
            // 
            // lblDatosMantis
            // 
            this.lblDatosMantis.AutoSize = true;
            this.lblDatosMantis.Location = new System.Drawing.Point(128, 56);
            this.lblDatosMantis.Name = "lblDatosMantis";
            this.lblDatosMantis.Size = new System.Drawing.Size(43, 13);
            this.lblDatosMantis.TabIndex = 3;
            this.lblDatosMantis.Text = "------------";
            // 
            // btnBuscarJira
            // 
            this.btnBuscarJira.Location = new System.Drawing.Point(17, 87);
            this.btnBuscarJira.Name = "btnBuscarJira";
            this.btnBuscarJira.Size = new System.Drawing.Size(100, 23);
            this.btnBuscarJira.TabIndex = 2;
            this.btnBuscarJira.Text = "Buscar en Jira";
            this.btnBuscarJira.UseVisualStyleBackColor = true;
            this.btnBuscarJira.Click += new System.EventHandler(this.btnBuscarJira_Click);
            // 
            // btnBuscarMantis
            // 
            this.btnBuscarMantis.Location = new System.Drawing.Point(17, 51);
            this.btnBuscarMantis.Name = "btnBuscarMantis";
            this.btnBuscarMantis.Size = new System.Drawing.Size(99, 23);
            this.btnBuscarMantis.TabIndex = 1;
            this.btnBuscarMantis.Text = "Buscar en Mantis";
            this.btnBuscarMantis.UseVisualStyleBackColor = true;
            this.btnBuscarMantis.Click += new System.EventHandler(this.btnBuscarMantis_Click);
            // 
            // txtNroMantis
            // 
            this.txtNroMantis.Location = new System.Drawing.Point(17, 16);
            this.txtNroMantis.Name = "txtNroMantis";
            this.txtNroMantis.Size = new System.Drawing.Size(100, 20);
            this.txtNroMantis.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.btnGuardarConfig);
            this.tabPage5.Controls.Add(this.btnCargarConfig);
            this.tabPage5.Controls.Add(this.dgvConfig);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(566, 429);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Configuracion";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btnGuardarConfig
            // 
            this.btnGuardarConfig.Location = new System.Drawing.Point(159, 6);
            this.btnGuardarConfig.Name = "btnGuardarConfig";
            this.btnGuardarConfig.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarConfig.TabIndex = 2;
            this.btnGuardarConfig.Text = "Guardar";
            this.btnGuardarConfig.UseVisualStyleBackColor = true;
            this.btnGuardarConfig.Click += new System.EventHandler(this.btnGuardarConfig_Click);
            // 
            // btnCargarConfig
            // 
            this.btnCargarConfig.Location = new System.Drawing.Point(6, 6);
            this.btnCargarConfig.Name = "btnCargarConfig";
            this.btnCargarConfig.Size = new System.Drawing.Size(75, 23);
            this.btnCargarConfig.TabIndex = 1;
            this.btnCargarConfig.Text = "Refrescar";
            this.btnCargarConfig.UseVisualStyleBackColor = true;
            this.btnCargarConfig.Click += new System.EventHandler(this.btnCargarConfig_Click);
            // 
            // dgvConfig
            // 
            this.dgvConfig.AllowUserToAddRows = false;
            this.dgvConfig.AllowUserToDeleteRows = false;
            this.dgvConfig.AllowUserToResizeRows = false;
            this.dgvConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvConfig.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvConfig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConfig.Location = new System.Drawing.Point(6, 35);
            this.dgvConfig.Name = "dgvConfig";
            this.dgvConfig.Size = new System.Drawing.Size(554, 388);
            this.dgvConfig.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 461);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(736, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(619, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // btnBajarTimeReport
            // 
            this.btnBajarTimeReport.Location = new System.Drawing.Point(88, 12);
            this.btnBajarTimeReport.Name = "btnBajarTimeReport";
            this.btnBajarTimeReport.Size = new System.Drawing.Size(75, 23);
            this.btnBajarTimeReport.TabIndex = 10;
            this.btnBajarTimeReport.Text = "Cargar Archivo";
            this.btnBajarTimeReport.UseVisualStyleBackColor = true;
            this.btnBajarTimeReport.Visible = false;
            this.btnBajarTimeReport.Click += new System.EventHandler(this.btnBajarTimeReport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 483);
            this.Controls.Add(this.btnBajarTimeReport);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnEquipo);
            this.Controls.Add(this.btnRefrescarDias);
            this.Controls.Add(this.clstUsuarios);
            this.Controls.Add(this.btnCargar);
            this.Name = "Form1";
            this.Text = "MantisChew";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorasxMantis)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorasxFecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleMantis)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorasxJira)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMantisEstado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadoAgrupado)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConfig)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.CheckedListBox clstUsuarios;
        private System.Windows.Forms.Button btnRefrescarDias;
        private System.Windows.Forms.Button btnEquipo;
        private System.Windows.Forms.DataGridView dgvHorasxMantis;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvHorasxFecha;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvHorasxJira;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBuscarTodosJira;
        private System.Windows.Forms.Button btnIrAJira;
        private System.Windows.Forms.Button btnIrAMantis;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvDetalleMantis;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.Button btnCargarDiferenciaEnJira;
        private System.Windows.Forms.Button btnCargarMantisInfo;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvMantisEstado;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.DataGridView dgvEstadoAgrupado;
        private System.Windows.Forms.Button btnLoginMantis;
        private System.Windows.Forms.Button btnBajarTimeReport;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnBuscarJira;
        private System.Windows.Forms.Button btnBuscarMantis;
        private System.Windows.Forms.TextBox txtNroMantis;
        private System.Windows.Forms.Label lblDatosMantis;
        private System.Windows.Forms.Label lblDatosJira;
        private System.Windows.Forms.Button btnCrearEnJira;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSummary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProjectKey;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCreateResult;
        private System.Windows.Forms.LinkLabel lnkNewJira;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dgvConfig;
        private System.Windows.Forms.Button btnCargarConfig;
        private System.Windows.Forms.Button btnGuardarConfig;
        private System.Windows.Forms.ComboBox cmbComponent;
        private System.Windows.Forms.ComboBox cmbIssueType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.TextBox txtLabel;
    }
}

