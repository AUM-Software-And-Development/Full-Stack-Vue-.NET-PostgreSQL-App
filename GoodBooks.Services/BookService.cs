using GoodBooks.Data;
using GoodBooks.Data.Models;

namespace GoodBooks.Services;
public class BookService : IBookService
{
    private readonly GoodBooksDbContext _db;

    public BookService(GoodBooksDbContext db)
    {
        _db = db;
    }

    public void AddBook(Book book)
    {
        _db.Add(book);
        _db.SaveChanges();
    }

    public void DeleteBook(int bookId)
    {
        var bookToDelete = _db.Books.Find(bookId);
        if (bookToDelete != null) {
            _db.Books.Remove(bookToDelete);
            _db.SaveChanges();
        }
        else
        {
            throw new InvalidOperationException("Unable to delete a book that does not exist. This book does not exist.");
        }
    }

    public List<Book> GetAllBooks()
    {
        return _db.Books.ToList();
    }

    public Book GetBook(int bookId)
    {
        // Virtually the same as first of default.
        return _db.Books.Find(bookId);
    }
}
