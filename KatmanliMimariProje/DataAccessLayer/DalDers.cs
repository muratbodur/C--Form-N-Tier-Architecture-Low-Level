using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
	public class DalDers
	{
		//CRUD İŞLEMLERİ

		public static int DersEkle(EntityDers p)
		{
			SqlCommand komut1 = new SqlCommand("INSERT INTO TBLDERSLER (DersAd) VALUES (@p1)", baglanti.bgl);
			if (komut1.Connection.State != ConnectionState.Open)
			{
				komut1.Connection.Open();
			}
			komut1.Parameters.AddWithValue("@p1", p.DersAd);
			return komut1.ExecuteNonQuery();	

		}

		public static List<EntityDers> DersListesi()
		{
			List<EntityDers> dersler = new List<EntityDers>();
			SqlCommand komut2 = new SqlCommand("SELECT * FROM TBLDERSLER", baglanti.bgl);
			if (komut2.Connection.State != ConnectionState.Open)
			{
				komut2.Connection.Open();
			}
			SqlDataReader dr = komut2.ExecuteReader();
			while (dr.Read())
			{
				EntityDers ent = new EntityDers();
				ent.DersId = byte.Parse(dr["DersID"].ToString());
				ent.DersAd = dr["DersAd"].ToString();
				dersler.Add(ent);
			}
			dr.Close();
			return dersler;
		}


		public static int DersSil(byte p)
		{
			SqlCommand komut3 = new SqlCommand("DELETE FROM TBLDERSLER WHERE DersID =@p1", baglanti.bgl);
			if (komut3.Connection.State != ConnectionState.Open)
			{
				komut3.Connection.Open();
			}
			komut3.Parameters.AddWithValue("@p1", p);
			return komut3.ExecuteNonQuery();

		}

		public static int DersGuncelle(EntityDers p) 
		{

			SqlCommand komut4= new SqlCommand("UPDATE TBLDERSLER SET DersAd=@p1 WHERE dersID=@p2", baglanti.bgl);
			if (komut4.Connection.State != ConnectionState.Open)
			{
				komut4.Connection.Open();
			}
			komut4.Parameters.AddWithValue("@p1", p.DersAd);
			komut4.Parameters.AddWithValue("@p2", p.DersId);
			return komut4.ExecuteNonQuery();
		}



	}
}
