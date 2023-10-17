namespace Projeto_tcc
{
    partial class Perfil
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
            this.switchTema = new MaterialSkin.Controls.MaterialSwitch();
            this.txb_nome = new MaterialSkin.Controls.MaterialTextBox2();
            this.txb_email = new MaterialSkin.Controls.MaterialTextBox2();
            this.txb_senha = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnfoto = new System.Windows.Forms.PictureBox();
            this.lblDash = new System.Windows.Forms.Label();
            this.lbltema = new System.Windows.Forms.Label();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_login = new MaterialSkin.Controls.MaterialTextBox2();
            this.label4 = new System.Windows.Forms.Label();
            this.materialSwitch1 = new MaterialSkin.Controls.MaterialSwitch();
            this.label5 = new System.Windows.Forms.Label();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnfoto)).BeginInit();
            this.SuspendLayout();
            // 
            // switchTema
            // 
            this.switchTema.AutoSize = true;
            this.switchTema.Depth = 0;
            this.switchTema.Location = new System.Drawing.Point(766, 47);
            this.switchTema.Margin = new System.Windows.Forms.Padding(0);
            this.switchTema.MouseLocation = new System.Drawing.Point(-1, -1);
            this.switchTema.MouseState = MaterialSkin.MouseState.HOVER;
            this.switchTema.Name = "switchTema";
            this.switchTema.Ripple = true;
            this.switchTema.Size = new System.Drawing.Size(58, 37);
            this.switchTema.TabIndex = 1;
            this.switchTema.UseVisualStyleBackColor = true;
            this.switchTema.CheckedChanged += new System.EventHandler(this.switchTema_CheckedChanged);
            // 
            // txb_nome
            // 
            this.txb_nome.AnimateReadOnly = false;
            this.txb_nome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txb_nome.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txb_nome.Depth = 0;
            this.txb_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txb_nome.HideSelection = true;
            this.txb_nome.LeadingIcon = null;
            this.txb_nome.Location = new System.Drawing.Point(35, 220);
            this.txb_nome.MaxLength = 32767;
            this.txb_nome.MouseState = MaterialSkin.MouseState.OUT;
            this.txb_nome.Name = "txb_nome";
            this.txb_nome.PasswordChar = '\0';
            this.txb_nome.PrefixSuffixText = null;
            this.txb_nome.ReadOnly = false;
            this.txb_nome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txb_nome.SelectedText = "";
            this.txb_nome.SelectionLength = 0;
            this.txb_nome.SelectionStart = 0;
            this.txb_nome.ShortcutsEnabled = true;
            this.txb_nome.Size = new System.Drawing.Size(370, 48);
            this.txb_nome.TabIndex = 3;
            this.txb_nome.TabStop = false;
            this.txb_nome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txb_nome.TrailingIcon = null;
            this.txb_nome.UseSystemPasswordChar = false;
            this.txb_nome.Click += new System.EventHandler(this.materialTextBox21_Click);
            // 
            // txb_email
            // 
            this.txb_email.AnimateReadOnly = false;
            this.txb_email.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txb_email.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txb_email.Depth = 0;
            this.txb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txb_email.HideSelection = true;
            this.txb_email.LeadingIcon = null;
            this.txb_email.Location = new System.Drawing.Point(34, 311);
            this.txb_email.MaxLength = 32767;
            this.txb_email.MouseState = MaterialSkin.MouseState.OUT;
            this.txb_email.Name = "txb_email";
            this.txb_email.PasswordChar = '\0';
            this.txb_email.PrefixSuffixText = null;
            this.txb_email.ReadOnly = false;
            this.txb_email.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txb_email.SelectedText = "";
            this.txb_email.SelectionLength = 0;
            this.txb_email.SelectionStart = 0;
            this.txb_email.ShortcutsEnabled = true;
            this.txb_email.Size = new System.Drawing.Size(370, 48);
            this.txb_email.TabIndex = 4;
            this.txb_email.TabStop = false;
            this.txb_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txb_email.TrailingIcon = null;
            this.txb_email.UseSystemPasswordChar = false;
            // 
            // txb_senha
            // 
            this.txb_senha.AnimateReadOnly = false;
            this.txb_senha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txb_senha.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txb_senha.Depth = 0;
            this.txb_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txb_senha.HideSelection = true;
            this.txb_senha.LeadingIcon = null;
            this.txb_senha.Location = new System.Drawing.Point(472, 324);
            this.txb_senha.MaxLength = 32767;
            this.txb_senha.MouseState = MaterialSkin.MouseState.OUT;
            this.txb_senha.Name = "txb_senha";
            this.txb_senha.PasswordChar = '\0';
            this.txb_senha.PrefixSuffixText = null;
            this.txb_senha.ReadOnly = false;
            this.txb_senha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txb_senha.SelectedText = "";
            this.txb_senha.SelectionLength = 0;
            this.txb_senha.SelectionStart = 0;
            this.txb_senha.ShortcutsEnabled = true;
            this.txb_senha.Size = new System.Drawing.Size(370, 48);
            this.txb_senha.TabIndex = 5;
            this.txb_senha.TabStop = false;
            this.txb_senha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txb_senha.TrailingIcon = null;
            this.txb_senha.UseSystemPasswordChar = false;
            // 
            // btnfoto
            // 
            this.btnfoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnfoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnfoto.Location = new System.Drawing.Point(131, 74);
            this.btnfoto.Name = "btnfoto";
            this.btnfoto.Size = new System.Drawing.Size(133, 109);
            this.btnfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnfoto.TabIndex = 6;
            this.btnfoto.TabStop = false;
            this.btnfoto.Click += new System.EventHandler(this.btnfoto_Click);
            // 
            // lblDash
            // 
            this.lblDash.AutoSize = true;
            this.lblDash.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDash.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblDash.Location = new System.Drawing.Point(27, 24);
            this.lblDash.Name = "lblDash";
            this.lblDash.Size = new System.Drawing.Size(102, 42);
            this.lblDash.TabIndex = 9;
            this.lblDash.Text = "Perfil";
            // 
            // lbltema
            // 
            this.lbltema.AutoSize = true;
            this.lbltema.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltema.ForeColor = System.Drawing.SystemColors.Control;
            this.lbltema.Location = new System.Drawing.Point(568, 50);
            this.lbltema.Name = "lbltema";
            this.lbltema.Size = new System.Drawing.Size(140, 29);
            this.lbltema.TabIndex = 10;
            this.lbltema.Text = "Tema Claro";
            this.lbltema.Click += new System.EventHandler(this.label2_Click);
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(317, 526);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(76, 36);
            this.materialButton1.TabIndex = 12;
            this.materialButton1.Text = "Salvar";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(39, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(38, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "E-mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(477, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 29);
            this.label3.TabIndex = 15;
            this.label3.Text = "Senha";
            // 
            // txb_login
            // 
            this.txb_login.AnimateReadOnly = false;
            this.txb_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txb_login.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txb_login.Depth = 0;
            this.txb_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txb_login.HideSelection = true;
            this.txb_login.LeadingIcon = null;
            this.txb_login.Location = new System.Drawing.Point(472, 220);
            this.txb_login.MaxLength = 32767;
            this.txb_login.MouseState = MaterialSkin.MouseState.OUT;
            this.txb_login.Name = "txb_login";
            this.txb_login.PasswordChar = '\0';
            this.txb_login.PrefixSuffixText = null;
            this.txb_login.ReadOnly = false;
            this.txb_login.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txb_login.SelectedText = "";
            this.txb_login.SelectionLength = 0;
            this.txb_login.SelectionStart = 0;
            this.txb_login.ShortcutsEnabled = true;
            this.txb_login.Size = new System.Drawing.Size(370, 48);
            this.txb_login.TabIndex = 16;
            this.txb_login.TabStop = false;
            this.txb_login.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txb_login.TrailingIcon = null;
            this.txb_login.UseSystemPasswordChar = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(479, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 29);
            this.label4.TabIndex = 17;
            this.label4.Text = "Login";
            // 
            // materialSwitch1
            // 
            this.materialSwitch1.AutoSize = true;
            this.materialSwitch1.Depth = 0;
            this.materialSwitch1.Location = new System.Drawing.Point(784, 284);
            this.materialSwitch1.Margin = new System.Windows.Forms.Padding(0);
            this.materialSwitch1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialSwitch1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSwitch1.Name = "materialSwitch1";
            this.materialSwitch1.Ripple = true;
            this.materialSwitch1.Size = new System.Drawing.Size(58, 37);
            this.materialSwitch1.TabIndex = 19;
            this.materialSwitch1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(477, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 29);
            this.label5.TabIndex = 20;
            this.label5.Text = "id";
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(442, 526);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(84, 36);
            this.materialButton2.TabIndex = 23;
            this.materialButton2.Text = "Alterar";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click_1);
            // 
            // Perfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(885, 612);
            this.Controls.Add(this.materialButton2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.materialSwitch1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txb_login);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.lbltema);
            this.Controls.Add(this.lblDash);
            this.Controls.Add(this.btnfoto);
            this.Controls.Add(this.txb_senha);
            this.Controls.Add(this.txb_email);
            this.Controls.Add(this.txb_nome);
            this.Controls.Add(this.switchTema);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Perfil";
            this.Text = "Perfil";
            this.Load += new System.EventHandler(this.Perfil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnfoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialSwitch switchTema;
        private MaterialSkin.Controls.MaterialTextBox2 txb_nome;
        private MaterialSkin.Controls.MaterialTextBox2 txb_email;
        private MaterialSkin.Controls.MaterialTextBox2 txb_senha;
        private System.Windows.Forms.PictureBox btnfoto;
        private System.Windows.Forms.Label lblDash;
        private System.Windows.Forms.Label lbltema;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialTextBox2 txb_login;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialSwitch materialSwitch1;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialButton materialButton2;
    }
}