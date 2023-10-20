using System;
using System.Threading;

class Program
{
    static string a , b;
    static void Main()
    {
        Console.WriteLine("Букви української абетки в дiапазонi,заданому користувачем.");
        Console.WriteLine("Введiть першу букву дiапазону");
        a = Console.ReadLine();
        Console.WriteLine("Введiть другу букву дiапазону");
        b = Console.ReadLine();
        if(a != null && b != null)
        {
            Thread thread = new Thread(new ThreadStart(() => Worker()));
            thread.Start();
            thread.Join();
        }
        else
        {
            Console.WriteLine("Одна з змiнних є нулевою.");
        }
    }

    static void Worker()
    {
        string[] ukrainianAlphabet = {"а", "б", "в", "г", "ґ", "д", "е", "є", "ж", "з","и", "і", "ї", "й", "к", "л", "м", "н", "о", "п","р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ","ь", "ю", "я"};
        int e = Array.IndexOf(ukrainianAlphabet, a);
        int f = Array.IndexOf(ukrainianAlphabet, b);
        for (int i = e; i < f + 1; i++)
        {
            if (i != f)
            { Console.Write(ukrainianAlphabet[i] + ", "); }
            else
            { Console.Write(ukrainianAlphabet[i]);}
            Thread.Sleep(100);
        }
    }
}