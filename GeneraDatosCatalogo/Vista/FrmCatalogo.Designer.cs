namespace GeneraDatosCatalogo
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dGViewProductos = new System.Windows.Forms.DataGridView();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnExportarExcel = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tSB_Save = new System.Windows.Forms.ToolStripButton();
            this.tSB_New = new System.Windows.Forms.ToolStripButton();
            this.tSBOpen = new System.Windows.Forms.ToolStripButton();
            this.tSBExcel = new System.Windows.Forms.ToolStripButton();
            this.tSBConfig = new System.Windows.Forms.ToolStripButton();
            this.tSBExit = new System.Windows.Forms.ToolStripButton();
            this.tSLDetalles = new System.Windows.Forms.ToolStripLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.insertarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restablecerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblProgress = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGViewProductos)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGViewProductos
            // 
            this.dGViewProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGViewProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGViewProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dGViewProductos.Location = new System.Drawing.Point(12, 69);
            this.dGViewProductos.Name = "dGViewProductos";
            this.dGViewProductos.Size = new System.Drawing.Size(776, 200);
            this.dGViewProductos.TabIndex = 0;
            this.dGViewProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGViewProductos_CellContentClick);
            this.dGViewProductos.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.lista_dias_CellMouseClick);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(336, 12);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(73, 37);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "Nuevo Catalogo";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.Location = new System.Drawing.Point(459, 21);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new System.Drawing.Size(61, 27);
            this.btnExportarExcel.TabIndex = 2;
            this.btnExportarExcel.Text = "Exportar Excel";
            this.btnExportarExcel.UseVisualStyleBackColor = true;
            this.btnExportarExcel.Click += new System.EventHandler(this.btnExportarExcel_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSB_Save,
            this.tSB_New,
            this.tSBOpen,
            this.tSBExcel,
            this.tSBConfig,
            this.tSBExit,
            this.tSLDetalles});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 57);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // tSB_Save
            // 
            this.tSB_Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSB_Save.Image = ((System.Drawing.Image)(resources.GetObject("tSB_Save.Image")));
            this.tSB_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB_Save.Name = "tSB_Save";
            this.tSB_Save.Size = new System.Drawing.Size(54, 54);
            this.tSB_Save.Text = "tSB_Save";
            this.tSB_Save.ToolTipText = "Guardar Catalogo";
            this.tSB_Save.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tSB_New
            // 
            this.tSB_New.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSB_New.Image = ((System.Drawing.Image)(resources.GetObject("tSB_New.Image")));
            this.tSB_New.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB_New.Name = "tSB_New";
            this.tSB_New.Size = new System.Drawing.Size(54, 54);
            this.tSB_New.ToolTipText = "Nuevo Catalogo";
            this.tSB_New.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // tSBOpen
            // 
            this.tSBOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBOpen.Image = ((System.Drawing.Image)(resources.GetObject("tSBOpen.Image")));
            this.tSBOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBOpen.Name = "tSBOpen";
            this.tSBOpen.Size = new System.Drawing.Size(54, 54);
            this.tSBOpen.ToolTipText = "Abrir Catalogo";
            this.tSBOpen.Click += new System.EventHandler(this.tSBOpen_Click);
            // 
            // tSBExcel
            // 
            this.tSBExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBExcel.Image = ((System.Drawing.Image)(resources.GetObject("tSBExcel.Image")));
            this.tSBExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBExcel.Name = "tSBExcel";
            this.tSBExcel.Size = new System.Drawing.Size(54, 54);
            this.tSBExcel.ToolTipText = "Exportar EXCEL";
            this.tSBExcel.Click += new System.EventHandler(this.btnExportarExcel_Click);
            // 
            // tSBConfig
            // 
            this.tSBConfig.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBConfig.Image = ((System.Drawing.Image)(resources.GetObject("tSBConfig.Image")));
            this.tSBConfig.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBConfig.Name = "tSBConfig";
            this.tSBConfig.Size = new System.Drawing.Size(54, 54);
            this.tSBConfig.ToolTipText = "Configuracion";
            this.tSBConfig.Click += new System.EventHandler(this.tSBConfig_Click);
            // 
            // tSBExit
            // 
            this.tSBExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBExit.Image = ((System.Drawing.Image)(resources.GetObject("tSBExit.Image")));
            this.tSBExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBExit.Name = "tSBExit";
            this.tSBExit.Size = new System.Drawing.Size(54, 54);
            this.tSBExit.ToolTipText = "Salir";
            this.tSBExit.Click += new System.EventHandler(this.tSBExit_Click);
            // 
            // tSLDetalles
            // 
            this.tSLDetalles.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tSLDetalles.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tSLDetalles.Name = "tSLDetalles";
            this.tSLDetalles.Size = new System.Drawing.Size(0, 54);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertarToolStripMenuItem,
            this.restablecerToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(135, 48);
            // 
            // insertarToolStripMenuItem
            // 
            this.insertarToolStripMenuItem.Name = "insertarToolStripMenuItem";
            this.insertarToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.insertarToolStripMenuItem.Text = "Insertar";
            this.insertarToolStripMenuItem.Click += new System.EventHandler(this.ContextMenuStrip_Click);
            // 
            // restablecerToolStripMenuItem
            // 
            this.restablecerToolStripMenuItem.Name = "restablecerToolStripMenuItem";
            this.restablecerToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.restablecerToolStripMenuItem.Text = "Restablecer";
            this.restablecerToolStripMenuItem.Click += new System.EventHandler(this.restablecerToolStripMenuItem_Click);
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblProgress.Location = new System.Drawing.Point(0, 268);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(0, 13);
            this.lblProgress.TabIndex = 5;
            this.lblProgress.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 281);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnExportarExcel);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dGViewProductos);
            this.Name = "Form1";
            this.Text = "Sistema de Generación de información de Catálogos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGViewProductos)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGViewProductos;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnExportarExcel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tSB_New;
        private System.Windows.Forms.ToolStripButton tSBOpen;
        private System.Windows.Forms.ToolStripButton tSBExcel;
        private System.Windows.Forms.ToolStripButton tSBExit;
        private System.Windows.Forms.ToolStripButton tSBConfig;
        private System.Windows.Forms.ToolStripLabel tSLDetalles;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem insertarToolStripMenuItem;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.ToolStripButton tSB_Save;
        private System.Windows.Forms.ToolStripMenuItem restablecerToolStripMenuItem;
    }
}

