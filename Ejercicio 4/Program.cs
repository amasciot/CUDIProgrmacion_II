internal class Program
{
    private static void Main(string[] args)
    {

        // se solicitan los datos de entrada 
        Console.WriteLine("Introduce un número entero distinto de cero ");
        int numero = Int32.Parse(Console.ReadLine()); 

        // Se coloca una titulo para dar mejor forma a la respuesta.
        Console.WriteLine($"El número {numero} tiene los siguientes divisores :");

        // recorremos los posibles divisiores del numero 
        for (int i = 0; i < numero; i++)
        {

            if (numero % (i + 1) == 0)
            {
                Console.WriteLine($"Es divisible por {i + 1}"); //Se muestran solo los divisores.
            }
        }

    }
}