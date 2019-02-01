using kaffe;
using System;
using System.Collections.Generic;

namespace KaffeConsoleAppNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Cortado cortado = new Cortado();
            Latte latte = new Latte();
            SortKaffe sortkaffe = new SortKaffe();
            FlatWhite flatWhite = new FlatWhite(12);

            List<Imælk> liste = new List<Imælk>();
            liste.Add(cortado);
            liste.Add(latte);
            liste.Add(flatWhite);

            foreach (var item in liste)
            {
                Console.WriteLine("før cast" + item.MlMælk());
                if (item is Latte)
                {
                    Latte i = item as Latte;
                    Console.WriteLine("latte styrke" + i.styrke());
                }
                else if (item is Cortado) 
                {
                    Cortado c = item as Cortado;
                }
               
            }

           

        }
    }
}
