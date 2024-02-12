using BusinessLayer;
using DataAccessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KatmanliMimariProje
{
	public partial class frmOgrenci : Form
	{
		public frmOgrenci()
		{
			InitializeComponent();
		}

		private void btnKaydet_Click(object sender, EventArgs e)
		{
			EntityOgrenci ent = new EntityOgrenci();
			ent.Ad = txtOgrAd.Text;
			ent.Soyad = txtOgrSoyad.Text;
			ent.Numara = txtOgrNumara.Text;	
			ent.Bolum = txtOgrBolum.Text;
			BLOgrenci.OgrenciEkleBL(ent);


		}

		private void btnListele_Click(object sender, EventArgs e)
		{
			List<EntityOgrenci> ogrenci = DalOgrenci.OgrenciListesi();
			dataGridView1.DataSource = ogrenci;
		}

		private void frmOgrenci_Load(object sender, EventArgs e)
		{

		}

		private void btnSil_Click(object sender, EventArgs e)
		{
			int deger = int.Parse(txtID.Text);
			EntityOgrenci ogrenci = new EntityOgrenci();
			ogrenci.OgrId = deger;
			BLOgrenci.OgrenciSillBL(ogrenci.OgrId);
		}

		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			EntityOgrenci ent = new EntityOgrenci();
			ent.Ad =txtOgrAd.Text;
			ent.Soyad = txtOgrSoyad.Text;
			ent.Numara = txtOgrNumara.Text;
			ent.Bolum = txtOgrBolum.Text;
			ent.OgrId = int.Parse(txtID.Text);	
			BLOgrenci.OgrenciGuncelleBL(ent);
		}
	}
}
