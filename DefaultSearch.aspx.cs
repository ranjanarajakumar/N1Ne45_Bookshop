using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DefaultSearch : System.Web.UI.Page
{
    BooksController booksController = new BooksController();
    protected void Page_Load(object sender, EventArgs e)
    {     
            string name = Request.QueryString["Name"];
            List<Book> theList = booksController.RetrieveByTitle(name);
            GridViewResult.DataSource = theList;
            GridViewResult.DataBind();
    }
}