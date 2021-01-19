using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeCompositeKata
{
    public class ValueIsNotOfIntTypeException : Exception
    {
        public ValueIsNotOfIntTypeException(string message) : base(message)
        {
            
        }
    }
}
