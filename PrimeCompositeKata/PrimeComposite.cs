using System;

namespace PrimeCompositeKata
{
    public class PrimeComposite
    {
        public static string GetOutput(int number)
        {
            if (number < 1 || number > 100)
            {
                throw new ValueIsNotInRangeException("Value can be between 1 and 100");
            }
            int count = 0;
            
            for (int i = 1; i <= number; i++)
                if (number % i == 0)
                    count++;
            if (count == 2)
                return "Prime";
            if (count > 2 && number % 2 != 0)
                return "Composite";
            return number.ToString();
        }
    }
}
