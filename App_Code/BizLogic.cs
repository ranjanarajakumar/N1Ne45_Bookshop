using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BizLogic
/// </summary>
public class BizLogic
{


    public class OrdersMade
    {
        List<Order> orders;
        string custID;
        public OrdersMade(List<Order> orders, string custID)
        {
            this.orders = orders;
            this.custID = custID;
        }
        public List<Order> Orders
        {
            get { return orders; }
            set { orders = value; }
        }
        public string CustID
        {
            get { return custID; }
            set { custID = value; }
        }
    }

    public List<Order> getOrdersMade()
    {
        Order a = new Order(15, "When Breath Becomes Air", "9780812988406", 4, 25.00);
        Order b = new Order(21, "The Stranger in the Woods: The Extraordinary Story of the Last True Hermit", "9781101875681", 1, 25.95);
        List<Order> o = new List<Order>() { a, b };
        return o;
    }

    static void Main()
    {


    }
}

public class Order
{
    int bookID;
    string title;
    string isbn;
    int qty;
    double price;

    public Order(int bookID, string title, string isbn, int qty, double price)
    {
        this.bookID = bookID;
        this.title = title;
        this.isbn = isbn;
        this.qty = qty;
        this.price = price;
    }
    public int BookID
    {
        get { return bookID; }
        set { bookID = value; }
    }
    public string Title
    {
        get { return title; }
        set { title = value; }
    }
    public string Isbn
    {
        get { return isbn; }
        set { isbn = value; }
    }
    public int Qty
    {
        get { return qty; }
        set { qty = value; }
    }
    public double Price
    {
        get { return price; }
        set { price = value; }
    }
}