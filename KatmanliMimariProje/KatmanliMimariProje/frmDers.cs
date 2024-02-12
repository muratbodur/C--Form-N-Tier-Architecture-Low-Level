using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using DataAccessLayer;
using BusinessLayer;

namespace KatmanliMimariProje
{
	public partial class frmDers : Form
	{
		public frmDers()
		{
			InitializeComponent();
		}

		private void btnKaydet_Click(object sender, EventArgs e)
		{
			EntityDers ent = new EntityDers();
			ent.DersAd = txtDersAd.Text;
			BLDers.DersEkleBL(ent);

		}

		
		private void btnListele_Click(object sender, EventArgs e)
		{
			List<EntityDers> ders = BLDers.DersListesiBL();
			dataGridView1.DataSource = ders;

		}

		private void btnSil_Click(object sender, EventArgs e)
		{
			byte deger = byte.Parse(txtID.Text);
			EntityDers ders = new EntityDers();
			ders.DersId = deger;
			BLDers.DersSilBL(ders.DersId);
					
		}

		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			EntityDers ent = new EntityDers();
			ent.DersAd = txtDersAd.Text;
			ent.DersId = byte.Parse(txtID.Text);
			BLDers.DersGuncelleBL(ent);
		}
	}
}
