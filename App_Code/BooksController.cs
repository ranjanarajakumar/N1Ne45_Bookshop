using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class BooksController
{
    BookshopEntities context = new BookshopEntities();
    public BooksController()
    {       
    }

    public List<Book> RetriveLastFiveBooks()
    {
        return context.Books.OrderByDescending(x => x.BookID).Take(5).ToList();
    }
    public int RetrieveLastID()
    {
        return context.Books.OrderByDescending(x => x.BookID).First().BookID;
    }

    public Book RetrieveByID(int id)
    {
        return context.Books.Where(x => x.BookID == id).First();
    }
    public List<Book> RetrieveByIDToList(int id)
    {
        return context.Books.Where(x => x.BookID == id).ToList();
    }

    public List<Book> RetrieveAll()
    {
        return context.Books.ToList();
    }
    public List<Book> RetrieveByTitle(string input)
    {
        return context.Books.Where(x => x.Title.Contains(input)).ToList();
        //return context.Books.Where(x => x.Title.Contains(input)).AsEnumerable().Select(y => new Book { Image=y.Image,Title = y.Title, Author = y.Author, Category = y.Category, Price = y.Price, Discount=y.Discount, Stock = y.Stock }).ToList();
    }
    public List<Book> RetrieveByCategory(int value)
    {
        return context.Books.Where(x => x.CategoryID == value).ToList();
    }
    public List<Book> RetrieveByAuthor(string input)
    {
        return context.Books.Where(x => x.Author.Contains(input)).ToList();
    }

    public List<Book> RetrieveByAuthorCategory(string input, int value)
    {
        return context.Books.Where(x => x.Author.Contains(input) && x.CategoryID == value).ToList();
    }

    public List<Book> RetrieveByTitleCategory(string input, int value)
    {
        return context.Books.Where(x => x.Title.Contains(input) && x.CategoryID == value).ToList();
    }

    public List<Book> RetrieveByTitleAuthor(string input1,string input2)
    {
        return context.Books.Where(x => x.Title.Contains(input1) && x.Author.Contains(input2)).ToList();
    }

    public List<Book> RetrieveByTitleAuthorCategory(string input1, string input2, int value)
    {
        return context.Books.Where(x => x.Title.Contains(input1) && x.Author.Contains(input2)&& x.CategoryID == value).ToList();
    }

    public void updateStock(int id, int newStock, decimal discount)
    {
       Book theBook= RetrieveByID(id);
       theBook.Stock = newStock;
       theBook.Discount = discount;
       context.SaveChanges();
    }

    public void updateDiscountAll(decimal discount)
    {
        List<Book> allBook = RetrieveAll();
        allBook.ForEach(x => x.Discount = discount);
        context.SaveChanges();
    }

}