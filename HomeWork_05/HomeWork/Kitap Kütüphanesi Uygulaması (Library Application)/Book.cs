using System;

namespace HomeWork.Kitap_Kütüphanesi_Uygulaması__Library_Application_;

public  class Book
{
    public Book(string title, string author, int pages, int ıSBN)
    {
        Title = title;
        Author = author;
        Pages = pages;
        ISBN = ıSBN;
    }

    public string Title { get; set; }
    public string Author { get; set; }
    public int Pages { get; set; }
    public int ISBN { get; set; }



    public virtual void Borrow()
    {
        System.Console.WriteLine($"{Title} adlı kitap ödünç alındı.");
    }

    public virtual void Return()
    {
        System.Console.WriteLine($"{ISBN} numaralı {Title} adlı kitap İade edilmiştir");
    }

}




