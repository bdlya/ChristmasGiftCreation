using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain.Products.Confections;

namespace Box
{
    public class Gift
    {
        private readonly ICollection<ConfectioneryProductBase> _confections;

        public Gift(ICollection<ConfectioneryProductBase> collection) => _confections = collection;

        public void Add(ConfectioneryProductBase confection) => _confections.Add(confection);

        public void AddRange(params ConfectioneryProductBase[] confections)
        {
            foreach (var confection in confections)
                Add(confection);
        }

        public double CountWeight() => _confections.Sum(x => x.Weight);

        public Gift OrderByManufacturer() => new Gift(_confections.OrderBy(x => x.ManufacturerName).ToList());

        public override string ToString()
        {
            StringBuilder confections = new StringBuilder();

            foreach (var product in _confections)
            {
                confections.Append(product);
            }

            return confections.ToString();
        }
    }
}