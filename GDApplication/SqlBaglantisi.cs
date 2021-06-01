using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace GDApplication
{
    class SqlBaglantisi
    {
        public SqlConnection baglan()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=GazeteDergiApp;Integrated Security=True");
            baglanti.Open();
            return baglanti;
        }
    }
}
