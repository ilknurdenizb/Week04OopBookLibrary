using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04OopLibraryMain
{
    internal class Week04BookClassification
    {
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public string AuthorSurname { get; set; }
        public int BookPages { get; set; }
        public string BookFirm { get; set; }
        public DateTime BookRecordDate { get; set; }

        public Week04BookClassification()
        {
            Title = "Default";
            AuthorName = "Default";
            AuthorSurname = "Default";
            BookPages = 0;
            BookFirm = "Default";
            BookRecordDate = DateTime.Now;
        }

        public Week04BookClassification( string title, string authorName, string authorSurname, int bookPages, string bookFirm)
        {
            Title = title;
            AuthorName = authorName;
            AuthorSurname = authorSurname;
            BookPages = bookPages;
            BookFirm = bookFirm;
            BookRecordDate = DateTime.Now;

        }
        public void DisplayBookInfo ()
        {
            Console.WriteLine($"{AuthorName} {AuthorSurname} yazarının {BookPages} sayfalık, {BookFirm} yayınevinden çıkan {Title} kitabını oluşturunuz. - {BookRecordDate}");
        }


    }
}
