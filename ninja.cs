using System;

namespace WizardNinjaSamurai
{
    public class Ninja : Human
    {
        public Ninja(string name) : base(name)
        {
            dexterity = 175;
        }
        public Ninja steal(Human target)
        {
            if (target == null)
            {
                Console.WriteLine("Failed Attack");
            }
            else
            {
                attack(target);
                health += 10;
            }
            return this;
        }
        public Ninja get_away()
        {
            health -= 10;
            return this;
        }
    }
}
