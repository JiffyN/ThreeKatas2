using System;

namespace PrimeCompositeKata
{
    public class PrimeComposite
    {
        public static string GetOutput(int input)
        {
            int count = 0;
            
            for (int i = 1; i <= input; i++)
                if (input % i == 0)
                    count++;
            if (count == 2)
                return "Prime";
            if(count > 2 && input % 2 != 0)
                return "Composite";
            
            return input.ToString();
        }
    }
}
