public static class TempConverter
{
    static TempConverter()
    {
        
    }

    public static double FahrenheitToCelcius(double temp)
    {
        double retVal = (temp - 32)/1.8;
        return retVal;
    }

    public static double CelciusToFahrenheit(double temp)
    {
        double retVal = temp * 1.8 + 32;
        return retVal;
    }
}