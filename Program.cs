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
            List<Product> electronics = SearchProducts( catalog, product => product.Category == "Electronics");

            Console.WriteLine("Electronics Products:");

            foreach (Product product in electronics)
            {
                Console.WriteLine($"{product.Name} - ${product.Price} - Stock: {product.Stock}" );
            }


            
            List<Product> cheapProducts = SearchProducts(catalog,product => product.Price < 50);

            Console.WriteLine("Products Cheaper Than $50:");

            foreach (Product product in cheapProducts)
            {
                Console.WriteLine( $"{product.Name} - ${product.Price} - Stock: {product.Stock}");
            }


            
            List<Product> inStockProducts = SearchProducts( catalog,product => product.Stock > 0 );

            Console.WriteLine("Products In Stock:");

            foreach (Product product in inStockProducts)
            {
                Console.WriteLine(  $"{product.Name} - ${product.Price} - Stock: {product.Stock}");
            }


            
            List<Product> clothingUnder100 = SearchProducts(catalog,product => product.Category == "Clothing" && product.Price < 100 );

            Console.WriteLine("Clothing Products Under $100:");

            foreach (Product product in clothingUnder100)
            {
                Console.WriteLine( $"{product.Name} - ${product.Price} - Stock: {product.Stock}");
            }
        

        }
    }
}
