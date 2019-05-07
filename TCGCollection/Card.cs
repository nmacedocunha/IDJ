using System;
namespace TCGCollection
{
    public class Card
    {

        protected int width;
        protected int height;

        public bool isFlipped
        {
            get; set;
        }

        public Card()
        {
            isFlipped = false;
        }

        public void Flip()
        {
            isFlipped = !isFlipped;
        }
    }
}
