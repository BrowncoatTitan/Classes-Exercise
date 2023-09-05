using System.Security.Cryptography.X509Certificates;

namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var car1 = new Car("Lamborghini", "Urus", 2023);
            Console.WriteLine($"The car I want is a {car1.Year} {car1.Make} {car1.Model}.");
        }
    }
}
