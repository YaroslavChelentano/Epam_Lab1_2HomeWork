using lab1task1;

using lab1task2;

using lab1task3;

using lab1task4;

using lab1task5;

using lab2task1;

using System;
using System.Collections.Generic;

namespace Lab1_2_NET_Epam
{
    public class Menu
    {
        public void EmptyRows(int count)
        {
            for (int i = 0; i < count; i++)
                Console.WriteLine();
        }
        public void ChooseAction()
        {
            Console.WriteLine("Choose what you want to do :");
            Console.WriteLine("1. Type data from console");
            Console.WriteLine("2. Work with example");
        }

        public void ChooseLab()
        {
            Console.WriteLine("Choose Lab :");
            Console.WriteLine("1. Lab 1");
            Console.WriteLine("2. Lab 2");
        }

        public void Bye()
        {
            Console.WriteLine("Good bye!");
        }
    }
}
