using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace hometute.webpages.Webexperiments.output
{
    public partial class Exp1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtbxresult.Text = "0";
        }

        protected void btnBackspace_Click(object sender, EventArgs e)
        {
            if (txtbxresult.Text != "0")
            {
                txtbxresult.Text = txtbxresult.Text.Remove(txtbxresult.Text.Length - 1, 1);
            }
        }

        protected void BtnModulus_Click(object sender, EventArgs e)
        {
            if (!txtbxresult.Text.Equals("0"))
                               txtbxresult.Text += "%";

            int length = txtbxresult.Text.Length;
            string orgstring = txtbxresult.Text.Trim();
            string part1;
            if (txtbxresult.Text.Contains("%") || txtbxresult.Text.Contains("+") || txtbxresult.Text.Contains("X") || txtbxresult.Text.Contains("-") || txtbxresult.Text.Contains("/"))
            {
                for (int i = 0; i < txtbxresult.Text.Length; i++)
                {
                    
                }
            }
        }

        protected void BtnDevide_Click(object sender, EventArgs e)
        {

        }

        protected void btnseven_Click(object sender, EventArgs e)
        {
            if (txtbxresult.Text.Equals("0"))
            txtbxresult.Text = "7";
            else
            txtbxresult.Text += "7";
        }

        protected void btneight_Click(object sender, EventArgs e)
        {
            if (txtbxresult.Text.Equals("0"))
                txtbxresult.Text = "8";
            else
                txtbxresult.Text += "8";
        }

        protected void btnnine_Click(object sender, EventArgs e)
        {
            if (txtbxresult.Text.Equals("0"))
                txtbxresult.Text = "9";
            else
                txtbxresult.Text += "9";
        }

        protected void btntimes_Click(object sender, EventArgs e)
        {

        }

        protected void btnone_Click(object sender, EventArgs e)
        {
            if (txtbxresult.Text.Equals("0"))
                txtbxresult.Text = "1";
            else
                txtbxresult.Text += "1";
        }

        protected void btntwo_Click(object sender, EventArgs e)
        {
            if (txtbxresult.Text.Equals("0"))
                txtbxresult.Text = "2";
            else
                txtbxresult.Text += "2";
        }

        protected void btnthree_Click(object sender, EventArgs e)
        {
            if (txtbxresult.Text.Equals("0"))
                txtbxresult.Text = "3";
            else
                txtbxresult.Text += "3";
        }

        protected void btnaddition_Click(object sender, EventArgs e)
        {

        }

        protected void btndummy_Click(object sender, EventArgs e)
        {

        }

        protected void btnzero_Click(object sender, EventArgs e)
        {
            if (!txtbxresult.Text.Equals("0"))
                               txtbxresult.Text += "0";
        }

        protected void btnpoint_Click(object sender, EventArgs e)
        {
            if (txtbxresult.Text.Equals("0") || !txtbxresult.Text.Contains("."))
                               txtbxresult.Text += ".";
        }

        protected void btnassign_Click(object sender, EventArgs e)
        {

        }

        protected void btnfour_Click(object sender, EventArgs e)
        {
            if (txtbxresult.Text.Equals("0"))
                txtbxresult.Text = "4";
            else
                txtbxresult.Text += "4";
        }

        protected void btnfive_Click(object sender, EventArgs e)
        {
            if (txtbxresult.Text.Equals("0"))
                txtbxresult.Text = "5";
            else
                txtbxresult.Text += "5";
        }

        protected void btnsix_Click(object sender, EventArgs e)
        {
            if (txtbxresult.Text.Equals("0"))
                txtbxresult.Text = "6";
            else
                txtbxresult.Text += "6";
        }

        protected void btnsubstract_Click(object sender, EventArgs e)
        {

        }
    }
}