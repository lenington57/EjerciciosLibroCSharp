using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjerciciosLibroCSharp.Capítulo_4
{
    class Ejercicios1_2_5
    {
        public void UnoCuatro()
        {
            int n, num;
            Console.WriteLine("Este programa muestra la Tabla de Multiplicar del 1 al 10 de cualquier número...");
            Console.WriteLine("\nDigite el número del cual desea saber su Tabla de Multiplicar: ");
            n = Convert.ToInt32(Console.ReadLine());
            num = n;
            for (int i = 1; i <= 10; i++)
            {
                n *= i;
                Console.WriteLine("{0} * {1} = {2}", num, i, n);
                n = num;
            }
            Console.WriteLine("\n\n________________________________________________________________________________________________________________________");
        }

        public void DosCuatro()
        {
            int n, e, num;
            Console.WriteLine("Este programa calcula el resultado de un número elevado a cualquier potencia...");
            Console.WriteLine("\nDigite el número que desea elevar o base: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nDigite el exponente al cual desea elevar su base: ");
            e = Convert.ToInt32(Console.ReadLine());
            num = n;
            Console.Write("El resultado es igual a: ");
            for (int i = 1; i <e; i++)
                n = n * num;
            Console.Write("{0}", n);
            Console.WriteLine("\n\n________________________________________________________________________________________________________________________");
        }

        public void CincoCuatro()
        {
            int cant, c, edad, prom;
            int mayor = 0;
            int menor = 987;
            int sum = 0;
            Console.WriteLine("Este programa calcula el promedio de edad de un grupo de personas y dice cuál es la de edad más grande y cuál es la más joven....");
            Console.WriteLine("\nDigite la cantidad de personas a ingresar edad: ");
            cant = Convert.ToInt32(Console.ReadLine());
            c = cant;
            do
            {
                Console.WriteLine("Digite la edad de la persona:");
                edad = Convert.ToInt32(Console.ReadLine());
                sum += edad;
                if (edad < menor)
                    menor = edad;
                if (edad > mayor)
                    mayor = edad;
                cant--;
            } while (cant > 0);
            prom = sum / c;
            Console.WriteLine("\nEl Promedio de las Edades es igual a: {0} años \nLa Edad Mayor es: {1} años \nLa Edad Menor es: {2} años", prom, mayor, menor);
        }
    }
}
