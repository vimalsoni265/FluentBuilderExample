namespace FluentBuilderPattern
{
    public class BurgerFluentBuilder
    {
        private Burger _burger = null;

        private BurgerFluentBuilder(Burger burger)
        {
            _burger = burger;
        }

        public static BurgerFluentBuilder Default()
        {
            return new BurgerFluentBuilder(DefaultBurger());
        }

        public BurgerFluentBuilder WithPatties(int num)
        {
            _burger.NumPatties = num;
            return this;
        }

        public BurgerFluentBuilder WithCheese(bool requested)
        {
            _burger.Cheese = requested;
            return this;
        }
        
        public BurgerFluentBuilder WithBacon(bool requested)
        {
            _burger.Bacon = requested;
            return this;
        }

        public BurgerFluentBuilder WithPickel(bool requested)
        {
            _burger.Pickles = requested;
            return this;
        }

        public BurgerFluentBuilder WithLetuce(bool requested)
        {
            _burger.Letuce = requested;
            return this;
        }

        public BurgerFluentBuilder WithTomato(bool requested)
        {
            _burger.Tomato = requested;
            return this;
        }

        public Burger Build()
        {
            return _burger;
        }

        private static Burger DefaultBurger()
        {
            return new Burger(1)
            {
                Bacon = false,
                Cheese = true,
                Letuce = true,
                Pickles = false,
                Tomato = true
            };
        }
    }
}
