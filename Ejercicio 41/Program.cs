internal class Program
{
    private static void Main(string[] args)
    {
        int lances = 1;
        // Crear una instancia de la clase Random
        Random random = new Random();
        int cara = 0;
        int seca = 0;
        // Generar un número aleatorio entre 1 y 100
        do
        {
            int numeroAleatorio = random.Next(1, 101);
            //Console.WriteLine("El número aleatorio es:" + numeroAleatorio);
            lances++;   

            if (numeroAleatorio % 2 == 0)
            {
              cara = cara + 1;
            }
            else
            { 
              seca = seca + 1;
            }
        } while (lances < 101);


        // Se muestra la cantidad de veces que salio cada cara en 100 intentos


        Console.WriteLine($"Hemos lanzado 100 veces la moneda, de las cuales ah salido: \n El lado cara {cara} veces \n El lado seca {seca} veces.");
    }
}