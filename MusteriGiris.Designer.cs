using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Kültür_Etkinlik_ve_bilet
{
    partial class MusteriGiris
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriGiris));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.tabPageBiletAl = new System.Windows.Forms.TabPage();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSatinAl = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2CustomRadioButton1 = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.radioKrediKart = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownAdet = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.guna2DataGridView2 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tabPageEtkinlikler = new System.Windows.Forms.TabPage();
            this.guna2DataGridView3 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tabPageHesabim = new System.Windows.Forms.TabPage();
            this.tabPageAlinanBiletler = new System.Windows.Forms.TabPage();
            this.guna2DataGridView4 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tabPageCikis = new System.Windows.Forms.TabPage();
            this.guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.lblAdSoyad1 = new System.Windows.Forms.Label();
            this.lblKullaniciAdi1 = new System.Windows.Forms.Label();
            this.lblCinsiyet1 = new System.Windows.Forms.Label();
            this.tabPageBiletAl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView2)).BeginInit();
            this.tabPageEtkinlikler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView3)).BeginInit();
            this.tabPageHesabim.SuspendLayout();
            this.tabPageAlinanBiletler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView4)).BeginInit();
            this.guna2TabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // tabPageBiletAl
            // 
            this.tabPageBiletAl.Controls.Add(this.lblRol);
            this.tabPageBiletAl.Controls.Add(this.lblAdSoyad);
            this.tabPageBiletAl.Controls.Add(this.lblKullaniciAdi);
            this.tabPageBiletAl.Controls.Add(this.label3);
            this.tabPageBiletAl.Controls.Add(this.btnSatinAl);
            this.tabPageBiletAl.Controls.Add(this.label6);
            this.tabPageBiletAl.Controls.Add(this.label5);
            this.tabPageBiletAl.Controls.Add(this.guna2CustomRadioButton1);
            this.tabPageBiletAl.Controls.Add(this.radioKrediKart);
            this.tabPageBiletAl.Controls.Add(this.label4);
            this.tabPageBiletAl.Controls.Add(this.lblToplamTutar);
            this.tabPageBiletAl.Controls.Add(this.label2);
            this.tabPageBiletAl.Controls.Add(this.label1);
            this.tabPageBiletAl.Controls.Add(this.numericUpDownAdet);
            this.tabPageBiletAl.Controls.Add(this.guna2DataGridView2);
            this.tabPageBiletAl.Location = new System.Drawing.Point(184, 4);
            this.tabPageBiletAl.Name = "tabPageBiletAl";
            this.tabPageBiletAl.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBiletAl.Size = new System.Drawing.Size(771, 452);
            this.tabPageBiletAl.TabIndex = 3;
            this.tabPageBiletAl.Text = "Bilet Satın Al";
            this.tabPageBiletAl.UseVisualStyleBackColor = true;
            this.tabPageBiletAl.Click += new System.EventHandler(this.tabPageBiletAl_Click);
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(393, 10);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(49, 16);
            this.lblRol.TabIndex = 17;
            this.lblRol.Text = "Durum:";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(77, 10);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(34, 16);
            this.lblAdSoyad.TabIndex = 16;
            this.lblAdSoyad.Text = "İsim:";
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(6, 9);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(56, 16);
            this.lblKullaniciAdi.TabIndex = 15;
            this.lblKullaniciAdi.Text = "Kullancı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "ETKİNLİK İSMİ";
            // 
            // btnSatinAl
            // 
            this.btnSatinAl.Animated = true;
            this.btnSatinAl.AutoRoundedCorners = true;
            this.btnSatinAl.BackColor = System.Drawing.Color.Transparent;
            this.btnSatinAl.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSatinAl.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSatinAl.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSatinAl.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSatinAl.FillColor = System.Drawing.Color.Goldenrod;
            this.btnSatinAl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnSatinAl.ForeColor = System.Drawing.Color.White;
            this.btnSatinAl.Image = ((System.Drawing.Image)(resources.GetObject("btnSatinAl.Image")));
            this.btnSatinAl.Location = new System.Drawing.Point(18, 366);
            this.btnSatinAl.Name = "btnSatinAl";
            this.btnSatinAl.Size = new System.Drawing.Size(209, 51);
            this.btnSatinAl.TabIndex = 13;
            this.btnSatinAl.Text = "Şatın al";
            this.btnSatinAl.Click += new System.EventHandler(this.btnSatinAl_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(455, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nakit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(288, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Kredi Kartı";
            // 
            // guna2CustomRadioButton1
            // 
            this.guna2CustomRadioButton1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CustomRadioButton1.CheckedState.BorderThickness = 0;
            this.guna2CustomRadioButton1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CustomRadioButton1.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2CustomRadioButton1.Location = new System.Drawing.Point(429, 333);
            this.guna2CustomRadioButton1.Name = "guna2CustomRadioButton1";
            this.guna2CustomRadioButton1.Size = new System.Drawing.Size(20, 20);
            this.guna2CustomRadioButton1.TabIndex = 10;
            this.guna2CustomRadioButton1.Text = "guna2CustomRadioButton1";
            this.guna2CustomRadioButton1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CustomRadioButton1.UncheckedState.BorderThickness = 2;
            this.guna2CustomRadioButton1.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.guna2CustomRadioButton1.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // radioKrediKart
            // 
            this.radioKrediKart.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioKrediKart.CheckedState.BorderThickness = 0;
            this.radioKrediKart.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioKrediKart.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radioKrediKart.Location = new System.Drawing.Point(361, 333);
            this.radioKrediKart.Name = "radioKrediKart";
            this.radioKrediKart.Size = new System.Drawing.Size(20, 20);
            this.radioKrediKart.TabIndex = 9;
            this.radioKrediKart.Text = "guna2CustomRadioButton1";
            this.radioKrediKart.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioKrediKart.UncheckedState.BorderThickness = 2;
            this.radioKrediKart.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radioKrediKart.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.radioKrediKart.CheckedChanged += new System.EventHandler(this.radioKrediKart_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(338, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ödeme Yöntemi";
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToplamTutar.Location = new System.Drawing.Point(470, 394);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(44, 23);
            this.lblToplamTutar.TabIndex = 4;
            this.lblToplamTutar.Text = "0 TL";
            this.lblToplamTutar.Click += new System.EventHandler(this.lblToplamTutar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(338, 394);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Toplam Tutar :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kaç Adet Bilet Alınacak";
            // 
            // numericUpDownAdet
            // 
            this.numericUpDownAdet.BackColor = System.Drawing.Color.Transparent;
            this.numericUpDownAdet.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numericUpDownAdet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numericUpDownAdet.Location = new System.Drawing.Point(18, 243);
            this.numericUpDownAdet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDownAdet.Name = "numericUpDownAdet";
            this.numericUpDownAdet.Size = new System.Drawing.Size(114, 48);
            this.numericUpDownAdet.TabIndex = 1;
            this.numericUpDownAdet.ValueChanged += new System.EventHandler(this.numericUpDownAdet_ValueChanged);
            // 
            // guna2DataGridView2
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.guna2DataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.guna2DataGridView2.ColumnHeadersHeight = 4;
            this.guna2DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView2.DefaultCellStyle = dataGridViewCellStyle6;
            this.guna2DataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView2.Location = new System.Drawing.Point(0, 35);
            this.guna2DataGridView2.Name = "guna2DataGridView2";
            this.guna2DataGridView2.RowHeadersVisible = false;
            this.guna2DataGridView2.RowHeadersWidth = 51;
            this.guna2DataGridView2.RowTemplate.Height = 24;
            this.guna2DataGridView2.Size = new System.Drawing.Size(547, 126);
            this.guna2DataGridView2.TabIndex = 0;
            this.guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView2.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.guna2DataGridView2.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.Height = 4;
            this.guna2DataGridView2.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView2.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView2.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView2.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2DataGridView2.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView2.ThemeStyle.RowsStyle.Height = 24;
            this.guna2DataGridView2.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView2.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView2_CellContentClick);
            // 
            // tabPageEtkinlikler
            // 
            this.tabPageEtkinlikler.Controls.Add(this.guna2DataGridView3);
            this.tabPageEtkinlikler.Location = new System.Drawing.Point(184, 4);
            this.tabPageEtkinlikler.Name = "tabPageEtkinlikler";
            this.tabPageEtkinlikler.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEtkinlikler.Size = new System.Drawing.Size(771, 452);
            this.tabPageEtkinlikler.TabIndex = 2;
            this.tabPageEtkinlikler.Text = "Etkinlik Listesi";
            this.tabPageEtkinlikler.UseVisualStyleBackColor = true;
            this.tabPageEtkinlikler.Click += new System.EventHandler(this.tabPageEtkinlikler_Click);
            // 
            // guna2DataGridView3
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView3.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView3.ColumnHeadersHeight = 4;
            this.guna2DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView3.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView3.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView3.Location = new System.Drawing.Point(0, 4);
            this.guna2DataGridView3.Name = "guna2DataGridView3";
            this.guna2DataGridView3.RowHeadersVisible = false;
            this.guna2DataGridView3.RowHeadersWidth = 51;
            this.guna2DataGridView3.RowTemplate.Height = 24;
            this.guna2DataGridView3.Size = new System.Drawing.Size(601, 169);
            this.guna2DataGridView3.TabIndex = 0;
            this.guna2DataGridView3.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView3.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView3.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView3.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView3.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView3.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView3.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView3.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView3.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView3.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2DataGridView3.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView3.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView3.ThemeStyle.HeaderStyle.Height = 4;
            this.guna2DataGridView3.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView3.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView3.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView3.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2DataGridView3.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView3.ThemeStyle.RowsStyle.Height = 24;
            this.guna2DataGridView3.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView3.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // tabPageHesabim
            // 
            this.tabPageHesabim.Controls.Add(this.lblCinsiyet1);
            this.tabPageHesabim.Controls.Add(this.lblKullaniciAdi1);
            this.tabPageHesabim.Controls.Add(this.lblAdSoyad1);
            this.tabPageHesabim.Location = new System.Drawing.Point(184, 4);
            this.tabPageHesabim.Name = "tabPageHesabim";
            this.tabPageHesabim.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHesabim.Size = new System.Drawing.Size(771, 452);
            this.tabPageHesabim.TabIndex = 1;
            this.tabPageHesabim.Text = "Hesabım";
            this.tabPageHesabim.UseVisualStyleBackColor = true;
            // 
            // tabPageAlinanBiletler
            // 
            this.tabPageAlinanBiletler.Controls.Add(this.guna2DataGridView4);
            this.tabPageAlinanBiletler.Location = new System.Drawing.Point(184, 4);
            this.tabPageAlinanBiletler.Name = "tabPageAlinanBiletler";
            this.tabPageAlinanBiletler.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAlinanBiletler.Size = new System.Drawing.Size(771, 452);
            this.tabPageAlinanBiletler.TabIndex = 4;
            this.tabPageAlinanBiletler.Text = "Alınan Biletler";
            this.tabPageAlinanBiletler.UseVisualStyleBackColor = true;
            this.tabPageAlinanBiletler.Click += new System.EventHandler(this.tabPageAlinanBiletler_Click);
            // 
            // guna2DataGridView4
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView4.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView4.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.guna2DataGridView4.ColumnHeadersHeight = 4;
            this.guna2DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView4.DefaultCellStyle = dataGridViewCellStyle9;
            this.guna2DataGridView4.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView4.Location = new System.Drawing.Point(0, 6);
            this.guna2DataGridView4.Name = "guna2DataGridView4";
            this.guna2DataGridView4.RowHeadersVisible = false;
            this.guna2DataGridView4.RowHeadersWidth = 51;
            this.guna2DataGridView4.RowTemplate.Height = 24;
            this.guna2DataGridView4.Size = new System.Drawing.Size(586, 169);
            this.guna2DataGridView4.TabIndex = 1;
            this.guna2DataGridView4.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView4.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView4.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView4.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView4.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView4.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView4.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView4.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView4.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView4.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2DataGridView4.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView4.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView4.ThemeStyle.HeaderStyle.Height = 4;
            this.guna2DataGridView4.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView4.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView4.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView4.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2DataGridView4.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView4.ThemeStyle.RowsStyle.Height = 24;
            this.guna2DataGridView4.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView4.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // tabPageCikis
            // 
            this.tabPageCikis.Location = new System.Drawing.Point(184, 4);
            this.tabPageCikis.Name = "tabPageCikis";
            this.tabPageCikis.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCikis.Size = new System.Drawing.Size(771, 452);
            this.tabPageCikis.TabIndex = 5;
            this.tabPageCikis.Text = "Çıkış Yap";
            this.tabPageCikis.UseVisualStyleBackColor = true;
            // 
            // guna2TabControl1
            // 
            this.guna2TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.guna2TabControl1.Controls.Add(this.tabPageHesabim);
            this.guna2TabControl1.Controls.Add(this.tabPageEtkinlikler);
            this.guna2TabControl1.Controls.Add(this.tabPageBiletAl);
            this.guna2TabControl1.Controls.Add(this.tabPageAlinanBiletler);
            this.guna2TabControl1.Controls.Add(this.tabPageCikis);
            this.guna2TabControl1.ItemSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.Location = new System.Drawing.Point(3, -4);
            this.guna2TabControl1.Name = "guna2TabControl1";
            this.guna2TabControl1.SelectedIndex = 0;
            this.guna2TabControl1.Size = new System.Drawing.Size(959, 460);
            this.guna2TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.guna2TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.guna2TabControl1.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.guna2TabControl1.TabButtonSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.TabIndex = 3;
            this.guna2TabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.SelectedIndexChanged += new System.EventHandler(this.guna2TabControl1_SelectedIndexChanged);
            // 
            // lblAdSoyad1
            // 
            this.lblAdSoyad1.AutoSize = true;
            this.lblAdSoyad1.Location = new System.Drawing.Point(28, 13);
            this.lblAdSoyad1.Name = "lblAdSoyad1";
            this.lblAdSoyad1.Size = new System.Drawing.Size(67, 16);
            this.lblAdSoyad1.TabIndex = 0;
            this.lblAdSoyad1.Text = "Ad Soyad";
            // 
            // lblKullaniciAdi1
            // 
            this.lblKullaniciAdi1.AutoSize = true;
            this.lblKullaniciAdi1.Location = new System.Drawing.Point(28, 59);
            this.lblKullaniciAdi1.Name = "lblKullaniciAdi1";
            this.lblKullaniciAdi1.Size = new System.Drawing.Size(76, 16);
            this.lblKullaniciAdi1.TabIndex = 1;
            this.lblKullaniciAdi1.Text = "Kullancı Adı";
            // 
            // lblCinsiyet1
            // 
            this.lblCinsiyet1.AutoSize = true;
            this.lblCinsiyet1.Location = new System.Drawing.Point(28, 108);
            this.lblCinsiyet1.Name = "lblCinsiyet1";
            this.lblCinsiyet1.Size = new System.Drawing.Size(54, 16);
            this.lblCinsiyet1.TabIndex = 2;
            this.lblCinsiyet1.Text = "Çinsiyet";
            // 
            // MusteriGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guna2TabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MusteriGiris";
            this.Text = "Müşteri Giriş Paneli";
            this.tabPageBiletAl.ResumeLayout(false);
            this.tabPageBiletAl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView2)).EndInit();
            this.tabPageEtkinlikler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView3)).EndInit();
            this.tabPageHesabim.ResumeLayout(false);
            this.tabPageHesabim.PerformLayout();
            this.tabPageAlinanBiletler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView4)).EndInit();
            this.guna2TabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
   
        }

        private void lblToplamTutar_Click(object sender, EventArgs e)
        {
            
        }

        private void radioKrediKart_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void tabPageBiletAl_Click(object sender, EventArgs e)
        {

        }


            private void tabPageEtkinlikler_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string query = "SELECT EtkinlikID, EtkinlikAdi, EtkinlikTarihi, Konum, Kategori, Kontenjan, BiletFiyati FROM Etkinlikler ORDER BY EtkinlikTarihi ASC";

                SqlDataAdapter da = new SqlDataAdapter(query, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);

                guna2DataGridView3.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Hiç etkinlik bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Etkinlik listesi yüklenirken hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private System.Windows.Forms.TabPage tabPageHesabim;
        private System.Windows.Forms.TabPage tabPageEtkinlikler;
        private System.Windows.Forms.TabPage tabPageBiletAl;
        private System.Windows.Forms.TabPage tabPageAlinanBiletler;
        private System.Windows.Forms.TabPage tabPageCikis;
        private Label label1;
        private Guna.UI2.WinForms.Guna2NumericUpDown numericUpDownAdet;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView2;
        private Label label4;
        private Label lblToplamTutar;
        private Label label2;
        private Label label6;
        private Label label5;
        private Guna.UI2.WinForms.Guna2CustomRadioButton guna2CustomRadioButton1;
        private Guna.UI2.WinForms.Guna2CustomRadioButton radioKrediKart;
        private Guna.UI2.WinForms.Guna2Button btnSatinAl;
        private Label label3;
        private Label lblRol;
        private Label lblAdSoyad;
        private Label lblKullaniciAdi;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView3;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView4;
        private Label lblAdSoyad1;
        private Label lblCinsiyet1;
        private Label lblKullaniciAdi1;
    }
}
