using System;

namespace hw
{
    class Program
    {
        static void Main(string[] args)
        {
            /*🛑🛑🛑🛑 Note I put Every thing in variables because it makes the
             programmmer life easier 😎, also when it comes in changing the int value , and it makes it more organized
            and easy to read */



            string hero = "Somou";
            int health = 100;

            int DHealth = 20;
            int Bhealth = 10; 
            int NewHealth = health - DHealth;
            int BoostedHealth = NewHealth + Bhealth;
            int Damage;
            Damage = damaged();
            int damaged()
            {
                return NewHealth;

            }

            Console.WriteLine($"damaged health {Damage}");
            int Boost;
            Boost = boosted();
            int boosted()
            {
                return BoostedHealth;
            }
            Console.WriteLine($"Boosted health {Boost}");

                if (Damage < Boost)
            {
                Console.WriteLine($"The damged health wich is equals to {Damage} is less than the boosted health wich is equal to {Boost} ");

            } else if (Damage > Boost)
            {
                Console.WriteLine($"Becarefull! , The damged health wich is equals to {Damage} is Bigger than the boosted health wich is equal to {Boost} ");

            } else
            {
                Console.WriteLine("Enjoy your game ");
            }
        }
      
    }
}

