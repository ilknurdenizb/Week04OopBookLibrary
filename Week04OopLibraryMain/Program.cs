using System;
using Week04OopLibraryMain;


class Program // Main program class
{
    static void Main(string[]args) // Main method the beggining point of the program
    {
        
        Week04BookClassification book1 = new Week04BookClassification(); // Default constructor is called
        Week04BookClassification book2 = new Week04BookClassification("Adı Aylin", "Ayşe", "Kulin", 398, "Remzi Kitabevi"); // Parameterized constructor is called with specific values
        Week04BookClassification book3 = new Week04BookClassification("Bir Kitap", "Ahmet", "Yılmaz", 320, "Alfa Yayınları"); // Another parameterized constructor is called with different values
        Week04BookClassification book4 = new Week04BookClassification("Başka Bir Kitap", "Ayşe", "Karan", 215, "Beta Yayınları"); // Another parameterized constructor is called with different values
        Week04BookClassification book5 = new Week04BookClassification("Daha Başka Kitap", "Mehmet", "Demir", 450, "Gama Yayınları");
        Week04BookClassification book6 = new Week04BookClassification("Son Kitap", "Elif", "Şahin", 275, "Delta Yayınları");
        Week04BookClassification book7 = new Week04BookClassification("Örnek Kitap", "Selin", "Yurt", 198, "Epsilon Yayınları");


        book1.DisplayBookInfo(); // Display information of the default book
        book2.DisplayBookInfo(); // Display information of the first parameterized book
        book3.DisplayBookInfo(); // Display information of the second parameterized book
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