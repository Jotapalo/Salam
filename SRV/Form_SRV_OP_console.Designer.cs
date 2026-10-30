namespace SALAM.SRV

{
    partial class Form_SRV_OP_console
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_SRV_OP_console));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxConsolaInput = new System.Windows.Forms.TextBox();
            this.richTextBoxConsola = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxConsolaInput);
            this.panel1.Controls.Add(this.richTextBoxConsola);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // textBoxConsolaInput
            // 
            this.textBoxConsolaInput.BackColor = System.Drawing.Color.Black;
            this.textBoxConsolaInput.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConsolaInput.ForeColor = System.Drawing.Color.White;
            this.textBoxConsolaInput.Location = new System.Drawing.Point(3, 427);
            this.textBoxConsolaInput.Name = "textBoxConsolaInput";
            this.textBoxConsolaInput.Size = new System.Drawing.Size(794, 23);
            this.textBoxConsolaInput.TabIndex = 1;
            this.textBoxConsolaInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxConsolaInput_KeyDown);
            // 
            // richTextBoxConsola
            // 
            this.richTextBoxConsola.BackColor = System.Drawing.Color.Black;
            this.richTextBoxConsola.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxConsola.ForeColor = System.Drawing.SystemColors.Info;
            this.richTextBoxConsola.Location = new System.Drawing.Point(3, 0);
            this.richTextBoxConsola.Name = "richTextBoxConsola";
            this.richTextBoxConsola.Size = new System.Drawing.Size(794, 423);
            this.richTextBoxConsola.TabIndex = 0;
            this.richTextBoxConsola.Text = "";
            this.richTextBoxConsola.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBoxConsola_KeyPress);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consola";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBoxConsola;
        private System.Windows.Forms.TextBox textBoxConsolaInput;
    }
}