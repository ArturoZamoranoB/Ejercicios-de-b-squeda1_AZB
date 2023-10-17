using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_de_búsqueda1_AZB.Clase
{
    internal class Practica6
    {
        public void Ejercicio6()
        {
            string[] Matriz = new string[10] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
            Console.WriteLine("Ingrese la letra de buscar, en mayuscula");
            String CadenaBuscar = (Console.ReadLine());

            int Inicio = 0;
            int Fin = Matriz.Length - 1;
            int Medio = (Inicio + Fin + 1) / 2;

            bool encontrado = false;
            while (Inicio <= Fin)
            {
                if (Matriz[Medio] == CadenaBuscar)
                {
                    Console.WriteLine($"El número {CadenaBuscar} se encuentra en la posición {Medio}.");
                    encontrado = true;
                    break;
                }
                else if (String.Compare(Matriz[Medio] ,CadenaBuscar) > 0)
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
                Console.WriteLine($"El número {CadenaBuscar} no se encuentra en la lista.");
            }
        }
    }
}
