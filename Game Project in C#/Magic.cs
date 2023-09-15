using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenged
{
    public class Magic : Enemy
    {
        public Magic() : base("Wizzard", 80)
        {
            Attacklist = new List<Attack>()
            {

                new Attack("Fireball", 25),
                new Attack("Lightning Bolt", 20),
                new Attack("Staff Strike", 10)

            };
        }


        public void Heal(Enemy Target)
        {
            if ((Target.Health + 40) > Target.MaxHealth)
            {
                int difference = (Target.MaxHealth - Target.Health) * -1;
                Target.ChangeHealth(difference);
            }
            else
            {
                Target.ChangeHealth(-40);
            }
            Console.WriteLine($"{Name} heals {Target.Name} to {Target.Health} hp!");


        }

    }

}

/* lets say 100 + 40= 140 is Currenthealth
maxhealth is cap at 100

the difference of max health and current health is (-40) since 
100 - 140 = -40 

then multiply by -1 so it will be possitive 40

now in Changehealth(int amount) method 

health -= amount

so 140 (current health ) - 40 (the difference) = 100
this is from Target.Changehealth(difference) 

now the cap is again to be 100 */

