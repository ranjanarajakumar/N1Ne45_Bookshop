using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RegisteredUsers_AdvanceSearch : System.Web.UI.Page
{
    BooksController booksController = new BooksController();
    BookshopEntities bookshopEntities = new BookshopEntities();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        List<Book> theList=new List<Book>();
        string sql = "";
        string bookTitle = txtSearch.Text.ToString();
        string bookAuthor = txtAuthor.Text.ToString();
        string bookCategory = DropDownListCategory.Items[DropDownListCategory.SelectedIndex].ToString();

        if (chkSearch.Checked == true && chkAuthor.Checked == true && ChkCategory.Checked == true)
        {
            theList = booksController.RetrieveByTitleAuthorCategory(txtSearch.Text, txtAuthor.Text, int.Parse(DropDownListCategory.SelectedValue.ToString()));
            //sql = "Select * from Book, Category where Book.CategoryID= Category.CategoryID and Title like '%" + bookTitle + "%' and Author like '%" + bookAuthor + "%' and Name = '" + bookCategory + "' ";
        }

        else if (chkSearch.Checked == true && chkAuthor.Checked == true)
        {
            theList = booksController.RetrieveByTitleAuthor(txtSearch.Text, txtAuthor.Text);
            //sql = "Select * from Book where Title like '%" + bookTitle + "%' and Author like '%" + bookAuthor + "%' ";
        }

        else if (chkSearch.Checked == true && ChkCategory.Checked == true)
        {
            theList = booksController.RetrieveByTitleCategory(txtSearch.Text, int.Parse(DropDownListCategory.SelectedValue.ToString()));
            //sql = "Select * from Book, Category where Book.CategoryID= Category.CategoryID and Title like '%" + bookTitle + "%' and Name = '" + bookCategory + "' ";
        }

        else if (chkAuthor.Checked == true && ChkCategory.Checked == true)
        {
            theList = booksController.RetrieveByAuthorCategory(txtAuthor.Text, int.Parse(DropDownListCategory.SelectedValue.ToString()));
            //sql = "Select * from Book, Category where Book.CategoryID= Category.CategoryID and Author like '%" + bookAuthor + "%' and Name = '" + bookCategory + "' ";
        }
        else if (chkSearch.Checked == true)
        {
            theList = booksController.RetrieveByTitle(txtSearch.Text);
            //sql = "Select * from Book where Title like '%" + bookTitle + "%' ";
        }

        else if (chkAuthor.Checked == true)
        {
            theList = booksController.RetrieveByAuthor(txtAuthor.Text);
            //sql = "Select * from Book where Author like '%" + bookAuthor + "%' ";
        }

        else if (ChkCategory.Checked == true)
        {
            theList=booksController.RetrieveByCategory(int.Parse(DropDownListCategory.SelectedValue.ToString()));
            //sql = "Select * from Book, Category where Book.CategoryID= Category.CategoryID and Name= '" + bookCategory + "' ";
        }

        else
        {
            theList = booksController.RetrieveAll();
        }
        GridViewResult.DataSource = theList;

        GridViewResult.DataBind();
    }

    protected void btnReset_Click(object sender, EventArgs e)
    {
        txtSearch.Text = "";
        txtAuthor.Text = "";
        chkSearch.Checked = false;
        chkAuthor.Checked = false;
        ChkCategory.Checked = false;
        DropDownListCategory.SelectedIndex = 0;
        GridViewResult.DataSource = null;
        GridViewResult.DataBind();
    }

    protected void GridViewResult_SelectedIndexChanged(object sender, EventArgs e)
    {
        GridViewResult.SelectedRow.Enabled = false;

        List<Book> BookInCart = (List<Book>)Session["Cart"];

        Book newbook = bookshopEntities.Books.Where(x => x.BookID == (int)GridViewResult.SelectedValue).First();
        BookInCart.Add(newbook);
        Session["Cart"] = BookInCart;
    }

    protected void AddCartButton_Click(object sender, EventArgs e)
    {
        Server.Transfer("Cart.aspx");
    }
}