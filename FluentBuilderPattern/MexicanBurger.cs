using System;
using System.Collections.Generic;
using System.Text;

namespace FluentBuilderPattern
{
    /// <summary>
    /// Mexican Burger
    /// </summary>
    public class MexicanBurger : BurgerBuilder
    {
        public MexicanBurger()
        {
            CreateBurger();
            GetName();
        }

        private void GetName()
        {
            GetBurger().Name = "Mexican Burger";
        }

        public override void IncludeBacon(bool isInclude = false)
        {
            GetBurger().IsBacon = isInclude;
        }

        public override void IncludePickles(bool isInclude = false)
        {
            GetBurger().IsPickles = isInclude;
        }

        public override void IncludeLetuce(bool isInclude = false)
        {
            GetBurger().IsLetuce = isInclude;
        }

        public override void IncludePatties(short numberOfPatties)
        {
            GetBurger().NumPatties = numberOfPatties;
        }

        public override void IncludeCheese(bool isInclude)
        {
            GetBurger().IsCheese = isInclude;
        }

        public override void IncludeTomato(bool isInclude)
        {
            GetBurger().IsTomato = isInclude;
        }

        public override void IncludeOnion(bool isInclude)
        {
            GetBurger().IsOnion = isInclude;
        }
    }
}
