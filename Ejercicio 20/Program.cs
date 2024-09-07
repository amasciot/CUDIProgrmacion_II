using System;
using System.Formats.Tar;
using System.Runtime.InteropServices;

internal class Program
{
    static void Main(string[] args)
    {
        // Se solicitan datos de entrada para definir cuantas personas contiene la lista 

        Console.WriteLine("Ingrese la cantidad de personas a medir");
        double personas = Double.Parse(Console.ReadLine());
        
        int a = 0;
        int b = 0;
        int c = 0;
        int d = 0;
        int Tarea = 0;

        // Se solicitan los datos de los diferentes participantes 
        do
        {
            Console.WriteLine("valores de estatura del tipo x,... ; utilice coma ',' como separador decimal");
            double altura = Double.Parse(Console.ReadLine());
            if (altura > 1.6){
                a = a + 1;
            }
            else if (altura < 1.2)
            {
                b = b + 1;
            }else if(altura >= 1.2 && altura <= 1.5)
            {
                c = c +1;
            }
            else
            {
                d = d + 1;
            }
         Tarea++;
        } while (Tarea < personas);
        
        // Se muestra un resumen de la cantidad de participante en cada segmento.

        Console.WriteLine($"Tenemos {b} alumnos de menos de 1.2 m,\n {c} alumnos entre 1.2m y 1.5m,\n {d} alumnos de mas de 1,5 pero menos de 1,6 m ;\n {a} alumnos de mas de 1,6 m de estatura");

    }
}
     