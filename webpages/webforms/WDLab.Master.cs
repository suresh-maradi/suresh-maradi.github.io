using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace hometute.webpages.webforms
{
    public partial class WDLab : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           /*if (!string.IsNullOrEmpty(Session["indexchanged"] as string))              
            {
                drpdwnListofExperiments.SelectedIndex =Int16.Parse(Session["indexchanged"].ToString());
                lblExperimentName.Text = Session["Experiment"].ToString();
                
            }*/
        }

        protected void drpdwnListofExperiments_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedindex = drpdwnListofExperiments.SelectedIndex;

            switch (selectedindex)
            {
                case 1:
                    lblExperimentName.Text = "Write a JavaScript to design a simple calculator to perform the following operations:sum, product, difference and quotient.";
                    break;
                case 2:
                    lblExperimentName.Text = "Write a JavaScript that calculates the squares and cubes of the numbers from 0 to 10 and outputs HTML text that displays the resulting values in an HTML table format.";
                    break;
                case 3:
                    lblExperimentName.Text = "Write a JavaScript code that displays text “TEXT-GROWING” with increasing font size in the interval of 100ms in RED COLOR, when the font size reaches 50pt it displays “TEXT - SHRINKING” in BLUE color. Then the font size decreases to 5pt.";
                    break;
                case 4:
                    lblExperimentName.Text = "Develop and demonstrate a HTML5 file that includes JavaScript script that uses" +
"functions for the following problems:" + "<br/>" +
"a.Parameter: A string" + "<br/>" +
"b.Output: The position in the string of the left - most vowel" + "<br/>" +
"c.Parameter: A number" + "<br/>" +
"d.Output: The number with its digits in the reverse order";
                    break;
                case 5:
                    lblExperimentName.Text = "Design an XML document to store information about a student in an engineering"+
"college affiliated to VTU. The information must include USN, Name, and Name of"+
"the College, Branch, Year of Joining, and email id.Make up sample data for 3"+
"students.Create a CSS style sheet and use it to display the document.";
                    break;
                case 6:
                    lblExperimentName.Text = "Write a PHP program to keep track of the number of visitors visiting the web page"+
"and to display this count of visitors, with proper headings.";
                    break;
                case 7:
                    lblExperimentName.Text = "Write a PHP program to display a digital clock which displays the current time of the"+
"server.";
                    break;
                case 8: lblExperimentName.Text= "Write the PHP programs to do the following:"+
"a.Implement simple calculator operations." +
"b.Find the transpose of a matrix." +
"c.Multiplication of two matrices." +
"d.Addition of two matrices.";
                    break;
                case 9:
                    lblExperimentName.Text = "Write a PHP program named states.py that declares a variable states with value" +
"Mississippi Alabama Texas Massachusetts Kansas.write a PHP program that does" +
"the following:" +
                 "a.Search for a word in variable states that ends in xas.Store this word in element" +
                "0 of a list named statesList." +
                "b.Search for a word in states that begins with k and ends in s.Perform a caseinsensitive" +
               "comparison. [Note: Passing re.Ias a second parameter to method" +
               "compile performs a case -insensitive comparison.] Store this word in element1" +
                "of statesList." +
                "c.Search for a word in states that begins with M and ends in s.Store this" +
               "word in element 2 of the list." +
               "d.Search for a word in states that ends in a.Store this word in element 3 of the" +
              "list.";
                    break;

                case 10:
                    lblExperimentName.Text= "Write a PHP program to sort the student records which are stored in the database"+
"using selection sort.";
                    break;
                default: lblExperimentName.Text = "Select experiment";
                    break;
                

            }
            Session["indexchanged"] = drpdwnListofExperiments.SelectedIndex;
            Session["Experiment"] = lblExperimentName.Text.Trim();
            if(drpdwnListofExperiments.SelectedIndex!=0)
            Response.Redirect("~/webpages/Webexperiments/Theory/Theory"+drpdwnListofExperiments.SelectedIndex+".aspx");
        }

        protected void btntheory_Click(object sender, EventArgs e)
        {
            int indexselected = drpdwnListofExperiments.SelectedIndex;
            if (indexselected == 0)
                drpdwnListofExperiments.Focus();
            else
            Response.Redirect("~/webpages/Webexperiments/Theory/Theory"+indexselected+".aspx");
        }

        protected void btnprogram_Click(object sender, EventArgs e)
        {
            int indexselected = drpdwnListofExperiments.SelectedIndex;
            if (indexselected == 0)
                drpdwnListofExperiments.Focus();
            else
                Response.Redirect("~/webpages/Webexperiments/codedtext/Expcode"+indexselected+".aspx");
        }

        protected void btnviva_Click(object sender, EventArgs e)
        {
            int indexselected = drpdwnListofExperiments.SelectedIndex;
            if (indexselected == 0)
                drpdwnListofExperiments.Focus();
            else
                Response.Redirect("~/webpages/Webexperiments/Viva/viva" + indexselected + ".aspx");

        }
    }
}