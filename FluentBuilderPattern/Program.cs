using System;
using System.ComponentModel;

namespace FluentBuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var burger = BurgerFluentBuilder.Default();

                ParseInstuction("Customize you burger");
                ParseInstuction("Howmany pattie you want?");
                int.TryParse(Console.ReadLine(), out var pattie);
                burger.WithPatties(pattie);

                //Cheese
                ParseInstuction("Want to add Cheese? Y/N");
                var requested = Console.ReadLine().ToString();
                Console.WriteLine(requested.ToLower().Equals("y"));
                burger.WithCheese(false);

                //Bacon
                ParseInstuction("Want to add Bacon? Y/N");
                burger.WithBacon(Console.ReadLine().ToLower().Equals("y"));

                //Pickel
                ParseInstuction("Want to add Pickel? Y/N");
                burger.WithPickel(Console.ReadLine().ToLower().Equals("y"));

                //Letuce
                ParseInstuction("Want to add Letuce? Y/N");
                burger.WithLetuce(Console.ReadLine().ToLower().Equals("y"));

                //Tomato
                ParseInstuction("Want to add Tomato? Y/N");
                burger.WithTomato(Console.ReadLine().ToLower().Equals("y"));


                ParseInstuction("Please confirm your customization? Y/N");
                if (Console.ReadLine().ToLower().Equals("n"))
                {
                    continue;
                }

                var finalizeburger = burger.Build();
                ParseInstuction("=================================");
                foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(finalizeburger))
                {
                    ParseInstuction($"{ descriptor.Name}: {descriptor.GetValue(finalizeburger)}");
                }
                break;
            }
        }

        static void ParseInstuction(string instruction)
        {
            Console.WriteLine(instruction);
        }
    }
}
