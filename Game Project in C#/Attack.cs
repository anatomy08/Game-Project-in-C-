

namespace Challenged
{
    public class Attack // Build the Attack class
    {
        public string Name;
        private int FixDamage = 0; // Bonus: Practice good programming by making the Enemy's damage
                                   // attribute private and adding a Public version that lets us just
                                   // see the value of private damage
        public int DamageAmount
        {
            get { return FixDamage; }

            set { FixDamage = value; }
        }

        public Attack(string name, int damage)
        {
            Name = name;
            DamageAmount = damage + FixDamage;
        }


    }
}