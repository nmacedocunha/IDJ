using System;
namespace TCGCollection
{
    public class TCGMonster : TCGCard
    {
        public int defense;
        public int attack;
        public int life;

        public string type;
        public bool hasAbility;

        public TCGMonster(string name, string description, Colors manaColor):base(name, description, manaColor)
        {
            Random r = new Random();
            ManaCost = r.Next(0, 11);
        }

        public void Attack()
        {
            Tap();
            // Do Damage;
        }

        public void Defend()
        {
            Tap();
        }
    }
}
