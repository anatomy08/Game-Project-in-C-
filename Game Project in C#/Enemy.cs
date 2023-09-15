

using GameDev2_No_Bonus;

namespace Challenged
{
    public class Enemy // Build the Enemy class
    {
        public string Name;
        public int Health = 100;
        public int MaxHealth = 120;
        public int Level = 40;
        public List<Attack> Attacklist;

        public Enemy(string name)
        {
            Health = 100;
            MaxHealth = 100;
            Attacklist = new List<Attack>();
        }

        public Enemy(string n, int h)
        {
            Name = n;
            Health = h;



        }

        public Attack RandomAttack()
        {
            Random rand = new Random();


            int randattack = rand.Next(Attacklist.Count);
            Console.WriteLine($"{Name} performs {Attacklist[randattack].Name}");
            Console.WriteLine($"{Name}'s Health:{Health}");

            return Attacklist[randattack];
        }


        public virtual void PerformAttack(Player Target, Attack ChosenAttack)
        {
            // Write some logic here to reduce the Targets health by your Attack's DamageAmount
            Target.Health -= ChosenAttack.DamageAmount;
            Console.WriteLine($"{Name} use {ChosenAttack.Name} attack on {Target.Name}, dealing {ChosenAttack.DamageAmount} damage and reducing {Target.Name}'s health to {Target.Health}!!");
        }

        public void ChangeHealth(int Amount) // this is where the output of changehealth when targeting health
        {
            Health -= Amount;
            Console.WriteLine($"{Name}'s health is now {Health}");

        }

        public void Resethealth()
        {
            Health = MaxHealth;
        }

    }
}
