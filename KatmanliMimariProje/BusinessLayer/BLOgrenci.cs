using DataAccessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
	public class BLOgrenci
	{
		public static int OgrenciEkleBL(EntityOgrenci p)
		{
			if (p.Ad != null && p.Soyad != null && p.Numara != null && p.Bolum!="" && p.Ad.Length>=2 && p.Ad.Length <=30 && p.Numara.Length==5)
			{
				return DalOgrenci.OgrenciEkle(p);
			}
			return -1;
		}

		public static int OgrenciSillBL(int p)
		{
			if (p > 1)
			{
				return DalOgrenci.OgrenciSil(p);
			}
			else
			{
				return -1;
			}
		}

		public static int OgrenciGuncelleBL(EntityOgrenci p)
		{
			if (p.Ad != null && p.Soyad != null && p.Numara != null && p.Bolum != "" && p.Ad.Length >= 2 && p.Ad.Length <= 30 && p.Numara.Length == 5)
			{
				return DalOgrenci.OgrenciGuncelle(p);
			}
			return -1;
		}





	}
}
