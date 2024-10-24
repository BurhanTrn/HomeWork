using System;

namespace HomeWork.Hesap_Makinesi;

public class Calculator
{
    int sonuc=0;
    public virtual int Add(int sayı1,int sayi2)
    {
        sonuc=sayı1+sayi2;
        return sonuc;
    }
    public virtual int Subtract(int sayı1, int sayi2)
    {
        sonuc = sayı1 - sayi2;
        return sonuc;
    }
    public virtual int Multiply(int sayı1, int sayi2)
    {
        sonuc = sayı1 * sayi2;
        return sonuc;
    }
    public virtual int Divide(int sayı1, int sayi2)
    {
        if(sayi2 > 0){
            sonuc = sayı1 / sayi2;
        } else
        {
            System.Console.WriteLine("ikinci sayı 0 dan büyük olmalıdır");
            
        }
        
        return sonuc;
    }


}
