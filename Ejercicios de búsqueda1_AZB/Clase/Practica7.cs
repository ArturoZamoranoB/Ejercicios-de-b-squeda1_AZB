using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_de_búsqueda1_AZB.Clase
{
    internal class Practica7
    {
        public void Ejercicio7()
        {
            int[] Matriz = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int Inicio = 0;
            int Fin = Matriz.Length - 1;
            int Medio = (Inicio + Fin) / 2;

            while (Inicio <= Fin)
            {
                if (Matriz[Medio] % 2 == 0) 
                {
                    Console.WriteLine($"El primer número par encontrado es {Matriz[Medio]} en la posición {Medio}.");
                    break;
                }
                else if (Matriz[Medio] % 2 != 0)  
                {
                    Inicio = Medio + 1;
                    Medio = (Inicio + Fin) / 2;
                }
            }
        }

    }
}
