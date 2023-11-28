namespace Projeto_tcc
{
    partial class Listas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Listas));
            this.Txb_Url = new MaterialSkin.Controls.MaterialTextBox2();
            this.dataGridBlackList = new System.Windows.Forms.DataGridView();
            this.btn_addlist = new System.Windows.Forms.PictureBox();
            this.lblDash = new System.Windows.Forms.Label();
            this.btn_deletelist = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Domain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBlackList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_addlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_deletelist)).BeginInit();
            this.SuspendLayout();
            // 
            // Txb_Url
            // 
            this.Txb_Url.AccessibleDescription = "domain.com";
            this.Txb_Url.AccessibleName = "";
            this.Txb_Url.AnimateReadOnly = false;
            this.Txb_Url.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Txb_Url.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Txb_Url.Depth = 0;
            this.Txb_Url.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Txb_Url.HideSelection = true;
            this.Txb_Url.LeadingIcon = null;
            this.Txb_Url.Location = new System.Drawing.Point(118, 98);
            this.Txb_Url.Margin = new System.Windows.Forms.Padding(2);
            this.Txb_Url.MaxLength = 32767;
            this.Txb_Url.MouseState = MaterialSkin.MouseState.OUT;
            this.Txb_Url.Name = "Txb_Url";
            this.Txb_Url.PasswordChar = '\0';
            this.Txb_Url.PrefixSuffixText = null;
            this.Txb_Url.ReadOnly = false;
            this.Txb_Url.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Txb_Url.SelectedText = "";
            this.Txb_Url.SelectionLength = 0;
            this.Txb_Url.SelectionStart = 0;
            this.Txb_Url.ShortcutsEnabled = true;
            this.Txb_Url.Size = new System.Drawing.Size(343, 48);
            this.Txb_Url.TabIndex = 0;
            this.Txb_Url.TabStop = false;
            this.Txb_Url.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Txb_Url.TrailingIcon = null;
            this.Txb_Url.UseSystemPasswordChar = false;
            // 
            // dataGridBlackList
            // 
            this.dataGridBlackList.AllowUserToAddRows = false;
            this.dataGridBlackList.AllowUserToDeleteRows = false;
            this.dataGridBlackList.AllowUserToResizeColumns = false;
            this.dataGridBlackList.AllowUserToResizeRows = false;
            this.dataGridBlackList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridBlackList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridBlackList.ColumnHeadersHeight = 29;
            this.dataGridBlackList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridBlackList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Domain});
            this.dataGridBlackList.Location = new System.Drawing.Point(72, 159);
            this.dataGridBlackList.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridBlackList.Name = "dataGridBlackList";
            this.dataGridBlackList.ReadOnly = true;
            this.dataGridBlackList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridBlackList.RowHeadersWidth = 51;
            this.dataGridBlackList.RowTemplate.Height = 24;
            this.dataGridBlackList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridBlackList.Size = new System.Drawing.Size(516, 261);
            this.dataGridBlackList.TabIndex = 1;
            this.dataGridBlackList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridBlackList_CellContentClick);
            // 
            // btn_addlist
            // 
            this.btn_addlist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addlist.Image = ((System.Drawing.Image)(resources.GetObject("btn_addlist.Image")));
            this.btn_addlist.Location = new System.Drawing.Point(501, 117);
            this.btn_addlist.Margin = new System.Windows.Forms.Padding(2);
            this.btn_addlist.Name = "btn_addlist";
            this.btn_addlist.Size = new System.Drawing.Size(29, 29);
            this.btn_addlist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_addlist.TabIndex = 2;
            this.btn_addlist.TabStop = false;
            this.btn_addlist.Click += new System.EventHandler(this.btn_addlist_Click);
            // 
            // lblDash
            // 
            this.lblDash.AutoSize = true;
            this.lblDash.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDash.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblDash.Location = new System.Drawing.Point(16, 18);
            this.lblDash.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDash.Name = "lblDash";
            this.lblDash.Size = new System.Drawing.Size(135, 36);
            this.lblDash.TabIndex = 8;
            this.lblDash.Text = "BlackList";
            // 
            // btn_deletelist
            // 
            this.btn_deletelist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_deletelist.Image = ((System.Drawing.Image)(resources.GetObject("btn_deletelist.Image")));
            this.btn_deletelist.Location = new System.Drawing.Point(547, 117);
            this.btn_deletelist.Margin = new System.Windows.Forms.Padding(2);
            this.btn_deletelist.Name = "btn_deletelist";
            this.btn_deletelist.Size = new System.Drawing.Size(29, 29);
            this.btn_deletelist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_deletelist.TabIndex = 10;
            this.btn_deletelist.TabStop = false;
            this.btn_deletelist.Click += new System.EventHandler(this.btn_deletelist_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(68, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "URL:";
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Domain
            // 
            this.Domain.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Domain.HeaderText = "Domínio";
            this.Domain.Name = "Domain";
            this.Domain.ReadOnly = true;
            this.Domain.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Listas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(664, 497);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_deletelist);
            this.Controls.Add(this.lblDash);
            this.Controls.Add(this.btn_addlist);
            this.Controls.Add(this.dataGridBlackList);
            this.Controls.Add(this.Txb_Url);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Listas";
            this.Text = "Listas";
            this.Load += new System.EventHandler(this.Listas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBlackList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_addlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_deletelist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 Txb_Url;
        private System.Windows.Forms.DataGridView dataGridBlackList;
        private System.Windows.Forms.PictureBox btn_addlist;
        private System.Windows.Forms.Label lblDash;
        private System.Windows.Forms.PictureBox btn_deletelist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Domain;
    }
}