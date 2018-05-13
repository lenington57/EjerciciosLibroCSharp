using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjerciciosLibroCSharp.Capítulo_3
{
    class Ejercicios1_4_5
    {
        public void UnoTres()
        {
            int n;
            Console.WriteLine("Este programa dice si un número es par o impar...");
            Console.WriteLine("\nDigite un número:");
            n = Convert.ToInt32(Console.ReadLine());
            if (n % 2 == 0)
                Console.WriteLine("El número {0} es Par", n);
            else
                Console.WriteLine("El número {0} es Impar", n);
            Console.WriteLine("\n\n________________________________________________________________________________________________________________________");
        }

        public void CuatroTres()
        {
            int n;
            Console.WriteLine("Este programa dice el día de la semana que le corresponde a cada dígito desde 1 hasta el 7...");
            Console.WriteLine("\nDigite un número que esté comprendido entre el 1 y el 7:");
            n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.WriteLine("El número digitado corresponde al día Lunes");
                    break;
                case 2:
                    Console.WriteLine("El número digitado corresponde al día Martes");
                    break;
                case 3:
                    Console.WriteLine("El número digitado corresponde al día Miercoles");
                    break;
                case 4:
                    Console.WriteLine("El número digitado corresponde al día Jueves");
                    break;
                case 5:
                    Console.WriteLine("El número digitado corresponde al día Viernes");
                    break;
                case 6:
                    Console.WriteLine("El número digitado corresponde al día Sábado");
                    break;
                case 7:
                    Console.WriteLine("El número digitado corresponde al día Domingo");
                    break;
            }
            Console.WriteLine("El número digitado fue: "+ n);
            Console.WriteLine("\n\n________________________________________________________________________________________________________________________");
        }

        public void CincoTres()
        {
            int opc;
            double lados, valLados, per;
            Console.WriteLine("Este programa dice calcula el Area y el Perímetro de cualquier Polígono Regular...");
            Console.WriteLine("\nQué desea calcular? \nSi es el Area digite '1'\nSi es Perímetro digite '2'");
            Console.WriteLine("Digite el número de la opción deseada: ");
            opc = Convert.ToInt32(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    double ap, area;
                    Console.WriteLine("Digite el número de lados del polígono: ");
                    lados = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("Digite el valor de uno de lados del polígono: ");
                    valLados = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("Digite el valor de la apotema del polígono: ");
                    ap = Convert.ToSingle(Console.ReadLine());
                    area = (lados * valLados * ap) / 2;
                    Console.WriteLine("\nEl Area de su Polígono es: " + area);
                    break;
                case 2:
                    Console.WriteLine("Digite el número de lados del polígono: ");
                    lados = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("Digite el valor de uno de lados del polígono: ");
                    valLados = Convert.ToSingle(Console.ReadLine());
                    per = lados * valLados;
                    Console.WriteLine("\nEl Perímetro de su Polígono es: " + per);
                    break;
            }
            Console.WriteLine("\n\n________________________________________________________________________________________________________________________");
        }
    }
}
