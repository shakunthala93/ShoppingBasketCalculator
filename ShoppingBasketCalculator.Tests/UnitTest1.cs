using Xunit;
using System;
using System.Collections.Generic;

public class ShoppingBasketTests
{
    [Fact]
    public void EmptyBasket_ReturnsZero()
    {
        var basket = new ShoppingBasket();
        Assert.Equal(0, basket.CalculateTotal(new List<string>()));
    }

    [Fact]
    public void UppercaseApple_Returns35()
    {
        var basket = new ShoppingBasket();
        Assert.Equal(35, basket.CalculateTotal(new List<string> { "APPLE" }));
    }

    [Fact]
    public void LowercaseBanana_Returns20()
    {
        var basket = new ShoppingBasket();
        Assert.Equal(20, basket.CalculateTotal(new List<string> { "banana" }));
    }

    [Fact]
    public void InvalidItem_ThrowsException()
    {
        var basket = new ShoppingBasket();

        Assert.Throws<ArgumentException>(() =>
            basket.CalculateTotal(new List<string> { "Orange" }));
    }

    [Fact]
    public void NullBasket_ThrowsException()
    {
        var basket = new ShoppingBasket();

        Assert.Throws<ArgumentNullException>(() =>
            basket.CalculateTotal(null!));
    }

    [Fact]
    public void MixedBasket_Returns170()
    {
        var basket = new ShoppingBasket();

        var items = new List<string>
        {
            "Apple", "Apple", "Banana",
            "Melon", "Melon",
            "Lime", "Lime", "Lime"
        };

        Assert.Equal(170, basket.CalculateTotal(items));
    }
}

