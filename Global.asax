<%@ Application Language="C#" %>

<script runat="server">

    void Application_Start(object sender, EventArgs e)
    {
        // Code that runs on application startup

    }

    void Application_End(object sender, EventArgs e)
    {
        //  Code that runs on application shutdown

    }

    void Application_Error(object sender, EventArgs e)
    {
        // Code that runs when an unhandled error occurs

    }

    void Session_Start(object sender, EventArgs e)
    {
        Session["TaskTable"]=new List<Book>();
        Session["Cart"] = new List<Book>();
    }

    void Session_End(object sender, EventArgs e)
    {
       Session.Clear();
    }

</script>
