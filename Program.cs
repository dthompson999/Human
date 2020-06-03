using System;
using human.Models;

namespace human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human newHuman = new Human("Jon Snow");

            Console.WriteLine($"{newHuman.Name} has:\na starting strength of {newHuman.Strength},\na starting intelligence of {newHuman.Intelligence},\na starting dexterity of {newHuman.Dexterity},\nand a full tank of health ({newHuman.Health}) ");

            Human deadHuman = new Human("Night King", 15, 5, 10, 100);

            Console.WriteLine($"{deadHuman.Name} has:\na starting strength of {deadHuman.Strength},\na starting intelligence of {deadHuman.Intelligence},\na starting dexterity of {deadHuman.Dexterity},\nand a full tank of health ({deadHuman.Health}) ");

            newHuman.Attack(deadHuman);
        }
    }
}
