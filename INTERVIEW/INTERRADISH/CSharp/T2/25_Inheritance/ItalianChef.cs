namespace T2
{
    // de esta forma todo lo del chef -> italian (subclass)
    public class ItalianChef : Chef
    {
        public void MakePasta()
        {
            Console.WriteLine("Making pasta");
        }

        public override void MakeSpecialDish()
        {
            Console.WriteLine("Making special ITALIAN dish");
        }
    }
}