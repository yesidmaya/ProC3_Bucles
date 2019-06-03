using System;

namespace Proyecto2
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultado = 0;

            Console.WriteLine("INTRODUZCA VALORES A SUMAR");

            Console.WriteLine("introduzca el PRIMER valor: ");
            int a = Convert.ToInt32(Console.ReadLine()); // convertimos el valor a entero cuando lo agreguemos por consola

            Console.WriteLine("Introduzca el SEGUNDO valor a sumar: ");
            int b = Convert.ToInt32(Console.ReadLine());

            resultado = a + b;

            Console.WriteLine("El RESULTADO es ");
                        
            while(resultado <= 100)
            {
                resultado = 10 + resultado;
                Console.WriteLine("El resultado de la operacion es " + resultado.ToString());
            }

            Console.WriteLine("SE EJECUTO EL BUCLE WHILE.......");
            resultado = 0;

            do {
                resultado = 10 + resultado;
                Console.WriteLine("El resultado de la operacion es " + resultado.ToString());
            }
            while (resultado <= 100);
            Console.WriteLine("SE EJECUTO EL BUBLE DO WHILE............");
            

            for (int i = 0; i<resultado; i++) {
                Console.WriteLine("El valor de i es: " + i.ToString());
            }
            Console.WriteLine("SE EJECUTO EL BUBLE FOR............");
          

            Console.WriteLine("Pulse un tecla para finalizar");
            Console.ReadLine();
        }
    }
}
