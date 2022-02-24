using System;
using System.Collections.Generic;
using System.Text;

namespace FluentBuilderPattern
{
    public abstract class BurgerBuilder
    {
        protected Burger burger;

        protected void CreateBurger()
        {
            burger = new Burger();
        }

        public Burger GetBurger()
        {
            return burger;
        }
        
        public abstract void IncludePatties(short numberOfPatties);

        public abstract void IncludeCheese(bool isInclude);

        public abstract void IncludeBacon(bool isInclude);

        public abstract void IncludePickles(bool isInclude);

        public abstract void IncludeLetuce(bool isInclude);

        public abstract void IncludeTomato(bool isInclude);

        public abstract void IncludeOnion(bool isInclude);
    }
}
