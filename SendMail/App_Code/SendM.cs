using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Net.Mail;
using System.Net;

/// <summary>
/// SendM 的摘要说明
/// </summary>
public class SendM
{
    public SendM()
    {
        //
        // TODO: 在此处添加构造函数逻辑
        //
    }

    public bool SendMessage(string mailto,string mailSubject,string mailContent)
    {
        string stmpSever = "smtp.qq.com";
        string mailfrom = "3088994117@qq.com";
        string mailfromPwd = "opfswhsazzipdggd";

        MailMessage message = new MailMessage();
        message.Subject = mailSubject;
        message.Body = mailContent;
        message.BodyEncoding = Encoding.UTF8;
        message.From =new MailAddress(mailfrom);
        message.To.Add(mailto);
        message.Priority = MailPriority.Normal;
        message.IsBodyHtml = true;

        SmtpClient client = new SmtpClient();
        client.Host = stmpSever;
        client.UseDefaultCredentials = false;
        client.Credentials= new NetworkCredential(mailfrom, mailfromPwd);
        client.DeliveryMethod = SmtpDeliveryMethod.Network;
        //client.Send(message);
        //return true;
        try
        {
            client.Send(message);
            return true;
        }
        catch
        {
            return false;
        }
    }
}