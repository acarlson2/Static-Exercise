namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            double f = 45;
            double c = 2.5;

            //45 Fahrenheit should be 7.22222 Celcius
            Console.WriteLine(TempConverter.FahrenheitToCelcius(f));

            //2.5 Celcius should be 36.5 Fahrenheit
            Console.WriteLine(TempConverter.CelciusToFahrenheit(c));
        }
    }
}
