using System;

namespace _12DaysOfChristmas.app
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] day = new string[12] { "first", "second", "third", "fourth", "fifth", "sixth", "seventh", "eighth", "ninth", "tenth", "eleventh", "twelfth" };

            string[] present = new string[12] { "A partridge in a pear tree", "Two turtle doves,", "Three French hens,", "Four calling birds,", "Five golden rings,", 
                "Six eese a-laying,", "Seven swans a-swimming,", "Eight maids a-milking,", "Nine ladies dancing,", "Ten lords a-leaping,", "Eleven pipers piping,", "Twelve drummers drumming," };

            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine($"On the {day[i]} day of Christmas, my true love sent to me ");

                int n = i + 1;
                while (n-- > 0)
                    Console.WriteLine(present[n]);
                    Console.WriteLine();

                if (i == 0)
                    present[0] = "And a partridge in a pear tree.";
            }
        }

    }
}
