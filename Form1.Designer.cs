using System;
using System.Windows.Forms;

namespace Kültür_Etkinlik_ve_bilet
{
    partial class b
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(b));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.chkYetkili = new System.Windows.Forms.CheckBox();
            this.chkMusteri = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnGiris = new Guna.UI2.WinForms.Guna2Button();
            this.txtTcKimlik = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSifre = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2Panel1.BackgroundImage")));
            this.guna2Panel1.Controls.Add(this.Panel2);
            this.guna2Panel1.Location = new System.Drawing.Point(-3, -39);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(857, 495);
            this.guna2Panel1.TabIndex = 0;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.Panel2.Controls.Add(this.chkYetkili);
            this.Panel2.Controls.Add(this.chkMusteri);
            this.Panel2.Controls.Add(this.linkLabel1);
            this.Panel2.Controls.Add(this.btnGiris);
            this.Panel2.Controls.Add(this.txtTcKimlik);
            this.Panel2.Controls.Add(this.txtSifre);
            this.Panel2.Controls.Add(this.label1);
            this.Panel2.Location = new System.Drawing.Point(226, 91);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(417, 331);
            this.Panel2.TabIndex = 2;
            this.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // chkYetkili
            // 
            this.chkYetkili.AutoSize = true;
            this.chkYetkili.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.chkYetkili.Location = new System.Drawing.Point(179, 218);
            this.chkYetkili.Name = "chkYetkili";
            this.chkYetkili.Size = new System.Drawing.Size(81, 27);
            this.chkYetkili.TabIndex = 11;
            this.chkYetkili.Text = "Yetkili";
            this.chkYetkili.UseVisualStyleBackColor = true;
            this.chkYetkili.CheckedChanged += new System.EventHandler(this.chkPersonel_CheckedChanged);
            // 
            // chkMusteri
            // 
            this.chkMusteri.AutoSize = true;
            this.chkMusteri.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMusteri.Location = new System.Drawing.Point(80, 218);
            this.chkMusteri.Name = "chkMusteri";
            this.chkMusteri.Size = new System.Drawing.Size(93, 27);
            this.chkMusteri.TabIndex = 9;
            this.chkMusteri.Text = "Müşteri";
            this.chkMusteri.UseVisualStyleBackColor = true;
            this.chkMusteri.CheckedChanged += new System.EventHandler(this.chkMusteri_CheckedChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.Location = new System.Drawing.Point(312, 270);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(80, 25);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Kayıt Ol";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnGiris
            // 
            this.btnGiris.Animated = true;
            this.btnGiris.AutoRoundedCorners = true;
            this.btnGiris.BackColor = System.Drawing.Color.Transparent;
            this.btnGiris.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGiris.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGiris.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGiris.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGiris.FillColor = System.Drawing.Color.Goldenrod;
            this.btnGiris.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnGiris.ForeColor = System.Drawing.Color.White;
            this.btnGiris.Image = ((System.Drawing.Image)(resources.GetObject("btnGiris.Image")));
            this.btnGiris.Location = new System.Drawing.Point(89, 252);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(209, 51);
            this.btnGiris.TabIndex = 7;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // txtTcKimlik
            // 
            this.txtTcKimlik.Animated = true;
            this.txtTcKimlik.AutoRoundedCorners = true;
            this.txtTcKimlik.BackColor = System.Drawing.Color.Goldenrod;
            this.txtTcKimlik.BorderColor = System.Drawing.Color.White;
            this.txtTcKimlik.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTcKimlik.DefaultText = "";
            this.txtTcKimlik.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTcKimlik.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTcKimlik.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTcKimlik.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTcKimlik.FillColor = System.Drawing.Color.Gainsboro;
            this.txtTcKimlik.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTcKimlik.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTcKimlik.ForeColor = System.Drawing.Color.White;
            this.txtTcKimlik.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTcKimlik.Location = new System.Drawing.Point(80, 63);
            this.txtTcKimlik.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTcKimlik.Name = "txtTcKimlik";
            this.txtTcKimlik.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtTcKimlik.PlaceholderText = "Kullancı Adı";
            this.txtTcKimlik.SelectedText = "";
            this.txtTcKimlik.Size = new System.Drawing.Size(229, 48);
            this.txtTcKimlik.TabIndex = 5;
            this.txtTcKimlik.TextChanged += new System.EventHandler(this.txtTcKimlik_TextChanged);
            // 
            // txtSifre
            // 
            this.txtSifre.Animated = true;
            this.txtSifre.AutoRoundedCorners = true;
            this.txtSifre.BackColor = System.Drawing.Color.Goldenrod;
            this.txtSifre.BorderColor = System.Drawing.Color.White;
            this.txtSifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSifre.DefaultText = "";
            this.txtSifre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSifre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSifre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSifre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSifre.FillColor = System.Drawing.Color.Gainsboro;
            this.txtSifre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSifre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSifre.ForeColor = System.Drawing.Color.White;
            this.txtSifre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSifre.Location = new System.Drawing.Point(80, 156);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtSifre.PlaceholderText = "Şifre";
            this.txtSifre.SelectedText = "";
            this.txtSifre.Size = new System.Drawing.Size(229, 48);
            this.txtSifre.TabIndex = 6;
            this.txtSifre.TextChanged += new System.EventHandler(this.txtSifre_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(120, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "GİRİŞ EKRANI";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // b
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 457);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "b";
            this.Text = "Kültür Bilet";
            this.guna2Panel1.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtTcKimlik_TextChanged(object sender, EventArgs e)
        {

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel Panel2;
        private System.Windows.Forms.CheckBox chkYetkili;
        private System.Windows.Forms.CheckBox chkMusteri;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private Guna.UI2.WinForms.Guna2Button btnGiris;
        private Guna.UI2.WinForms.Guna2TextBox txtTcKimlik;
        private Guna.UI2.WinForms.Guna2TextBox txtSifre;
        private System.Windows.Forms.Label label1;
    }
}

