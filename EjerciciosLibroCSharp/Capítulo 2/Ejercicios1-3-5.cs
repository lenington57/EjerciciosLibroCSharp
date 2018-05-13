using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjerciciosLibroCSharp.Capítulo_2
{
    class Ejercicios1_3_5
    {
        public void UnoDos()
        {
            double lados, valor, per;
            Console.WriteLine("Este programa sirve para calcular el Perímetro de cualquier polígono regular...");
            Console.WriteLine("\nDigite la cantidad de lados de su Polígono: ");
            lados = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Digite el valor de uno de los lados: ");
            valor = Convert.ToSingle(Console.ReadLine());
            per = lados * valor;
            Console.WriteLine("\nEl Perímetro de su Polígono es: " + per);
            Console.WriteLine("\n\n________________________________________________________________________________________________________________________");
        }

        public void TresDos()
        {
            double grados, rad;
            Console.WriteLine("Este programa transforma de grados a radianes...");
            Console.WriteLine("Digite la cantidad de grados que desea convertir:");
            grados = Convert.ToSingle(Console.ReadLine());
            rad = (grados * 3.14) / 180;
            Console.WriteLine("La cantidad de grados que que convirtió es igual a: {0} Radianes", rad);
            Console.WriteLine("\n\n________________________________________________________________________________________________________________________");
        }

        public void CuatroDos()
        {
            double cent, fah;
            Console.WriteLine("Este programa transforma de Grados Centígrados a Grados Fahrenheit...");
            Console.WriteLine("\nDigite la cantidad de grados Centígrados que desea convertir:");
            cent = Convert.ToSingle(Console.ReadLine());
            fah = ((cent * 9) / 5) + 32;
            Console.WriteLine("La cantidad de grados centígrados que convirtió es igual a: {0} Fahrenheit", fah);
            Console.WriteLine("\n\n________________________________________________________________________________________________________________________");
        }

        public void CincoDos()
        {
            double dolCamb, eurCamb, dol, eur, resD, resE;
            Console.WriteLine("Este programa convierte entre Dólares y Euros...");
            Console.WriteLine("Digite tipo de cambio del día para el Dólar: ");
            dolCamb = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Digite tipo de cambio del día para el Euro: ");
            eurCamb = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("\nDigite la cantidad de Dólares que desea convertir a Euros: ");
            dol = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Digite la cantidad de Euros que desea convertir a Dólares: ");
            eur = Convert.ToSingle(Console.ReadLine());
            resE = dol * dolCamb;
            Console.WriteLine("\n\nLa cantidad de Dólares que convirtió es igual a: {0} Euros", resE);
            resD = eur * eurCamb;
            Console.WriteLine("La cantidad de Euros que convirtió es igual a: {0} Dólares", resD);
            Console.WriteLine("\n\nLas tasas de cambio utilizadas fueron: \n{0} Para Dólares\n{1} Para Euros", dolCamb, eurCamb);
            Console.WriteLine("\n\n________________________________________________________________________________________________________________________");
        }
    }
}
