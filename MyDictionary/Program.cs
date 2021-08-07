using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int,string> personel= new MyDictionary<int, string> ();
            personel.Add(1,"derya");
            personel.Add(2, "mevsim");
            personel.Add(3, "ali");

            Console.WriteLine("*********************************");
            Console.WriteLine("Kayıtlı personel sayısı: " + personel.Count);

            Console.WriteLine("********************************");

            foreach (var key in personel.Keys)
            {
                Console.WriteLine("Personel No: " + key);
            }

            Console.WriteLine("******************************");

            foreach (var value in personel.Values)
            {
                Console.WriteLine("Personel Adı: " + value);
            }
        }
    }
}
