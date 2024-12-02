namespace miniprojet
{
    partial class espAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(espAdmin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_login = new System.Windows.Forms.Button();
            this.textBox_usrname = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.lblMotDePasse = new System.Windows.Forms.Label();
            this.lblUtilisateur = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelErrorUsername = new System.Windows.Forms.Label();
            this.labelErrorPassword = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(91)))), ((int)(((byte)(53)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(761, 56);
            this.panel1.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(927, -1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(211, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gestion des Notes";
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(91)))), ((int)(((byte)(53)))));
            this.button_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_login.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_login.ForeColor = System.Drawing.Color.White;
            this.button_login.Location = new System.Drawing.Point(215, 417);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(325, 41);
            this.button_login.TabIndex = 30;
            this.button_login.Text = "Se Connecter";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // textBox_usrname
            // 
            this.textBox_usrname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_usrname.Location = new System.Drawing.Point(215, 264);
            this.textBox_usrname.Name = "textBox_usrname";
            this.textBox_usrname.Size = new System.Drawing.Size(325, 27);
            this.textBox_usrname.TabIndex = 28;
            this.textBox_usrname.TextChanged += new System.EventHandler(this.textBox_usrname_TextChanged);
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_password.Location = new System.Drawing.Point(215, 359);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(325, 27);
            this.textBox_password.TabIndex = 29;
            this.textBox_password.UseSystemPasswordChar = true;
            this.textBox_password.TextChanged += new System.EventHandler(this.textBox_password_TextChanged);
            // 
            // lblMotDePasse
            // 
            this.lblMotDePasse.AutoSize = true;
            this.lblMotDePasse.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotDePasse.ForeColor = System.Drawing.Color.Black;
            this.lblMotDePasse.Location = new System.Drawing.Point(212, 335);
            this.lblMotDePasse.Name = "lblMotDePasse";
            this.lblMotDePasse.Size = new System.Drawing.Size(121, 21);
            this.lblMotDePasse.TabIndex = 23;
            this.lblMotDePasse.Text = "Mot de Passe :";
            // 
            // lblUtilisateur
            // 
            this.lblUtilisateur.AutoSize = true;
            this.lblUtilisateur.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUtilisateur.ForeColor = System.Drawing.Color.Black;
            this.lblUtilisateur.Location = new System.Drawing.Point(212, 240);
            this.lblUtilisateur.Name = "lblUtilisateur";
            this.lblUtilisateur.Size = new System.Drawing.Size(94, 21);
            this.lblUtilisateur.TabIndex = 24;
            this.lblUtilisateur.Text = "Utilisateur :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label5.Location = new System.Drawing.Point(475, 469);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(331, 21);
            this.label5.TabIndex = 25;
            this.label5.Text = "@Copy Right Learn to Code Like a Native";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(91)))), ((int)(((byte)(53)))));
            this.label2.Location = new System.Drawing.Point(276, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 23);
            this.label2.TabIndex = 26;
            this.label2.Text = "Espace Administration";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(318, 84);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(115, 103);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // labelErrorUsername
            // 
            this.labelErrorUsername.AutoSize = true;
            this.labelErrorUsername.Location = new System.Drawing.Point(216, 308);
            this.labelErrorUsername.Name = "labelErrorUsername";
            this.labelErrorUsername.Size = new System.Drawing.Size(0, 13);
            this.labelErrorUsername.TabIndex = 31;
            // 
            // labelErrorPassword
            // 
            this.labelErrorPassword.AutoSize = true;
            this.labelErrorPassword.Location = new System.Drawing.Point(216, 389);
            this.labelErrorPassword.Name = "labelErrorPassword";
            this.labelErrorPassword.Size = new System.Drawing.Size(0, 13);
            this.labelErrorPassword.TabIndex = 32;
            // 
            // espAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 470);
            this.Controls.Add(this.labelErrorPassword);
            this.Controls.Add(this.labelErrorUsername);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.textBox_usrname);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.lblMotDePasse);
            this.Controls.Add(this.lblUtilisateur);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "espAdmin";
            this.Text = "Login Administrateur";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.TextBox textBox_usrname;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label lblMotDePasse;
        private System.Windows.Forms.Label lblUtilisateur;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelErrorUsername;
        private System.Windows.Forms.Label labelErrorPassword;
    }
}