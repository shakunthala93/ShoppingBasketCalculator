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
    public void TwoMelons_Returns50()
    {
        var basket = new ShoppingBasket();
        Assert.Equal(50, basket.CalculateTotal(new List<string> { "Melon", "Melon" }));
    }

    [Fact]
    public void ThreeMelons_Returns100()
    {
        var basket = new ShoppingBasket();
        Assert.Equal(100, basket.CalculateTotal(new List<string> { "Melon", "Melon", "Melon" }));
    }

    [Fact]
    public void ThreeLimes_Returns30()
    {
        var basket = new ShoppingBasket();
        Assert.Equal(30, basket.CalculateTotal(new List<string> { "Lime", "Lime", "Lime" }));
    }

    [Fact]
    public void FourLimes_Returns45()
    {
        var basket = new ShoppingBasket();
        Assert.Equal(45, basket.CalculateTotal(new List<string> { "Lime", "Lime", "Lime", "Lime" }));
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

