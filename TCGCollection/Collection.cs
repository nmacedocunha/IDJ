using System;
using System.Collections.Generic;

namespace TCGCollection
{
    public class Collection
    {
        private bool Empty
        {
            get { return !(collection.Count > 0); }
        }

        private List<TCGCard> collection;

        public Collection()
        {
            collection = new List<TCGCard>();
        }

        public void AddToCollection(TCGCard card)
        {
            collection.Add(card);
        }

        public void ClearCollection()
        {
            collection.Clear();
        }

        public void ClearCardsType(Type type)
        {
            if (!Empty)
            {
                collection.RemoveAll(item => item.GetType().Equals(type));
            }
        }

        public void DisplayCards(Type type)
        {
            foreach (var item in collection)
            {
                if (item.GetType().Equals(type))
                {
                    Console.WriteLine($"Card Name : {item.Name} | Card description : {item.Description} | Mana Color : {item.ManaColor}");
                }
            }
        }

        public void DisplayCards(TCGCard.Colors color)
        {
            foreach (var item in collection)
            {
                if (item.ManaColor.Equals(color))
                {
                    Console.WriteLine($"Card Name : {item.Name} | Card description : {item.Description} | Mana Color : {item.ManaColor}");
                }
            }
        }
    }
}
