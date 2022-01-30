using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPM1_04_TabuadaModoDev
{
    public partial class Tabuada : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                for(int i = 0; i <= 10; i++)
                {
                    dlOperadores.Items.Add(i.ToString());
                }
            }
        }

        protected void btnExecutar_Click(object sender, EventArgs e)
        {
            lbOperacao.Items.Clear();
            ListItem listItem = dlOperadores.SelectedItem;
            int numeroTabuada = Convert.ToInt32(listItem.Value);
            int totalTabuada = 0;

            for(int i = 0; i <= 10; i++)
            {
                totalTabuada = numeroTabuada * i;
                lbOperacao.Items.Add(i.ToString() + " X " + numeroTabuada + " = " + totalTabuada);
            }
        }
    }
}