//using System;

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

//        string input = "";

//        while (true)
//        {

//            ShowStatus("wfwf", 0, 100, 0);
//            ShowMenu();
//            ShowPanelTitle("Ifk", ConsoleColor.Red);

//            input = Console.ReadLine();

//            if (input == "q") {
//                break;
//            } 
//        }

//    }
//}