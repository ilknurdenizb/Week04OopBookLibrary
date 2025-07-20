using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04OopLibraryMain 
{
    internal class Week04BookClassification // Week04BookClassification class represents a book with various properties and methods to display its information.
    {
        public string Title { get; set; } // Title of the book
        public string AuthorName { get; set; } // Author's first name
        public string AuthorSurname { get; set; } // Author's last name
        public int BookPages { get; set; } // Number of pages in the book
        public string BookFirm { get; set; } // Publishing firm of the book
        public DateTime BookRecordDate { get; set; } // Date when the book record was created

        public Week04BookClassification() // Default constructor initializes the book with default values
        {
            Title = "Default"; // Default title for the book
            AuthorName = "Default"; // Default author's first name
            AuthorSurname = "Default";
            BookPages = 0;
            BookFirm = "Default";
            BookRecordDate = DateTime.Now;
        }

        public Week04BookClassification( string title, string authorName, string authorSurname, int bookPages, string bookFirm) // Parameterized constructor allows setting specific values for the book properties
        {
            Title = title; // Title of the book 
            AuthorName = authorName; // Author's first name
            AuthorSurname = authorSurname;
            BookPages = bookPages;
            BookFirm = bookFirm;
            BookRecordDate = DateTime.Now;

        }
        public void DisplayBookInfo () // Method to display the book's information in a formatted string
        {
            Console.WriteLine($"{AuthorName} {AuthorSurname} yazarının {BookPages} sayfalık, {BookFirm} yayınevinden çıkan {Title} kitabını oluşturunuz. - {BookRecordDate}");
        }


    }
}
