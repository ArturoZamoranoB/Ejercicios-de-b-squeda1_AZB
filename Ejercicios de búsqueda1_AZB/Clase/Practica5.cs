using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_de_búsqueda1_AZB.Clase
{
    internal class Practica5
    {
        public void Ejercicio5()
        {
            int[] Matriz = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Ingrese el numero a buscar");
            int NumeroBuscar = Convert.ToInt32(Console.ReadLine());

            int Inicio = 0;
            int Fin = Matriz.Length - 1;
            int Medio = (Inicio + Fin + 1) / 2;

            bool encontrado = false;
            while (Inicio <= Fin)
            {
                if (Matriz[Medio] == NumeroBuscar)
                {
                    Console.WriteLine($"El número {NumeroBuscar} se encuentra en la posición {Medio}.");
                    encontrado = true;
                    break;
                }
                else if (Matriz[Medio] > NumeroBuscar)
                {
                    Fin = Medio - 1;
                    Medio = (Inicio + Fin) / 2;

                }
                else
                {
                    Inicio = Medio + 1;
                    Medio = (Inicio + Fin) / 2;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine($"El número {NumeroBuscar} no se encuentra en la lista.");
            }
        }
    }
}
