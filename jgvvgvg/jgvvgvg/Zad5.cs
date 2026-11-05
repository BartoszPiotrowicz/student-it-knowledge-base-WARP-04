//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//class program
//{

//    static void Main()
//    {
//        int CalculateDamage(int strength, int weaponDamage) => strength + weaponDamage;
//        // Proste dodawanie może być w jednej linijce.

//        int Heal(int health, int amount, int maxHealth) => Math.Min(health + amount, maxHealth);
//        // Jedno wywołanie metody, można skrócić.

//        bool IsGameOver(int health) => health <= 0 ? true : false;
//        // Jeden prosty warunek można umieścić w skróconej funkcji.

//        //bool IsGameOver(int health)
//        //{

//        //    if (health <= 0)
//        //    {
//        //        return true;
//        //    }

//        //    return false;

//        //}

//        //Console.WriteLine(IsGameOver(1));

//        string ReadCommand()
//        {
//            while (true)
//            {
//                Console.Write("Wybór: ");
//                string command = Console.ReadLine();

//                switch (command)
//                {
//                    case "1":
//                        return "1";
//                    case "2":
//                        return "2";
//                    case "3":
//                        return "3";
//                    default:
//                        Console.WriteLine("Kys");
//                        break;
//                }
//            }
//        }
//        // Wiele przypadków, nie można skrócić.

//        void ShowMenu()
//        {
//            // ShowPanelTitle("Menu", ConsoleColor.DarkCyan);
//            Console.WriteLine("[1] Atak treningowy");
//            Console.WriteLine("[2] Odpoczynek");
//            Console.WriteLine("[3] Koniec gry");
//        }
//        // Wywołanie metody i wypisywanie w konsoli, nie można skrócić. Jest to jeszcze void więc nie ma czego zwrócić.

//        // Reszta zadania
//        List<string> inventory = new List<string> { "miecz", "mikstura", "łuk" };
//        List<string> longNames = inventory.FindAll(item => item.Length >= 5);

//        for (int i = 0; i < longNames.Count; i++)
//        {
//            Console.WriteLine($"{longNames[i]}");
//        }

//        bool hasSword = inventory.Exists(item => item == "miecz");

//        Console.WriteLine(hasSword);

//    }
//}