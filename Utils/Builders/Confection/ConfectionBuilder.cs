using System;
using GiftContent.Products.Confections;
using GiftContent.Products.Characteristics;

namespace GiftContent.Builders.ConfectionBuilders
{
    public class ConfectionBuilder
    {
        protected ConfectioneryProduct Confection { get; set; }

        public ConfectionBuilder() => Confection = new ConfectioneryProduct();

        public ConfectionBuilder SetName(string name)
        {
            Confection.Name = name;
            return this;
        }

        public ConfectionBuilder SetManufacturerName(string manufacturerName)
        {
            Confection.ManufacturerName = manufacturerName;
            return this;
        }

        public ConfectionBuilder SetSugarContent(double sugarContent)
        {
            Confection.SugarContent = sugarContent;
            return this;
        }

        public ConfectionBuilder SetWeight(double weight)
        {
            Confection.Weight = weight;
            return this;
        }

        public ConfectionBuilder SetPricePerKilogram(int pricePerKilogram)
        {
            Confection.PricePerKilogram = pricePerKilogram;
            return this;
        }

        public ConfectionBuilder SetNutritionalValue(double proteinAmount, double fatAmount, double carbohydrateAmount)
        {
            Confection.NutritionalValue = new NutritionalValue(proteinAmount, fatAmount, carbohydrateAmount);
            return this;
        }

        public ConfectionBuilder SetExpirationDate(DateTime startDate, DateTime endDate)
        {
            Confection.ExpirationDate = new ExpirationDate(startDate, endDate);
            return this;
        }

        public ConfectioneryProduct Build() => Confection;
    }

}