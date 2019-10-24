using System;

namespace asd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var p1 = new Pracownik();
            p1.Wynagrodzenie = 100;
            p1.Nazwisko = "   Dziedzic  ";
            p1.DataZatrudnienia = new DateTime(2010, 10, 01);
            
            Console.WriteLine(p1);
        }
    }
}
