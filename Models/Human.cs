using System;

namespace human.Models
{
    class Human
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;
        public int Health
        {
            get {return health;}
        }

        public Human(string val)
        {
            Name = val;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
        }

        public Human(string name, int strength, int intelligence, int dexterity, int _health)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
            Dexterity = dexterity;
            health = _health;
        }

        public int Attack(Human target)
        {
            int damage = 5 * Strength;
            int currentHealth = target.health - damage;
            Console.WriteLine($"{target.Name}'s health took a hit of {damage}!");
            Console.WriteLine($"Current health is {currentHealth}");
            return currentHealth;
        }
    }
}
