using System;
namespace TCGCollection
{
    public class TCGCard : Card
    {
        public string Name { get; protected set; }
        public string Description { get; protected set; }
        public Colors ManaColor { get; protected set; }

        protected int ManaCost;

        public enum Colors
        {
            RED,
            BLUE,
            GREEN,
            BLACK,
            WHITE,
            NONE
        }

        public TCGCard()
        {

        }

        public TCGCard(string name, string description, Colors manaColor)
        {
            Name = name;
            Description = description;
            ManaColor = manaColor;
        }

        public void Tap()
        {
            // Tap on operation
        }
    }
}
