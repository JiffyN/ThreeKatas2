using System;

namespace PrimeCompositeKata
{
    public class PrimeComposite
    {
        public static string GetOutput<T>(T input)
        {
            if (typeof(T) != typeof(int))
            {
                throw new ValueIsNotOfIntTypeException("Value can be only of integer type");
            }

            var number = Convert.ToInt32(input);
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
