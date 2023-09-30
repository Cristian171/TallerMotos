namespace Taller_de_motos
{
    class Program
    {
        static void Main()
        {
            Moto moto = new Moto();
            Console.WriteLine("Parámetros iniciales de la moto:");
            Console.WriteLine($"Speed: {moto.Speed}");
            Console.WriteLine($"Acceleration: {moto.Acceleration}");
            Console.WriteLine($"Handling: {moto.Handling}");
            Console.WriteLine($"Grip: {moto.Grip}");

            Parte engine = new Engine();
            moto.PersonalizarParte(engine);
            Console.WriteLine("\nParámetros de la moto con Engine personalizado:");
            Console.WriteLine($"Speed: {moto.Speed}");
            Console.WriteLine($"Acceleration: {moto.Acceleration}");
            Console.WriteLine($"Handling: {moto.Handling}");
            Console.WriteLine($"Grip: {moto.Grip}");

            Parte Chassis = new Chasis();
            moto.PersonalizarParte(Chassis);
            Console.WriteLine("\nParámetros de la moto con Chasis personalizado:");
            Console.WriteLine($"Speed: {moto.Speed}");
            Console.WriteLine($"Acceleration: {moto.Acceleration}");
            Console.WriteLine($"Handling: {moto.Handling}");
            Console.WriteLine($"Grip: {moto.Grip}");
        }
    }
}