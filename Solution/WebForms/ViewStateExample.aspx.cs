using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms
{
    public partial class ViewStateExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PopulateDropDown();
            }
        }

        protected void MyList_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyList.Items.Add("NEW ITEM");
        }

        private void PopulateDropDown()
        {
            MyList.Items.Add("One");
            MyList.Items.Add("Two");
            MyList.Items.Add("Three");
            MyList.Items.Add("Four");
            MyList.Items.Add("Five");
        }
    }
}