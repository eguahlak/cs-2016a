using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_WEB_Forms_Application {
  public partial class About : Page {
    protected void Page_Load(object sender, EventArgs e) {
      if (IsPostBack) GreetingText.Text = "Hej "+GreetingText.Text;
      else GreetingText.Text = "Hello World!";
      }

    protected void OkButton_Command(object sender, CommandEventArgs e) {
      if (e.CommandName == "Opret")
        GreetingText.Text = "Halløjsa oprettet";

      else
        //  GreetingText.Text += " ikke oprettet";
        Response.Redirect("Contact.aspx");
      }
    }
  }