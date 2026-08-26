namespace AssignmentADVC_02
{
    internal class Program
    {
        static List<Product> SearchProducts(List<Product> products,Func<Product, bool> filter)
        {
            List<Product> result = new List<Product>();

            foreach (Product product in products)
            {
                if (filter(product))
                {
                    result.Add(product);
                }
            }

            return result;
        }
        static void PrintReport( List<Product> products, Action<Product> action)
        {
            foreach (Product product in products)
            {
                action(product);
            }
        }
        static List<string> TransformProducts( List<Product> products, Func<Product, string> transform)
        {

            List<string> result = new List<string>();

            foreach (Product product in products)
            {
                result.Add(transform(product));
            }

            return result;
        }
        static List<Product> FilterProducts( List<Product> products, Predicate<Product> condition)
        {

            List<Product> result = new List<Product>();

            foreach (Product product in products)
            {
                if (condition(product))
                {
                    result.Add(product);
                }
            }

            return result;
        }
        static void Main(string[] args)
        {
            List<Product> catalog = new()
            {
                new Product{Id=1,Name="Laptop",Category="Electronics",Price=1200,Stock=10},
                new Product{Id=2,Name="Phone",Category="Electronics",Price=800,Stock=25},
                new Product{Id=3,Name="Tshirt",Category="Clothing",Price=30,Stock=100},
                new Product{Id=4,Name="Jeans",Category="Clothing",Price=60,Stock=50},
                new Product{Id=5,Name="Chocolate",Category="Food",Price=5,Stock=200},
                new Product{Id=6,Name="Coffe Beans",Category="Food",Price=15,Stock=80},
                new Product{Id=7,Name="C# Book",Category="Books",Price=45,Stock=30},
                new Product{Id=8,Name="Novel",Category="Books",Price=20,Stock=60},
                new Product{Id=9,Name="Head Phones",Category="Electronics",Price=150,Stock=40},
                new Product{Id=10,Name="Jacket",Category="Clothing",Price=120,Stock=15},
            };
            #region Search products
            //List<Product> electronics = SearchProducts( catalog, product => product.Category == "Electronics");

            //Console.WriteLine("Electronics Products:");

            //foreach (Product product in electronics)
            //{
            //    Console.WriteLine($"{product.Name} - ${product.Price} - Stock: {product.Stock}" );
            //}



            //List<Product> cheapProducts = SearchProducts(catalog,product => product.Price < 50);

            //Console.WriteLine("Products Cheaper Than $50:");

            //foreach (Product product in cheapProducts)
            //{
            //    Console.WriteLine( $"{product.Name} - ${product.Price} - Stock: {product.Stock}");
            //}



            //List<Product> inStockProducts = SearchProducts( catalog,product => product.Stock > 0 );

            //Console.WriteLine("Products In Stock:");

            //foreach (Product product in inStockProducts)
            //{
            //    Console.WriteLine(  $"{product.Name} - ${product.Price} - Stock: {product.Stock}");
            //}



            //List<Product> clothingUnder100 = SearchProducts(catalog,product => product.Category == "Clothing" && product.Price < 100 );

            //Console.WriteLine("Clothing Products Under $100:");

            //foreach (Product product in clothingUnder100)
            //{
            //    Console.WriteLine( $"{product.Name} - ${product.Price} - Stock: {product.Stock}");
            //} 
            #endregion
            #region Print Reports
            //use Action delegate because it recieves product and not return value 
            // Short Report

            //Console.WriteLine("Short Report:");
            //PrintReport(catalog,product => Console.WriteLine($"{product.Name} - ${product.Price}"));


            //Detailed Report

            //Console.WriteLine("Detailed Report:");
            // PrintReport(catalog,product => Console.WriteLine($"[{product.Category}] {product.Name} | Price: ${product.Price} | Stock: {product.Stock}"));
            #endregion
            #region Transform products
            //func used because it recieve product and return string 
            //scenario 3:string
            //List<string> summary = TransformProducts( catalog, product => $"{product.Name} (${product.Price})");
            //Console.WriteLine("Summary List:");
            //foreach (string item in summary)
            //{
            //    Console.WriteLine(item);
            //}
            //scenario 4:label
            //List<string> priceLabels = TransformProducts(catalog, product => $"{product.Name}: {(product.Price > 100 ? "Expensive!" : "Affordable")}");

            //Console.WriteLine("Price Labels:");

            //foreach (string item in priceLabels)
            //{
            //    Console.WriteLine(item);
            // }
            #endregion
            #region Filter products
            // Predicate<Product> is used because the condition takes a Product and returns bool
            //List<Product> lowStockProducts = FilterProducts(catalog, product => product.Stock < 20);
            //Console.WriteLine("Low Stock Alerts:");

            //foreach (Product product in lowStockProducts)
            //{
            //    Console.WriteLine( $"[LOW STOCK] {product.Name}: only {product.Stock} left!" );
            //}
            #endregion



        }
    }
}
