using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASM1_ModoDev
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnExecutar_Click(object sender, EventArgs e)
        {
            if (txtMsg.Text.Equals(""))
            {
                lMsg.Text = "Alô Mundo - O WebForms não devia ter caixa de ferramentas";
            }
            else
            {
                lMsg.Text = txtMsg.Text;
            }
        }
    }
}