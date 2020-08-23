using Inspire.Core.Interface;
using Inspire.Common;
using Inspire.DataLayer.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Inspire.DataLayer.DAL;

namespace Inspire.Core.Repository
{
    public class MasterDataRepository: IMasterDataRepository
    {
        private readonly string _connStr;

        public MasterDataRepository()
        {
        }

        public List<ViewStatesddl> GetAllState()
        {
            try
            {
                List<ViewStatesddl> statesddls = new List<ViewStatesddl>();
                MasterDataDBAccess db = new MasterDataDBAccess();
                DataSet ds = db.Stateddl();
                if ((ds != null) && (ds.Tables.Count > 0) && (ds.Tables[0] != null) && (ds.Tables[0].Rows.Count > 0))
                    statesddls = ds.Tables[0].ToListOfObject<ViewStatesddl>();
                return statesddls;
            }
            catch (Exception ex)
            {
                //_logger.LogError(ex, $"");
                throw;
            }
        }
    }
}
