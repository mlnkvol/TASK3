using System;

public class Converter
{
    private decimal usdRate;
    private decimal euroRate;

    public Converter(decimal usdRate, decimal euroRate)
    {
        this.usdRate = usdRate;
        this.euroRate = euroRate;
    }

    public decimal ConvertToUSD(decimal amountInUAH)
    {
        return amountInUAH / usdRate;
    }

    public decimal ConvertToEuro(decimal amountInUAH)
    {
        return amountInUAH / euroRate;
    }

    public decimal ConvertFromUSD(decimal amountInUSD)
    {
        return amountInUSD * usdRate;
    }

    public decimal ConvertFromEuro(decimal amountInEuro)
    {
        return amountInEuro * euroRate;
    }
}
