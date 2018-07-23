using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SendMailMessage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SendM send = new SendM();
       if( send.SendMessage(txtmailTo.Text, txtmailSubject.Text, txtmailContent.Text))
        {
            Response.Write("<script>alert('发送成功!')</script>");
        }
        else
        {
            Response.Write("<script>alert('发送失败!')</script>");
        }
    }
}