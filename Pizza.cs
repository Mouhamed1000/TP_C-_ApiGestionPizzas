namespace PizzaStore.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public string? Nom { get; set; }
        public string? Description { get; set; }
    }

    public class PizzaEhod
    {
        public int IdEhod { get; set; }
        public string? NomEhod { get; set; }
        public string? DescriptionEhod { get; set; }
    }
}