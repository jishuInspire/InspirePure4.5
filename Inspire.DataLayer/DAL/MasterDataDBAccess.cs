using Inspire.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspire.DataLayer.DAL
{
   public class MasterDataDBAccess
    {

        public DataSet Stateddl()
        {
            try

            {
                DataSet ds = new DataSet();
                using (SqlCommand cmd = new SqlCommand("GetStatesforDDL"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_Id", 0);
                    DBAccess DB = new DBAccess();
                     ds = DB.GetDataSet(cmd);

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
