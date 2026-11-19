# Blazing Pizza

Blazor web app for the **CSE 325 – W03 Assignment: Build Web Applications with Blazor**.

- Pizza menu with a customization dialog (size + extra toppings)
- Order sidebar and a checkout page (pages, routing and layouts)
- **All prices are shown in Brazilian Real (R$)** via a single helper, `PriceFormatter.cs`
- **Footer shows the author's full name and country** (`Components/Layout/MainLayout.razor`)

## Run locally

Requires the [.NET SDK](https://dotnet.microsoft.com/download) (8.0 or newer).
If you have a newer SDK only, change `<TargetFramework>` in `BlazingPizza.csproj` (e.g. `net9.0` / `net10.0`).

```bash
dotnet run
```

Then open http://localhost:5080 .
