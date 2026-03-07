using System;

namespace AvaloniaApplication1.Classes;

public class ParcelCalculator
{
    public int CalculatePrice(int parcelWidth, int parcelHeight,int parcelDepth, int parcelWeight, bool express, int deliveryChoice)
    {
        double basePrice = 10.0;
        double finalPrice;
        
        finalPrice = basePrice + parcelWeight * 2;
        
        if (express)
        {
            finalPrice += 15;
        }

        if (deliveryChoice == 1)
        {
            finalPrice += 10;
        }
        else if (deliveryChoice == 2)
        {
            finalPrice = 100;
        }
        
        if (parcelWidth + parcelHeight + parcelDepth > 150)
        {
            finalPrice *= 1.5;
        }

        Math.Floor(finalPrice);
        return (int)finalPrice;
    }
}