﻿using System;
using Domain.Confections.Characteristics;
using Domain.Confections;

namespace Utils.Builders.Confection
{
    public abstract class ConfectionBuilderBase<T> where T : ConfectionBase, new ()
    {
        protected T Confection { get; }

        protected ConfectionBuilderBase() => Confection = new T();

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

        public ConfectionBuilderBase<T> SetStartDate(DateTime startDate)
        {
            Confection.StartDate = startDate;
            return this;
        }

        public T Build()
        {
            if (Confection.Name == null || Confection.ManufacturerName == null || Confection.Weight == 0 || Confection.SugarContent == 0)
            {
                throw new ArgumentException();
            }

            return Confection;
        }
    }

}