using Inspire.Core.Interface;
using Inspire.Core.Repository;
using Inspire.DataLayer.ViewModel;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace InspireApi4._5.Controllers
{
    [RoutePrefix("api/MasterData")]
    public class MasterDataController : ApiController
    {

        IMasterDataRepository _MasterDataRepository;
       
        public MasterDataController()
        {
            _MasterDataRepository = new MasterDataRepository();
        }
        public MasterDataController(IMasterDataRepository masterData)
        {
            _MasterDataRepository = masterData;
        }
        [Route("GetAllStates")]
        [HttpGet]
        public List<ViewStatesddl> GetAllStates()
        {
            try
            {
                return _MasterDataRepository.GetAllState();
            }
            catch (Exception ex)
            {
                //_logger.LogError(ex, $"");
                throw;
            }
            //return null;
        }
    }
}
