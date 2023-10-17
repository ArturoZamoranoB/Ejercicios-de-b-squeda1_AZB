using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_de_búsqueda1_AZB.Clase
{
    internal class Practica2
    {
        public void Ejercicio2()
        {
            string[] Matriz = new string[10] { "Azul", "Verde", "Rosa", "Amarillo", "Morado", "Rojo", "Gris", "Cafe", "Naranja", "Blanco" };
            Console.WriteLine("Ingrese el Color a buscar, La primera letra en mayuscula");
            String CadenaBuscar = (Console.ReadLine());

            bool encontrado = false;
            for (int i = 0; i < Matriz.Length; i++)
            {
                if (CadenaBuscar == Matriz[i])
                {
                    Console.WriteLine($"El color {CadenaBuscar} se encuentra en la posición {i}.");
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine($"El Color {CadenaBuscar} no se encuentra en la lista.");
            }
        }
    }
}
