using System;
using System.Collections.Generic;
using System.Text;

namespace Sedc.OOP.Class6.Excercises.App.NumberStats
{
    class IsDecimal
    {
        public static bool isNumberDecimal( int n)
        {
            n *= 10;
            return n % 1 != 0;
        }
    }
}
