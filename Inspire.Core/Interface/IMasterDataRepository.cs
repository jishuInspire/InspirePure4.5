using Inspire.DataLayer.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspire.Core.Interface
{
    public interface IMasterDataRepository
    {
       
            List<ViewStatesddl> GetAllState();
       
    }
}
