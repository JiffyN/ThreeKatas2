﻿using System;

namespace FizzBuzzKata
{
    public class FizzBuzz
    {
        public static string FizzBuzzMethod<T>(T input)
        {
            int number = 0;
            if (typeof(T) != typeof(int))
            {
                throw new NonIntTypeException("Value can be only an integer");
            }
            number = Convert.ToInt32(input);
            if (number % 3 == 0 && number % 5 == 0)
                return "FizzBuzz";

            if (number % 3 == 0)
                return "Fizz";

            if (number % 5 == 0)
                return "Buzz";

            return number.ToString();
        }
    }
}
