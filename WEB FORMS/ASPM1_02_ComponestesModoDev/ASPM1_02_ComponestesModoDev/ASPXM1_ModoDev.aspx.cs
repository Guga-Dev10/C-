using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPM1_02_ComponestesModoDev
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnInserir_Click(object sender, EventArgs e)
        {
            ListItem listItem = new ListItem(txtSite.Text, dlSite.Items.Count.ToString());
            dlSite.Items.Add(listItem);
            txtSite.Text = "";

            ListItem listItemEndereco = new ListItem(txtEndereço.Text, lbEndereco.Items.Count.ToString());
            lbEndereco.Items.Add(listItemEndereco);
            txtEndereço.Text = "";
        }

        protected void btnSelecionar_Click(object sender, EventArgs e)
        {
            ListItem listItemSite = dlSite.SelectedItem;
            txtSite.Text = listItemSite.Text;

            ListItem listItemEndereco = lbEndereco.SelectedItem;
            txtEndereço.Text = listItemEndereco.Text;
        }
    }
}