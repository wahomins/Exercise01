using System.Numerics;

namespace Exercise01
{
    public static class NumberExtensions
    {
        public static string lastPart(BigInteger value, BigInteger div)
        {
            BigInteger modulo = value % div;
            string lastPart = modulo == 0 ? "" : $"{(div == 100 ? "and " : "")}{ConvertTowards(modulo)}";
            return lastPart;
        }

        public static string ConvertTowards(BigInteger value)
        {

            string[] ordinals = new string[] {
                "zero", "one", "two", "three", "four",
                "five", "six", "seven", "eight", "nine",
                "ten", "eleven", "twelve",
                "thirteen",  "fourteen", "fifteen", "sixteen",
                "seventeen", "eighteen", "nineteen"
            };

            string[] multiplesOfTen = new string[] {
                "", "", "twenty",  "thirty", "forty",
                "fifty", "sixty", "seventy", "eighty", "ninety"
            };

            string[] powersOfTen = new string[] {
                "hundred", "thousand", "million", "billion", "trillion", "quadrillion", "quintillion"
            };

           
            // how about not using negative numbers
            if (value < 0)
            {
                value *= -1;
            }

            // we know these as ordinals
            if (value < 20)
            {
                return ordinals[(int)value];
            }

            // we know these as multiples of ten
            if (value < 100)
            {
                int modulo = (int)value % 10;
                return $"{multiplesOfTen[(int)value / 10]} {(modulo == 0 ? "" : ordinals[modulo])}";
            }

            // Hundred
            if (value < 1000)
            {
                int div = 100;
                return $"{ConvertTowards(value / div)} {powersOfTen[0]} {lastPart(value, div)}";
            }

            // Thousand
            if (value < 1_000_000)
            {
                int div = 1_000;
                return $"{ConvertTowards(value / div)} {powersOfTen[1]} {lastPart(value, div)}";
            }

            // Million
            if (value < 1_000_000_000)
            {
                int div = 1_000_000;
                return $"{ConvertTowards(value / div)} {powersOfTen[2]} {lastPart(value, div)}";
            }

            // Billion
            if (value < 1_000_000_000_000)
            {
                int div = 1_000_000_000;
                return $"{ConvertTowards(value / div)} {powersOfTen[3]} {lastPart(value, div)}";
            }

            // Trillion
            if (value < 1_000_000_000_000_000)
            {
                BigInteger div = 1_000_000_000_000;
                return $"{ConvertTowards(value / div)} {powersOfTen[4]} {lastPart(value, div)}";
            }

            // Quadrillion
            if (value < 1_000_000_000_000_000_000)
            {
                BigInteger div = 1_000_000_000_000_000;
                return $"{ConvertTowards(value / div)} {powersOfTen[5]} {lastPart(value, div)}";
            }

            // Quintillion
            if (value < 10_000_000_000_000_000_000)
            {
                BigInteger div = 1_000_000_000_000_000_000;
                return $"{ConvertTowards(value / div)} {powersOfTen[6]} {lastPart(value, div)}";
            }

            // ulong.MaxValue

            // Quintillion
            if (value < ulong.MaxValue)
            {
                BigInteger div = 1_000_000_000_000_000_000;
                return $"{ConvertTowards(value / div)} {powersOfTen[6]} {lastPart(value, div)}";
            }

            //// Sextillion
            //if (value < 1_000_000_000_000_000_000_000)
            //{
            //    BigInteger div = 1_000_000_000_000_000_000;
            //    return $"{ConvertTowards(value / div)} {powersOfTen[0]} {lastPart(value, div)}";
            //}

            //// Septillion
            //if (value < 1_000_000_000_000_000_000_000)
            //{
            //    BigInteger div = 1_000_000_000_000_000_000;
            //    return $"{ConvertTowards(value / div)} {powersOfTen[0]} {lastPart(value, div)}";
            //}

            // ..... There could be more but let's support that for now
            return $"{value} is not supported";
        }

        public static string Towards(this BigInteger bigInteger)
        {
            return ConvertTowards(bigInteger);
        }

        public static string Towards(this int integer)
        {
            return ConvertTowards(integer);
        }
    }
}