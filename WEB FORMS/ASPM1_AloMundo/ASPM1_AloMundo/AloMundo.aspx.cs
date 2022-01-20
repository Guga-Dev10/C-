using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPM1_AloMundo
{
    public partial class AloMundo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnExecutar_Click(object sender, EventArgs e)
        {
            if (txtMsg.Text.Equals(""))
            {
                /*
                 *  Se o TextBox Mensagem (txtMsg) for igual a vazio o c# irá chamar o Label Mensagem e irá executar o comando abaixo com um texto
                 */
                Lmsg.Text = "Aula 1 - Alô Mundo";
            }
            else
            {
                /*
                 *  Se o txtMsg não estiver vazio, o C# irá exibir no lmsg o que o usuário digitar usando a linha de comando abaixo
                 */
                Lmsg.Text = txtMsg.Text;
            }
        }
    }
}