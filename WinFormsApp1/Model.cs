using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorWinForms
{
    class Model
    {
        //public decimal Sqrt(decimal x, decimal? guess = null)
        //{
        //    var ourGuess = guess.GetValueOrDefault(x / 2m);
        //    var result = x / ourGuess;
        //    var average = (ourGuess + result) / 2m;

        //    if (average == ourGuess) // This checks for the maximum precision possible with a decimal.
        //        return average;
        //    else
        //        return Sqrt(x, average);
        //}
        public static decimal Sqrt(decimal x, decimal? guess = null)
        {
            var ourGuess = guess.GetValueOrDefault(x / 2m);
            var result = x / ourGuess;
            var average = (ourGuess + result) / 2m;

            if (average == ourGuess) // This checks for the maximum precision possible with a decimal.
                return average;
            else
                return Sqrt(x, average);
        }
        public static decimal Add(decimal argument1, decimal argument2)
        {
            decimal result = argument1 + argument2;
            return result;
        }
        public static decimal Sub(decimal argument1, decimal argument2)
        {
            decimal result = argument1 - argument2;
            return result;
        }
    }
}
