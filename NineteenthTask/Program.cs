using System;

namespace NineteenthTask
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0}", DisplayRoundedDecimal(12.345678M, 3));
            Console.WriteLine("Нажмите <enter> и ИДИТЕ НАХУЙ, ВЫ ТУПОЙ ПИДОРАС))");
            Console.Read();
        }
        public static string DisplayRoundedDecimal(decimal value, int nNumberOfSignificantDigits)
        {
            decimal mRoundedValue = decimal.Round(value, nNumberOfSignificantDigits);
            string s = Convert.ToString(mRoundedValue);
            return s;
        }
        public static string DisplayRoundedDecimal(decimal value)
        {
            string s = DisplayRoundedDecimal(value, 2);
            return s;
        }
    }
}
