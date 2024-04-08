namespace WebApplication1;

public class Visit
{
    private DateTime Date { get; set; }
    private Animal Animal { get; set; }
    private string Description { get; set; }
    private double Price { get; set; }

    public Visit(DateTime date, Animal animal, string description, double price)
    {
        Date = date;
        Animal = animal;
        Description = description;
        Price = price;
    }
    
    
}