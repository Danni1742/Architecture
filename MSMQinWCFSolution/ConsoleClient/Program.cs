using System;
using ConsoleClient.WishServiceRef;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Vasya", "Petya", "Dima" };
            string[] wishes = { "IPhone 5", "Samsung Galaxy S8", "Xiaomi Redmi 4X" };

            WishClient[] objArray = new WishClient[names.Length];

            for (int i = 0; i < objArray.Length; i++)
            {
                objArray[i] = new WishClient();
                objArray[i].SayYourWish(names[i], wishes[i]);
            }
            Console.WriteLine("All Wishes sent successfully");
            Console.ReadLine();
        }
    }
}