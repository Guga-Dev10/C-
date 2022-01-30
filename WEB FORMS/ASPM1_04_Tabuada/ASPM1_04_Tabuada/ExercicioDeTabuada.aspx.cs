using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPM1_04_Tabuada
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //Inserindo números da tabuada
                for (int i = 0; i <= 10; i++)
                {
                    dlNumeros.Items.Add(i.ToString());
                }
            }
        }

        protected void btnExecutar_Click(object sender, EventArgs e)
        {
            //Limpando dados do ListBox

            lbResultados.Items.Clear();

            ListItem listItem = dlNumeros.SelectedItem;
            int numero = Convert.ToInt32(listItem.Value);
            int total = 0;
            for (int i = 0; i <= 10; i++)
            {
                total = i * numero;
                lbResultados.Items.Add(i.ToString() + " X " + numero + " = " + total);
            }
        }
    }
}