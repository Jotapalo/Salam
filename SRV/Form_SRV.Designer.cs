namespace SALAM.SRV
{
    partial class Form_SRV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_SRV));
            this.groupBoxPrincipal = new System.Windows.Forms.GroupBox();
            this.panel_parameters = new System.Windows.Forms.Panel();
            this.groupBox_category = new System.Windows.Forms.GroupBox();
            this.textBoxCategoria = new System.Windows.Forms.TextBox();
            this.groupBox_name = new System.Windows.Forms.GroupBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.groupBox_amount = new System.Windows.Forms.GroupBox();
            this.textBoxUnidades = new System.Windows.Forms.TextBox();
            this.groupBox_price = new System.Windows.Forms.GroupBox();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.pictureBoxConf = new System.Windows.Forms.PictureBox();
            this.pictureBoxConsola = new System.Windows.Forms.PictureBox();
            this.panelUserInfo = new System.Windows.Forms.Panel();
            this.labelIndicadorNombreUsuario = new System.Windows.Forms.Label();
            this.labelCostoTotalNumerico = new System.Windows.Forms.Label();
            this.tableLayoutPanelBotones = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSAI = new System.Windows.Forms.Button();
            this.buttonFill = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSaveReord = new System.Windows.Forms.Button();
            this.buttonRecord = new System.Windows.Forms.Button();
            this.buttonClearSelection = new System.Windows.Forms.Button();
            this.buttonClearAll = new System.Windows.Forms.Button();
            this.buttonCleanEntries = new System.Windows.Forms.Button();
            this.panelGraficadorRegistro = new System.Windows.Forms.Panel();
            this.textBoxGraficadorRegistro = new System.Windows.Forms.TextBox();
            this.labelCostoTotal = new System.Windows.Forms.Label();
            this.panelListaItems = new System.Windows.Forms.Panel();
            this.listView_listaItems = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxPrincipal.SuspendLayout();
            this.panel_parameters.SuspendLayout();
            this.groupBox_category.SuspendLayout();
            this.groupBox_name.SuspendLayout();
            this.groupBox_amount.SuspendLayout();
            this.groupBox_price.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConsola)).BeginInit();
            this.panelUserInfo.SuspendLayout();
            this.tableLayoutPanelBotones.SuspendLayout();
            this.panelGraficadorRegistro.SuspendLayout();
            this.panelListaItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxPrincipal
            // 
            this.groupBoxPrincipal.BackColor = System.Drawing.Color.Silver;
            this.groupBoxPrincipal.Controls.Add(this.panel_parameters);
            this.groupBoxPrincipal.Controls.Add(this.pictureBoxConf);
            this.groupBoxPrincipal.Controls.Add(this.pictureBoxConsola);
            this.groupBoxPrincipal.Controls.Add(this.panelUserInfo);
            this.groupBoxPrincipal.Controls.Add(this.labelCostoTotalNumerico);
            this.groupBoxPrincipal.Controls.Add(this.tableLayoutPanelBotones);
            this.groupBoxPrincipal.Controls.Add(this.panelGraficadorRegistro);
            this.groupBoxPrincipal.Controls.Add(this.labelCostoTotal);
            this.groupBoxPrincipal.Controls.Add(this.panelListaItems);
            this.groupBoxPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxPrincipal.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPrincipal.Location = new System.Drawing.Point(0, 0);
            this.groupBoxPrincipal.Name = "groupBoxPrincipal";
            this.groupBoxPrincipal.Size = new System.Drawing.Size(1316, 748);
            this.groupBoxPrincipal.TabIndex = 0;
            this.groupBoxPrincipal.TabStop = false;
            this.groupBoxPrincipal.Text = "SALAM | sistema de registro de ventas";
            // 
            // panel_parameters
            // 
            this.panel_parameters.Controls.Add(this.groupBox_category);
            this.panel_parameters.Controls.Add(this.groupBox_name);
            this.panel_parameters.Controls.Add(this.groupBox_amount);
            this.panel_parameters.Controls.Add(this.groupBox_price);
            this.panel_parameters.Location = new System.Drawing.Point(12, 26);
            this.panel_parameters.Name = "panel_parameters";
            this.panel_parameters.Size = new System.Drawing.Size(672, 79);
            this.panel_parameters.TabIndex = 13;
            // 
            // groupBox_category
            // 
            this.groupBox_category.Controls.Add(this.textBoxCategoria);
            this.groupBox_category.Location = new System.Drawing.Point(493, 6);
            this.groupBox_category.Name = "groupBox_category";
            this.groupBox_category.Size = new System.Drawing.Size(176, 70);
            this.groupBox_category.TabIndex = 8;
            this.groupBox_category.TabStop = false;
            this.groupBox_category.Text = "Categoria";
            // 
            // textBoxCategoria
            // 
            this.textBoxCategoria.Location = new System.Drawing.Point(6, 32);
            this.textBoxCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 3);
            this.textBoxCategoria.Name = "textBoxCategoria";
            this.textBoxCategoria.Size = new System.Drawing.Size(164, 27);
            this.textBoxCategoria.TabIndex = 4;
            // 
            // groupBox_name
            // 
            this.groupBox_name.Controls.Add(this.textBoxNombre);
            this.groupBox_name.Location = new System.Drawing.Point(3, 6);
            this.groupBox_name.Name = "groupBox_name";
            this.groupBox_name.Size = new System.Drawing.Size(268, 70);
            this.groupBox_name.TabIndex = 5;
            this.groupBox_name.TabStop = false;
            this.groupBox_name.Text = "Nombre";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.AutoCompleteCustomSource.AddRange(new string[] {
            "vasos 7 onz",
            "vasos 3.5 onz",
            "vasos 8 onz"});
            this.textBoxNombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.textBoxNombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxNombre.Location = new System.Drawing.Point(6, 32);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 3);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(257, 27);
            this.textBoxNombre.TabIndex = 1;
            // 
            // groupBox_amount
            // 
            this.groupBox_amount.Controls.Add(this.textBoxUnidades);
            this.groupBox_amount.Location = new System.Drawing.Point(277, 6);
            this.groupBox_amount.Name = "groupBox_amount";
            this.groupBox_amount.Size = new System.Drawing.Size(101, 70);
            this.groupBox_amount.TabIndex = 6;
            this.groupBox_amount.TabStop = false;
            this.groupBox_amount.Text = "Unidades";
            // 
            // textBoxUnidades
            // 
            this.textBoxUnidades.Location = new System.Drawing.Point(6, 32);
            this.textBoxUnidades.Margin = new System.Windows.Forms.Padding(3, 2, 3, 3);
            this.textBoxUnidades.Name = "textBoxUnidades";
            this.textBoxUnidades.Size = new System.Drawing.Size(82, 27);
            this.textBoxUnidades.TabIndex = 2;
            this.textBoxUnidades.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // groupBox_price
            // 
            this.groupBox_price.Controls.Add(this.textBoxPrecio);
            this.groupBox_price.Location = new System.Drawing.Point(384, 6);
            this.groupBox_price.Name = "groupBox_price";
            this.groupBox_price.Size = new System.Drawing.Size(103, 70);
            this.groupBox_price.TabIndex = 7;
            this.groupBox_price.TabStop = false;
            this.groupBox_price.Text = "Precio";
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(6, 32);
            this.textBoxPrecio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 3);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(90, 27);
            this.textBoxPrecio.TabIndex = 3;
            this.textBoxPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // pictureBoxConf
            // 
            this.pictureBoxConf.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxConf.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxConf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxConf.Image = global::SALAM.Properties.Resources.ajuste;
            this.pictureBoxConf.Location = new System.Drawing.Point(538, 111);
            this.pictureBoxConf.Name = "pictureBoxConf";
            this.pictureBoxConf.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pictureBoxConf.Size = new System.Drawing.Size(64, 59);
            this.pictureBoxConf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxConf.TabIndex = 11;
            this.pictureBoxConf.TabStop = false;
            this.pictureBoxConf.Click += new System.EventHandler(this.pictureBoxConf_Click);
            // 
            // pictureBoxConsola
            // 
            this.pictureBoxConsola.AccessibleDescription = "CONSOLA";
            this.pictureBoxConsola.AccessibleName = "consola";
            this.pictureBoxConsola.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxConsola.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxConsola.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxConsola.Image = global::SALAM.Properties.Resources.ventana_de_terminal_vacia;
            this.pictureBoxConsola.Location = new System.Drawing.Point(608, 111);
            this.pictureBoxConsola.Name = "pictureBoxConsola";
            this.pictureBoxConsola.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pictureBoxConsola.Size = new System.Drawing.Size(67, 60);
            this.pictureBoxConsola.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxConsola.TabIndex = 0;
            this.pictureBoxConsola.TabStop = false;
            this.pictureBoxConsola.Tag = "";
            this.pictureBoxConsola.Click += new System.EventHandler(this.pictureBoxConsola_Click);
            // 
            // panelUserInfo
            // 
            this.panelUserInfo.BackColor = System.Drawing.Color.Gray;
            this.panelUserInfo.Controls.Add(this.labelIndicadorNombreUsuario);
            this.panelUserInfo.Location = new System.Drawing.Point(690, 26);
            this.panelUserInfo.Name = "panelUserInfo";
            this.panelUserInfo.Size = new System.Drawing.Size(244, 41);
            this.panelUserInfo.TabIndex = 0;
            // 
            // labelIndicadorNombreUsuario
            // 
            this.labelIndicadorNombreUsuario.AutoSize = true;
            this.labelIndicadorNombreUsuario.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIndicadorNombreUsuario.Location = new System.Drawing.Point(12, 6);
            this.labelIndicadorNombreUsuario.Name = "labelIndicadorNombreUsuario";
            this.labelIndicadorNombreUsuario.Size = new System.Drawing.Size(221, 29);
            this.labelIndicadorNombreUsuario.TabIndex = 0;
            this.labelIndicadorNombreUsuario.Text = "USER; DEFAULT";
            this.labelIndicadorNombreUsuario.Click += new System.EventHandler(this.labelIndicadorNombreUsuario_Click);
            // 
            // labelCostoTotalNumerico
            // 
            this.labelCostoTotalNumerico.BackColor = System.Drawing.Color.Black;
            this.labelCostoTotalNumerico.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelCostoTotalNumerico.Location = new System.Drawing.Point(554, 716);
            this.labelCostoTotalNumerico.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.labelCostoTotalNumerico.Name = "labelCostoTotalNumerico";
            this.labelCostoTotalNumerico.Size = new System.Drawing.Size(130, 20);
            this.labelCostoTotalNumerico.TabIndex = 0;
            this.labelCostoTotalNumerico.Text = "000.000,00";
            // 
            // tableLayoutPanelBotones
            // 
            this.tableLayoutPanelBotones.ColumnCount = 4;
            this.tableLayoutPanelBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.71429F));
            this.tableLayoutPanelBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.28571F));
            this.tableLayoutPanelBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tableLayoutPanelBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 182F));
            this.tableLayoutPanelBotones.Controls.Add(this.buttonSAI, 2, 0);
            this.tableLayoutPanelBotones.Controls.Add(this.buttonFill, 2, 1);
            this.tableLayoutPanelBotones.Controls.Add(this.buttonAdd, 0, 0);
            this.tableLayoutPanelBotones.Controls.Add(this.buttonSaveReord, 3, 0);
            this.tableLayoutPanelBotones.Controls.Add(this.buttonRecord, 3, 1);
            this.tableLayoutPanelBotones.Controls.Add(this.buttonClearSelection, 1, 0);
            this.tableLayoutPanelBotones.Controls.Add(this.buttonClearAll, 1, 1);
            this.tableLayoutPanelBotones.Controls.Add(this.buttonCleanEntries, 0, 1);
            this.tableLayoutPanelBotones.Location = new System.Drawing.Point(12, 109);
            this.tableLayoutPanelBotones.Name = "tableLayoutPanelBotones";
            this.tableLayoutPanelBotones.RowCount = 2;
            this.tableLayoutPanelBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBotones.Size = new System.Drawing.Size(523, 65);
            this.tableLayoutPanelBotones.TabIndex = 1;
            // 
            // buttonSAI
            // 
            this.buttonSAI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonSAI.Location = new System.Drawing.Point(207, 0);
            this.buttonSAI.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.buttonSAI.Name = "buttonSAI";
            this.buttonSAI.Size = new System.Drawing.Size(130, 29);
            this.buttonSAI.TabIndex = 9;
            this.buttonSAI.Text = "SAI";
            this.buttonSAI.UseVisualStyleBackColor = false;
            this.buttonSAI.Click += new System.EventHandler(this.buttonDataBase_Click);
            // 
            // buttonFill
            // 
            this.buttonFill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonFill.Location = new System.Drawing.Point(207, 32);
            this.buttonFill.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.buttonFill.Name = "buttonFill";
            this.buttonFill.Size = new System.Drawing.Size(130, 30);
            this.buttonFill.TabIndex = 10;
            this.buttonFill.Text = "Rellenar ( F )";
            this.buttonFill.UseVisualStyleBackColor = false;
            this.buttonFill.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonAdd.Location = new System.Drawing.Point(0, 0);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(92, 29);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Agregar";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSaveReord
            // 
            this.buttonSaveReord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonSaveReord.Location = new System.Drawing.Point(340, 0);
            this.buttonSaveReord.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.buttonSaveReord.Name = "buttonSaveReord";
            this.buttonSaveReord.Size = new System.Drawing.Size(179, 29);
            this.buttonSaveReord.TabIndex = 11;
            this.buttonSaveReord.Text = "Guardar Reg.";
            this.buttonSaveReord.UseVisualStyleBackColor = false;
            this.buttonSaveReord.Click += new System.EventHandler(this.button7_Click);
            // 
            // buttonRecord
            // 
            this.buttonRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonRecord.Location = new System.Drawing.Point(340, 32);
            this.buttonRecord.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.buttonRecord.Name = "buttonRecord";
            this.buttonRecord.Size = new System.Drawing.Size(179, 30);
            this.buttonRecord.TabIndex = 12;
            this.buttonRecord.Text = "Registrar";
            this.buttonRecord.UseVisualStyleBackColor = false;
            this.buttonRecord.Click += new System.EventHandler(this.button6_Click);
            // 
            // buttonClearSelection
            // 
            this.buttonClearSelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonClearSelection.Location = new System.Drawing.Point(95, 0);
            this.buttonClearSelection.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.buttonClearSelection.Name = "buttonClearSelection";
            this.buttonClearSelection.Size = new System.Drawing.Size(109, 29);
            this.buttonClearSelection.TabIndex = 7;
            this.buttonClearSelection.Text = "Borrar";
            this.buttonClearSelection.UseVisualStyleBackColor = false;
            this.buttonClearSelection.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonClearAll
            // 
            this.buttonClearAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonClearAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonClearAll.Location = new System.Drawing.Point(95, 32);
            this.buttonClearAll.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.buttonClearAll.Name = "buttonClearAll";
            this.buttonClearAll.Size = new System.Drawing.Size(109, 29);
            this.buttonClearAll.TabIndex = 8;
            this.buttonClearAll.Text = "Borrar todo";
            this.buttonClearAll.UseVisualStyleBackColor = false;
            this.buttonClearAll.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonCleanEntries
            // 
            this.buttonCleanEntries.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCleanEntries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonCleanEntries.Location = new System.Drawing.Point(0, 32);
            this.buttonCleanEntries.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.buttonCleanEntries.Name = "buttonCleanEntries";
            this.buttonCleanEntries.Size = new System.Drawing.Size(92, 30);
            this.buttonCleanEntries.TabIndex = 6;
            this.buttonCleanEntries.Text = "Limpiar";
            this.buttonCleanEntries.UseVisualStyleBackColor = false;
            this.buttonCleanEntries.Click += new System.EventHandler(this.button2_Click);
            // 
            // panelGraficadorRegistro
            // 
            this.panelGraficadorRegistro.BackColor = System.Drawing.Color.Silver;
            this.panelGraficadorRegistro.Controls.Add(this.textBoxGraficadorRegistro);
            this.panelGraficadorRegistro.Location = new System.Drawing.Point(690, 176);
            this.panelGraficadorRegistro.Name = "panelGraficadorRegistro";
            this.panelGraficadorRegistro.Size = new System.Drawing.Size(611, 560);
            this.panelGraficadorRegistro.TabIndex = 8;
            // 
            // textBoxGraficadorRegistro
            // 
            this.textBoxGraficadorRegistro.BackColor = System.Drawing.Color.Silver;
            this.textBoxGraficadorRegistro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxGraficadorRegistro.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxGraficadorRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxGraficadorRegistro.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGraficadorRegistro.Location = new System.Drawing.Point(0, 0);
            this.textBoxGraficadorRegistro.Multiline = true;
            this.textBoxGraficadorRegistro.Name = "textBoxGraficadorRegistro";
            this.textBoxGraficadorRegistro.ReadOnly = true;
            this.textBoxGraficadorRegistro.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxGraficadorRegistro.Size = new System.Drawing.Size(611, 560);
            this.textBoxGraficadorRegistro.TabIndex = 0;
            this.textBoxGraficadorRegistro.TabStop = false;
            // 
            // labelCostoTotal
            // 
            this.labelCostoTotal.AutoSize = true;
            this.labelCostoTotal.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCostoTotal.Location = new System.Drawing.Point(437, 716);
            this.labelCostoTotal.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.labelCostoTotal.Name = "labelCostoTotal";
            this.labelCostoTotal.Size = new System.Drawing.Size(120, 20);
            this.labelCostoTotal.TabIndex = 5;
            this.labelCostoTotal.Text = "Costo total:";
            // 
            // panelListaItems
            // 
            this.panelListaItems.Controls.Add(this.listView_listaItems);
            this.panelListaItems.Location = new System.Drawing.Point(16, 176);
            this.panelListaItems.Name = "panelListaItems";
            this.panelListaItems.Size = new System.Drawing.Size(668, 532);
            this.panelListaItems.TabIndex = 1;
            // 
            // listView_listaItems
            // 
            this.listView_listaItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView_listaItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_listaItems.FullRowSelect = true;
            this.listView_listaItems.GridLines = true;
            this.listView_listaItems.HideSelection = false;
            this.listView_listaItems.Location = new System.Drawing.Point(0, 0);
            this.listView_listaItems.Name = "listView_listaItems";
            this.listView_listaItems.Size = new System.Drawing.Size(668, 532);
            this.listView_listaItems.TabIndex = 13;
            this.listView_listaItems.UseCompatibleStateImageBehavior = false;
            this.listView_listaItems.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "#";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "NOMBRE";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "UNIDADES";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "PRECIO";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "CATEGORIA";
            this.columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "SUBTOTAL";
            this.columnHeader6.Width = 100;
            // 
            // Form_SRV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1313, 748);
            this.Controls.Add(this.groupBoxPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_SRV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SALAM | registro ventas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_SRV_FormClosing);
            this.groupBoxPrincipal.ResumeLayout(false);
            this.groupBoxPrincipal.PerformLayout();
            this.panel_parameters.ResumeLayout(false);
            this.groupBox_category.ResumeLayout(false);
            this.groupBox_category.PerformLayout();
            this.groupBox_name.ResumeLayout(false);
            this.groupBox_name.PerformLayout();
            this.groupBox_amount.ResumeLayout(false);
            this.groupBox_amount.PerformLayout();
            this.groupBox_price.ResumeLayout(false);
            this.groupBox_price.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConsola)).EndInit();
            this.panelUserInfo.ResumeLayout(false);
            this.panelUserInfo.PerformLayout();
            this.tableLayoutPanelBotones.ResumeLayout(false);
            this.panelGraficadorRegistro.ResumeLayout(false);
            this.panelGraficadorRegistro.PerformLayout();
            this.panelListaItems.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPrincipal;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxUnidades;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.TextBox textBoxCategoria;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCleanEntries;
        private System.Windows.Forms.Panel panelListaItems;
        private System.Windows.Forms.ListView listView_listaItems;
        private System.Windows.Forms.Button buttonClearSelection;
        private System.Windows.Forms.Button buttonClearAll;
        private System.Windows.Forms.Label labelCostoTotalNumerico;
        private System.Windows.Forms.Label labelCostoTotal;
        private System.Windows.Forms.Button buttonRecord;
        private System.Windows.Forms.Panel panelGraficadorRegistro;
        private System.Windows.Forms.TextBox textBoxGraficadorRegistro;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBotones;
        private System.Windows.Forms.Button buttonSaveReord;
        private System.Windows.Forms.Button buttonFill;
        private System.Windows.Forms.Button buttonSAI;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Panel panelUserInfo;
        private System.Windows.Forms.Label labelIndicadorNombreUsuario;
        private System.Windows.Forms.PictureBox pictureBoxConsola;
        private System.Windows.Forms.PictureBox pictureBoxConf;
        private System.Windows.Forms.GroupBox groupBox_name;
        private System.Windows.Forms.GroupBox groupBox_category;
        private System.Windows.Forms.GroupBox groupBox_price;
        private System.Windows.Forms.GroupBox groupBox_amount;
        private System.Windows.Forms.Panel panel_parameters;
    }
}

