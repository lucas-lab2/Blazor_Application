using BlazingPizza.Models;

namespace BlazingPizza.Services;

/// <summary>The customer's current order. Registered as scoped, so it lives for the browser session.</summary>
public class OrderState
{
    public List<Pizza> Pizzas { get; } = new();

    public void AddPizza(Pizza pizza) => Pizzas.Add(pizza);

    public void RemovePizza(Pizza pizza) => Pizzas.Remove(pizza);

    public void Clear() => Pizzas.Clear();

    public decimal GetTotalPrice() => Pizzas.Sum(p => p.GetTotalPrice());

    public string GetFormattedTotalPrice() => PriceFormatter.Format(GetTotalPrice());
}
