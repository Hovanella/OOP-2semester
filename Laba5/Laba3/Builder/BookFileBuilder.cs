using System;
using System.Collections.Generic;
using Laba2.BookFile;

namespace Laba2.Builder
{
    public class BookFileBuilder
    {
        private List<Author> _authors;
        private Format _format;
        private string _name;
        private int _numberOfPages;
        private PublishingHouse _publishingHouse;
        private int _size;
        private string _udc;
        private int _year;

        public BookFileBuilder()
        {
            _authors = new List<Author>();
            _year = new DateTime().Year;
            _udc = "000.000";
            _numberOfPages = 1;
            _name = "Unknown Book File Name";
            _size = 1;
            _publishingHouse = new PublishingHouse("Unknown", "Unknown", "Unknown", DateTime.Now, OwnershipType.Unknown);
            _format = Format.Unknown;
        }

        public BookFile.BookFile CreateBookFile()
        {
            return new BookFile.BookFile(_format, _size, _name, _udc, _numberOfPages, _publishingHouse, _year, _authors);
        }

        public void SetAutors(IEnumerable<Author> list)
        {
            _authors = new List<Author>(list);
        }

        public void SetSize(int size)
        {
            _size = size;
        }

        public void SetYear(int year)
        {
            _year = year;
        }

        public void SetUdc(string udc)
        {
            _udc = udc;
        }

        public void SetNumberOfPages(int numberOfPages)
        {
            _numberOfPages = numberOfPages;
        }

        public void SetFormat(Format format)
        {
            _format = format;
        }

        public void SetPublishingHouse(PublishingHouse publishingHouse)
        {
            _publishingHouse = publishingHouse;
        }

        public void SetName(string name)
        {
            _name = name;
        }
    }
}