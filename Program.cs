using System;
using System.Collections.Generic;
using System.Threading;

namespace Delegados
{
   public class Program
    {
       public delegate void myDelegate(string msj);
        static void Main(string[] args)
        {




            myDelegate objeDelegado;
            objeDelegado = MostrarMensaje;
            //objeDelegado += MostrarMensaje;
            //objeDelegado("hola");
            //objeDelegado = MostrarMensajeDos;
            //objeDelegado("mensaje dos");


            /*Ejemplo De Delegados Real*/
            Ejemplo objE = new Ejemplo();
            List<int> LstNumeros = new List<int>() { 1, 2, 3, 4, 5, 6 };
            List<int> LstNumerosPares = objE.NumerosPares(LstNumeros, objeDelegado);
            Console.WriteLine("Numeros pares: \n");
            foreach (int item in LstNumerosPares)
            {
                Console.WriteLine(item);
            }

        }
        public static void MostrarMensaje(string msj)
        {
            Console.WriteLine(msj);
        }
        public static void MostrarMensajeDos(string msjDos)
        {
            Console.WriteLine(msjDos);
        }

    }
}
