using BlazingPizza.Models;

namespace BlazingPizza.Services;

/// <summary>Holds the pizza menu. All prices are in Brazilian Real (BRL).</summary>
public class PizzaService
{
    public IReadOnlyList<PizzaSpecial> Specials { get; } = new List<PizzaSpecial>
    {
        new() { Id = 1, Name = "Basic Cheese Pizza", BasePrice = 39.90m,
                Description = "Mozzarella, tomato sauce and a golden crust.",
                ImageUrl = "images/pizzas/cheese.svg" },
        new() { Id = 2, Name = "The Baconator", BasePrice = 59.90m,
                Description = "Bacon, Canadian bacon, sausage and extra cheese.",
                ImageUrl = "images/pizzas/bacon.svg" },
        new() { Id = 3, Name = "Buffalo Chicken", BasePrice = 64.90m,
                Description = "Spicy chicken, hot sauce and blue cheese.",
                ImageUrl = "images/pizzas/buffalo.svg" },
        new() { Id = 4, Name = "Veggie Delight", BasePrice = 54.90m,
                Description = "Mushrooms, peppers, onions, olives and tomatoes.",
                ImageUrl = "images/pizzas/veggie.svg" },
        new() { Id = 5, Name = "Margherita", BasePrice = 49.90m,
                Description = "Fresh basil, mozzarella and tomato.",
                ImageUrl = "images/pizzas/margherita.svg" },
        new() { Id = 6, Name = "Meaty Deluxe", BasePrice = 69.90m,
                Description = "Pepperoni, sausage, ham and bacon.",
                ImageUrl = "images/pizzas/meaty.svg" },
    };

    public IReadOnlyList<Topping> Toppings { get; } = new List<Topping>
    {
        new() { Id = 1, Name = "Extra cheese", Price = 6.00m },
        new() { Id = 2, Name = "Bacon", Price = 8.00m },
        new() { Id = 3, Name = "Pepperoni", Price = 7.00m },
        new() { Id = 4, Name = "Mushrooms", Price = 5.00m },
        new() { Id = 5, Name = "Black olives", Price = 5.00m },
        new() { Id = 6, Name = "Green peppers", Price = 4.50m },
        new() { Id = 7, Name = "Onions", Price = 3.50m },
        new() { Id = 8, Name = "Pineapple", Price = 6.00m },
    };
}
