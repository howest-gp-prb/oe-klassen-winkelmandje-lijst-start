using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winkelmandje
{
    public class MandjeList
    {
        private List<Product> content;

        public MandjeList()
        {
            this.content = new List<Product>();
        }

        public void AddProduct(Product p)
        {
            content.Add(p);
        }

        public decimal GetTotalPrice()
        {
            decimal price = 0;
            foreach (Product p in content)
            {
                price += p.GetPrice();
            }

            return price;
        }

        public Product GetMostExpensiveItem()
        {
            Product most = content[0];
            foreach (Product p in content)
            {
                if (p.GetPrice() > most.GetPrice())
                {
                    most = p;
                }
            }
            return most;
        }

        public Product GetCheapestItem()
        {
            Product cheapest = content[0];
            foreach (Product p in content)
            {
                if (p.GetPrice() < cheapest.GetPrice())
                {
                    cheapest = p;
                }
            }
            return cheapest;
        }
    }
}
