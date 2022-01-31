using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPM1_05_PropDropList
{
    public partial class NovasPropriedades : System.Web.UI.Page
    {
        // Explorando novas propriedades do DropDownList e ListBox
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnInserirDados_Click(object sender, EventArgs e)
        {
            ListItem listItem = new ListItem(txtNomeSite.Text, dlDadosSite.Items.Count.ToString());
            dlDadosSite.Items.Add(listItem);
            txtNomeSite.Text = "";

            ListItem listItemEndereco = new ListItem(txtEderecoSite.Text, lbDadosEnderecoSite.Items.Count.ToString());
            lbDadosEnderecoSite.Items.Add(listItemEndereco);
            txtEderecoSite.Text = "";
        }

        protected void btnSelecionarItemSite_Click(object sender, EventArgs e)
        {
            ListItem listItemDadosSite = dlDadosSite.SelectedItem;
            txtNomeSite.Text = listItemDadosSite.Text;

            ListItem listItemEnderecosSite = lbDadosEnderecoSite.SelectedItem;
            txtEderecoSite.Text = listItemEnderecosSite.Text;
        }
    }
}