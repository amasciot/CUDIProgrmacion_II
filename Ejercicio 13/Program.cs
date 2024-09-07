using System.Timers;

internal class Program
{
    private static void Main(string[] args)
    {
        // Se solicitan parametros de entrada 


        Console.WriteLine("Indique dos numeros enteros a continuacion :");
        Console.WriteLine("tipee el primer número");
        int primero = Int32.Parse(Console.ReadLine());
        Console.WriteLine("tipee el segundo número");
        int segundo = Int32.Parse( Console.ReadLine());

        // Se realizan las verfificaciones para responder a la consigna 

        if( primero > 0 && segundo >0)
        {
            Console.WriteLine("ambos numeros son positivos");
        }
        if (primero < 0 && segundo < 0)
        {
            Console.WriteLine("ambos numeros son negativos");
        }
        if ( (primero * segundo) < 0)
        {
            Console.WriteLine("uno de los dos es positivo");
        }
        if( primero == 0 || segundo == 0 ) 
        {
            Console.WriteLine("alguno de los numeros es 0");
        }
    }
}