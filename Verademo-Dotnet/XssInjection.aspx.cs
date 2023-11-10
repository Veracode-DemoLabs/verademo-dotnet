using System;

namespace Verademo_dotnet
{
    public partial class XssInjection : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["text"] != null)
            {

                //  When ran, the following parameter added to the querystring results in XSS.  
                // text=<script>alert(1);</script>
                Response.Write(Request.QueryString["text"]);

            }
        }
    }
}
