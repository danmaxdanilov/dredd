using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DREDD.API.Models.DomainModels
{
    public class DicisionOutput
    {
        public string NextCondition { get; set; }
        public string MethodName { get; set; }
    }
}
