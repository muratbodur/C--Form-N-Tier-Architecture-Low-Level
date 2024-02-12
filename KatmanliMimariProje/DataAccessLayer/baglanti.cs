using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
	public class baglanti
	{
		public static SqlConnection bgl = new SqlConnection("Data Source=MURATBODUR;Initial Catalog=DbKatmanliMimari;User ID=sa; password=2697; MultipleActiveResultSets=True; Timeout=900");
	}
}
