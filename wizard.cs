using System;

namespace WizardNinjaSamurai
{
    public class Wizard : Human
    {
        public Wizard(string name) : base(name)
        {
            health = 50;
            intelligence = 25;
        }
        public Wizard heal()
        {
            health += intelligence * 10;
            return this;
        }
        public Wizard fireball(Human target)
        {
            if (target == null)
            {
                Console.WriteLine("Failed Attack");
            }
            else
            {
                Random random = new Random();
                target.health -= random.Next(20, 51);
            }
            return this;
        }
    }
}