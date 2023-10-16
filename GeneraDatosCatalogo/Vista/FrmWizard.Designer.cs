namespace WizardLayout
{
    partial class FrmWizard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWizard));
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pBarCatalogo = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtODatosAdic_File = new System.Windows.Forms.TextBox();
            this.btnSeleccionarOD = new System.Windows.Forms.Button();
            this.dGVOrigenDatosAdic = new System.Windows.Forms.DataGridView();
            this.btnODatosAdic_Add = new System.Windows.Forms.Button();
            this.btnODatosAdic_Remove = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.chkListCampos = new System.Windows.Forms.CheckedListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTituloPnl2 = new System.Windows.Forms.Label();
            this.LboxODatosAdic = new System.Windows.Forms.ListBox();
            this.PnlOpt2 = new System.Windows.Forms.Panel();
            this.PnlOpt3 = new System.Windows.Forms.Panel();
            this.gBoxIn = new System.Windows.Forms.GroupBox();
            this.cmbInValor = new System.Windows.Forms.ComboBox();
            this.btnInDel = new System.Windows.Forms.Button();
            this.LstInDetalle = new System.Windows.Forms.ListBox();
            this.btnInAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInValor = new System.Windows.Forms.TextBox();
            this.lblSeleccionCampos = new System.Windows.Forms.Label();
            this.lblTituloPnl3 = new System.Windows.Forms.Label();
            this.LstCriterios = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbOperador = new System.Windows.Forms.ComboBox();
            this.cmbCampo = new System.Windows.Forms.ComboBox();
            this.cmbOrigenDatos = new System.Windows.Forms.ComboBox();
            this.gBoxValor = new System.Windows.Forms.GroupBox();
            this.cmbValor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.PnlOpt1 = new System.Windows.Forms.Panel();
            this.cmbTipoCatalogo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTituloPnl1 = new System.Windows.Forms.Label();
            this.pnlBottom.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVOrigenDatosAdic)).BeginInit();
            this.PnlOpt2.SuspendLayout();
            this.PnlOpt3.SuspendLayout();
            this.gBoxIn.SuspendLayout();
            this.gBoxValor.SuspendLayout();
            this.PnlOpt1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(172, 450);
            this.pnlLeft.TabIndex = 1;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBottom.Controls.Add(this.pBarCatalogo);
            this.pnlBottom.Controls.Add(this.tableLayoutPanel1);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(172, 387);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Padding = new System.Windows.Forms.Padding(10);
            this.pnlBottom.Size = new System.Drawing.Size(628, 63);
            this.pnlBottom.TabIndex = 5;
            this.pnlBottom.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBottom_Paint);
            // 
            // pBarCatalogo
            // 
            this.pBarCatalogo.Location = new System.Drawing.Point(43, 20);
            this.pBarCatalogo.Name = "pBarCatalogo";
            this.pBarCatalogo.Size = new System.Drawing.Size(289, 23);
            this.pBarCatalogo.TabIndex = 1;
            this.pBarCatalogo.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnNext, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnBack, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(375, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(243, 43);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Location = new System.Drawing.Point(158, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(70, 31);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnNext
            // 
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNext.Location = new System.Drawing.Point(82, 6);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(70, 31);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "&Next >";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click_1);
            // 
            // btnBack
            // 
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBack.Location = new System.Drawing.Point(6, 6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(70, 31);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "< &Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // txtODatosAdic_File
            // 
            this.txtODatosAdic_File.Location = new System.Drawing.Point(103, 79);
            this.txtODatosAdic_File.Name = "txtODatosAdic_File";
            this.txtODatosAdic_File.Size = new System.Drawing.Size(153, 20);
            this.txtODatosAdic_File.TabIndex = 0;
            // 
            // btnSeleccionarOD
            // 
            this.btnSeleccionarOD.Location = new System.Drawing.Point(262, 79);
            this.btnSeleccionarOD.Name = "btnSeleccionarOD";
            this.btnSeleccionarOD.Size = new System.Drawing.Size(23, 23);
            this.btnSeleccionarOD.TabIndex = 1;
            this.btnSeleccionarOD.Text = "...";
            this.btnSeleccionarOD.UseVisualStyleBackColor = true;
            this.btnSeleccionarOD.Click += new System.EventHandler(this.button1_Click);
            // 
            // dGVOrigenDatosAdic
            // 
            this.dGVOrigenDatosAdic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVOrigenDatosAdic.Location = new System.Drawing.Point(25, 121);
            this.dGVOrigenDatosAdic.Name = "dGVOrigenDatosAdic";
            this.dGVOrigenDatosAdic.Size = new System.Drawing.Size(260, 102);
            this.dGVOrigenDatosAdic.TabIndex = 2;
            // 
            // btnODatosAdic_Add
            // 
            this.btnODatosAdic_Add.Location = new System.Drawing.Point(304, 151);
            this.btnODatosAdic_Add.Name = "btnODatosAdic_Add";
            this.btnODatosAdic_Add.Size = new System.Drawing.Size(75, 23);
            this.btnODatosAdic_Add.TabIndex = 4;
            this.btnODatosAdic_Add.Text = ">>";
            this.btnODatosAdic_Add.UseVisualStyleBackColor = true;
            this.btnODatosAdic_Add.Click += new System.EventHandler(this.btnODatosAdic_Add_Click);
            // 
            // btnODatosAdic_Remove
            // 
            this.btnODatosAdic_Remove.Location = new System.Drawing.Point(304, 180);
            this.btnODatosAdic_Remove.Name = "btnODatosAdic_Remove";
            this.btnODatosAdic_Remove.Size = new System.Drawing.Size(75, 23);
            this.btnODatosAdic_Remove.TabIndex = 5;
            this.btnODatosAdic_Remove.Text = "<<";
            this.btnODatosAdic_Remove.UseVisualStyleBackColor = true;
            this.btnODatosAdic_Remove.Click += new System.EventHandler(this.btnODatosAdic_Remove_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(25, 98);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(81, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Vista previa";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // chkListCampos
            // 
            this.chkListCampos.FormattingEnabled = true;
            this.chkListCampos.Location = new System.Drawing.Point(25, 259);
            this.chkListCampos.Name = "chkListCampos";
            this.chkListCampos.Size = new System.Drawing.Size(260, 94);
            this.chkListCampos.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Archivo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 243);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Detalle de campos";
            // 
            // lblTituloPnl2
            // 
            this.lblTituloPnl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTituloPnl2.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.lblTituloPnl2.Location = new System.Drawing.Point(4, 17);
            this.lblTituloPnl2.Name = "lblTituloPnl2";
            this.lblTituloPnl2.Size = new System.Drawing.Size(608, 45);
            this.lblTituloPnl2.TabIndex = 26;
            this.lblTituloPnl2.Text = "Selección de Orígenes de Datos Adicionales";
            this.lblTituloPnl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LboxODatosAdic
            // 
            this.LboxODatosAdic.FormattingEnabled = true;
            this.LboxODatosAdic.Location = new System.Drawing.Point(398, 121);
            this.LboxODatosAdic.Name = "LboxODatosAdic";
            this.LboxODatosAdic.Size = new System.Drawing.Size(183, 186);
            this.LboxODatosAdic.TabIndex = 27;
            // 
            // PnlOpt2
            // 
            this.PnlOpt2.Controls.Add(this.LboxODatosAdic);
            this.PnlOpt2.Controls.Add(this.lblTituloPnl2);
            this.PnlOpt2.Controls.Add(this.label9);
            this.PnlOpt2.Controls.Add(this.label8);
            this.PnlOpt2.Controls.Add(this.chkListCampos);
            this.PnlOpt2.Controls.Add(this.checkBox1);
            this.PnlOpt2.Controls.Add(this.btnODatosAdic_Remove);
            this.PnlOpt2.Controls.Add(this.btnODatosAdic_Add);
            this.PnlOpt2.Controls.Add(this.dGVOrigenDatosAdic);
            this.PnlOpt2.Controls.Add(this.btnSeleccionarOD);
            this.PnlOpt2.Controls.Add(this.txtODatosAdic_File);
            this.PnlOpt2.Location = new System.Drawing.Point(175, 0);
            this.PnlOpt2.Name = "PnlOpt2";
            this.PnlOpt2.Size = new System.Drawing.Size(615, 400);
            this.PnlOpt2.TabIndex = 3;
            // 
            // PnlOpt3
            // 
            this.PnlOpt3.Controls.Add(this.gBoxIn);
            this.PnlOpt3.Controls.Add(this.lblSeleccionCampos);
            this.PnlOpt3.Controls.Add(this.lblTituloPnl3);
            this.PnlOpt3.Controls.Add(this.LstCriterios);
            this.PnlOpt3.Controls.Add(this.btnRemove);
            this.PnlOpt3.Controls.Add(this.btnAdd);
            this.PnlOpt3.Controls.Add(this.label3);
            this.PnlOpt3.Controls.Add(this.label5);
            this.PnlOpt3.Controls.Add(this.label6);
            this.PnlOpt3.Controls.Add(this.cmbOperador);
            this.PnlOpt3.Controls.Add(this.cmbCampo);
            this.PnlOpt3.Controls.Add(this.cmbOrigenDatos);
            this.PnlOpt3.Controls.Add(this.gBoxValor);
            this.PnlOpt3.Location = new System.Drawing.Point(175, 0);
            this.PnlOpt3.Name = "PnlOpt3";
            this.PnlOpt3.Size = new System.Drawing.Size(615, 400);
            this.PnlOpt3.TabIndex = 6;
            // 
            // gBoxIn
            // 
            this.gBoxIn.Controls.Add(this.cmbInValor);
            this.gBoxIn.Controls.Add(this.btnInDel);
            this.gBoxIn.Controls.Add(this.LstInDetalle);
            this.gBoxIn.Controls.Add(this.btnInAdd);
            this.gBoxIn.Controls.Add(this.label1);
            this.gBoxIn.Controls.Add(this.txtInValor);
            this.gBoxIn.Location = new System.Drawing.Point(40, 209);
            this.gBoxIn.Name = "gBoxIn";
            this.gBoxIn.Size = new System.Drawing.Size(244, 121);
            this.gBoxIn.TabIndex = 27;
            this.gBoxIn.TabStop = false;
            this.gBoxIn.Visible = false;
            // 
            // cmbInValor
            // 
            this.cmbInValor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInValor.DropDownWidth = 200;
            this.cmbInValor.FormattingEnabled = true;
            this.cmbInValor.Location = new System.Drawing.Point(92, 13);
            this.cmbInValor.Name = "cmbInValor";
            this.cmbInValor.Size = new System.Drawing.Size(101, 21);
            this.cmbInValor.TabIndex = 27;
            this.cmbInValor.SelectedIndexChanged += new System.EventHandler(this.cmbInValor_SelectedIndexChanged);
            // 
            // btnInDel
            // 
            this.btnInDel.Location = new System.Drawing.Point(217, 13);
            this.btnInDel.Name = "btnInDel";
            this.btnInDel.Size = new System.Drawing.Size(18, 21);
            this.btnInDel.TabIndex = 25;
            this.btnInDel.Text = "-";
            this.btnInDel.UseVisualStyleBackColor = true;
            this.btnInDel.Click += new System.EventHandler(this.btnInDel_Click);
            // 
            // LstInDetalle
            // 
            this.LstInDetalle.FormattingEnabled = true;
            this.LstInDetalle.Location = new System.Drawing.Point(115, 38);
            this.LstInDetalle.Name = "LstInDetalle";
            this.LstInDetalle.Size = new System.Drawing.Size(120, 69);
            this.LstInDetalle.TabIndex = 24;
            // 
            // btnInAdd
            // 
            this.btnInAdd.Location = new System.Drawing.Point(197, 13);
            this.btnInAdd.Name = "btnInAdd";
            this.btnInAdd.Size = new System.Drawing.Size(18, 21);
            this.btnInAdd.TabIndex = 23;
            this.btnInAdd.Text = "+";
            this.btnInAdd.UseVisualStyleBackColor = true;
            this.btnInAdd.Click += new System.EventHandler(this.btnInAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Valor";
            // 
            // txtInValor
            // 
            this.txtInValor.Location = new System.Drawing.Point(115, 13);
            this.txtInValor.Name = "txtInValor";
            this.txtInValor.Size = new System.Drawing.Size(78, 20);
            this.txtInValor.TabIndex = 18;
            // 
            // lblSeleccionCampos
            // 
            this.lblSeleccionCampos.AutoSize = true;
            this.lblSeleccionCampos.Location = new System.Drawing.Point(46, 356);
            this.lblSeleccionCampos.Name = "lblSeleccionCampos";
            this.lblSeleccionCampos.Size = new System.Drawing.Size(0, 13);
            this.lblSeleccionCampos.TabIndex = 26;
            // 
            // lblTituloPnl3
            // 
            this.lblTituloPnl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTituloPnl3.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.lblTituloPnl3.Location = new System.Drawing.Point(4, 17);
            this.lblTituloPnl3.Name = "lblTituloPnl3";
            this.lblTituloPnl3.Size = new System.Drawing.Size(608, 45);
            this.lblTituloPnl3.TabIndex = 25;
            this.lblTituloPnl3.Text = "Selección de parámetros";
            this.lblTituloPnl3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LstCriterios
            // 
            this.LstCriterios.FormattingEnabled = true;
            this.LstCriterios.Location = new System.Drawing.Point(370, 128);
            this.LstCriterios.Name = "LstCriterios";
            this.LstCriterios.Size = new System.Drawing.Size(198, 147);
            this.LstCriterios.TabIndex = 24;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(304, 177);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(60, 23);
            this.btnRemove.TabIndex = 23;
            this.btnRemove.Text = "<<";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(304, 149);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(60, 23);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = ">>";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Operador";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Propiedad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Origen de Datos";
            // 
            // cmbOperador
            // 
            this.cmbOperador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperador.FormattingEnabled = true;
            this.cmbOperador.Items.AddRange(new object[] {
            "=",
            ">",
            ">=",
            "<",
            "<=",
            "In",
            "not In"});
            this.cmbOperador.Location = new System.Drawing.Point(156, 179);
            this.cmbOperador.Name = "cmbOperador";
            this.cmbOperador.Size = new System.Drawing.Size(121, 21);
            this.cmbOperador.TabIndex = 16;
            this.cmbOperador.SelectedIndexChanged += new System.EventHandler(this.cmbOperador_SelectedIndexChanged);
            // 
            // cmbCampo
            // 
            this.cmbCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCampo.FormattingEnabled = true;
            this.cmbCampo.Location = new System.Drawing.Point(156, 152);
            this.cmbCampo.Name = "cmbCampo";
            this.cmbCampo.Size = new System.Drawing.Size(121, 21);
            this.cmbCampo.TabIndex = 15;
            this.cmbCampo.SelectedIndexChanged += new System.EventHandler(this.cmbCampo_SelectedIndexChanged);
            // 
            // cmbOrigenDatos
            // 
            this.cmbOrigenDatos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrigenDatos.FormattingEnabled = true;
            this.cmbOrigenDatos.Items.AddRange(new object[] {
            "SAP"});
            this.cmbOrigenDatos.Location = new System.Drawing.Point(156, 125);
            this.cmbOrigenDatos.Name = "cmbOrigenDatos";
            this.cmbOrigenDatos.Size = new System.Drawing.Size(121, 21);
            this.cmbOrigenDatos.TabIndex = 14;
            this.cmbOrigenDatos.SelectedIndexChanged += new System.EventHandler(this.cmbOrigenDatos_SelectedIndexChanged);
            // 
            // gBoxValor
            // 
            this.gBoxValor.Controls.Add(this.cmbValor);
            this.gBoxValor.Controls.Add(this.label4);
            this.gBoxValor.Controls.Add(this.txtValor);
            this.gBoxValor.Location = new System.Drawing.Point(40, 209);
            this.gBoxValor.Name = "gBoxValor";
            this.gBoxValor.Size = new System.Drawing.Size(244, 82);
            this.gBoxValor.TabIndex = 28;
            this.gBoxValor.TabStop = false;
            // 
            // cmbValor
            // 
            this.cmbValor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbValor.DropDownWidth = 200;
            this.cmbValor.FormattingEnabled = true;
            this.cmbValor.Location = new System.Drawing.Point(116, 13);
            this.cmbValor.Name = "cmbValor";
            this.cmbValor.Size = new System.Drawing.Size(121, 21);
            this.cmbValor.TabIndex = 26;
            this.cmbValor.SelectedIndexChanged += new System.EventHandler(this.cmbValor_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(116, 13);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 24;
            // 
            // PnlOpt1
            // 
            this.PnlOpt1.Controls.Add(this.cmbTipoCatalogo);
            this.PnlOpt1.Controls.Add(this.label7);
            this.PnlOpt1.Controls.Add(this.label2);
            this.PnlOpt1.Controls.Add(this.pictureBox1);
            this.PnlOpt1.Controls.Add(this.lblTituloPnl1);
            this.PnlOpt1.Location = new System.Drawing.Point(175, 0);
            this.PnlOpt1.Name = "PnlOpt1";
            this.PnlOpt1.Size = new System.Drawing.Size(615, 400);
            this.PnlOpt1.TabIndex = 8;
            // 
            // cmbTipoCatalogo
            // 
            this.cmbTipoCatalogo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoCatalogo.FormattingEnabled = true;
            this.cmbTipoCatalogo.Items.AddRange(new object[] {
            "GENERAL",
            "LISTA",
            "MARCA",
            "Personalizado"});
            this.cmbTipoCatalogo.Location = new System.Drawing.Point(132, 336);
            this.cmbTipoCatalogo.Name = "cmbTipoCatalogo";
            this.cmbTipoCatalogo.Size = new System.Drawing.Size(168, 21);
            this.cmbTipoCatalogo.TabIndex = 11;
            this.cmbTipoCatalogo.Visible = false;
            this.cmbTipoCatalogo.SelectedIndexChanged += new System.EventHandler(this.cmbTipoCatalogo_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tipo de Catalogo";
            this.label7.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label2.Location = new System.Drawing.Point(1, 238);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label2.Size = new System.Drawing.Size(615, 80);
            this.label2.TabIndex = 9;
            this.label2.Text = resources.GetString("label2.Text");
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(615, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // lblTituloPnl1
            // 
            this.lblTituloPnl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTituloPnl1.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.lblTituloPnl1.Location = new System.Drawing.Point(0, 0);
            this.lblTituloPnl1.Name = "lblTituloPnl1";
            this.lblTituloPnl1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lblTituloPnl1.Size = new System.Drawing.Size(615, 53);
            this.lblTituloPnl1.TabIndex = 4;
            this.lblTituloPnl1.Text = "Generación de Catalogos";
            this.lblTituloPnl1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.PnlOpt3);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.PnlOpt1);
            this.Controls.Add(this.PnlOpt2);
            this.Name = "FrmWizard";
            this.Text = "Wizard- Generacion de Nuevo Catalogo";
            this.Load += new System.EventHandler(this.FrmWizard_Load);
            this.pnlBottom.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVOrigenDatosAdic)).EndInit();
            this.PnlOpt2.ResumeLayout(false);
            this.PnlOpt2.PerformLayout();
            this.PnlOpt3.ResumeLayout(false);
            this.PnlOpt3.PerformLayout();
            this.gBoxIn.ResumeLayout(false);
            this.gBoxIn.PerformLayout();
            this.gBoxValor.ResumeLayout(false);
            this.gBoxValor.PerformLayout();
            this.PnlOpt1.ResumeLayout(false);
            this.PnlOpt1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ProgressBar pBarCatalogo;
        private System.Windows.Forms.TextBox txtODatosAdic_File;
        private System.Windows.Forms.Button btnSeleccionarOD;
        private System.Windows.Forms.DataGridView dGVOrigenDatosAdic;
        private System.Windows.Forms.Button btnODatosAdic_Add;
        private System.Windows.Forms.Button btnODatosAdic_Remove;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckedListBox chkListCampos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTituloPnl2;
        private System.Windows.Forms.ListBox LboxODatosAdic;
        private System.Windows.Forms.Panel PnlOpt2;
        private System.Windows.Forms.Panel PnlOpt3;
        private System.Windows.Forms.GroupBox gBoxValor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.GroupBox gBoxIn;
        private System.Windows.Forms.Button btnInDel;
        private System.Windows.Forms.ListBox LstInDetalle;
        private System.Windows.Forms.Button btnInAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInValor;
        private System.Windows.Forms.Label lblSeleccionCampos;
        private System.Windows.Forms.Label lblTituloPnl3;
        private System.Windows.Forms.ListBox LstCriterios;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbOperador;
        private System.Windows.Forms.ComboBox cmbCampo;
        private System.Windows.Forms.ComboBox cmbOrigenDatos;
        private System.Windows.Forms.Panel PnlOpt1;
        private System.Windows.Forms.ComboBox cmbTipoCatalogo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTituloPnl1;
        private System.Windows.Forms.ComboBox cmbValor;
        private System.Windows.Forms.ComboBox cmbInValor;
    }
}