using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_de_búsqueda1_AZB.Clase
{
    internal class Practica3
    {
        public void Ejercicio3()
        {
            int[] Matriz = new int[10] { 2, 4, 6, 8, 11, 12, 13, 16, 17, 0};

            bool encontrado = false;
            for (int i = 0; i < Matriz.Length; i++)
            {
                if (Matriz[i] % 2 == 0) 
                {
                    Console.WriteLine($"los número pares son {Matriz[i]} en la posición {i}.");
                    encontrado = true;
                     
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("No se encontró ningún número par en la lista.");
            }
        }


    }
}
