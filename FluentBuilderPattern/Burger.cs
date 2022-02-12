namespace FluentBuilderPattern
{
    public class Burger
    {
        public int NumPatties { get; set; }
        
        public bool Cheese { get; set; }
        
        public bool Bacon { get; set; }
        
        public bool Pickles { get; set; }
        
        public bool Letuce { get; set; }
        
        public bool Tomato { get; set; }
        
        public Burger(int numPatties = 1)
        {
            NumPatties = numPatties;
        }
    }
}
