//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//class program
//{

//    static void Main()
//    {
//        int CalculateDamage(int strength, int weaponDamage)
//        {
//            return strength + weaponDamage;
//        }
//        int Heal(int health, int amount, int maxHealth)
//        {
//            return Math.Min(health + amount, maxHealth);
//        }
//        bool IsGameOver(int health)
//        {
//            if (health <= 0)
//            {
//                return true;
//            }

//            return false;

//        }

//        while (true)
//        {
//            int hp = int.Parse(Console.ReadLine());
//            int heal = int.Parse(Console.ReadLine());
//            int max_hp = int.Parse(Console.ReadLine());

//            int damage = CalculateDamage(5, 5);

//            Console.WriteLine("Damage: " + damage);

//            hp = Heal(hp, heal, max_hp);

//            Console.WriteLine("Health is " + hp);

//            if (IsGameOver(hp))
//            {
//                Console.WriteLine("Koniec gry.");
//                break;
//            }
//        }

//    }
//}