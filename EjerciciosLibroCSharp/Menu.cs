using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjerciciosLibroCSharp
{
    class Menu
    {
        public void Menus()
        {
            int resp;
            Console.WriteLine("Ejercicios de los primeros cuatro Capítulos del libro de CSharp de la primera tarea de Lenington del Orbe...");
            Console.WriteLine("\n1. Ejercicios del Primer Capítulo.\n2. Ejercicios del Segundo Capítulo.\n3. Ejercicios del Tercer Capítulo.\n4. Ejercicios del Cuarto Capítulo.\n5. Salir.");
            Console.WriteLine("\nDigite el número de la opción deseada: ");
            resp = Convert.ToInt32(Console.ReadLine());
            if (resp == 1)
            {
                Console.Clear();
                int r;
                Capítulo_1.Ejercicios1_5 c = new Capítulo_1.Ejercicios1_5();
                Console.WriteLine("\n1. Ejercicio 1.\n2. Ejercicio 5.\n3. Salir.\nDigite el número de la opción deseada: ");
                r = Convert.ToInt32(Console.ReadLine());
                switch (r)
                {
                    case 1:
                        Console.Clear();
                        c.Uno();
                        break;
                    case 2:
                        Console.Clear();
                        c.Cinco();
                        break;
                    case 3:
                        break;
                }
            }
            else if (resp == 2)
            {
                Console.Clear();
                int r;
                Capítulo_2.Ejercicios1_3_5 c = new Capítulo_2.Ejercicios1_3_5();
                Console.WriteLine("\n1. Ejercicio 1.\n2. Ejercicio 3.\n3. Ejercicio 4.\n4. Ejercicio 5.\n5. Salir.\nDigite el número de la opción deseada: ");
                r = Convert.ToInt32(Console.ReadLine());
                switch (r)
                {
                    case 1:
                        Console.Clear();
                        c.UnoDos();
                        break;
                    case 2:
                        Console.Clear();
                        c.TresDos();
                        break;
                    case 3:
                        Console.Clear();
                        c.CuatroDos();
                        break;
                    case 4:
                        Console.Clear();
                        c.CincoDos();
                        break;
                    case 5:
                        break;
                }
            }

            else if (resp == 3)
            {
                Console.Clear();
                int r;
                Capítulo_3.Ejercicios1_4_5 c = new Capítulo_3.Ejercicios1_4_5();
                Console.WriteLine("\n1. Ejercicio 1.\n2. Ejercicio 4.\n3. Ejercicio 5.\n4. Salir.\nDigite el número de la opción deseada: ");
                r = Convert.ToInt32(Console.ReadLine());
                switch (r)
                {
                    case 1:
                        Console.Clear();
                        c.UnoTres();
                        break;
                    case 2:
                        Console.Clear();
                        c.CuatroTres();
                        break;
                    case 3:
                        Console.Clear();
                        c.CincoTres();
                        break;
                    case 4:
                        break;
                }
            }

            else if (resp == 4)
            {
                Console.Clear();
                int r;
                Capítulo_4.Ejercicios1_2_5 c = new Capítulo_4.Ejercicios1_2_5();
                Console.WriteLine("\n1. Ejercicio 1.\n2. Ejercicio 2.\n3. Ejercicio 5.\n4. Salir.\nDigite el número de la opción deseada: ");
                r = Convert.ToInt32(Console.ReadLine());
                switch (r)
                {
                    case 1:
                        Console.Clear();
                        c.UnoCuatro();
                        break;
                    case 2:
                        Console.Clear();
                        c.DosCuatro();
                        break;
                    case 3:
                        Console.Clear();
                        c.CincoCuatro();
                        break;
                    case 4:
                        break;
                }
            }
            else if (resp == 5)
                System.Environment.Exit(-1);
        }
    }
}
