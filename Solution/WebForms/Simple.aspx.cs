using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms
{
    public partial class Simple : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            LogEvent("Page_Init");
        }

        protected void btnTest_Click(object sender, EventArgs e)
        {
            LogEvent("btnTest_Click");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            LogEvent("Page_Load");
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            LogEvent("Page_PreRender");
        }

        protected void Page_Unload(object sender, EventArgs e)
        {
            LogEvent("Page_Unload");
        }

        private void LogEvent(string eventName)
        {
            litLogger.Text += string.Format("<p>{0}</p>", eventName);
        }
    }
}