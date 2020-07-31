using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using static Delegados.Program;

namespace Delegados
{
    public class Ejemplo
    {
        public List<int> NumerosPares(List<int> Lst, myDelegate objeDelegado)
        {
            List<int> LstNumerosEnteros = new List<int>();
            foreach (int item in Lst)
            {
                //Console.WriteLine($"Elemento: {item}");
                objeDelegado(item.ToString());
                if (item % 2 == 0)
                {
                    LstNumerosEnteros.Add(item);
                    Thread.Sleep(4000);
                }
            }
            return LstNumerosEnteros;
        }

    }
}
