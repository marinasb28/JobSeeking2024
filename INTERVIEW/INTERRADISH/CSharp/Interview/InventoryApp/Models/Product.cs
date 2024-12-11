namespace InventoryApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string Location { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Quantity: {Quantity}, Location: {Location}";
        }
    }
}