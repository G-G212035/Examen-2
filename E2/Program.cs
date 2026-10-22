using System;
using System.Timers;
namespace E2
{
    class Program
    {
        static void Main(string [] args)
        {
            // Examen de Unidad 2
            // Problema 1:
            /* Escribir la sintaxis para definir una funcion:
            La sintaxis es:
            - Primero para definirla:
            tipo_de_dato identificador_funcion (parametos)
            {
                Bloque de datos
            }
            - Invocacion de la funcion:
            identificador_funcion (argumentos);

            Donde:
            tipo_de_dato = el dato usado para la variable (string, int, bool)
            identificador_funcion = el nombre dado a la funcion (ej. "Calculadora")
            (parametos) = los nombres de las expresiones que rigen la funcion
            */

            // Problema 2:
            // Define un ciclo que imprima los siguientes numeros: 2,4,6,9,12,15,19,23,27
            int Numero2 = 0; // Esta variable de nombre Numero2 sera la variable usada para el problema #2
            while (Numero2 < 27)
            {
                if (Numero2 < 6)
                {
                    Numero2 += 2;
                }
                else if (Numero2 < 15 && Numero2 >= 6)
                {
                    Numero2 += 3;
                }
                else if (Numero2 < 27 && Numero2 >= 15)
                {
                    Numero2 += 4;
                }
                Console.WriteLine($"Numero: {Numero2}");
            }
            // Problema 3:
            // Declarar 2 variables, incio y limite. Si producto es menor < que 8, e inicio mayor que limite, definir un ciclo descendente de 9 ejecuciones
            int inicio = 1;
            int limite = 10;
            int iterador;
            if ((inicio * limite) < 8)
            {
                iterador = inicio;
                while (inicio < (iterador + 8))
                {
                    Console.WriteLine($"Ciclo asendente {inicio}");
                    inicio ++;
                }
            }
            else
            {
                iterador = inicio;
                while (inicio >= (iterador - 8))
                {
                    Console.WriteLine($"Ciclo descendente {inicio}");
                    inicio --;
                }
            }
            // Problema 4.
            bool CalcularMultiplo(int numero4)
            {
                float restante = numero4 / 5;
                if (restante == 0)
                {
                    bool Resultado = true;
                    return Resultado;
                }
                else
                {
                    bool Resultado = false;
                    return Resultado;
                }
            }
            bool Resultado2 = CalcularMultiplo(5);
            Console.WriteLine($"El resultado de si es multiplo o no es {Resultado2}");
            
            // Problema 5
            void Progra ()
            {
                string Datos = "Programacion III";
                Console.WriteLine($"Examen: {Datos}");
            }
            Progra();
        }
    }
}
