using System.Globalization;

namespace BlazingPizza;

/// <summary>
/// Single place that formats every price shown in the app as Brazilian Real (R$ 1.234,56).
/// The format is built by hand so it never depends on the culture data installed on the machine.
/// </summary>
public static class PriceFormatter
{
    private static readonly NumberFormatInfo BrazilianNumberFormat = new()
    {
        NumberDecimalSeparator = ",",
        NumberGroupSeparator = ".",
        NumberDecimalDigits = 2
    };

    public static string Format(decimal value) => "R$ " + value.ToString("N2", BrazilianNumberFormat);
}
