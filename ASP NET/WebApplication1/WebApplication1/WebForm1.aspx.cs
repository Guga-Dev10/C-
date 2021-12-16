using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Executar_Click(object sender, EventArgs e)
        {
            if (txtMSG.Text.Equals(""))
            {
                /* Caso a caixa de mensagem esteja vazia 
                 * retornar a frase abaixo!
                 */
                Lmsg.Text = "Alô mundo!";
            }
            else
            {
                /*  
                 *  caso a caixa de mensagem esteja preenchida
                 *  Retornar valor da caixa de mensagem
                */
                Lmsg.Text = txtMSG.Text;
            }
        }
    }
}