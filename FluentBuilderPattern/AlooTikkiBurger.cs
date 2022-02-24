using System;
using System.Collections.Generic;
using System.Text;

namespace FluentBuilderPattern
{
    /// <summary>
    /// Aloo Tikki Burger
    /// </summary>
    public class AlooTikkiBurger : BurgerBuilder
    {
        public AlooTikkiBurger()
        {
            CreateBurger();
            GetName();
        }

        private void GetName()
        {
            GetBurger().Name = "Aloo Tikki Burger";
        }

        //  include with default value because of not a part of AlooTikkiBurger (this class)
        public override void IncludeBacon(bool isInclude = false)
        {
            GetBurger().IsBacon = false;
        }

        //  include with default value because of not a part of AlooTikkiBurger (this class)
        public override void IncludePickles(bool isInclude = false)
        {
            GetBurger().IsPickles = false;
        }

        //  include with default value because of not a part of AlooTikkiBurger (this class)
        public override void IncludeLetuce(bool isInclude = false)
        {
            GetBurger().IsLetuce = false;
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
