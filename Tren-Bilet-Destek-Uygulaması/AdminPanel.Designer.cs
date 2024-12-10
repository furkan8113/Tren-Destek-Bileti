namespace Tren_Destek_Bileti_Gerçek
{
    partial class AdminPanel
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
            this.cmbKategoriFiltre = new System.Windows.Forms.ComboBox();
            this.txtCevap = new System.Windows.Forms.TextBox();
            this.btnFiltrele = new System.Windows.Forms.Button();
            this.btnCevapla = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTickets
            // 
            this.dataGridViewTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTickets.Location = new System.Drawing.Point(18, 127);
            this.dataGridViewTickets.MultiSelect = false;
            this.dataGridViewTickets.Name = "dataGridViewTickets";
            this.dataGridViewTickets.RowHeadersWidth = 51;
            this.dataGridViewTickets.RowTemplate.Height = 24;
            this.dataGridViewTickets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTickets.Size = new System.Drawing.Size(750, 139);
            this.dataGridViewTickets.TabIndex = 0;
            // 
            // cmbKategoriFiltre
            // 
            this.cmbKategoriFiltre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbKategoriFiltre.FormattingEnabled = true;
            this.cmbKategoriFiltre.Location = new System.Drawing.Point(304, 26);
            this.cmbKategoriFiltre.Name = "cmbKategoriFiltre";
            this.cmbKategoriFiltre.Size = new System.Drawing.Size(144, 33);
            this.cmbKategoriFiltre.TabIndex = 1;
            // 
            // txtCevap
            // 
            this.txtCevap.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCevap.Location = new System.Drawing.Point(35, 331);
            this.txtCevap.Name = "txtCevap";
            this.txtCevap.Size = new System.Drawing.Size(149, 42);
            this.txtCevap.TabIndex = 2;
            // 
            // btnFiltrele
            // 
            this.btnFiltrele.Location = new System.Drawing.Point(491, 26);
            this.btnFiltrele.Name = "btnFiltrele";
            this.btnFiltrele.Size = new System.Drawing.Size(106, 33);
            this.btnFiltrele.TabIndex = 3;
            this.btnFiltrele.Text = "FİLTRELE";
            this.btnFiltrele.UseVisualStyleBackColor = true;
            this.btnFiltrele.Click += new System.EventHandler(this.btnFiltrele_Click_1);
            // 
            // btnCevapla
            // 
            this.btnCevapla.Location = new System.Drawing.Point(216, 331);
            this.btnCevapla.Name = "btnCevapla";
            this.btnCevapla.Size = new System.Drawing.Size(88, 23);
            this.btnCevapla.TabIndex = 4;
            this.btnCevapla.Text = "CEVAPLA";
            this.btnCevapla.UseVisualStyleBackColor = true;
            this.btnCevapla.Click += new System.EventHandler(this.btnCevapla_Click_1);
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(216, 375);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(88, 23);
            this.btnKapat.TabIndex = 5;
            this.btnKapat.Text = "KAPAT";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cevap Yaz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 35);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kategori Filtreleme";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(265, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 43);
            this.label3.TabIndex = 8;
            this.label3.Text = "Destek Biletleri";
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnCevapla);
            this.Controls.Add(this.btnFiltrele);
            this.Controls.Add(this.txtCevap);
            this.Controls.Add(this.cmbKategoriFiltre);
            this.Controls.Add(this.dataGridViewTickets);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTickets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTickets;
        private System.Windows.Forms.ComboBox cmbKategoriFiltre;
        private System.Windows.Forms.TextBox txtCevap;
        private System.Windows.Forms.Button btnFiltrele;
        private System.Windows.Forms.Button btnCevapla;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}