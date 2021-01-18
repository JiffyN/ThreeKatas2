using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeKatas
{
    public class MoreThanFiveGroupsException : Exception
    {
        public MoreThanFiveGroupsException(string message) : base(message)
        { }
    }
}
