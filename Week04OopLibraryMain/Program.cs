using System;
using Week04OopLibraryMain;

class Program
{
    static void Main(string[]args)
    {
        
        Week04BookClassification book1 = new Week04BookClassification();
        Week04BookClassification book2 = new Week04BookClassification("Adı Aylin", "Ayşe", "Kulin", 398, "Remzi Kitabevi");
        Week04BookClassification book3 = new Week04BookClassification("Bir Kitap", "Ahmet", "Yılmaz", 320, "Alfa Yayınları");
        Week04BookClassification book4 = new Week04BookClassification("Başka Bir Kitap", "Ayşe", "Karan", 215, "Beta Yayınları");
        Week04BookClassification book5 = new Week04BookClassification("Daha Başka Kitap", "Mehmet", "Demir", 450, "Gama Yayınları");
        Week04BookClassification book6 = new Week04BookClassification("Son Kitap", "Elif", "Şahin", 275, "Delta Yayınları");
        Week04BookClassification book7 = new Week04BookClassification("Örnek Kitap", "Selin", "Yurt", 198, "Epsilon Yayınları");


        book1.DisplayBookInfo();
        book2.DisplayBookInfo();
        book3.DisplayBookInfo();
        book4.DisplayBookInfo();
        book5.DisplayBookInfo();
        book6.DisplayBookInfo();
        book7.DisplayBookInfo();
    }
}
// Class: Week04BookClassification adında bir sınıf oluşturduk, kitap nesnelerini temsil eder.
// Property: Title, AuthorName gibi özellikler kitapla ilgili bilgileri tutar.
// Constructor: Sınıftan yeni nesne oluşturulduğunda ilk çalışan özel metotlardır.
// New: Bir sınıftan nesne oluşturmak için 'new' anahtar kelimesi kullanılır.