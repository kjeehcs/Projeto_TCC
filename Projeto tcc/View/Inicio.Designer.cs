﻿namespace Projeto_tcc
{
    partial class Inicio
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.switchLigar = new MaterialSkin.Controls.MaterialSwitch();
            this.lbltxt3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 81F);
            this.label1.ForeColor = System.Drawing.Color.SkyBlue;
            this.label1.Location = new System.Drawing.Point(153, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 154);
            this.label1.TabIndex = 0;
            this.label1.Text = "00:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label2.Location = new System.Drawing.Point(129, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "xx/xx/xxxx";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // switchLigar
            // 
            this.switchLigar.AutoSize = true;
            this.switchLigar.Depth = 0;
            this.switchLigar.Location = new System.Drawing.Point(158, 37);
            this.switchLigar.Margin = new System.Windows.Forms.Padding(0);
            this.switchLigar.MouseLocation = new System.Drawing.Point(-1, -1);
            this.switchLigar.MouseState = MaterialSkin.MouseState.HOVER;
            this.switchLigar.Name = "switchLigar";
            this.switchLigar.Ripple = true;
            this.switchLigar.Size = new System.Drawing.Size(58, 37);
            this.switchLigar.TabIndex = 2;
            this.switchLigar.UseVisualStyleBackColor = true;
            this.switchLigar.CheckedChanged += new System.EventHandler(this.switchLigar_CheckedChanged);
            // 
            // lbltxt3
            // 
            this.lbltxt3.AutoSize = true;
            this.lbltxt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltxt3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lbltxt3.Location = new System.Drawing.Point(34, 38);
            this.lbltxt3.Name = "lbltxt3";
            this.lbltxt3.Size = new System.Drawing.Size(78, 32);
            this.lbltxt3.TabIndex = 3;
            this.lbltxt3.Text = "Ligar";
            this.lbltxt3.Click += new System.EventHandler(this.label3_Click);
            // 
            // inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(885, 612);
            this.Controls.Add(this.lbltxt3);
            this.Controls.Add(this.switchLigar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "inicio";
            this.Text = "inicio";
            this.Load += new System.EventHandler(this.inicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private MaterialSkin.Controls.MaterialSwitch switchLigar;
        private System.Windows.Forms.Label lbltxt3;
    }
}