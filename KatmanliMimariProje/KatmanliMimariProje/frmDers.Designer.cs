namespace KatmanliMimariProje
{
	partial class frmDers
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.txtID = new System.Windows.Forms.TextBox();
			this.btnKaydet = new System.Windows.Forms.Button();
			this.txtDersAd = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnSil = new System.Windows.Forms.Button();
			this.btnGuncelle = new System.Windows.Forms.Button();
			this.btnListele = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(481, 211);
			this.dataGridView1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(510, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Ders ID";
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(559, 17);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(213, 20);
			this.txtID.TabIndex = 2;
			// 
			// btnKaydet
			// 
			this.btnKaydet.Location = new System.Drawing.Point(559, 69);
			this.btnKaydet.Name = "btnKaydet";
			this.btnKaydet.Size = new System.Drawing.Size(213, 34);
			this.btnKaydet.TabIndex = 3;
			this.btnKaydet.Text = "KAYDET";
			this.btnKaydet.UseVisualStyleBackColor = true;
			this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
			// 
			// txtDersAd
			// 
			this.txtDersAd.Location = new System.Drawing.Point(559, 43);
			this.txtDersAd.Name = "txtDersAd";
			this.txtDersAd.Size = new System.Drawing.Size(213, 20);
			this.txtDersAd.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(506, 50);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Ders Adı";
			// 
			// btnSil
			// 
			this.btnSil.Location = new System.Drawing.Point(559, 109);
			this.btnSil.Name = "btnSil";
			this.btnSil.Size = new System.Drawing.Size(213, 34);
			this.btnSil.TabIndex = 6;
			this.btnSil.Text = "SİL";
			this.btnSil.UseVisualStyleBackColor = true;
			this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
			// 
			// btnGuncelle
			// 
			this.btnGuncelle.Location = new System.Drawing.Point(559, 149);
			this.btnGuncelle.Name = "btnGuncelle";
			this.btnGuncelle.Size = new System.Drawing.Size(213, 34);
			this.btnGuncelle.TabIndex = 7;
			this.btnGuncelle.Text = "GÜNCELLE";
			this.btnGuncelle.UseVisualStyleBackColor = true;
			this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
			// 
			// btnListele
			// 
			this.btnListele.Location = new System.Drawing.Point(559, 189);
			this.btnListele.Name = "btnListele";
			this.btnListele.Size = new System.Drawing.Size(213, 34);
			this.btnListele.TabIndex = 8;
			this.btnListele.Text = "LİSTELE";
			this.btnListele.UseVisualStyleBackColor = true;
			this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
			// 
			// frmDers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 239);
			this.Controls.Add(this.btnListele);
			this.Controls.Add(this.btnGuncelle);
			this.Controls.Add(this.btnSil);
			this.Controls.Add(this.txtDersAd);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnKaydet);
			this.Controls.Add(this.txtID);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "frmDers";
			this.Text = "Ders İşlemleri";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.Button btnKaydet;
		private System.Windows.Forms.TextBox txtDersAd;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnSil;
		private System.Windows.Forms.Button btnGuncelle;
		private System.Windows.Forms.Button btnListele;
	}
}

