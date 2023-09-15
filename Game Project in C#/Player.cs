using Challenged;


namespace GameDev2_No_Bonus
{
    public class Player // build a player class
    {
        public string Name;
        public int Health;
        public int Level;
        public int Maxhealth;
        public List<Attack> Attacklist;

        public Player(string name)
        {
            Name = name;
            Health = 100;
            Maxhealth = 100;
            Level = 50;
            Attacklist = new List<Attack>()
            {
                new Attack("Mega Flare", 40),
                new Attack("Tackle", 10),
                new Attack("Throw Stone", 5),
                new Attack("Ultimate", 70),
                new Attack("Shoot Arrow", 15)
            };
        }

        public Attack RandomAttack() // player if random attacks occur
        {
            Random rand = new Random();

            int randomattack = rand.Next(Attacklist.Count);
            Console.WriteLine($"{Name} performs {Attacklist[randomattack].Name}");
            Console.WriteLine($"{Name} Health:{Health}");
            return Attacklist[randomattack];
        }

        public virtual void PerformAttack(Enemy Target, Attack ChosenAttack) // Playyer damage to target HP
        {
            if (ChosenAttack.Name == "Ultimate")
            { // Bonus: Write a method for adding Attacks to your Enemy's AttackList
              // rather than having to call on the List's Add method in Program.cs

                Health -= (ChosenAttack.DamageAmount + 500);
                Console.WriteLine($"Performs Ultimate, Additional 500 damage acquiared");
                Console.WriteLine($"{Name}'s damage increased '");
            }

            Target.Health -= ChosenAttack.DamageAmount;



            Console.WriteLine($"{Name} uses {ChosenAttack.Name} to {Target.Name}, Dealing {ChosenAttack.DamageAmount} damage to {Target.Name} health {Target.Health}!! ");
        }

        public void Changehealth(int Amount)
        {
            Health -= Amount;
            Console.WriteLine($"{Name} health is now {Health} ");
        }

        public void Resethealth()
        {
            Health = Maxhealth;
        }

        public void AddDamage(int Adddmg)
        {
            if (Name == "Mega Flare")
            { // Bonus: Write a method for adding Attacks to your Enemy's AttackList
              // rather than having to call on the List's Add method in Program.cs

                Health -= Adddmg;
                Console.WriteLine($"Performs Mega Flare, Additional 100 damage acquiared");
                Console.WriteLine($"{Name}'s damage increased '");
            }
        }






    }
}
