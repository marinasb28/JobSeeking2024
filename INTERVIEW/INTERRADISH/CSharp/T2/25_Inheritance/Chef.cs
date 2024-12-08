namespace T2
{
    //Superclass
    public class Chef
    {
        public void MakeChicken()
        {
            Console.WriteLine("Making chicken");
        }

        public void MakeSalad()
        {
            Console.WriteLine("Making salad");
        }

        // virtual -> it can be overridden
        public virtual void MakeSpecialDish()
        {
            Console.WriteLine("Making special dish");
        }
    }
}