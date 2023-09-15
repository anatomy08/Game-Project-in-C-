using GameDev2_No_Bonus;
using Challenged;

namespace Challenged
{
    public class Melee : Enemy
    {
        public Melee() : base("Knight Warrior", 200)
        {
            Attacklist = new List<Attack>() // pay attention with the curly brackets here
          {

            new Attack("Punch", 20),
            new Attack("Kick", 15), // also dont forget the coma's in every each of list element.
            new Attack("Tackle", 25)

          }; // the semi colon should be here when ending a list of element

        }

        public void Rage(Enemy target) // we made a rage method 
        {
            Attack rageatack = RandomAttack();
            int dmgrage = rageatack.DamageAmount + 10;
            target.ChangeHealth(dmgrage);

            Console.WriteLine();
            Console.WriteLine($"Rage used.\nWhen Rage is used Damage is enhanced by 10");

        }
    }
}


