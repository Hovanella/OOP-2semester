using System;
using System.Collections.Generic;

namespace Laba2.BookFile
{
    [Serializable]
    public class BookFile
    {
        public BookFile(Format format, int size, string name, string udc, int numberOfPages, PublishingHouse publishingHouse, int year,
            List<Author> authors)
        {
            Format = format;
            Size = size;
            Name = name;
            Udc = udc;
            NumberOfPages = numberOfPages;
            PublishingHouse = publishingHouse;
            Year = year;
            Authors = authors;
        }

        public Format Format { get; set; }
        public int Size { get; set; }
        public string Name { get; set; }
        public string Udc { get; set; }
        public int NumberOfPages { get; set; }
        public PublishingHouse PublishingHouse { get; set; }
        public int Year { get; set; }
        public List<Author> Authors { get; set; }

        public override string ToString()
        {
            return string.Format("Format - {0}, Size - {1}(mb) , Name - {2} , UDC - {3} , Year - {4}", Format, Size, Name, Udc, Year);
        }
    }
}