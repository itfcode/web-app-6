using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITFCodeWA.Core.Data.Base.Interface
{
    public interface ITrackable
    {
        DateTimeOffset CreatedOn { get; set; }       
        DateTimeOffset ModifiedOn { get; set; }
    }
}
