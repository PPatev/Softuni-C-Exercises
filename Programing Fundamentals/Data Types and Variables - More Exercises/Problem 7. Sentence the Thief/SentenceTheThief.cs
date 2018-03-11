using System;

namespace Problem_7._Sentence_the_Thief
{
    class SentenceTheThief
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            var lines = int.Parse(Console.ReadLine());
            var max = 0L;
            var currmax = long.MinValue;

            switch (type)
            {
                case "sbyte":
                    max = sbyte.MaxValue;
                    break;
                case "int":
                    max = int.MaxValue;
                    break;
                case "long":
                    max = long.MaxValue;
                    break;
            }

            for (int i = 0; i < lines; i++)
            {
                var num = long.Parse(Console.ReadLine());

                if ((num > currmax && num <= max))
                {
                    currmax = num;
                }
            }

            double sentence = 0.0;

            if (currmax <= 0)
            {
                sentence = currmax / -128.0;
            }
            else
            {
                sentence = currmax / 127.0;
            }

            sentence = Math.Ceiling(sentence);
            var end = "";
            if (sentence > 1.0)
            {
                end = "s";
            }

            Console.WriteLine($"Prisoner with id {currmax} is sentenced to {sentence} year{end}");
        }
    }
}
