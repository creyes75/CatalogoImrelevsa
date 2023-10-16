namespace GeneraDatosCatalogo.Vista
{
    partial class FrmMantOrden
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMantOrden));
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.btnConsultaSAP = new System.Windows.Forms.Button();
            this.cmbTipoModificacion = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOrdenNivel6 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProductoId = new System.Windows.Forms.TextBox();
            this.txtIdNivel5 = new System.Windows.Forms.TextBox();
            this.txtIdNivel4 = new System.Windows.Forms.TextBox();
            this.txtIdNivel3 = new System.Windows.Forms.TextBox();
            this.txtIdNivel2 = new System.Windows.Forms.TextBox();
            this.txtIdNivel1 = new System.Windows.Forms.TextBox();
            this.NUDOrden = new System.Windows.Forms.NumericUpDown();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnGrabar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.lblAnular = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.GroupBox1.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDOrden)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox1.Controls.Add(this.GroupBox3);
            this.GroupBox1.Location = new System.Drawing.Point(12, 41);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(602, 287);
            this.GroupBox1.TabIndex = 6;
            this.GroupBox1.TabStop = false;
            // 
            // GroupBox3
            // 
            this.GroupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox3.Controls.Add(this.btnConsultaSAP);
            this.GroupBox3.Controls.Add(this.cmbTipoModificacion);
            this.GroupBox3.Controls.Add(this.label7);
            this.GroupBox3.Controls.Add(this.label6);
            this.GroupBox3.Controls.Add(this.txtOrdenNivel6);
            this.GroupBox3.Controls.Add(this.label5);
            this.GroupBox3.Controls.Add(this.label1);
            this.GroupBox3.Controls.Add(this.txtProductoId);
            this.GroupBox3.Controls.Add(this.txtIdNivel5);
            this.GroupBox3.Controls.Add(this.txtIdNivel4);
            this.GroupBox3.Controls.Add(this.txtIdNivel3);
            this.GroupBox3.Controls.Add(this.txtIdNivel2);
            this.GroupBox3.Controls.Add(this.txtIdNivel1);
            this.GroupBox3.Controls.Add(this.NUDOrden);
            this.GroupBox3.Controls.Add(this.Label8);
            this.GroupBox3.Controls.Add(this.Label4);
            this.GroupBox3.Controls.Add(this.Label3);
            this.GroupBox3.Controls.Add(this.Label2);
            this.GroupBox3.Controls.Add(this.lblTipo);
            this.GroupBox3.Location = new System.Drawing.Point(22, 10);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(563, 261);
            this.GroupBox3.TabIndex = 100;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Datos";
            // 
            // btnConsultaSAP
            // 
            this.btnConsultaSAP.Location = new System.Drawing.Point(338, 17);
            this.btnConsultaSAP.Name = "btnConsultaSAP";
            this.btnConsultaSAP.Size = new System.Drawing.Size(41, 20);
            this.btnConsultaSAP.TabIndex = 156;
            this.btnConsultaSAP.Text = "SAP";
            this.btnConsultaSAP.UseVisualStyleBackColor = true;
            this.btnConsultaSAP.Click += new System.EventHandler(this.btnConsultaSAP_Click);
            // 
            // cmbTipoModificacion
            // 
            this.cmbTipoModificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoModificacion.FormattingEnabled = true;
            this.cmbTipoModificacion.Items.AddRange(new object[] {
            "Insertar Numeracion",
            "Reemplazar Numeracion",
            "Adicionar al final"});
            this.cmbTipoModificacion.Location = new System.Drawing.Point(224, 176);
            this.cmbTipoModificacion.Name = "cmbTipoModificacion";
            this.cmbTipoModificacion.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoModificacion.TabIndex = 18;
            this.cmbTipoModificacion.SelectedIndexChanged += new System.EventHandler(this.cmbTipoModificacion_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 155;
            this.label7.Text = "Tipo Modificacion :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 154;
            this.label6.Text = "Orden Nivel 6:";
            // 
            // txtOrdenNivel6
            // 
            this.txtOrdenNivel6.Location = new System.Drawing.Point(224, 227);
            this.txtOrdenNivel6.Name = "txtOrdenNivel6";
            this.txtOrdenNivel6.Size = new System.Drawing.Size(222, 20);
            this.txtOrdenNivel6.TabIndex = 17;
            this.txtOrdenNivel6.TextChanged += new System.EventHandler(this.txtOrdenNivel6_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 152;
            this.label5.Text = "Orden:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 151;
            this.label1.Text = "Nivel 5:";
            // 
            // txtProductoId
            // 
            this.txtProductoId.Location = new System.Drawing.Point(224, 18);
            this.txtProductoId.Name = "txtProductoId";
            this.txtProductoId.Size = new System.Drawing.Size(100, 20);
            this.txtProductoId.TabIndex = 10;
            this.txtProductoId.TextChanged += new System.EventHandler(this.txtProductoId_TextChanged);
            this.txtProductoId.Leave += new System.EventHandler(this.txtProductoId_Leave);
            // 
            // txtIdNivel5
            // 
            this.txtIdNivel5.Enabled = false;
            this.txtIdNivel5.Location = new System.Drawing.Point(224, 150);
            this.txtIdNivel5.Name = "txtIdNivel5";
            this.txtIdNivel5.Size = new System.Drawing.Size(100, 20);
            this.txtIdNivel5.TabIndex = 15;
            this.txtIdNivel5.TextChanged += new System.EventHandler(this.txtIdNivel5_TextChanged);
            // 
            // txtIdNivel4
            // 
            this.txtIdNivel4.Enabled = false;
            this.txtIdNivel4.Location = new System.Drawing.Point(224, 124);
            this.txtIdNivel4.Name = "txtIdNivel4";
            this.txtIdNivel4.Size = new System.Drawing.Size(100, 20);
            this.txtIdNivel4.TabIndex = 14;
            this.txtIdNivel4.TextChanged += new System.EventHandler(this.txtIdNivel4_TextChanged);
            // 
            // txtIdNivel3
            // 
            this.txtIdNivel3.Enabled = false;
            this.txtIdNivel3.Location = new System.Drawing.Point(224, 98);
            this.txtIdNivel3.Name = "txtIdNivel3";
            this.txtIdNivel3.Size = new System.Drawing.Size(100, 20);
            this.txtIdNivel3.TabIndex = 13;
            this.txtIdNivel3.TextChanged += new System.EventHandler(this.txtIdNivel3_TextChanged);
            // 
            // txtIdNivel2
            // 
            this.txtIdNivel2.Enabled = false;
            this.txtIdNivel2.Location = new System.Drawing.Point(225, 71);
            this.txtIdNivel2.Name = "txtIdNivel2";
            this.txtIdNivel2.Size = new System.Drawing.Size(100, 20);
            this.txtIdNivel2.TabIndex = 12;
            this.txtIdNivel2.TextChanged += new System.EventHandler(this.txtIdNivel2_TextChanged);
            // 
            // txtIdNivel1
            // 
            this.txtIdNivel1.Enabled = false;
            this.txtIdNivel1.Location = new System.Drawing.Point(225, 45);
            this.txtIdNivel1.Name = "txtIdNivel1";
            this.txtIdNivel1.Size = new System.Drawing.Size(100, 20);
            this.txtIdNivel1.TabIndex = 11;
            this.txtIdNivel1.TextChanged += new System.EventHandler(this.txtIdNivel1_TextChanged);
            // 
            // NUDOrden
            // 
            this.NUDOrden.Location = new System.Drawing.Point(225, 201);
            this.NUDOrden.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.NUDOrden.Name = "NUDOrden";
            this.NUDOrden.Size = new System.Drawing.Size(59, 20);
            this.NUDOrden.TabIndex = 16;
            this.NUDOrden.ValueChanged += new System.EventHandler(this.NUDOrden_ValueChanged);
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(29, 47);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(43, 13);
            this.Label8.TabIndex = 129;
            this.Label8.Text = "Nivel 1:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(30, 126);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(43, 13);
            this.Label4.TabIndex = 125;
            this.Label4.Text = "Nivel 4:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(30, 99);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(43, 13);
            this.Label3.TabIndex = 123;
            this.Label3.Text = "Nivel 3:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(30, 73);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(43, 13);
            this.Label2.TabIndex = 121;
            this.Label2.Text = "Nivel 2:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(28, 21);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(77, 13);
            this.lblTipo.TabIndex = 111;
            this.lblTipo.Text = "Producto Id:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnNuevo,
            this.btnGrabar,
            this.btnEliminar,
            this.btnBuscar,
            this.btnCancelar,
            this.btnSalir,
            this.lblAnular,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(630, 37);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("BtnNuevo.Image")));
            this.BtnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(34, 34);
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGrabar.Image = ((System.Drawing.Image)(resources.GetObject("btnGrabar.Image")));
            this.btnGrabar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(34, 34);
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(34, 34);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(34, 34);
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(34, 34);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(34, 34);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblAnular
            // 
            this.lblAnular.Name = "lblAnular";
            this.lblAnular.Size = new System.Drawing.Size(0, 34);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 37);
            // 
            // FrmMantOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 337);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.GroupBox1);
            this.Name = "FrmMantOrden";
            this.Text = "FrmMantOrden";
            this.Load += new System.EventHandler(this.FrmMantOrden_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDOrden)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.NumericUpDown NUDOrden;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnNuevo;
        private System.Windows.Forms.ToolStripButton btnGrabar;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.TextBox txtIdNivel5;
        private System.Windows.Forms.TextBox txtIdNivel4;
        private System.Windows.Forms.TextBox txtIdNivel3;
        private System.Windows.Forms.TextBox txtIdNivel2;
        private System.Windows.Forms.TextBox txtIdNivel1;
        internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOrdenNivel6;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProductoId;
        private System.Windows.Forms.ToolStripLabel lblAnular;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ComboBox cmbTipoModificacion;
        internal System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnConsultaSAP;
    }
}