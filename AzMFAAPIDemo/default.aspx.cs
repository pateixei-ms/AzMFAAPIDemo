using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AzMFAAPIDemo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            PfAuthParams pfAuthParams = new PfAuthParams();
            pfAuthParams.Phone = txtPhone.Text;
            pfAuthParams.Mode = pf_auth.MODE_SMS_ONE_WAY_OTP;
            pfAuthParams.SmsText = "Digite o código <$otp$> para ter acesso ao sistema.";
            pfAuthParams.CertFilePath = Server.MapPath(".//pf//certs//cert_key.p12");

            string otp;
            int callStatus, errorId;

            // o parâmetro "otp" contém a chave de acesso gerada pelo sistema e enviada para o telefone destino
            bool res = pf_auth.pf_authenticate(pfAuthParams, out otp, out callStatus, out errorId);

            // o código de status 'callStatus == 20' indica que o SMS foi enviado com sucesso
            if (callStatus == 20)
            {
                // guardar o código no SessionState para validar no próximo campo
                Session["otp"] = otp;
                Label1.Text = "SMS enviado com sucesso!";
            }
            else Label1.Text = "SMS não enviado - código de status: " + callStatus.ToString(); 
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Label1.Text = "";
            // obter o código digitado pelo usuário e comparar com o guardado no SessionState
            if (txtCodigo.Text == Session["otp"].ToString())
            {
                LabelResultado.Text = "Autenticação com sucesso! OTP = '" + Session["otp"] + "'";
            } else {
                LabelResultado.Text = "Falha na autenticação: OTP != '" + txtCodigo.Text + "'. Gere um novo código de acesso!" ;
            }
            txtCodigo.Text = "";
            Session["otp"] = "";
            
        }

    }
}