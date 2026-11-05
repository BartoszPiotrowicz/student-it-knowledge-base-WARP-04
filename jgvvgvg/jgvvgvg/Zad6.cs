//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//class program
//{

//    static void Main()
//    {
//        void ShowPanelTitle(string title, ConsoleColor backgroundColor)
//        {
//            Console.BackgroundColor = backgroundColor;
//            Console.ForegroundColor = ConsoleColor.White;
//            Console.WriteLine($"  {title.ToUpper()}  ");
//            Console.ResetColor();
//        }

//        void ShowStatus(string name, int health, int maxHealth, int gold)
//        {
//            ShowPanelTitle("Status bohatera", ConsoleColor.DarkBlue);

//            Console.ForegroundColor = ConsoleColor.Cyan;
//            Console.Write("Bohater:  ");
//            Console.ResetColor();
//            Console.WriteLine(name);

//            Console.ForegroundColor = ConsoleColor.Green;
//            Console.Write("Zdrowie: ");
//            Console.ResetColor();
//            Console.WriteLine($"{health}/{maxHealth} HP");

//            Console.ForegroundColor = ConsoleColor.Yellow;
//            Console.Write("Złoto:    ");
//            Console.ResetColor();
//            Console.WriteLine(gold);
//        }

//        void ShowMenu()
//        {
//            ShowPanelTitle("Menu", ConsoleColor.DarkCyan);
//            Console.WriteLine("[1] Atak treningowy");
//            Console.WriteLine("[2] Odpoczynek");
//            Console.WriteLine("[3] Koniec gry");
//        }

//        int CalculateDamage(int strength, int weaponDamage) => strength + weaponDamage;

//        int Heal(int health, int amount, int maxHealth) => Math.Min(health + amount, maxHealth);

//        string ReadCommand() => Console.ReadLine();

//        bool isRunning = false;

//        while (!isRunning)
//        {
//            ShowStatus("wfwwfqd", 100, 100, 0);
//            ShowMenu();
//            string command = ReadCommand();

//            if (command == "1")
//            {
//                int damage = CalculateDamage(5, 5);
//                Console.WriteLine($"Zadajesz {damage} obrażeń manekinowi.");
//            }
//            else if (command == "2")
//            {
//                int hp = Heal(100, 10, 100);
//                Console.WriteLine($"Odpoczywasz. Masz teraz {hp} HP.");
//            }
//            else
//            {
//                isRunning = true;
//            }
//        }

//    }
//}