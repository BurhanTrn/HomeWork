using System;

namespace HomeWork.Mağza_Ürün_Yönetimi;

public class Product
{
    public Product(string name, decimal price, int stockQuantity)
    {
        Name = name;
        Price = price;
        StockQuantity = stockQuantity;
    }

    public string Name { get; set; }

    public decimal Price { get; set; }

    public int StockQuantity { get; set; }

    public virtual int StockKontrol()
    {
        return StockQuantity;
    }

    public virtual int StockGüncelle(int yenistockadet)
    {
        StockQuantity = yenistockadet;
        return StockQuantity;

    }

    public virtual void Bilgilendirme()
    {
        System.Console.WriteLine($"Ürün:{Name}\nÜrün Fiyatı:{Price}\nÜrün Stok:{StockQuantity}");
    }


}
