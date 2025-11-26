using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Book : LibraryItemBase
    {
        public string Author { get; set; }

        public Book (string title, int year, string author) : base (title, year)
        {
            Author = author;
        }

        public override string GetItemType()
        {
            return "Book";
        }

        public new string GetDisplayInfo()
        {
            return base.GetDisplayInfo() + $", Autor: {Author}";
        }
    }
}
