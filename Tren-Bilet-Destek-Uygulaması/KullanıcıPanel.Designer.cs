namespace Tren_Destek_Bileti_Gerçek
{
    partial class KullanıcıPanel
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
            this.dataGridViewTickets = new System.Windows.Forms.DataGridView();
            this.txtBaslik = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.btnBiletOlustur = new System.Windows.Forms.Button();
            this.btnDurumGor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTickets
            // 
            this.dataGridViewTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTickets.Location = new System.Drawing.Point(16, 171);
            this.dataGridViewTickets.MultiSelect = false;
            this.dataGridViewTickets.Name = "dataGridViewTickets";
            this.dataGridViewTickets.RowHeadersWidth = 51;
            this.dataGridViewTickets.RowTemplate.Height = 24;
            this.dataGridViewTickets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTickets.Size = new System.Drawing.Size(752, 175);
            this.dataGridViewTickets.TabIndex = 0;
            // 
            // txtBaslik
            // 
            this.txtBaslik.Location = new System.Drawing.Point(12, 92);
            this.txtBaslik.Name = "txtBaslik";
            this.txtBaslik.Size = new System.Drawing.Size(100, 22);
            this.txtBaslik.TabIndex = 1;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(196, 90);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(100, 22);
            this.txtAciklama.TabIndex = 2;
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(401, 90);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(121, 24);
            this.cmbKategori.TabIndex = 3;
            // 
            // btnBiletOlustur
            // 
            this.btnBiletOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBiletOlustur.Location = new System.Drawing.Point(623, 46);
            this.btnBiletOlustur.Name = "btnBiletOlustur";
            this.btnBiletOlustur.Size = new System.Drawing.Size(145, 68);
            this.btnBiletOlustur.TabIndex = 4;
            this.btnBiletOlustur.Text = "BİLET OLUŞTUR";
            this.btnBiletOlustur.UseVisualStyleBackColor = true;
            this.btnBiletOlustur.Click += new System.EventHandler(this.btnBiletOlustur_Click_1);
            // 
            // btnDurumGor
            // 
            this.btnDurumGor.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDurumGor.Location = new System.Drawing.Point(293, 371);
            this.btnDurumGor.Name = "btnDurumGor";
            this.btnDurumGor.Size = new System.Drawing.Size(147, 67);
            this.btnDurumGor.TabIndex = 5;
            this.btnDurumGor.Text = "DURUM GÖR";
            this.btnDurumGor.UseVisualStyleBackColor = true;
            this.btnDurumGor.Click += new System.EventHandler(this.btnDurumGor_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(247, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Destek Bileti Oluştur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Başlık";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(398, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kategori Seçimi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(192, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Açıklama";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(247, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(284, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mevcut Destek Biletlerim";
            // 
            // KullanıcıPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDurumGor);
            this.Controls.Add(this.btnBiletOlustur);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtBaslik);
            this.Controls.Add(this.dataGridViewTickets);
            this.Name = "KullanıcıPanel";
            this.Text = "KullanıcıPanel";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTickets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTickets;
        private System.Windows.Forms.TextBox txtBaslik;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.Button btnBiletOlustur;
        private System.Windows.Forms.Button btnDurumGor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}