public class Bag
{
    private string products;
    private string brand;

    public Bag(string products, string brand)
    {
        this.products = products
        this.brand = brand
    }

    public string NameBrand()
    {
        Console.WriteLine("Наименование продукта: " + products);
        Console.WriteLine("Название фирмы: " + brand);

    }
}

public class Output
{
    public static void Main(string[] args)
    {
        Bag bag = new Bag("Тени", "MAC");

        bag.NameBrand();
    }
}