using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_UpdateDiscount : System.Web.UI.Page
{
    BooksController booksController = new BooksController();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Wizard1_NextButtonClick(object sender, WizardNavigationEventArgs e)
    {
        if (Wizard1.ActiveStepIndex == 1)
        {
            if (RadioButton2.Checked)
            {
                Wizard1.ActiveStepIndex = 2;
            }
            else
            {
                Wizard1.ActiveStepIndex = 3;
            }
        }

    }

    protected void Wizard1_FinishButtonClick(object sender, WizardNavigationEventArgs e)
    {

    }


    protected void SearchButton_Click(object sender, EventArgs e)
    {
        int id = int.Parse(SearchTextBox.Text);
        List<Book> theList = booksController.RetrieveByIDToList(id);
        SearchGridView.DataSource = theList;
        SearchGridView.DataBind();
    }
}