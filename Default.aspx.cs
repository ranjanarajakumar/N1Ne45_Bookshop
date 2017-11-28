using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    BooksController booksController = new BooksController();
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (!IsPostBack)
        {
            List<Book> theLastestBooks = booksController.RetriveLastFiveBooks();
            int theLastBookID = booksController.RetrieveLastID();
            //Book1
            Book book1 = theLastestBooks.Find(x => x.BookID == theLastBookID);
            string s = string.Format("images/images/{0}.jpg",book1.ISBN);
            Image1.ImageUrl = s;
            lbBook1Name.Text = book1.Title;
            lbBook1Author.Text = "Author: "+book1.Author;
            lbBook1Price.Text = "Price: $"+book1.Price.ToString();
            //Book2
            Book book2 = theLastestBooks.Find(x => x.BookID == theLastBookID-1);
            string s2 = string.Format("images/images/{0}.jpg",book2.ISBN);
            Image2.ImageUrl = s2;
            lbBook2Name.Text = book2.Title;
            lbBook2Author.Text = "Author: "+book2.Author;
            lbBook2Price.Text = "Price: $"+book2.Price.ToString();
            //Book3           
            Book book3 = theLastestBooks.Find(x => x.BookID == theLastBookID-2);
            string s3 = string.Format("images/images/{0}.jpg",book3.ISBN);
            Image3.ImageUrl = s3;
            lbBook3Name.Text = book3.Title;
            lbBook3Author.Text = "Author: "+book3.Author;
            lbBook3Price.Text = "Price: $"+book3.Price.ToString();
            //Book4
            Book book4 = theLastestBooks.Find(x => x.BookID == theLastBookID-3);
            string s4 = string.Format("images/images/{0}.jpg",book4.ISBN);
            Image4.ImageUrl = s4;
            lbBook4Name.Text = book4.Title;
            lbBook4Author.Text = "Author: "+book4.Author;
            lbBook4Price.Text = "Price: $"+book4.Price.ToString();
            //Book5
            Book book5 = theLastestBooks.Find(x => x.BookID == theLastBookID-4);
            string s5 = string.Format("images/images/{0}.jpg",book5.ISBN);
            Image5.ImageUrl = s5;
            lbBook5Name.Text = book5.Title;
            lbBook5Author.Text = "Author: "+book5.Author;
            lbBook5Price.Text = "Price: $"+book5.Price.ToString();  
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string input = TextBox1.Text;
        Response.Redirect("DefaultSearch.aspx?Name="+input);
    }
}