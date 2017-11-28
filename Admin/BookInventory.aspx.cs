using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_BookInventory : System.Web.UI.Page
{
    BooksController booksController = new BooksController();
    

    protected void Page_Load(object sender, EventArgs e)
    {
       
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        List<Book> theList = new List<Book>();
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
            theList = booksController.RetrieveByCategory(int.Parse(DropDownListCategory.SelectedValue.ToString()));
            //sql = "Select * from Book, Category where Book.CategoryID= Category.CategoryID and Name= '" + bookCategory + "' ";
        }

        else
        {
            theList = booksController.RetrieveAll();
        }

        Session["TaskTable"] = theList; 
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

    protected void OnRowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            Book theBook = (Book)e.Row.DataItem;
            int id = theBook.BookID;

            Label lbISBN = (e.Row.FindControl("lbISBN") as Label);
            if (lbISBN != null)
                lbISBN.Text = theBook.ISBN;

            Label lbBookTitle = (e.Row.FindControl("lbBookTitle") as Label);
            if (lbBookTitle != null)
                lbBookTitle.Text = theBook.Title;

            Label lbAuthor = (e.Row.FindControl("lbAuthor") as Label);
            if (lbAuthor != null)
                lbAuthor.Text = theBook.Author;
            Label lbStock = (e.Row.FindControl("lbStock") as Label);
            if (lbStock != null)
                lbStock.Text = theBook.Stock.ToString();
        }
    }

    protected void OnRowEditing(object sender, GridViewEditEventArgs e)
    {
        
        GridViewResult.EditIndex = e.NewEditIndex;
        BindData();
    }

    protected void OnRowCancelingEdit(object sender, EventArgs e)
    {
        GridViewResult.EditIndex = -1;
        BindData();
    }

    protected void OnRowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        GridViewRow row = GridViewResult.Rows[e.RowIndex];
        int bookID = Convert.ToInt32(GridViewResult.DataKeys[e.RowIndex].Values[0]);
        int stock = Convert.ToInt32((row.FindControl("tbEditStock") as TextBox).Text);
        decimal discount= Convert.ToDecimal((row.FindControl("tbEditDiscount") as TextBox).Text);
        booksController.updateStock(bookID, stock,discount);
        HttpContext.Current.Response.Write("<script>Update Completed!')</script>");

        GridViewResult.EditIndex = -1;
        BindData();
    }

    private void BindData()
    {
        GridViewResult.DataSource = (List<Book>)Session["TaskTable"];
        GridViewResult.DataBind();
    }




}