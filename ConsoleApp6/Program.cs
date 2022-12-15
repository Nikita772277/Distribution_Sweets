using System;
using ConsoleApp6;

DistributionSweets ds = new DistributionSweets();
Random random = new Random();
var numberArray = random.Next(1, 20);
int[] ints = new int[numberArray];
for (int i = 0; i < numberArray; i++)
{
    var number = random.Next(1, 30);
    ints[i] = number;
}
void Menu()
{
    Console.WriteLine();
    Console.WriteLine($"1)Всего дал конфет");
    Console.WriteLine($"2)Всего детей");
    Console.WriteLine($"3)Изначально конфет у каждого ребёнка");
    Console.WriteLine();
}
void UseMenu()
{
    while (true)
    {
        Menu();
        string enter = Console.ReadLine();
        bool checkEnter = int.TryParse(enter, out int result);
        if (result == 1)
        {
            var sumSweets = ds.DistributionOfSweets(ints);
            Console.WriteLine();
            if (sumSweets == -1)
            {
                Console.WriteLine($"");
            }
            else
            {
                Console.WriteLine($"Всего дал конфет: {sumSweets}");
            }
        }
        else if (result == 2)
        {
            var numberChildren = ds.TotalChildren(ints);
            Console.WriteLine();
            if (numberChildren == -1)
            {
                Console.WriteLine($"");
            }
            else
            {
                Console.WriteLine($"Всего детей: {numberChildren}");
            }
        }
        else if (result == 3)
        {
            ds.InitiallySweets(ints);
        }
        else
        {
            Console.WriteLine($"Выберите пункт из меню");
        }
    }

}
UseMenu();


