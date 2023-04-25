using SimpleSendEmailAPI.Model;

namespace SimpleSendEmailAPI.Services
{
    public interface IEmailService
    {
        void SendEmail(EmailDto emailDto);
    }
}
