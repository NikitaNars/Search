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
                    // Найден продукт
                    return sortedProducts[mid];
                }
                else if (comparison < 0)
                {
                    // Искомое имя правее
                    left = mid + 1;
                }
                else
                {
                    // Искомое имя левее
                    right = mid - 1;
                }
            }

            // Продукт не найден
            return null;


        }
        public static Product LinearSearchLinq(List<Product> products, string name)
        {
            return products.FirstOrDefault(p =>
                p.name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

    }

}
