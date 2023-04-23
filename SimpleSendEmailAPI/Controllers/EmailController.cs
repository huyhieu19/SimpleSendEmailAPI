using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MimeKit.Text;

namespace SimpleSendEmailAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        [HttpPost]
        public IActionResult SendEmail(string body)
        {
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse("davon.lowe@ethereal.email"));
            email.To.Add(MailboxAddress.Parse("davon.lowe@ethereal.email"));
            email.Subject = "abc";
            email.Body = new TextPart(TextFormat.Html) { Text = body };
            using var smtp = new SmtpClient();

            smtp.Connect("smtp.ethereal.email", 587, MailKit.Security.SecureSocketOptions.StartTls);
            smtp.Authenticate("davon.lowe@ethereal.email", "yfres2mGDJdsTsaFBB");
            smtp.Send(email);
            smtp.Disconnect(true);
            return Ok("send email succeed");


        }
    }
}
