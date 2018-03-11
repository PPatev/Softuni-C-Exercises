using System;
using System.Numerics;

namespace Problem_10._Centuries_to_Nanoseconds
{
    class CenturiesToNanoseconds
    {
        static void Main(string[] args)
        {
            var century = int.Parse(Console.ReadLine());
            long years = century * 100;
            BigInteger days = new BigInteger(years * 365.2422);
            BigInteger hours = days * 24;
            BigInteger minutes = hours * 60;
            BigInteger seconds = minutes * 60;
            BigInteger milliseconds = seconds * 1000;
            BigInteger microseconds = milliseconds * 1000;
            BigInteger nanoseconds = microseconds * 1000;

            Console.WriteLine($"{century} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
        }
    }
}
