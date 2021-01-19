using System;

namespace PrimeCompositeKata
{
    public class PrimeComposite
    {
        public static string GetOutput(int input)
        {
            if (input % input == 0 || input % 1 == 0)
                return "Prime";

            return null;
        }
    }
}
