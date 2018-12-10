using System;

namespace WizardNinjaSamurai
{
    public class Samurai : Human
    {
        public Samurai(string name) : base(name)
        {
            health = 200;
        }
        public Samurai death_blow(Human target)
        {
            attack(target);
            if(target == null)
            {
                Console.WriteLine("Failed Attack");
            }
            else if (target.health < 50)
            {
                target.health = 0;
            }
            return this;
        }
        public Samurai meditate()
        {
            health = 200;
            return this;
        }
    }
}
