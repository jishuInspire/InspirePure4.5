using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspire.Common
{
    public class parameters
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }
    }

   
    public class DBAccess
    {
        string _connStr = ConfigurationManager.ConnectionStrings["InspireConnection"].ConnectionString;

        public DataSet GetDataSet(SqlCommand cmd)
        {
            try

            {
              
                DataSet ds = new DataSet();

                using (SqlConnection con = new SqlConnection(_connStr))
                {
                    cmd.Connection = con;

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(ds);
                            con.Close();
                        }
                    
                }
                return ds;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
