namespace FluentBuilderPattern
{
    /// <summary>
    /// Default Burger
    /// </summary>
    public class Burger
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int numPatties;
        public int NumPatties
        {
            get { return numPatties; }
            set { numPatties = value; }
        }

        private bool isCheese;
        public bool IsCheese
        {
            get { return isCheese; }
            set { isCheese = value; }
        }

        private bool isBacon;
        public bool IsBacon
        {
            get { return isBacon; }
            set { isBacon = value; }
        }

        private bool isPickles;
        public bool IsPickles
        {
            get { return isPickles; }
            set { isPickles = value; }
        }

        private bool isLetuce;
        public bool IsLetuce
        {
            get { return isLetuce; }
            set { isLetuce = value; }
        }

        private bool isTomato;
        public bool IsTomato
        {
            get { return isTomato; }
            set { isTomato = value; }
        }

        private bool isOnion;
        public bool IsOnion
        {
            get { return isOnion; }
            set { isOnion = value; }
        }

        /// <summary>
        /// Default Burger
        /// </summary>
        public Burger()
        {
            numPatties = 1;
            isCheese = true;
            isBacon = false;
            isPickles = false;
            isLetuce = true;
            isTomato = true;
            isOnion = true;
        }

        public string BurgerSummary()
        {
            string summary = $"*********************\n";
            summary += $"{Name}\n";
            summary += $"*********************\n";
            summary += $"Number of Patties: {NumPatties}\n";
            summary += $"Include Cheese: {(IsCheese ? "Yes" : "No")}\n";
            summary += $"Include Bacon: {(IsBacon ? "Yes" : "No")}\n";
            summary += $"Include Pickles: {(IsPickles ? "Yes" : "No")}\n";
            summary += $"Include Letuce: {(IsLetuce ? "Yes" : "No")}\n";
            summary += $"Include Tomato: {(IsTomato ? "Yes" : "No")}\n";
            summary += $"Include Onion: {(IsOnion ? "Yes" : "No")}\n";
            summary += $"*********************\n";
            summary += $"***** THANK YOU *****\n";
            return summary;
        }
    }
}
