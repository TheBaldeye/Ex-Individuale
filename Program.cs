namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Creazione nuovo Rettangolo di partenza:");
            Rettangolo rettangoloBase = new Rettangolo();
            Console.WriteLine($"\nL'altezza è: {rettangoloBase.Altezza}");
            Console.WriteLine($"\nLa larghezza è: {rettangoloBase.Larghezza}");

            Console.WriteLine($"\nCreazione nuovo Rettangolo personalizzato:");
            Rettangolo rettangoloPersonalizzato = new Rettangolo(20, 30);
            Console.WriteLine($"\nL'altezza è: {rettangoloPersonalizzato.Altezza}");
            Console.WriteLine($"\nLa larghezza è: {rettangoloPersonalizzato.Larghezza}");

            Console.WriteLine($"\nCreazione nuovo Rettangolo personalizzato 1:");
            Rettangolo rettangoloPersonalizzato1 = new Rettangolo(30, 40);
            Console.WriteLine($"\nL'altezza è: {rettangoloPersonalizzato1.Altezza}");
            Console.WriteLine($"\nLa larghezza è: {rettangoloPersonalizzato1.Larghezza}");

            Console.WriteLine($"\nL'area del rettangolo personalizzato è: {rettangoloPersonalizzato.CalcoloArea()}");
            Console.WriteLine($"\nL'area del rettangolo personalizzato moltiplicato per 8 è: {rettangoloPersonalizzato.CalcoloArea(8)}");

            Console.WriteLine($"\nI rettangoli creati sono: {Rettangolo.ConteggioRettangoli}");

            Console.WriteLine($"\n{Rettangolo.ConfrontaAree(rettangoloPersonalizzato, rettangoloPersonalizzato1).CalcoloArea()}");
            
        }
    }
}
