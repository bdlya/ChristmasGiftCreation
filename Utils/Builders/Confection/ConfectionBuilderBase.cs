using System;
using Domain.Products.Characteristics;
using Domain.Products.Confections;

namespace Utils.Builders.Confection
{
    public abstract class ConfectionBuilderBase<T> where T : ConfectioneryProductBase, new ()
    {
        protected T Confection { get; }

        public ConfectionBuilderBase() => Confection = new T();

        public ConfectionBuilderBase<T> SetName(string name)
        {
            Confection.Name = name;
            return this;
        }

        public ConfectionBuilderBase<T> SetManufacturerName(string manufacturerName)
        {
            Confection.ManufacturerName = manufacturerName;
            return this;
        }

        public ConfectionBuilderBase<T> SetSugarContent(double sugarContent)
        {
            Confection.SugarContent = sugarContent;
            return this;
        }

        public ConfectionBuilderBase<T> SetWeight(double weight)
        {
            Confection.Weight = weight;
            return this;
        }

        public ConfectionBuilderBase<T> SetPricePerKilogram(int pricePerKilogram)
        {
            Confection.PricePerKilogram = pricePerKilogram;
            return this;
        }

        public ConfectionBuilderBase<T> SetNutritionalValue(double proteinAmount, double fatAmount, double carbohydrateAmount)
        {
            Confection.NutritionalValue = new NutritionalValue(proteinAmount, fatAmount, carbohydrateAmount);
            return this;
        }

        public ConfectionBuilderBase<T> SetExpirationDate(DateTime startDate)
        {
            Confection.StartDate = startDate;
            return this;
        }

        public T Build() => Confection;
    }

}