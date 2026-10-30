namespace SALAM
{
    partial class Form_home
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
            this.tableLayoutPanel_toolsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.button_registerOutputTool = new System.Windows.Forms.Button();
            this.button_inventoryTool = new System.Windows.Forms.Button();
            this.label_registerInputTool = new System.Windows.Forms.Label();
            this.button_registerInputTool = new System.Windows.Forms.Button();
            this.label_inventoryTool = new System.Windows.Forms.Label();
            this.label_registerOutputTool = new System.Windows.Forms.Label();
            this.groupBox_settings = new System.Windows.Forms.GroupBox();
            this.label_basePathInfo = new System.Windows.Forms.Label();
            this.label_basePath = new System.Windows.Forms.Label();
            this.tableLayoutPanel_toolsPanel.SuspendLayout();
            this.groupBox_settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_toolsPanel
            // 
            this.tableLayoutPanel_toolsPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel_toolsPanel.ColumnCount = 2;
            this.tableLayoutPanel_toolsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91.53543F));
            this.tableLayoutPanel_toolsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.464567F));
            this.tableLayoutPanel_toolsPanel.Controls.Add(this.button_registerOutputTool, 1, 2);
            this.tableLayoutPanel_toolsPanel.Controls.Add(this.button_inventoryTool, 1, 1);
            this.tableLayoutPanel_toolsPanel.Controls.Add(this.label_registerInputTool, 0, 0);
            this.tableLayoutPanel_toolsPanel.Controls.Add(this.button_registerInputTool, 1, 0);
            this.tableLayoutPanel_toolsPanel.Controls.Add(this.label_inventoryTool, 0, 1);
            this.tableLayoutPanel_toolsPanel.Controls.Add(this.label_registerOutputTool, 0, 2);
            this.tableLayoutPanel_toolsPanel.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel_toolsPanel.Name = "tableLayoutPanel_toolsPanel";
            this.tableLayoutPanel_toolsPanel.RowCount = 3;
            this.tableLayoutPanel_toolsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_toolsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_toolsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_toolsPanel.Size = new System.Drawing.Size(423, 114);
            this.tableLayoutPanel_toolsPanel.TabIndex = 0;
            // 
            // button_registerOutputTool
            // 
            this.button_registerOutputTool.BackgroundImage = global::SALAM.Properties.Resources.flecha_derecha;
            this.button_registerOutputTool.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_registerOutputTool.Location = new System.Drawing.Point(388, 79);
            this.button_registerOutputTool.Name = "button_registerOutputTool";
            this.button_registerOutputTool.Size = new System.Drawing.Size(30, 30);
            this.button_registerOutputTool.TabIndex = 5;
            this.button_registerOutputTool.UseVisualStyleBackColor = true;
            this.button_registerOutputTool.Click += new System.EventHandler(this.button_registerOutputTool_Click);
            // 
            // button_inventoryTool
            // 
            this.button_inventoryTool.BackgroundImage = global::SALAM.Properties.Resources.flecha_derecha;
            this.button_inventoryTool.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_inventoryTool.Location = new System.Drawing.Point(388, 42);
            this.button_inventoryTool.Name = "button_inventoryTool";
            this.button_inventoryTool.Size = new System.Drawing.Size(30, 29);
            this.button_inventoryTool.TabIndex = 4;
            this.button_inventoryTool.UseVisualStyleBackColor = true;
            this.button_inventoryTool.Click += new System.EventHandler(this.button_inventoryTool_Click);
            // 
            // label_registerInputTool
            // 
            this.label_registerInputTool.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_registerInputTool.AutoSize = true;
            this.label_registerInputTool.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_registerInputTool.Location = new System.Drawing.Point(5, 9);
            this.label_registerInputTool.Name = "label_registerInputTool";
            this.label_registerInputTool.Size = new System.Drawing.Size(374, 20);
            this.label_registerInputTool.TabIndex = 0;
            this.label_registerInputTool.Text = "SREM (Sistema Registro de Entrada de Mercancia)";
            // 
            // button_registerInputTool
            // 
            this.button_registerInputTool.BackgroundImage = global::SALAM.Properties.Resources.flecha_derecha;
            this.button_registerInputTool.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_registerInputTool.Location = new System.Drawing.Point(388, 5);
            this.button_registerInputTool.Name = "button_registerInputTool";
            this.button_registerInputTool.Size = new System.Drawing.Size(30, 29);
            this.button_registerInputTool.TabIndex = 3;
            this.button_registerInputTool.UseVisualStyleBackColor = true;
            this.button_registerInputTool.Click += new System.EventHandler(this.button_registerInputTool_Click);
            // 
            // label_inventoryTool
            // 
            this.label_inventoryTool.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_inventoryTool.AutoSize = true;
            this.label_inventoryTool.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_inventoryTool.Location = new System.Drawing.Point(5, 46);
            this.label_inventoryTool.Name = "label_inventoryTool";
            this.label_inventoryTool.Size = new System.Drawing.Size(312, 20);
            this.label_inventoryTool.TabIndex = 2;
            this.label_inventoryTool.Text = "SAI (Sistema Administracion de Inventario)";
            // 
            // label_registerOutputTool
            // 
            this.label_registerOutputTool.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_registerOutputTool.AutoSize = true;
            this.label_registerOutputTool.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_registerOutputTool.Location = new System.Drawing.Point(5, 84);
            this.label_registerOutputTool.Name = "label_registerOutputTool";
            this.label_registerOutputTool.Size = new System.Drawing.Size(256, 20);
            this.label_registerOutputTool.TabIndex = 1;
            this.label_registerOutputTool.Text = "SRV (Sistema Registro de Ventas)";
            // 
            // groupBox_settings
            // 
            this.groupBox_settings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox_settings.Controls.Add(this.label_basePathInfo);
            this.groupBox_settings.Controls.Add(this.label_basePath);
            this.groupBox_settings.Location = new System.Drawing.Point(12, 132);
            this.groupBox_settings.Name = "groupBox_settings";
            this.groupBox_settings.Size = new System.Drawing.Size(423, 277);
            this.groupBox_settings.TabIndex = 1;
            this.groupBox_settings.TabStop = false;
            this.groupBox_settings.Text = "Configuraciones";
            // 
            // label_basePathInfo
            // 
            this.label_basePathInfo.AutoSize = true;
            this.label_basePathInfo.Location = new System.Drawing.Point(85, 16);
            this.label_basePathInfo.Name = "label_basePathInfo";
            this.label_basePathInfo.Size = new System.Drawing.Size(16, 13);
            this.label_basePathInfo.TabIndex = 1;
            this.label_basePathInfo.Text = "...";
            // 
            // label_basePath
            // 
            this.label_basePath.AutoSize = true;
            this.label_basePath.Location = new System.Drawing.Point(6, 16);
            this.label_basePath.Name = "label_basePath";
            this.label_basePath.Size = new System.Drawing.Size(73, 13);
            this.label_basePath.TabIndex = 0;
            this.label_basePath.Text = "Ruta maestra:";
            // 
            // Form_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 421);
            this.Controls.Add(this.groupBox_settings);
            this.Controls.Add(this.tableLayoutPanel_toolsPanel);
            this.Location = new System.Drawing.Point(20, 20);
            this.MaximumSize = new System.Drawing.Size(460, 460);
            this.MinimumSize = new System.Drawing.Size(460, 240);
            this.Name = "Form_home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_home_FormClosing);
            this.Load += new System.EventHandler(this.Form_home_Load);
            this.tableLayoutPanel_toolsPanel.ResumeLayout(false);
            this.tableLayoutPanel_toolsPanel.PerformLayout();
            this.groupBox_settings.ResumeLayout(false);
            this.groupBox_settings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_toolsPanel;
        private System.Windows.Forms.Label label_registerInputTool;
        private System.Windows.Forms.Label label_registerOutputTool;
        private System.Windows.Forms.Label label_inventoryTool;
        private System.Windows.Forms.Button button_registerOutputTool;
        private System.Windows.Forms.GroupBox groupBox_settings;
        public System.Windows.Forms.Button button_inventoryTool;
        public System.Windows.Forms.Button button_registerInputTool;
        private System.Windows.Forms.Label label_basePathInfo;
        private System.Windows.Forms.Label label_basePath;
    }
}