using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Page_PreInit(object sender, EventArgs e)
        {
            if ((string)Session["Theme"] != null)
            {
                Page.Theme = (string)Session["Theme"];
                if (RBThemeBlue.Text == (string)Session["Theme"])
                    RBThemeBlue.Checked = true;
                else
                    RBThemeRed.Checked = true;
            }
            else
            {
                if (RBThemeRed.Checked)
                    Session["Theme"] = RBThemeBlue.Text;
                else
                    Session["Theme"] = RBThemeRed.Text;
                Page.Theme = "Blue";
            }

            CBLWeekend.Items.Add("Mon");
            CBLWeekend.Items.Add("Thu");
            CBLWeekend.Items.Add("Wed");
            CBLWeekend.Items.Add("Thu");
            CBLWeekend.Items.Add("Fri");
            CBLWeekend.Items.Add("Sat");
            CBLWeekend.Items.Add("Sun");
            foreach (ListItem li in CBLWeekend.Items)
                if (li.Text == "Sat" || li.Text == "Sun")
                    li.Selected = true;

            LBProducts.Items.Add("Potato");
            LBProducts.Items.Add("Tomato");
            LBProducts.Items.Add("Cabbage");
            LBProducts.Items.Add("Corn");
            LBProducts.Items.Add("Onion");
            LBProducts.Items.Add("Radish");
            LBProducts.Items.Add("Cucumber");
        }

        protected void ChangeTheme(object sender, EventArgs e)
        {
            if (RBThemeBlue.Checked)
                Session["Theme"] = "Blue";
            else
                Session["Theme"] = "Red";
            Server.Transfer(Request.FilePath);
        }

        protected void AddProducts(object sender, EventArgs e)
        {
            int[] indexes = LBProducts.GetSelectedIndices();
            for (int index = 0; index < indexes.Length; index++)
            {
                string str = LBProducts.Items[indexes[index] - index].ToString();
                ListItem item = new ListItem(str);
                LBProducts.Items.Remove(item);
                LBCart.Items.Add(item);
            }
        }

        protected void RemoveProducts(object sender, EventArgs e)
        {
            int[] indexes = LBCart.GetSelectedIndices();
            for (int index = 0; index < indexes.Length; index++)
            {
                string str = LBCart.Items[indexes[index] - index].ToString();
                ListItem item = new ListItem(str);
                LBCart.Items.Remove(item);
                LBProducts.Items.Add(item);
            }
        }

        protected void AddAllProducts(object sender, EventArgs e)
        {
            for (int index = 0; index < LBProducts.Items.Count; index++)
            {
                string str = LBProducts.Items[index].ToString();
                ListItem item = new ListItem(str);
                LBCart.Items.Add(item);
            }
            LBProducts.Items.Clear();
        }

        protected void RemoveAllProducts(object sender, EventArgs e)
        {
            for (int index = 0; index < LBCart.Items.Count; index++)
            {
                string str = LBCart.Items[index].ToString();
                ListItem item = new ListItem(str);
                LBProducts.Items.Add(item);
            }
            LBCart.Items.Clear();
        }
    }
}