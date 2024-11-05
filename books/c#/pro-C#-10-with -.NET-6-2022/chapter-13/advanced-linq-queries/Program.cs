 using advanced_linq_queries;

ProductInfo[] itemsInStock = new[] {
    new ProductInfo{Name = "Mac's Coffee", Description = "Coffee with TEETH", NumberInStock = 24},
    new ProductInfo{ Name = "Milk Maid Milk", Description = "Milk cow's love", NumberInStock = 100},
    new ProductInfo{ Name = "Pure Silk Tofu", Description = "Bland as Possible", NumberInStock = 120},
    new ProductInfo{ Name = "Crunchy Pops", Description = "Cheezy, peppery goodness", NumberInStock = 2},
    new ProductInfo{ Name = "RipOff Water", Description = "From the tap to your wallet", NumberInStock = 100},
    new ProductInfo{ Name = "Classic Valpo Pizza", Description = "Everyone lovespizza!", NumberInStock = 73}
};

// basic LINQ expression
// var result = 
//     from matchingItem in container
//     select matchingItem;

SelectEverything(itemsInStock);
ListProductName(itemsInStock);
GetOverStock(itemsInStock);
PagingWithLINQ(itemsInStock);

static void SelectEverything(ProductInfo[] products)
{
    var allProducts = 
        from product in products
        select product;

    foreach (var product in allProducts)
    {
        Console.WriteLine("Product: {0}", product.Name);
    }
}

static void ListProductName(ProductInfo[] products)
{
    var names = 
        from product in products
        select product.Name;

    foreach (var product in names)
    {
        Console.WriteLine("Product: {0}", product);
    }
}

// filtered LINQ expression
// var result = 
//     from item
//     in container
//     where BooleanExpression
//     select item;

static void GetOverStock(ProductInfo[] products)
{
    var overstock =
        from product
        in products
        where product.NumberInStock > 25
        select product;

    foreach (var product in overstock)
    {
        Console.WriteLine("Product: {0}", product.Name);
    }
}


// PAGING methods
static void PagingWithLINQ(ProductInfo[] products)
{
    var list = (from product in products select product).Take(3);
    foreach (var p in list)
    {
        Console.WriteLine("Product: {0}", p.ToString());
    }
}
