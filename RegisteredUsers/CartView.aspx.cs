using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



public partial class RegisteredUsers_CartView : System.Web.UI.Page
{
    BookshopEntities bookshopEntities = new BookshopEntities();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //BizLogic b = new BizLogic();
            //Repeater1.SelectMethod= b.getOrdersMade();
            Repeater1.ItemType = "<%bookshopEntities.Books%>";
            Repeater1.DataSource = Session["Cart"];
            Repeater1.DataBind();
        }


    }
    protected void Repeater1_ItemCommand(object source, DataListCommandEventArgs e)
    {
        TextBox tb = new TextBox();
        Label BookIDLabel = new Label();
        Label BookPriceLabel = new Label();
        for (int i = 0; i < Repeater1.Items.Count; i++)
        {
            tb = (TextBox)Repeater1.Items[i].FindControl("TextBox1");
            BookIDLabel = (Label)Repeater1.Items[i].FindControl("Label10");
            BookPriceLabel = (Label)Repeater1.Items[i].FindControl("Label3");
        }
        int qty = Int32.Parse(tb.Text);
        //double price = Convert.ToDouble(BookPriceLabel.Text
        //Substring(1,BookPriceLabel.Text.Length-1)
        //);
        if (e.CommandName == "Increase") qty++;
        else if (e.CommandName == "Decrease")
            if (qty > 1) qty--;
            else if (e.CommandName == "Delete")
            {
                List<Book> b = (List<Book>)Session["Cart"];
                Book BookToRemove = b.Where(x => x.BookID == Int32.Parse(BookIDLabel.Text)).First();
                b.Remove(BookToRemove);
                Session["Cart"] = b;
                Repeater1.DataSource = Session["Cart"];
                Repeater1.DataBind();
            }
        tb.Text = qty.ToString();
        //BookPriceLabel.Text = (qty * price).ToString();
    }
}