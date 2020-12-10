using System.Collections.Generic;
using Box;
using Domain.Confections;

namespace Utils.Builders.GiftBox
{
    public abstract class GiftBuilder
    {
        public Gift Gift { get; }

        public GiftBuilder() => Gift = new Gift(new List<ConfectionBase>());

        public abstract void AddCandyBar();

        public abstract void AddWaffle();

        public abstract void AddLollipop();

        public abstract void AddChocolate();
    }
}