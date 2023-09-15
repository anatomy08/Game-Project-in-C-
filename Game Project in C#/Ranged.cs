using GameDev2_No_Bonus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Challenged
{
    public class Ranged : Enemy
    {
        public int Distance;

        public Ranged() : base("Archer", 80)
        {
            Distance = 5;

            Attacklist = new List<Attack>()
            {

                new Attack("Shoot an arrow", 20),
                new Attack("Throw Knife", 15)
            };
        }

        public override void PerformAttack(Player Target, Attack ChosenAttack)
        {
            if (Distance < 10)
            {
                Console.WriteLine("Cannot attack, Too Near. get far-away to attack");
            }
            else
            {
                Target.Health -= ChosenAttack.DamageAmount;
                Console.WriteLine($"{Name} attacks {ChosenAttack.Name} on {Target.Name}, dealing {ChosenAttack.DamageAmount} damage and reducing {Target.Name}'s health to {Target.Health}!!");
            }
        }

        public void Dash()
        {
            Distance += 20;
            Console.WriteLine($"{Name} dashes away!");
            Console.WriteLine($"Increase its distance by {Distance}");
        }
    }
}
