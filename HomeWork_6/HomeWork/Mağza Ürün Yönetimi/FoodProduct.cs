using System;

namespace HomeWork.Mağza_Ürün_Yönetimi;

public class FoodProduct : Product
{
    public FoodProduct(string name, decimal price, int stockQuantity, DateTime expiraionDate) : base(name, price, stockQuantity)
    {
        ExpiraionDate = expiraionDate;
    }

    public DateTime ExpiraionDate { get; set; }

    public override int StockGüncelle(int yenistockadet)
    {
        return base.StockGüncelle(yenistockadet);
    }

    public override int StockKontrol()
    {
        return base.StockKontrol();
    }

    public override void Bilgilendirme()
    {
        base.Bilgilendirme();
        System.Console.WriteLine($"Ürün SonKullanma Tarihi:{ExpiraionDate}");
    }
}
