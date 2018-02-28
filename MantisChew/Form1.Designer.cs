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
            this.btnCargarMantisInfo = new System.Windows.Forms.Button();
            this.dgvMantisEstado = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.dgvEstadoAgrupado = new System.Windows.Forms.DataGridView();
            this.btnLoginMantis = new System.Windows.Forms.Button();
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
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadoAgrupado)).BeginInit();
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
            this.tabControl1.Location = new System.Drawing.Point(162, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(574, 455);
            this.tabControl1.TabIndex = 8;
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
            this.splitContainer3.Panel1.Controls.Add(this.btnCargarMantisInfo);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.dgvEstadoAgrupado);
            this.splitContainer3.Panel2.Controls.Add(this.dgvMantisEstado);
            this.splitContainer3.Size = new System.Drawing.Size(560, 423);
            this.splitContainer3.SplitterDistance = 32;
            this.splitContainer3.TabIndex = 6;
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
            this.dgvMantisEstado.Location = new System.Drawing.Point(0, 0);
            this.dgvMantisEstado.Name = "dgvMantisEstado";
            this.dgvMantisEstado.ReadOnly = true;
            this.dgvMantisEstado.RowHeadersVisible = false;
            this.dgvMantisEstado.Size = new System.Drawing.Size(560, 298);
            this.dgvMantisEstado.TabIndex = 5;
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
            // dgvEstadoAgrupado
            // 
            this.dgvEstadoAgrupado.AllowUserToAddRows = false;
            this.dgvEstadoAgrupado.AllowUserToDeleteRows = false;
            this.dgvEstadoAgrupado.AllowUserToOrderColumns = true;
            this.dgvEstadoAgrupado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEstadoAgrupado.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dgvEstadoAgrupado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstadoAgrupado.Location = new System.Drawing.Point(0, 303);
            this.dgvEstadoAgrupado.Name = "dgvEstadoAgrupado";
            this.dgvEstadoAgrupado.ReadOnly = true;
            this.dgvEstadoAgrupado.RowHeadersVisible = false;
            this.dgvEstadoAgrupado.Size = new System.Drawing.Size(560, 84);
            this.dgvEstadoAgrupado.TabIndex = 6;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 483);
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
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadoAgrupado)).EndInit();
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
    }
}

