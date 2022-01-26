using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DREDD.API.Infrastructure.Exceptions
{
    public class DreddDomainException : Exception
    {
        public DreddDomainException()
        { }

        public DreddDomainException(string message)
            : base(message)
        { }

        public DreddDomainException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}
