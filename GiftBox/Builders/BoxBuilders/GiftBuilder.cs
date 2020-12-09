using System.Collections.Generic;
using GiftBox.Box;
using GiftContent.Products;

namespace GiftBox.Builders
{
    public abstract class GiftBuilder
    {
        public Gift Gift { get; }

        public GiftBuilder() => Gift = new Gift(new List<IProduct>());

        public abstract void AddCandyBar();
        public abstract void AddWaffle();
        public abstract void AddLollipop();
        public abstract void AddChocolate();
    }
}