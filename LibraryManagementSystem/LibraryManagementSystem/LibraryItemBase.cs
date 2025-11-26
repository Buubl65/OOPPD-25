using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public abstract class LibraryItemBase : ILibraryItem
    {
        protected static int _nextId = 1;

        public int Id { get; }
        public string Title { get; set; }
        public int Year { get; set; }
        public LibraryItemBase(string title, int year) 
        {
            Id = _nextId++;
            Title = title;
            Year = year;
        }

        public abstract string GetItemType();
        
        public string GetDisplayInfo()
        {
            return $"{GetItemType()} ID: ${Id}, Title: ${Title}, Year: ${Year}";
        }
    }
}
