using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RegisteredUsers_Cart : System.Web.UI.Page
{
    int count;
    int index;
    protected void Page_Load(object sender, EventArgs e)
    {
        GridView1.DataSource = Session["Cart"];
        GridView1.DataBind();
    }

    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        List<Book> b = (List<Book>)Session["Cart"];
        b.Remove(b[index]);
        GridView1.DataSource = Session["Cart"];
        GridView1.DataBind();
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        GridViewRow row = GridView1.SelectedRow;
        index = GridView1.SelectedIndex;
    }



    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        //GridViewRow row = GridView1.Rows[e.RowIndex];
        //int qty = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Values[0]);
        //GridView1.EditIndex = -1;
        //GridView1.DataBind();
        //List<Book> b = (List<Book>)Session["Cart"];
        //GridView1.DataSource = Session["Cart"];
        //GridView1.DataBind();
    }

    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        GridView1.DataSource = Session["Cart"];
        GridView1.DataBind();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Literal1.Text = "Confirm!";
    }


}