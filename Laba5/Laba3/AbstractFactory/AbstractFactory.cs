using System.Collections.Generic;
using Laba2;
using Laba2.AbstractFactory;
using Laba2.BookFile;

namespace Laba2.AbstractFactory
{
    public interface IBookFileFactory
    {
        List<Author> CreateAutorsList();
        PublishingHouse CreatePublishingHouse();
        BookFileInfo CreateBookInfo();
    }
}

public class NativeBookFileFactory : IBookFileFactory
{
    private readonly List<Author> _authorsFormCurrentAuthorsList;
    private readonly Form1 _currentForm;
    private readonly PublishingHouse _currentPublishingHouse;
    private readonly Format _format;
    private readonly string _name;
    private readonly int _numberOfPages;
    private readonly int _size;
    private readonly string _udc;
    private readonly int _year;

    public NativeBookFileFactory(Form1 currentForm)
    {
    }

    public NativeBookFileFactory(List<Author> authorsFormCurrentAuthorsList, PublishingHouse currentPublishingHouse, string name, int size,
        int numberOfPages, string udc, Format format, int year)
    {
        _authorsFormCurrentAuthorsList = authorsFormCurrentAuthorsList;
        _currentPublishingHouse = currentPublishingHouse;
        _name = name;
        _size = size;
        _numberOfPages = numberOfPages;
        _udc = udc;
        _format = format;
        _year = year;
    }

    public List<Author> CreateAutorsList()
    {
        return new List<Author>(_authorsFormCurrentAuthorsList);
    }

    public PublishingHouse CreatePublishingHouse()
    {
        return _currentPublishingHouse;
    }

    public BookFileInfo CreateBookInfo()
    {
        return new BookFileInfo(_format, _size, _name, _udc, _numberOfPages, _year);
    }
}