// See https://aka.ms/new-console-template for more information
public class Bag
{
    private List<Cosmetic> products;
    private string brand;

    public Bag(string brand)
    {
        this.products = new List<Cosmetic>();
        this.brand = brand;
    }

    public void addToBag(Cosmetic item){
        products.Add(item);
    }

    public void NameBrand()
    {
        Console.WriteLine("Наименование продукта: " + products);
        Console.WriteLine("Название фирмы: " + brand);

    }
}



public class Cosmetic {
    string brand;
    string quality;
    string country;
public Cosmetic(string brand,string quality,string country) {
    this.brand = brand;
    this.quality = quality;
    this.country = country;
}
public string GetBrand(){
    return brand;
}
}

public class Pomada : Cosmetic {
    string color;
    public Pomada(string brand,string quality,string country, string color) : base(brand, quality, country)
    {
        this.color = color;
    }
}
public class Ton : Cosmetic {
    string shade;
    public Ton(string brand,string quality,string country, string shade) :base(brand, quality, country)
    {
        this.shade = shade;
    }
}
public class Blush : Cosmetic {
    string kind;
    public Blush(string brand,string quality,string country, string kind) :base(brand, quality, country)
    {
        this.kind = kind;
    }
}



public class Name
{
    public static void Main()
    {
        // Cosmetic firstCosmeticName = new Cosmetic("NYX", "elite", "USA");
        // Cosmetic secondCosmeticName = new Cosmetic("estel", "good", "Japan");
        // Cosmetic thirdCosmeticName = new Cosmetic("billy", "elite", "Korean");
        // color first = new color("red", "Помада", "2023-2025");
        // color second = new color("brown", "Тени", "2020-2024");
        // color third = new color("black", "Карандаш", "2020-2030");
        Pomada model = new Pomada("NYX", "elite", "USA", "red");
        Ton shadeNumber = new Ton("NYX", "elite", "USA", "0,5");
        Blush kinds= new Blush("NYX", "elite", "USA", "жидкий,сухой");
        
    }
}





// public class color : Bag
// {
//     string colorr;
//     string products;
//     string date;
// public color(string colorr, string products, string date) {
//     this.colorr = colorr;
//     this.products = products;
//     this.date = date;
// }
// public string NewColor(){
//     return colorr;
// }
// public string Newproducts(){
//     return products;
// }
// public string NewDate(){
//     return date;
// }
// }

