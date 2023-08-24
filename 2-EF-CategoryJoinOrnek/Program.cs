
using _2_EF_CategoryJoinOrnek;

List<Product> products = new List<Product>()
{
    new Product(){ProductId=1,Name="Elma",Price=15m,CategoryId=1},
    new Product(){ProductId=2,Name="Armut",Price=25m,CategoryId=1},
    new Product(){ProductId=3,Name="Kiraz",Price=55m,CategoryId=1},
    new Product(){ProductId=4,Name="Patates",Price=60m,CategoryId=2},
    new Product(){ProductId=5,Name="Kabak",Price=150m,CategoryId=2},
    new Product(){ProductId=6,Name="Biber",Price=53m,CategoryId=2},
    new Product(){ProductId=7,Name="Çilek",Price=78m,CategoryId=1},
    new Product(){ProductId=8,Name="Kivi",Price=98m,CategoryId=1},
    new Product(){ProductId=9,Name="Portakal",Price=75m,CategoryId=1},
    new Product(){ProductId=10,Name="Havuç",Price=56m,CategoryId=2}
};

List<Category> categories = new List<Category>()
{
    new Category(){CategoryId=1,Name="Meyve"},
    new Category(){CategoryId=2,Name="Sebze"}
};

var join = products.Join(
    categories,
    product => product.CategoryId,
    categorie => categorie.CategoryId,
    (product, categorie) => new
    {
        Product = product,
        CategoryName = categorie.Name
    }
    )
    .GroupBy(categorie => categorie.CategoryName)
    .Select(group => new
    {
        CategoryName = group.Key,
        Products = group.Select(product => product.Product).ToList()
    }
    );

foreach (var group in join)
{
    Console.WriteLine($"Category: {group.CategoryName}");
    foreach (var product in group.Products)
    {
        Console.WriteLine($"  Product: {product.Name}");
    }
}

Console.WriteLine("*********************************************");
var enPahali=products.OrderByDescending(p => p.Price).FirstOrDefault();
if (enPahali != null)
{
    Console.WriteLine($"En Pahali Ürün: {enPahali.Name}, Price: {enPahali.Price}");
}
else
{
    Console.WriteLine("No products available.");
}

Console.WriteLine("*********************************************");

var categorySayi= products
            .GroupBy(product => product.CategoryId)
            .Select(group => new
            {
                CategoryId = group.Key,
                ProductCount = group.Count()
            });

foreach (var result in categorySayi)
{
    Console.WriteLine($"Category ID: {result.CategoryId}, Product Count: {result.ProductCount}");
}