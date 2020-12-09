using System.Collections.Generic;
using System.Text;
using Domain.Products.Confections;

namespace Box
{
    public class Gift
    {
        public ICollection<ConfectioneryProductBase> Confections { get; }

        public Gift(ICollection<ConfectioneryProductBase> collection) => Confections = collection;

        public void Add(ConfectioneryProductBase confection) => Confections.Add(confection);

        public override string ToString()
        {
            StringBuilder confections = new StringBuilder();

            foreach (var product in Confections)
                confections.Append(product);

            return confections.ToString();
        }
    }
}