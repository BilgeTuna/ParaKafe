
namespace ParaKafe
{
    partial class SiparisForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMasaTasi = new System.Windows.Forms.Button();
            this.dgvsiparisDetaylar = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMasaNo = new System.Windows.Forms.Label();
            this.lblOdemeTutari = new System.Windows.Forms.Label();
            this.btnSiparisIptal = new System.Windows.Forms.Button();
            this.btnOdemeAl = new System.Windows.Forms.Button();
            this.btnAnasayfayaDon = new System.Windows.Forms.Button();
            this.nudAdet = new System.Windows.Forms.NumericUpDown();
            this.cboUrun = new System.Windows.Forms.ComboBox();
            this.cboMasaNo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsiparisDetaylar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(397, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Adet :";
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEkle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEkle.Location = new System.Drawing.Point(628, 54);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(164, 38);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1004, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Masa No :";
            // 
            // btnMasaTasi
            // 
            this.btnMasaTasi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMasaTasi.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnMasaTasi.Location = new System.Drawing.Point(1184, 55);
            this.btnMasaTasi.Name = "btnMasaTasi";
            this.btnMasaTasi.Size = new System.Drawing.Size(157, 37);
            this.btnMasaTasi.TabIndex = 8;
            this.btnMasaTasi.Text = "TAŞI";
            this.btnMasaTasi.UseVisualStyleBackColor = false;
            this.btnMasaTasi.Click += new System.EventHandler(this.btnMasaTasi_Click);
            // 
            // dgvsiparisDetaylar
            // 
            this.dgvsiparisDetaylar.AllowUserToAddRows = false;
            this.dgvsiparisDetaylar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvsiparisDetaylar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvsiparisDetaylar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvsiparisDetaylar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsiparisDetaylar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvsiparisDetaylar.Location = new System.Drawing.Point(12, 112);
            this.dgvsiparisDetaylar.MultiSelect = false;
            this.dgvsiparisDetaylar.Name = "dgvsiparisDetaylar";
            this.dgvsiparisDetaylar.ReadOnly = true;
            this.dgvsiparisDetaylar.RowHeadersWidth = 62;
            this.dgvsiparisDetaylar.RowTemplate.Height = 28;
            this.dgvsiparisDetaylar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvsiparisDetaylar.Size = new System.Drawing.Size(780, 523);
            this.dgvsiparisDetaylar.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "UrunAd";
            this.Column1.HeaderText = "Ürün Adı";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "BirimFiyat";
            dataGridViewCellStyle1.Format = "#,###.00₺";
            this.Column2.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column2.HeaderText = "Birim Fiyatı";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Adet";
            this.Column3.HeaderText = "Adet";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TutarTL";
            this.Column4.HeaderText = "Tutar";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // lblMasaNo
            // 
            this.lblMasaNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMasaNo.BackColor = System.Drawing.Color.Salmon;
            this.lblMasaNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMasaNo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblMasaNo.Location = new System.Drawing.Point(813, 118);
            this.lblMasaNo.Name = "lblMasaNo";
            this.lblMasaNo.Size = new System.Drawing.Size(528, 244);
            this.lblMasaNo.TabIndex = 9;
            this.lblMasaNo.Text = "00";
            this.lblMasaNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOdemeTutari
            // 
            this.lblOdemeTutari.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOdemeTutari.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblOdemeTutari.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdemeTutari.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblOdemeTutari.Location = new System.Drawing.Point(813, 382);
            this.lblOdemeTutari.Name = "lblOdemeTutari";
            this.lblOdemeTutari.Size = new System.Drawing.Size(528, 87);
            this.lblOdemeTutari.TabIndex = 10;
            this.lblOdemeTutari.Text = " Ödeme Tutarı : 0.00₺";
            this.lblOdemeTutari.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSiparisIptal
            // 
            this.btnSiparisIptal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSiparisIptal.BackColor = System.Drawing.Color.Maroon;
            this.btnSiparisIptal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSiparisIptal.Location = new System.Drawing.Point(808, 483);
            this.btnSiparisIptal.Name = "btnSiparisIptal";
            this.btnSiparisIptal.Size = new System.Drawing.Size(251, 66);
            this.btnSiparisIptal.TabIndex = 11;
            this.btnSiparisIptal.Text = "SİPARİŞ İPTAL";
            this.btnSiparisIptal.UseVisualStyleBackColor = false;
            this.btnSiparisIptal.Click += new System.EventHandler(this.btnSiparisIptal_Click);
            // 
            // btnOdemeAl
            // 
            this.btnOdemeAl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOdemeAl.BackColor = System.Drawing.Color.YellowGreen;
            this.btnOdemeAl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOdemeAl.Location = new System.Drawing.Point(1089, 483);
            this.btnOdemeAl.Name = "btnOdemeAl";
            this.btnOdemeAl.Size = new System.Drawing.Size(252, 66);
            this.btnOdemeAl.TabIndex = 12;
            this.btnOdemeAl.Text = "ÖDEME AL";
            this.btnOdemeAl.UseVisualStyleBackColor = false;
            this.btnOdemeAl.Click += new System.EventHandler(this.btnOdemeAl_Click);
            // 
            // btnAnasayfayaDon
            // 
            this.btnAnasayfayaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnasayfayaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAnasayfayaDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAnasayfayaDon.Location = new System.Drawing.Point(808, 555);
            this.btnAnasayfayaDon.Name = "btnAnasayfayaDon";
            this.btnAnasayfayaDon.Size = new System.Drawing.Size(533, 80);
            this.btnAnasayfayaDon.TabIndex = 13;
            this.btnAnasayfayaDon.Text = "ANASAYFAYA DÖN";
            this.btnAnasayfayaDon.UseVisualStyleBackColor = false;
            this.btnAnasayfayaDon.Click += new System.EventHandler(this.btnAnasayfayaDon_Click);
            // 
            // nudAdet
            // 
            this.nudAdet.Location = new System.Drawing.Point(402, 57);
            this.nudAdet.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudAdet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAdet.Name = "nudAdet";
            this.nudAdet.Size = new System.Drawing.Size(169, 35);
            this.nudAdet.TabIndex = 4;
            this.nudAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cboUrun
            // 
            this.cboUrun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUrun.FormattingEnabled = true;
            this.cboUrun.Location = new System.Drawing.Point(13, 55);
            this.cboUrun.Name = "cboUrun";
            this.cboUrun.Size = new System.Drawing.Size(345, 37);
            this.cboUrun.TabIndex = 1;
            // 
            // cboMasaNo
            // 
            this.cboMasaNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboMasaNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMasaNo.FormattingEnabled = true;
            this.cboMasaNo.Location = new System.Drawing.Point(1009, 54);
            this.cboMasaNo.Name = "cboMasaNo";
            this.cboMasaNo.Size = new System.Drawing.Size(162, 37);
            this.cboMasaNo.TabIndex = 7;
            // 
            // SiparisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1373, 647);
            this.Controls.Add(this.cboMasaNo);
            this.Controls.Add(this.cboUrun);
            this.Controls.Add(this.nudAdet);
            this.Controls.Add(this.lblMasaNo);
            this.Controls.Add(this.dgvsiparisDetaylar);
            this.Controls.Add(this.btnAnasayfayaDon);
            this.Controls.Add(this.btnOdemeAl);
            this.Controls.Add(this.btnSiparisIptal);
            this.Controls.Add(this.btnMasaTasi);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblOdemeTutari);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "SiparisForm";
            this.Text = "Masa 0";
            ((System.ComponentModel.ISupportInitialize)(this.dgvsiparisDetaylar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMasaTasi;
        private System.Windows.Forms.DataGridView dgvsiparisDetaylar;
        private System.Windows.Forms.Label lblMasaNo;
        private System.Windows.Forms.Label lblOdemeTutari;
        private System.Windows.Forms.Button btnSiparisIptal;
        private System.Windows.Forms.Button btnOdemeAl;
        private System.Windows.Forms.Button btnAnasayfayaDon;
        private System.Windows.Forms.NumericUpDown nudAdet;
        private System.Windows.Forms.ComboBox cboUrun;
        private System.Windows.Forms.ComboBox cboMasaNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}