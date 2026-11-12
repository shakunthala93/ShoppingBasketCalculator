using System;
using System.Collections.Generic;

public class ShoppingBasket
{
    public int CalculateTotal(List<string> items)
    {
        if (items == null)
            throw new ArgumentNullException(nameof(items));

        int apples = 0;
        int bananas = 0;
        int melons = 0;
        int limes = 0;

        foreach (string item in items)
        {
            switch (item?.Trim().ToLowerInvariant())
            {
                case "apple":
                    apples++;
                    break;

                case "banana":
                    bananas++;
                    break;

                case "melon":
                    melons++;
                    break;

                case "lime":
                    limes++;
                    break;

                default:
                    throw new ArgumentException("Invalid item: " + item);
            }
        }

        return apples * 35
             + bananas * 20
             + ((melons + 1) / 2) * 50
             + (limes - limes / 3) * 15;
    }
}