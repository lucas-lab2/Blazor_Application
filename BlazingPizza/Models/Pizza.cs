namespace BlazingPizza.Models;

public class Pizza
{
    public const int DefaultSize = 12;
    public const int MinimumSize = 9;
    public const int MaximumSize = 17;

    public PizzaSpecial? Special { get; set; }
    public int Size { get; set; } = DefaultSize;
    public List<Topping> Toppings { get; set; } = new();

    public decimal GetBasePrice() =>
        Special is null ? 0 : ((decimal)Size / DefaultSize) * Special.BasePrice;

    public decimal GetTotalPrice() => GetBasePrice() + Toppings.Sum(t => t.Price);

    public string GetFormattedTotalPrice() => PriceFormatter.Format(GetTotalPrice());
}
