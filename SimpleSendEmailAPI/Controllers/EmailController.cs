using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MimeKit.Text;
using Org.BouncyCastle.Asn1.Ocsp;
using SimpleSendEmailAPI.Model;
using SimpleSendEmailAPI.Services;

namespace SimpleSendEmailAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IEmailService _emailService;

        public EmailController(IEmailService emailService)
        {
            _emailService = emailService;
        }
        [HttpPost]
        public bool SendEmail(EmailDto emailDto)
        {
            _emailService.SendEmail(emailDto);
            return true;
        } 
    }
}
