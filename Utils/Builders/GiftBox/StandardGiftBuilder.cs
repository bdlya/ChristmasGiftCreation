using System;
using System.Collections.Generic;
using Box;
using Domain.Confections;
using Domain.Confections.Characteristics;
using Utils.Builders.Confection;

namespace Utils.Builders.GiftBox
{
    public class StandardGiftBuilder : IGiftBuilder
    {
        public Gift Gift { get; }

        public StandardGiftBuilder() => Gift = new Gift();

        public void AddCandyBar()
        {
            CandyBar marsCandyBar = new CandyBarBuilder()
                .SetGlazing(true)
                .SetNutType(Nut.Acorn)
                .SetSize(Size.Medium)
                .SetName("Mars")
                .SetManufacturerName("Mars")
                .SetNutritionalValue(10, 20, 30)
                .SetPricePerKilogram(100)
                .SetStartDate(new DateTime(2020, 1, 1))
                .SetSugarContent(12)
                .SetWeight(130)
                .Build();
            CandyBar spartakCandyBar = new CandyBarBuilder()
                .SetGlazing(true)
                .SetNutType(Nut.Almond)
                .SetSize(Size.Large)
                .SetName("Spartak")
                .SetManufacturerName("Spartak")
                .SetNutritionalValue(13, 18, 25)
                .SetPricePerKilogram(90)
                .SetStartDate(new DateTime(2020, 1, 2))
                .SetSugarContent(10)
                .SetWeight(100)
                .Build();

            Gift.AddRange(marsCandyBar, spartakCandyBar);
        }

        public void AddWaffle()
        {
            Waffle standardWaffle = new WaffleBuilder()
                .SetTaste("Orange")
                .SetWaffleType(WaffleType.American)
                .SetName("Standard")
                .SetManufacturerName("Mars")
                .SetNutritionalValue(5, 10, 15)
                .SetPricePerKilogram(100)
                .SetStartDate(new DateTime(2020, 2, 3))
                .SetSugarContent(60)
                .SetWeight(80)
                .Build();

            Gift.Add(standardWaffle);
        }

        public void AddLollipop()
        {
            Lollipop hitLollipop = new LollipopBuilder()
                .SetLollipopType(LollipopType.Caramel)
                .SetName("Hit")
                .SetManufacturerName("Oh no")
                .SetNutritionalValue(5, 5, 5)
                .SetPricePerKilogram(100)
                .SetStartDate(new DateTime(2020, 2, 4))
                .SetSugarContent(20)
                .SetWeight(100)
                .Build();

            Gift.Add(hitLollipop);
        }

        public  void AddChocolate()
        {
            Chocolate milkaChocolate = new ChocolateBuilder()
                .SetChocolateType(ChocolateType.Milk)
                .SetName("Spartak")
                .SetManufacturerName("Spartak")
                .SetNutritionalValue(10, 20, 30)
                .SetPricePerKilogram(100)
                .SetStartDate(new DateTime(2020, 3, 4))
                .SetSugarContent(50)
                .SetWeight(200)
                .Build();

            Gift.Add(milkaChocolate);
        }

        public Gift Build()
        {
            AddCandyBar();
            AddWaffle();
            AddLollipop();
            AddChocolate();
            return Gift;
        }
    }
}