using System;

namespace GencYasli
{
    class Program
    {
        static void Main(string[] args)
        {
            // Girilen yaşa göre ekranda Genç veya Yaşlı yazan program
            int yas;
            Console.Write("Yaşınızı giriniz:");
            yas = int.Parse(Console.ReadLine());
            if (yas<30)
            {
                Console.WriteLine("Genç");
            }
            else if (yas<50)
            {
                Console.WriteLine("Orta Yaş");
            }
            else
            {
                Console.WriteLine("Yaşlı");
            }
            Console.ReadKey();

        }
    }
}
