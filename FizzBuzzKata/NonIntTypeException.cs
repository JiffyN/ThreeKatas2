using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzKata
{
    public class NonIntTypeException : Exception
    {
        public NonIntTypeException(string message) : base(message)
        {
            
        }
    }
}
