﻿namespace DesignPatterns.Strategy;
public class Sale
{
    private readonly decimal _amount;
    private readonly ISalePricingStrategy _strategy;

    public Sale(decimal amount, ISalePricingStrategy strategy)
    {
        _amount = amount;
        _strategy = strategy;
    }

    public decimal Amount => _amount;

    public decimal GetTotal()
    {
        return _strategy.GetTotalIncludingDiscount(this);
    }
}
