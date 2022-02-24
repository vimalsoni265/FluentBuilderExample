using System;
using System.ComponentModel;

namespace FluentBuilderPattern
{
    class Program
    {
        private static void Main(string[] args)
        {
            Burger alooTikkiBurger;
            Burger mexicanBurger;

            var customisedAlooTikkiBurger = new AlooTikkiBurger();
            customisedAlooTikkiBurger.IncludePatties(1);
            customisedAlooTikkiBurger.IncludeCheese(true);
            customisedAlooTikkiBurger.IncludeBacon(true);
            customisedAlooTikkiBurger.IncludePickles(true);
            customisedAlooTikkiBurger.IncludeLetuce(true);
            customisedAlooTikkiBurger.IncludeTomato(true);
            customisedAlooTikkiBurger.IncludeOnion(false);
            alooTikkiBurger = customisedAlooTikkiBurger.GetBurger();
            Console.WriteLine(alooTikkiBurger.BurgerSummary());     // alooTikkiBurger.BurgerSummary()  Not needed just included for reference
     
            var customisedMexicanBurger = new MexicanBurger();
            customisedMexicanBurger.IncludePatties(2);
            customisedMexicanBurger.IncludeCheese(true);
            customisedMexicanBurger.IncludeBacon(true);
            customisedMexicanBurger.IncludePickles(true);
            customisedMexicanBurger.IncludeLetuce(true);
            customisedMexicanBurger.IncludeTomato(true);
            customisedMexicanBurger.IncludeOnion(false);
            mexicanBurger = customisedMexicanBurger.GetBurger();
            Console.WriteLine(mexicanBurger.BurgerSummary());       // mexicanBurger.BurgerSummary()  Not needed just included for reference

            Console.ReadKey();
        }        
    }
}
