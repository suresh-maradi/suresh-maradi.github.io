using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace hometute.webpages.Webexperiments.codedtext
{
    public partial class Expcode5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownList drpdwnListofExperiments = (DropDownList)Page.Master.FindControl("drpdwnListofExperiments");
                Label lblExperimentName = (Label)Page.Master.FindControl("lblExperimentName");

                drpdwnListofExperiments.SelectedIndex = Int16.Parse(Session["indexchanged"].ToString());
                lblExperimentName.Text = Session["Experiment"].ToString();
            }
        }
    }
}