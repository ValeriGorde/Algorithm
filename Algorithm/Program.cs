using System;
using System.Collections.Generic;
using System.Threading;

namespace Algorithm
{
    internal class Program
    {
        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }

        static void Main(string[] args)
        {
            List<User> users = new List<User>()
            {
                new User() {Login = "BigBang", Name = "Александр", IsPremium = true },
                new User() {Login = "halo11", Name = "Наталья", IsPremium = false },
                new User() {Login = "mareouou", Name = "Леонид", IsPremium = true },
                new User() {Login = "shmnvd", Name = "Дарья", IsPremium = false }
            };

            for (int i = 0; i < users.Count; i++) 
            {
                Console.WriteLine("Здравствуйте, {0}! ", users[i].Name);
                if (users[i].IsPremium == false) 
                {
                    ShowAds();
                    Console.WriteLine();
                }
                else 
                {
                    Console.WriteLine("У вас есть подписка! \n");
                }
            }

        }
    }
}
