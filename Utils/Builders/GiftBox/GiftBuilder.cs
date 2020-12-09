using System.Collections.Generic;
using Box;
using Domain.Products.Confections;

namespace Utils.Builders.GiftBox
{
    public abstract class GiftBuilder
    {
        public Gift Gift { get; }

        public GiftBuilder() => Gift = new Gift(new List<ConfectioneryProductBase>());

        public abstract void AddCandyBar();
        public abstract void AddWaffle();
        public abstract void AddLollipop();
        public abstract void AddChocolate();
    }
}