using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPM1_02_Componentes
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInserir_Click(object sender, EventArgs e)
        {
            // Ações do DropdownList

            // O listItem captura o que o usuário digitar no textbox txtSite e ao mesmo tempo faz uma contagem dos itens no dlSite
            // dlSite = dropdownlist
            ListItem items = new ListItem(txtSite.Text, dlSite.Items.Count.ToString());
            //inserindo dados no DropDownList
            dlSite.Items.Add(items);
            // limpando o txtSite
            txtSite.Text = "";

            // Ações do ListBox

            ListItem itemsListBox = new ListItem(txtEndereco.Text, dlSite.Items.Count.ToString());
            // Inserindo dados no ListBox
            lbEndereco.Items.Add(itemsListBox);
            txtEndereco.Text = "";
        }

        protected void btnSelecionar_Click(object sender, EventArgs e)
        {
            /* o Listitem foi adicionado para que o valor text fosse encontrado ao invés do value
             */

            ListItem itemSite = dlSite.SelectedItem;
            // txtSite.Text = itemSite.Value; seleciona o Value da variável
            txtSite.Text = itemSite.Text;

            ListItem itemEndereco = lbEndereco.SelectedItem;
            txtEndereco.Text = itemEndereco.Text;
        }
    }
}