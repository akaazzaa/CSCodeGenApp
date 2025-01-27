using CSCodeGen.DataAccess.Model;
using CSCodeGen.DataAccess.Repository;
using System.Collections.Generic;
using System.Linq;

namespace CSCodeGen.Library
{
    public class PlaceholderController : ControllerBase<Placeholder>
    {

        public PlaceholderController(PlaceholderRepository repo) : base(repo)
        {
            
        }

        
    }
}
