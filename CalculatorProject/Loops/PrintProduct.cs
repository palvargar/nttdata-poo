using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.Loops
{
    public class PrintProduct
    {
        private static List<Product> products = new List<Product>();

        public static void CreateListProduct()
        {
            var potatoes = new Product
            {
                Id = 1,
                Name = "Patatas",
                Price = 24.56f
            };
            products.Add(potatoes);

            var oil = new Product
            {
                Id = 1,
                Name = "Aceite",
                Price = 35.27f
            };
            products.Add(oil);

            var game = new Product
            {
                Id = 1,
                Name = "Juego",
                Price = 39.99f
            };
            products.Add(game);

            var shoes = new Product(4, "Zapatos", 20.99f);
            products.Add(shoes);

            System.Console.WriteLine(shoes.ToString());
        }

        public List<Product> GetProductsGreaterThan30WithFor()
        {
            if (products.Count == 0)
                CreateListProduct();
            var lista = new List<Product>();
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Price > 30.00f)
                {
                    lista.Add(products[i]);
                }
            }

            return lista ;
        }
        public List<Product> GetProductsGreaterThan30WithForEach()
        {
            if (products.Count == 0)
                CreateListProduct();
            var lista = new List<Product>();
            foreach (var i in products)
            {
                if (i.Price > 30.00f)
                {
                    lista.Add(i);
                }
            }

            return lista;
        }
        public List<Product> GetProductsGreaterThan30WithWhile()
        {
            if (products.Count == 0)
                CreateListProduct();
            var lista = new List<Product>();
            var i = 0;
            while (i < products.Count)
            {
                if (products[i].Price > 30.00f)
                {
                    lista.Add(products[i]);
                }
                i++;
            }

            return lista;
        }
        public List<Product> GetProductsGreaterThan30WithLinq()
        {
            if (products.Count == 0)
                CreateListProduct();
            var lista = (from productGreaterThan30 in products 
                         where productGreaterThan30.Price > 30.00f 
                         select productGreaterThan30).ToList();

            return lista;
        }
    }
}
