
namespace T2
{
    public static class Inheritance
    {
        public static void Main(string[] args)
        {
            Chef chef = new Chef();
            chef.MakeChicken();
            chef.MakeSpecialDish();

            ItalianChef ichef = new ItalianChef();
            ichef.MakeChicken();
            ichef.MakePasta();
            ichef.MakeSpecialDish();
        }
    }
}