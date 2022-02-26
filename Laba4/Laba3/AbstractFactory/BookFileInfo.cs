using Laba2.BookFile;

namespace Laba2.AbstractFactory
{
    public class BookFileInfo
    {
        public BookFileInfo(Format format, int size, string name, string udc, int numberOfPages, int year)
        {
            Format = format;
            Size = size;
            Name = name;
            Udc = udc;
            NumberOfPages = numberOfPages;
            Year = year;
        }

        public Format Format { get; private set; }
        public string Name { get; private set; }
        public int NumberOfPages { get; private set; }
        public int Size { get; private set; }
        public int Year { get; private set; }
        public string Udc { get; private set; }
    }
}