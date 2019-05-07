using System;
namespace TCGCollection
{
    public class TCGEnchament : TCGCard
    {
        public int boostAttack;
        public int boostDef;

        public TCGEnchament(string name, string description, Colors color) : base(name, description, color)
        {
            Random r = new Random();
            ManaCost = r.Next(0, 11);
            boostAttack = r.Next(0, 11);
            boostDef = r.Next(0, 11);
        }

        public void Attach(TCGMonster monster)
        {
            monster.attack += boostAttack;
            monster.defense += boostDef;
        }
    }
}
