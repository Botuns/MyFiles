using System.Threading.Tasks;

namespace BotunsEntities.MailServices
{
    public interface IEmailSender
    {
        Task<bool> SendEmail(EmailRequestModel email);
    }
}
