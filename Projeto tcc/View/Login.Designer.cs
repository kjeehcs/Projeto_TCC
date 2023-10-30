namespace Projeto_tcc.View
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btnEntrar = new System.Windows.Forms.Button();
            this.txb_user_senha = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txb_user_login = new MaterialSkin.Controls.MaterialTextBox2();
            this.picMostrar = new System.Windows.Forms.PictureBox();
            this.picOcultar = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Fechar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMostrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOcultar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.FlatAppearance.BorderSize = 0;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnEntrar.Location = new System.Drawing.Point(533, 392);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(157, 61);
            this.btnEntrar.TabIndex = 3;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // txb_user_senha
            // 
            this.txb_user_senha.AllowPromptAsInput = true;
            this.txb_user_senha.AnimateReadOnly = false;
            this.txb_user_senha.AsciiOnly = false;
            this.txb_user_senha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txb_user_senha.BeepOnError = false;
            this.txb_user_senha.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txb_user_senha.Depth = 0;
            this.txb_user_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txb_user_senha.HidePromptOnLeave = false;
            this.txb_user_senha.HideSelection = true;
            this.txb_user_senha.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txb_user_senha.LeadingIcon = null;
            this.txb_user_senha.Location = new System.Drawing.Point(463, 297);
            this.txb_user_senha.Mask = "";
            this.txb_user_senha.MaxLength = 32767;
            this.txb_user_senha.MouseState = MaterialSkin.MouseState.OUT;
            this.txb_user_senha.Name = "txb_user_senha";
            this.txb_user_senha.PasswordChar = '●';
            this.txb_user_senha.PrefixSuffixText = null;
            this.txb_user_senha.PromptChar = '_';
            this.txb_user_senha.ReadOnly = false;
            this.txb_user_senha.RejectInputOnFirstFailure = false;
            this.txb_user_senha.ResetOnPrompt = true;
            this.txb_user_senha.ResetOnSpace = true;
            this.txb_user_senha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txb_user_senha.SelectedText = "";
            this.txb_user_senha.SelectionLength = 0;
            this.txb_user_senha.SelectionStart = 0;
            this.txb_user_senha.ShortcutsEnabled = true;
            this.txb_user_senha.Size = new System.Drawing.Size(297, 48);
            this.txb_user_senha.SkipLiterals = true;
            this.txb_user_senha.TabIndex = 2;
            this.txb_user_senha.TabStop = false;
            this.txb_user_senha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txb_user_senha.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txb_user_senha.TrailingIcon = null;
            this.txb_user_senha.UseSystemPasswordChar = false;
            this.txb_user_senha.ValidatingType = null;
            // 
            // txb_user_login
            // 
            this.txb_user_login.AnimateReadOnly = false;
            this.txb_user_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txb_user_login.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txb_user_login.Depth = 0;
            this.txb_user_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txb_user_login.HideSelection = true;
            this.txb_user_login.LeadingIcon = null;
            this.txb_user_login.Location = new System.Drawing.Point(463, 209);
            this.txb_user_login.MaxLength = 32767;
            this.txb_user_login.MouseState = MaterialSkin.MouseState.OUT;
            this.txb_user_login.Name = "txb_user_login";
            this.txb_user_login.PasswordChar = '\0';
            this.txb_user_login.PrefixSuffixText = null;
            this.txb_user_login.ReadOnly = false;
            this.txb_user_login.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txb_user_login.SelectedText = "";
            this.txb_user_login.SelectionLength = 0;
            this.txb_user_login.SelectionStart = 0;
            this.txb_user_login.ShortcutsEnabled = true;
            this.txb_user_login.Size = new System.Drawing.Size(297, 48);
            this.txb_user_login.TabIndex = 1;
            this.txb_user_login.TabStop = false;
            this.txb_user_login.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txb_user_login.TrailingIcon = null;
            this.txb_user_login.UseSystemPasswordChar = false;
            this.txb_user_login.Click += new System.EventHandler(this.materialTextBox21_Click);
            // 
            // picMostrar
            // 
            this.picMostrar.Image = global::Projeto_tcc.Properties.Resources.visiblePassword;
            this.picMostrar.Location = new System.Drawing.Point(783, 310);
            this.picMostrar.Name = "picMostrar";
            this.picMostrar.Size = new System.Drawing.Size(25, 25);
            this.picMostrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMostrar.TabIndex = 15;
            this.picMostrar.TabStop = false;
            this.picMostrar.Click += new System.EventHandler(this.picMostrar_Click);
            // 
            // picOcultar
            // 
            this.picOcultar.Image = global::Projeto_tcc.Properties.Resources.invisiblePassword;
            this.picOcultar.Location = new System.Drawing.Point(783, 310);
            this.picOcultar.Name = "picOcultar";
            this.picOcultar.Size = new System.Drawing.Size(25, 25);
            this.picOcultar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOcultar.TabIndex = 14;
            this.picOcultar.TabStop = false;
            this.picOcultar.Click += new System.EventHandler(this.picOcultar_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(300, 527);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(422, 222);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(422, 310);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // Fechar
            // 
            this.Fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Fechar.Image = ((System.Drawing.Image)(resources.GetObject("Fechar.Image")));
            this.Fechar.Location = new System.Drawing.Point(859, 12);
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(35, 30);
            this.Fechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Fechar.TabIndex = 9;
            this.Fechar.TabStop = false;
            this.Fechar.Click += new System.EventHandler(this.Fechar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(463, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(297, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 527);
            this.Controls.Add(this.picMostrar);
            this.Controls.Add(this.picOcultar);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Fechar);
            this.Controls.Add(this.txb_user_login);
            this.Controls.Add(this.txb_user_senha);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMostrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOcultar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEntrar;
        private MaterialSkin.Controls.MaterialTextBox2 txb_user_login;
        private System.Windows.Forms.PictureBox Fechar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox picOcultar;
        private System.Windows.Forms.PictureBox picMostrar;
        public MaterialSkin.Controls.MaterialMaskedTextBox txb_user_senha;
    }
}

