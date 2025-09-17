using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public static class ProductSearch
    {
        public static Product BinSertch(List<Product> products, string name)
        {
            var sortedProducts = products.OrderBy(p => p.name).ToList();

            int left = 0;
            int right = sortedProducts.Count - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                int comparison = string.Compare(sortedProducts[mid].name, name, StringComparison.OrdinalIgnoreCase);

                if (comparison == 0)
                {
                    
                    return sortedProducts[mid];
                }
                else if (comparison < 0)
                {
                    
                    left = mid + 1;
                }
                else
                {
                    
                    right = mid - 1;
                }
            }

            
            return null;


        }
        public static Product LinearSearchLinq(List<Product> products, string name)
        {
            return products.FirstOrDefault(p =>
                p.name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

    }

}
