using System.Drawing;

namespace WebApplication1;

public class Animal
{
    private int Id { get; }
    private string Name { get; set; }
    private string Category { get; set; }
    private double Mass { get; set; }
    private Color Color { get; set; }

    public Animal(int id, string name, string category, double mass, Color color)
    {
        Id = id;
        Name = name;
        Category = category;
        Mass = mass;
        Color = color;
    }
}