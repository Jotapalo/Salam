namespace SALAM
{
    partial class Form_SREM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_SREM));
            this.textBox_fileContent = new System.Windows.Forms.TextBox();
            this.panel_filesRegion = new System.Windows.Forms.Panel();
            this.listBox_itemsRecord = new SALAM.utils.FileListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_edit = new System.Windows.Forms.Button();
            this.label_filter = new System.Windows.Forms.Label();
            this.comboBox_filters = new System.Windows.Forms.ComboBox();
            this.button_alternate_schema = new System.Windows.Forms.Button();
            this.button_export = new System.Windows.Forms.Button();
            this.button_addRecord = new System.Windows.Forms.Button();
            this.panel_filesRegion.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_fileContent
            // 
            this.textBox_fileContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_fileContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_fileContent.Location = new System.Drawing.Point(0, 0);
            this.textBox_fileContent.Multiline = true;
            this.textBox_fileContent.Name = "textBox_fileContent";
            this.textBox_fileContent.ReadOnly = true;
            this.textBox_fileContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_fileContent.Size = new System.Drawing.Size(593, 439);
            this.textBox_fileContent.TabIndex = 2;
            // 
            // panel_filesRegion
            // 
            this.panel_filesRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_filesRegion.Controls.Add(this.textBox_fileContent);
            this.panel_filesRegion.Controls.Add(this.listBox_itemsRecord);
            this.panel_filesRegion.Location = new System.Drawing.Point(1, 50);
            this.panel_filesRegion.Name = "panel_filesRegion";
            this.panel_filesRegion.Size = new System.Drawing.Size(681, 439);
            this.panel_filesRegion.TabIndex = 3;
            // 
            // listBox_itemsRecord
            // 
            this.listBox_itemsRecord.Dock = System.Windows.Forms.DockStyle.Right;
            this.listBox_itemsRecord.FilePaths = ((System.Collections.Generic.List<string>)(resources.GetObject("listBox_itemsRecord.FilePaths")));
            this.listBox_itemsRecord.FormattingEnabled = true;
            this.listBox_itemsRecord.Location = new System.Drawing.Point(593, 0);
            this.listBox_itemsRecord.Name = "listBox_itemsRecord";
            this.listBox_itemsRecord.Size = new System.Drawing.Size(88, 439);
            this.listBox_itemsRecord.TabIndex = 2;
            this.listBox_itemsRecord.SelectedIndexChanged += new System.EventHandler(this.fileListBoxArchivos_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_edit);
            this.panel1.Controls.Add(this.label_filter);
            this.panel1.Controls.Add(this.comboBox_filters);
            this.panel1.Controls.Add(this.button_alternate_schema);
            this.panel1.Controls.Add(this.button_export);
            this.panel1.Controls.Add(this.button_addRecord);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 44);
            this.panel1.TabIndex = 1;
            // 
            // button_edit
            // 
            this.button_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_edit.Location = new System.Drawing.Point(328, 3);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(84, 37);
            this.button_edit.TabIndex = 4;
            this.button_edit.Text = "editar";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // label_filter
            // 
            this.label_filter.AutoSize = true;
            this.label_filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_filter.Location = new System.Drawing.Point(520, 25);
            this.label_filter.Name = "label_filter";
            this.label_filter.Size = new System.Drawing.Size(42, 16);
            this.label_filter.TabIndex = 3;
            this.label_filter.Text = "Filtro";
            this.label_filter.Click += new System.EventHandler(this.label_filter_Click);
            // 
            // comboBox_filters
            // 
            this.comboBox_filters.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_filters.FormattingEnabled = true;
            this.comboBox_filters.Items.AddRange(new object[] {
            "ascendente",
            "descendente"});
            this.comboBox_filters.Location = new System.Drawing.Point(568, 23);
            this.comboBox_filters.Name = "comboBox_filters";
            this.comboBox_filters.Size = new System.Drawing.Size(110, 24);
            this.comboBox_filters.TabIndex = 3;
            this.comboBox_filters.Text = "ascendente";
            this.comboBox_filters.SelectedIndexChanged += new System.EventHandler(this.comboBox_filters_SelectedIndexChanged);
            this.comboBox_filters.SelectionChangeCommitted += new System.EventHandler(this.comboBox_filters_SelectionChangeCommitted);
            // 
            // button_alternate_schema
            // 
            this.button_alternate_schema.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_alternate_schema.Location = new System.Drawing.Point(93, 3);
            this.button_alternate_schema.Name = "button_alternate_schema";
            this.button_alternate_schema.Size = new System.Drawing.Size(139, 37);
            this.button_alternate_schema.TabIndex = 3;
            this.button_alternate_schema.Text = "Cambiar a texto";
            this.button_alternate_schema.UseVisualStyleBackColor = true;
            this.button_alternate_schema.Click += new System.EventHandler(this.button_alternate_schema_Click);
            // 
            // button_export
            // 
            this.button_export.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_export.Location = new System.Drawing.Point(238, 3);
            this.button_export.Name = "button_export";
            this.button_export.Size = new System.Drawing.Size(84, 37);
            this.button_export.TabIndex = 2;
            this.button_export.Text = "exportar";
            this.button_export.UseVisualStyleBackColor = true;
            this.button_export.Click += new System.EventHandler(this.button_export_Click);
            // 
            // button_addRecord
            // 
            this.button_addRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addRecord.Location = new System.Drawing.Point(3, 3);
            this.button_addRecord.Name = "button_addRecord";
            this.button_addRecord.Size = new System.Drawing.Size(84, 37);
            this.button_addRecord.TabIndex = 1;
            this.button_addRecord.Text = "agregar";
            this.button_addRecord.UseVisualStyleBackColor = true;
            this.button_addRecord.Click += new System.EventHandler(this.button_addRecord_Click);
            // 
            // Form_SREM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 488);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_filesRegion);
            this.MinimumSize = new System.Drawing.Size(700, 527);
            this.Name = "Form_SREM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_SREM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_SREM_FormClosing);
            this.panel_filesRegion.ResumeLayout(false);
            this.panel_filesRegion.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_fileContent;
        private System.Windows.Forms.Panel panel_filesRegion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_addRecord;
        private System.Windows.Forms.Button button_export;
        public utils.FileListBox listBox_itemsRecord;
        private System.Windows.Forms.Button button_alternate_schema;
        private System.Windows.Forms.ComboBox comboBox_filters;
        private System.Windows.Forms.Label label_filter;
        private System.Windows.Forms.Button button_edit;
    }
}