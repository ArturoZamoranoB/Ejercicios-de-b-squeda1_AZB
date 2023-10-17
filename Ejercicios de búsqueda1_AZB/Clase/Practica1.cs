using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_de_búsqueda1_AZB.Clase
{
    internal class Practica1
    {
        public void Ejercicio1()
        {
            int[] Matriz = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Ingrese el numero a buscar");
            int NumeroBuscar = Convert.ToInt32(Console.ReadLine());

            bool encontrado = false;
            for (int i = 0; i < Matriz.Length; i++)
            {
                if (NumeroBuscar == Matriz[i])
                {
                    Console.WriteLine($"El número {NumeroBuscar} se encuentra en la posición {i}.");
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine($"El número {NumeroBuscar} no se encuentra en la lista.");
            }
        }

    }
}
