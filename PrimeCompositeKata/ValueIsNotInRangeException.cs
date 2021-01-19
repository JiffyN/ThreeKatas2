using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeCompositeKata
{
    public class ValueIsNotInRangeException : Exception
    {
        public ValueIsNotInRangeException(string message) : base(message)
        {
            
        }
    }
}
