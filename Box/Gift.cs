using System.Collections.Generic;
using System.Text;
using GiftContent.Products;

namespace GiftBox.Box
{
    public class Gift
    {
        public ICollection<IProduct> Confections { get; }

        public Gift(ICollection<IProduct> collection) => Confections = collection;

        public void Add(IProduct confection) => Confections.Add(confection);

        public override string ToString()
        {
            StringBuilder confections = new StringBuilder();

            foreach (var product in Confections)
                confections.Append(product);

            return confections.ToString();
        }
    }
}