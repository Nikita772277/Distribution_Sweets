using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class DistributionSweets
    {
        public int DistributionOfSweets(int[] ints)
        {
            var counter = Counter(ints);
            if (counter >= 2)
            {
                int Sweets = 0;
                int maxSweets = 0;
                foreach (int i in ints)
                {
                    if (maxSweets < i)
                    {
                        maxSweets = i;
                    }
                }
                for (int i = 0; i < ints.Length; i++)
                {
                    if (ints[i] != maxSweets)
                    {
                        for (int j = 1; ;)
                        {
                            if (ints[i] + j == maxSweets)
                            {
                                Sweets += j;
                                Console.WriteLine($"{i + 1} ребёнок получил {j} конфет");
                                Console.WriteLine();
                                break;
                            }
                            j++;
                        }
                    }
                }
                return Sweets;
            }
            return -1;
        }
        public int TotalChildren(int[] ints)
        {
            var counter = Counter(ints);
            if (counter >= 1)
            {
                int totalChildren = 0;
                foreach (var i in ints)
                {
                    totalChildren++;
                }
                return totalChildren;
            }
            return 0;
        }
        public void InitiallySweets(int[] ints)
        {
            string word = "";
            for (var i = 0; i < ints.Length; i++)
            {
                if (ints[i] == 1)
                {
                    word = "конфета";
                }
                else if (ints[i] == 2)
                {
                    word = "конфеты";
                }
                else
                {
                    word = "конфет";
                }
                Console.WriteLine($"Изначально у ребёнка {i + 1}-{ints[i]} {word}");
                Console.WriteLine();
            }
        }
        public int Counter(int[] ints)
        {
            int counter = 0;
            for (int i = 0; i < ints.Length; i++)
            {
                counter++;
                if (counter >= 2)
                {
                    return counter;
                }
            }
            return 0;
        }
    }
}
