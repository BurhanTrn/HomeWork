using System;

namespace HomeWork.Kitap_Kütüphanesi_Uygulaması__Library_Application_;

public class Library : Book
{
    public Library(string title, string author, int pages, int ıSBN) : base(title, author, pages, ıSBN)
    {
    }

    public override void Borrow()
    {
        base.Borrow();
    }

    public override void Return()
    {
        base.Return();
    }

    
}
