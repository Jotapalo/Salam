namespace SALAM.SREM
{
    partial class Form_SREM_OP_add
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
            this.label_optionDate = new System.Windows.Forms.Label();
            this.comboBox_dateMonthSelector = new System.Windows.Forms.ComboBox();
            this.comboBox_dateYearSelector = new System.Windows.Forms.ComboBox();
            this.label_infoFile = new System.Windows.Forms.Label();
            this.panel_controls = new System.Windows.Forms.Panel();
            this.groupBox_items = new System.Windows.Forms.GroupBox();
            this.listView_items = new System.Windows.Forms.ListView();
            this.columnHeader_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_cost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_provider = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox_actionButtons = new System.Windows.Forms.GroupBox();
            this.button_save = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_insert = new System.Windows.Forms.Button();
            this.groupBox_parametros = new System.Windows.Forms.GroupBox();
            this.checkBox_category = new System.Windows.Forms.CheckBox();
            this.checkBox_description = new System.Windows.Forms.CheckBox();
            this.checkBox_provider = new System.Windows.Forms.CheckBox();
            this.textBox_ITEM_category = new System.Windows.Forms.TextBox();
            this.label_ITEM_category = new System.Windows.Forms.Label();
            this.textBox_ITEM_price = new System.Windows.Forms.TextBox();
            this.label_ITEM_price = new System.Windows.Forms.Label();
            this.label_errorShow = new System.Windows.Forms.Label();
            this.label_ITEM_name = new System.Windows.Forms.Label();
            this.textBox_ITEM_description = new System.Windows.Forms.TextBox();
            this.label_ITEM_provider = new System.Windows.Forms.Label();
            this.textBox_ITEM_provider = new System.Windows.Forms.TextBox();
            this.label_ITEM_description = new System.Windows.Forms.Label();
            this.textBox_ITEM_amount = new System.Windows.Forms.TextBox();
            this.label_ITEM_cost = new System.Windows.Forms.Label();
            this.textBox_ITEM_cost = new System.Windows.Forms.TextBox();
            this.label_ITEM_amount = new System.Windows.Forms.Label();
            this.textBox_ITEM_name = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.preferenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_dateTime = new System.Windows.Forms.Panel();
            this.escrituraRapidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_controls.SuspendLayout();
            this.groupBox_items.SuspendLayout();
            this.groupBox_actionButtons.SuspendLayout();
            this.groupBox_parametros.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel_dateTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_optionDate
            // 
            this.label_optionDate.AutoSize = true;
            this.label_optionDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_optionDate.Location = new System.Drawing.Point(3, 3);
            this.label_optionDate.Name = "label_optionDate";
            this.label_optionDate.Size = new System.Drawing.Size(45, 16);
            this.label_optionDate.TabIndex = 0;
            this.label_optionDate.Text = "Fecha";
            // 
            // comboBox_dateMonthSelector
            // 
            this.comboBox_dateMonthSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_dateMonthSelector.FormattingEnabled = true;
            this.comboBox_dateMonthSelector.Items.AddRange(new object[] {
            "enero",
            "febrero",
            "marzo",
            "abril",
            "mayo",
            "junio",
            "julio",
            "agosto",
            "septiembre",
            "octubre",
            "noviembre",
            "diciembre"});
            this.comboBox_dateMonthSelector.Location = new System.Drawing.Point(54, 0);
            this.comboBox_dateMonthSelector.Name = "comboBox_dateMonthSelector";
            this.comboBox_dateMonthSelector.Size = new System.Drawing.Size(75, 24);
            this.comboBox_dateMonthSelector.TabIndex = 1;
            this.comboBox_dateMonthSelector.SelectedIndexChanged += new System.EventHandler(this.Check_files);
            // 
            // comboBox_dateYearSelector
            // 
            this.comboBox_dateYearSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_dateYearSelector.FormattingEnabled = true;
            this.comboBox_dateYearSelector.Items.AddRange(new object[] {
            "2024",
            "2025",
            "2026"});
            this.comboBox_dateYearSelector.Location = new System.Drawing.Point(135, 0);
            this.comboBox_dateYearSelector.Name = "comboBox_dateYearSelector";
            this.comboBox_dateYearSelector.Size = new System.Drawing.Size(59, 24);
            this.comboBox_dateYearSelector.TabIndex = 2;
            this.comboBox_dateYearSelector.SelectedIndexChanged += new System.EventHandler(this.Check_files);
            // 
            // label_infoFile
            // 
            this.label_infoFile.AutoSize = true;
            this.label_infoFile.BackColor = System.Drawing.SystemColors.Control;
            this.label_infoFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_infoFile.Location = new System.Drawing.Point(200, 3);
            this.label_infoFile.Name = "label_infoFile";
            this.label_infoFile.Size = new System.Drawing.Size(19, 16);
            this.label_infoFile.TabIndex = 3;
            this.label_infoFile.Text = "...";
            // 
            // panel_controls
            // 
            this.panel_controls.Controls.Add(this.groupBox_items);
            this.panel_controls.Controls.Add(this.groupBox_actionButtons);
            this.panel_controls.Controls.Add(this.groupBox_parametros);
            this.panel_controls.Location = new System.Drawing.Point(0, 58);
            this.panel_controls.Name = "panel_controls";
            this.panel_controls.Size = new System.Drawing.Size(928, 584);
            this.panel_controls.TabIndex = 4;
            // 
            // groupBox_items
            // 
            this.groupBox_items.Controls.Add(this.listView_items);
            this.groupBox_items.Location = new System.Drawing.Point(5, 149);
            this.groupBox_items.Name = "groupBox_items";
            this.groupBox_items.Size = new System.Drawing.Size(915, 435);
            this.groupBox_items.TabIndex = 12;
            this.groupBox_items.TabStop = false;
            this.groupBox_items.Text = "Items";
            // 
            // listView_items
            // 
            this.listView_items.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_name,
            this.columnHeader_cost,
            this.columnHeader_amount,
            this.columnHeader_price,
            this.columnHeader_provider,
            this.columnHeader_description,
            this.columnHeader_category});
            this.listView_items.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_items.FullRowSelect = true;
            this.listView_items.GridLines = true;
            this.listView_items.HideSelection = false;
            this.listView_items.Location = new System.Drawing.Point(3, 16);
            this.listView_items.Name = "listView_items";
            this.listView_items.Size = new System.Drawing.Size(909, 416);
            this.listView_items.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView_items.TabIndex = 0;
            this.listView_items.UseCompatibleStateImageBehavior = false;
            this.listView_items.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_name
            // 
            this.columnHeader_name.Text = "nombre";
            this.columnHeader_name.Width = 146;
            // 
            // columnHeader_cost
            // 
            this.columnHeader_cost.Text = "costo";
            this.columnHeader_cost.Width = 69;
            // 
            // columnHeader_amount
            // 
            this.columnHeader_amount.Text = "cantidad";
            this.columnHeader_amount.Width = 54;
            // 
            // columnHeader_price
            // 
            this.columnHeader_price.Text = "precio";
            this.columnHeader_price.Width = 65;
            // 
            // columnHeader_provider
            // 
            this.columnHeader_provider.Text = "proveedor";
            this.columnHeader_provider.Width = 94;
            // 
            // columnHeader_description
            // 
            this.columnHeader_description.Text = "descripcion";
            this.columnHeader_description.Width = 277;
            // 
            // columnHeader_category
            // 
            this.columnHeader_category.Text = "categoria";
            this.columnHeader_category.Width = 200;
            // 
            // groupBox_actionButtons
            // 
            this.groupBox_actionButtons.Controls.Add(this.button_save);
            this.groupBox_actionButtons.Controls.Add(this.button_delete);
            this.groupBox_actionButtons.Controls.Add(this.button_insert);
            this.groupBox_actionButtons.Location = new System.Drawing.Point(841, 1);
            this.groupBox_actionButtons.Name = "groupBox_actionButtons";
            this.groupBox_actionButtons.Size = new System.Drawing.Size(79, 98);
            this.groupBox_actionButtons.TabIndex = 11;
            this.groupBox_actionButtons.TabStop = false;
            this.groupBox_actionButtons.Text = "acciones";
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(3, 72);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 2;
            this.button_save.Text = "guardar";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_export_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(3, 45);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 23);
            this.button_delete.TabIndex = 1;
            this.button_delete.Text = "eliminar";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_insert
            // 
            this.button_insert.Location = new System.Drawing.Point(3, 16);
            this.button_insert.Name = "button_insert";
            this.button_insert.Size = new System.Drawing.Size(75, 23);
            this.button_insert.TabIndex = 0;
            this.button_insert.Text = "insertar";
            this.button_insert.UseVisualStyleBackColor = true;
            this.button_insert.Click += new System.EventHandler(this.button_insert_Click);
            // 
            // groupBox_parametros
            // 
            this.groupBox_parametros.Controls.Add(this.checkBox_category);
            this.groupBox_parametros.Controls.Add(this.checkBox_description);
            this.groupBox_parametros.Controls.Add(this.checkBox_provider);
            this.groupBox_parametros.Controls.Add(this.textBox_ITEM_category);
            this.groupBox_parametros.Controls.Add(this.label_ITEM_category);
            this.groupBox_parametros.Controls.Add(this.textBox_ITEM_price);
            this.groupBox_parametros.Controls.Add(this.label_ITEM_price);
            this.groupBox_parametros.Controls.Add(this.label_errorShow);
            this.groupBox_parametros.Controls.Add(this.label_ITEM_name);
            this.groupBox_parametros.Controls.Add(this.textBox_ITEM_description);
            this.groupBox_parametros.Controls.Add(this.label_ITEM_provider);
            this.groupBox_parametros.Controls.Add(this.textBox_ITEM_provider);
            this.groupBox_parametros.Controls.Add(this.label_ITEM_description);
            this.groupBox_parametros.Controls.Add(this.textBox_ITEM_amount);
            this.groupBox_parametros.Controls.Add(this.label_ITEM_cost);
            this.groupBox_parametros.Controls.Add(this.textBox_ITEM_cost);
            this.groupBox_parametros.Controls.Add(this.label_ITEM_amount);
            this.groupBox_parametros.Controls.Add(this.textBox_ITEM_name);
            this.groupBox_parametros.Location = new System.Drawing.Point(5, 3);
            this.groupBox_parametros.Name = "groupBox_parametros";
            this.groupBox_parametros.Size = new System.Drawing.Size(832, 140);
            this.groupBox_parametros.TabIndex = 10;
            this.groupBox_parametros.TabStop = false;
            this.groupBox_parametros.Text = "parametros";
            // 
            // checkBox_category
            // 
            this.checkBox_category.AutoSize = true;
            this.checkBox_category.Location = new System.Drawing.Point(563, 79);
            this.checkBox_category.Name = "checkBox_category";
            this.checkBox_category.Size = new System.Drawing.Size(71, 17);
            this.checkBox_category.TabIndex = 14;
            this.checkBox_category.TabStop = false;
            this.checkBox_category.Text = "Mantener";
            this.checkBox_category.UseVisualStyleBackColor = true;
            // 
            // checkBox_description
            // 
            this.checkBox_description.AutoSize = true;
            this.checkBox_description.Location = new System.Drawing.Point(258, 79);
            this.checkBox_description.Name = "checkBox_description";
            this.checkBox_description.Size = new System.Drawing.Size(71, 17);
            this.checkBox_description.TabIndex = 13;
            this.checkBox_description.TabStop = false;
            this.checkBox_description.Text = "Mantener";
            this.checkBox_description.UseVisualStyleBackColor = true;
            // 
            // checkBox_provider
            // 
            this.checkBox_provider.AutoSize = true;
            this.checkBox_provider.Location = new System.Drawing.Point(9, 79);
            this.checkBox_provider.Name = "checkBox_provider";
            this.checkBox_provider.Size = new System.Drawing.Size(71, 17);
            this.checkBox_provider.TabIndex = 7;
            this.checkBox_provider.TabStop = false;
            this.checkBox_provider.Text = "Mantener";
            this.checkBox_provider.UseVisualStyleBackColor = true;
            // 
            // textBox_ITEM_category
            // 
            this.textBox_ITEM_category.Location = new System.Drawing.Point(640, 51);
            this.textBox_ITEM_category.Name = "textBox_ITEM_category";
            this.textBox_ITEM_category.Size = new System.Drawing.Size(155, 20);
            this.textBox_ITEM_category.TabIndex = 11;
            // 
            // label_ITEM_category
            // 
            this.label_ITEM_category.AutoSize = true;
            this.label_ITEM_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ITEM_category.Location = new System.Drawing.Point(559, 49);
            this.label_ITEM_category.Name = "label_ITEM_category";
            this.label_ITEM_category.Size = new System.Drawing.Size(75, 20);
            this.label_ITEM_category.TabIndex = 12;
            this.label_ITEM_category.Text = "categoria";
            // 
            // textBox_ITEM_price
            // 
            this.textBox_ITEM_price.Location = new System.Drawing.Point(708, 16);
            this.textBox_ITEM_price.Name = "textBox_ITEM_price";
            this.textBox_ITEM_price.Size = new System.Drawing.Size(50, 20);
            this.textBox_ITEM_price.TabIndex = 8;
            this.textBox_ITEM_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_ITEM_price_KeyPress);
            // 
            // label_ITEM_price
            // 
            this.label_ITEM_price.AutoSize = true;
            this.label_ITEM_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ITEM_price.Location = new System.Drawing.Point(594, 14);
            this.label_ITEM_price.Name = "label_ITEM_price";
            this.label_ITEM_price.Size = new System.Drawing.Size(108, 20);
            this.label_ITEM_price.TabIndex = 10;
            this.label_ITEM_price.Text = "precio unitario";
            // 
            // label_errorShow
            // 
            this.label_errorShow.AutoSize = true;
            this.label_errorShow.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_errorShow.ForeColor = System.Drawing.Color.Red;
            this.label_errorShow.Location = new System.Drawing.Point(6, 124);
            this.label_errorShow.Name = "label_errorShow";
            this.label_errorShow.Size = new System.Drawing.Size(25, 13);
            this.label_errorShow.TabIndex = 5;
            this.label_errorShow.Text = "...";
            // 
            // label_ITEM_name
            // 
            this.label_ITEM_name.AutoSize = true;
            this.label_ITEM_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ITEM_name.Location = new System.Drawing.Point(6, 16);
            this.label_ITEM_name.Name = "label_ITEM_name";
            this.label_ITEM_name.Size = new System.Drawing.Size(63, 20);
            this.label_ITEM_name.TabIndex = 0;
            this.label_ITEM_name.Text = "nombre";
            // 
            // textBox_ITEM_description
            // 
            this.textBox_ITEM_description.Location = new System.Drawing.Point(349, 51);
            this.textBox_ITEM_description.Name = "textBox_ITEM_description";
            this.textBox_ITEM_description.Size = new System.Drawing.Size(204, 20);
            this.textBox_ITEM_description.TabIndex = 10;
            // 
            // label_ITEM_provider
            // 
            this.label_ITEM_provider.AutoSize = true;
            this.label_ITEM_provider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ITEM_provider.Location = new System.Drawing.Point(7, 51);
            this.label_ITEM_provider.Name = "label_ITEM_provider";
            this.label_ITEM_provider.Size = new System.Drawing.Size(80, 20);
            this.label_ITEM_provider.TabIndex = 1;
            this.label_ITEM_provider.Text = "proveedor";
            // 
            // textBox_ITEM_provider
            // 
            this.textBox_ITEM_provider.Location = new System.Drawing.Point(93, 51);
            this.textBox_ITEM_provider.Name = "textBox_ITEM_provider";
            this.textBox_ITEM_provider.Size = new System.Drawing.Size(155, 20);
            this.textBox_ITEM_provider.TabIndex = 9;
            // 
            // label_ITEM_description
            // 
            this.label_ITEM_description.AutoSize = true;
            this.label_ITEM_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ITEM_description.Location = new System.Drawing.Point(254, 51);
            this.label_ITEM_description.Name = "label_ITEM_description";
            this.label_ITEM_description.Size = new System.Drawing.Size(89, 20);
            this.label_ITEM_description.TabIndex = 2;
            this.label_ITEM_description.Text = "descripcion";
            // 
            // textBox_ITEM_amount
            // 
            this.textBox_ITEM_amount.Location = new System.Drawing.Point(553, 14);
            this.textBox_ITEM_amount.Name = "textBox_ITEM_amount";
            this.textBox_ITEM_amount.Size = new System.Drawing.Size(35, 20);
            this.textBox_ITEM_amount.TabIndex = 7;
            this.textBox_ITEM_amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_ITEM_amount_KeyPress);
            // 
            // label_ITEM_cost
            // 
            this.label_ITEM_cost.AutoSize = true;
            this.label_ITEM_cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ITEM_cost.Location = new System.Drawing.Point(320, 16);
            this.label_ITEM_cost.Name = "label_ITEM_cost";
            this.label_ITEM_cost.Size = new System.Drawing.Size(83, 20);
            this.label_ITEM_cost.TabIndex = 3;
            this.label_ITEM_cost.Text = "costo total";
            // 
            // textBox_ITEM_cost
            // 
            this.textBox_ITEM_cost.Location = new System.Drawing.Point(409, 16);
            this.textBox_ITEM_cost.Name = "textBox_ITEM_cost";
            this.textBox_ITEM_cost.Size = new System.Drawing.Size(62, 20);
            this.textBox_ITEM_cost.TabIndex = 6;
            this.textBox_ITEM_cost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_ITEM_cost_KeyPress);
            // 
            // label_ITEM_amount
            // 
            this.label_ITEM_amount.AutoSize = true;
            this.label_ITEM_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ITEM_amount.Location = new System.Drawing.Point(477, 14);
            this.label_ITEM_amount.Name = "label_ITEM_amount";
            this.label_ITEM_amount.Size = new System.Drawing.Size(70, 20);
            this.label_ITEM_amount.TabIndex = 4;
            this.label_ITEM_amount.Text = "cantidad";
            // 
            // textBox_ITEM_name
            // 
            this.textBox_ITEM_name.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_ITEM_name.Location = new System.Drawing.Point(75, 16);
            this.textBox_ITEM_name.Name = "textBox_ITEM_name";
            this.textBox_ITEM_name.Size = new System.Drawing.Size(239, 20);
            this.textBox_ITEM_name.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferenciasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(932, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // preferenciasToolStripMenuItem
            // 
            this.preferenciasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.escrituraRapidaToolStripMenuItem});
            this.preferenciasToolStripMenuItem.Name = "preferenciasToolStripMenuItem";
            this.preferenciasToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.preferenciasToolStripMenuItem.Text = "Preferencias";
            // 
            // panel_dateTime
            // 
            this.panel_dateTime.Controls.Add(this.label_optionDate);
            this.panel_dateTime.Controls.Add(this.comboBox_dateMonthSelector);
            this.panel_dateTime.Controls.Add(this.comboBox_dateYearSelector);
            this.panel_dateTime.Controls.Add(this.label_infoFile);
            this.panel_dateTime.Location = new System.Drawing.Point(10, 27);
            this.panel_dateTime.Name = "panel_dateTime";
            this.panel_dateTime.Size = new System.Drawing.Size(448, 28);
            this.panel_dateTime.TabIndex = 6;
            // 
            // escrituraRapidaToolStripMenuItem
            // 
            this.escrituraRapidaToolStripMenuItem.Name = "escrituraRapidaToolStripMenuItem";
            this.escrituraRapidaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.escrituraRapidaToolStripMenuItem.Text = "Escritura rapida";
            this.escrituraRapidaToolStripMenuItem.Click += new System.EventHandler(this.escrituraRapidaToolStripMenuItem_Click);
            // 
            // Form_SREM_OP_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 646);
            this.Controls.Add(this.panel_dateTime);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel_controls);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_SREM_OP_add";
            this.Text = "Form_SREM_OP_add";
            this.Shown += new System.EventHandler(this.Form_SREM_OP_add_Shown);
            this.panel_controls.ResumeLayout(false);
            this.groupBox_items.ResumeLayout(false);
            this.groupBox_actionButtons.ResumeLayout(false);
            this.groupBox_parametros.ResumeLayout(false);
            this.groupBox_parametros.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel_dateTime.ResumeLayout(false);
            this.panel_dateTime.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_optionDate;
        private System.Windows.Forms.ComboBox comboBox_dateMonthSelector;
        private System.Windows.Forms.ComboBox comboBox_dateYearSelector;
        private System.Windows.Forms.Label label_infoFile;
        private System.Windows.Forms.Panel panel_controls;
        private System.Windows.Forms.Label label_ITEM_provider;
        private System.Windows.Forms.Label label_ITEM_name;
        private System.Windows.Forms.Label label_ITEM_cost;
        private System.Windows.Forms.Label label_ITEM_description;
        private System.Windows.Forms.Label label_ITEM_amount;
        private System.Windows.Forms.TextBox textBox_ITEM_description;
        private System.Windows.Forms.TextBox textBox_ITEM_provider;
        private System.Windows.Forms.TextBox textBox_ITEM_amount;
        private System.Windows.Forms.TextBox textBox_ITEM_cost;
        private System.Windows.Forms.TextBox textBox_ITEM_name;
        private System.Windows.Forms.GroupBox groupBox_parametros;
        private System.Windows.Forms.GroupBox groupBox_actionButtons;
        private System.Windows.Forms.GroupBox groupBox_items;
        private System.Windows.Forms.ListView listView_items;
        private System.Windows.Forms.Button button_insert;
        private System.Windows.Forms.ColumnHeader columnHeader_name;
        private System.Windows.Forms.ColumnHeader columnHeader_cost;
        private System.Windows.Forms.ColumnHeader columnHeader_amount;
        private System.Windows.Forms.ColumnHeader columnHeader_provider;
        private System.Windows.Forms.ColumnHeader columnHeader_description;
        private System.Windows.Forms.Label label_errorShow;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label label_ITEM_category;
        private System.Windows.Forms.TextBox textBox_ITEM_price;
        private System.Windows.Forms.Label label_ITEM_price;
        private System.Windows.Forms.TextBox textBox_ITEM_category;
        private System.Windows.Forms.ColumnHeader columnHeader_price;
        private System.Windows.Forms.ColumnHeader columnHeader_category;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem preferenciasToolStripMenuItem;
        private System.Windows.Forms.Panel panel_dateTime;
        private System.Windows.Forms.CheckBox checkBox_provider;
        private System.Windows.Forms.CheckBox checkBox_category;
        private System.Windows.Forms.CheckBox checkBox_description;
        private System.Windows.Forms.ToolStripMenuItem escrituraRapidaToolStripMenuItem;
    }
}