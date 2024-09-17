using HomeWork.Çalışan_Yönetim_Sistemi__Employee_Management_System_;
using HomeWork.Hayvanat_Bahçesi_Uygulaması__Zoological_Application_;
using HomeWork.Taşıt_Yönetim_Sistemi__Vehicle_Management_System_;

namespace HomeWork;

class Program
{
    static void Main(string[] args)
    {
        // Lion lion1 = new Lion("Burak", 7, "Kedi");
        // Elephant elephant1 = new Elephant("Uğur", 8, "uzunburun");
        // Giraffe giraffe1 = new Giraffe("Samet", 9, "yerdenbacak");

        // lion1.MakeSound();
        // elephant1.MakeSound();
        // giraffe1.MakeSound();

        // Car car1 = new Car("Mercedes", "c180", 2016, 5);
        // Bicycle bicycle1 = new Bicycle("Kron", "tx150", 2020, "Zili var");
        // Motorcycle motorcycle1 = new Motorcycle("Honda", "space", 2023, "Yok");

        // motorcycle1.BilgileriEkranaYaz();
        // car1.BilgileriEkranaYaz();
        // bicycle1.BilgileriEkranaYaz();

        //         Bir `Employee` (Çalışan)sınıfı oluşturun.Bu sınıf aşağıdaki özelliklere sahip olmalıdır:
        // - `Name` (isim): Çalışanın adı
        // - `Id` (kimlik numarası): Çalışanın kimlik numarası
        // - `Salary` (maaş): Çalışanın maaşı

        // `Employee` sınıfından `Manager` (Yönetici), `Developer` (Geliştirici)ve `Intern` (Stajyer)sınıflarını türetin. `Manager`     sınıfına ek olarak `NumberOfTeams` (Takım Sayısı) özelliğini, `Developer` sınıfına ise `ProgrammingLanguage` (Programlama Dili) özelliğini ekleyin.

        //         Bir `Book` (Kitap)sınıfı oluşturun.Bu sınıf aşağıdaki özelliklere sahip olmalıdır:
        // - `Title` (başlık): Kitap başlığı
        // - `Author` (yazar): Yazarın adı
        // - `Pages` (sayfa sayısı): Kitap sayfa sayısı
        // - `ISBN` (ISBN numarası): Kitap ISBN numarası

        // `Book` sınıfına `Borrow` (Ödünç Al) ve `Return` (İade Et) metodlarını ekleyin. Daha sonra bir `Library` (Kütüphane)sınıfı oluşturun ve içinde bir dizi `Book` nesnesi tutarak bu kitapları yönetebilsin.



        Menager menager1 = new Menager("Hakan", 12423, 75000, 4);
        Developer developer1 = new Developer("Korhan", 132124, 60000, "C#");
        Intern ıntern1 = new Intern("Kemal", 127000, 20000);

        menager1.BilgileriEkranaYazdır();
        developer1.BilgileriEkranaYazdır();
        ıntern1.BilgileriEkranaYazdır();






    }
}
