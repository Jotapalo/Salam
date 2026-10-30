namespace SALAM
{
    partial class Form_login
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
            this.groupBox_userName = new System.Windows.Forms.GroupBox();
            this.textBox_userName = new System.Windows.Forms.TextBox();
            this.Label_userName = new System.Windows.Forms.Label();
            this.groupBox_userPassword = new System.Windows.Forms.GroupBox();
            this.textBox_userPassword = new System.Windows.Forms.TextBox();
            this.label_userPassword = new System.Windows.Forms.Label();
            this.button_login = new System.Windows.Forms.Button();
            this.pictureBox_imageProgram = new System.Windows.Forms.PictureBox();
            this.groupBox_userName.SuspendLayout();
            this.groupBox_userPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_imageProgram)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_userName
            // 
            this.groupBox_userName.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox_userName.Controls.Add(this.textBox_userName);
            this.groupBox_userName.Controls.Add(this.Label_userName);
            this.groupBox_userName.Location = new System.Drawing.Point(125, 112);
            this.groupBox_userName.Name = "groupBox_userName";
            this.groupBox_userName.Size = new System.Drawing.Size(150, 100);
            this.groupBox_userName.TabIndex = 0;
            this.groupBox_userName.TabStop = false;
            // 
            // textBox_userName
            // 
            this.textBox_userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_userName.Location = new System.Drawing.Point(6, 45);
            this.textBox_userName.Name = "textBox_userName";
            this.textBox_userName.Size = new System.Drawing.Size(134, 22);
            this.textBox_userName.TabIndex = 1;
            // 
            // Label_userName
            // 
            this.Label_userName.AutoSize = true;
            this.Label_userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_userName.Location = new System.Drawing.Point(7, 16);
            this.Label_userName.Name = "Label_userName";
            this.Label_userName.Size = new System.Drawing.Size(56, 16);
            this.Label_userName.TabIndex = 0;
            this.Label_userName.Text = "Nombre";
            // 
            // groupBox_userPassword
            // 
            this.groupBox_userPassword.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox_userPassword.Controls.Add(this.textBox_userPassword);
            this.groupBox_userPassword.Controls.Add(this.label_userPassword);
            this.groupBox_userPassword.Location = new System.Drawing.Point(125, 218);
            this.groupBox_userPassword.Name = "groupBox_userPassword";
            this.groupBox_userPassword.Size = new System.Drawing.Size(150, 100);
            this.groupBox_userPassword.TabIndex = 1;
            this.groupBox_userPassword.TabStop = false;
            // 
            // textBox_userPassword
            // 
            this.textBox_userPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_userPassword.Location = new System.Drawing.Point(6, 49);
            this.textBox_userPassword.Name = "textBox_userPassword";
            this.textBox_userPassword.Size = new System.Drawing.Size(134, 22);
            this.textBox_userPassword.TabIndex = 1;
            // 
            // label_userPassword
            // 
            this.label_userPassword.AutoSize = true;
            this.label_userPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_userPassword.Location = new System.Drawing.Point(7, 20);
            this.label_userPassword.Name = "label_userPassword";
            this.label_userPassword.Size = new System.Drawing.Size(76, 16);
            this.label_userPassword.TabIndex = 0;
            this.label_userPassword.Text = "Contraseña";
            // 
            // button_login
            // 
            this.button_login.AutoSize = true;
            this.button_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_login.Location = new System.Drawing.Point(150, 334);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(100, 26);
            this.button_login.TabIndex = 2;
            this.button_login.Text = "Iniciar sesion";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // pictureBox_imageProgram
            // 
            this.pictureBox_imageProgram.BackgroundImage = global::SALAM.Properties.Resources.marca;
            this.pictureBox_imageProgram.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_imageProgram.Location = new System.Drawing.Point(151, 12);
            this.pictureBox_imageProgram.Name = "pictureBox_imageProgram";
            this.pictureBox_imageProgram.Size = new System.Drawing.Size(94, 94);
            this.pictureBox_imageProgram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_imageProgram.TabIndex = 3;
            this.pictureBox_imageProgram.TabStop = false;
            // 
            // Form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.Controls.Add(this.pictureBox_imageProgram);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.groupBox_userPassword);
            this.Controls.Add(this.groupBox_userName);
            this.MinimumSize = new System.Drawing.Size(400, 450);
            this.Name = "Form_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Inicio sesion";
            this.Resize += new System.EventHandler(this.Form_login_Resize);
            this.groupBox_userName.ResumeLayout(false);
            this.groupBox_userName.PerformLayout();
            this.groupBox_userPassword.ResumeLayout(false);
            this.groupBox_userPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_imageProgram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_userName;
        private System.Windows.Forms.GroupBox groupBox_userPassword;
        private System.Windows.Forms.Label Label_userName;
        private System.Windows.Forms.Label label_userPassword;
        private System.Windows.Forms.TextBox textBox_userName;
        private System.Windows.Forms.TextBox textBox_userPassword;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.PictureBox pictureBox_imageProgram;
    }
}

