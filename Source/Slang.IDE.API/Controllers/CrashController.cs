using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Slang.IDE.Domain.Entities.Common;
using System.Net;
using System.Net.Mail;

namespace Slang.IDE.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class CrashController : ControllerBase
    {
        public IActionResult CrashReport([FromBody] Crash crash)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            try
            {
                var mailMessage = new MailMessage();
                var smtpClient = new SmtpClient();

                mailMessage.From = new MailAddress("crashreport@slang.com", "Crash Report");
                mailMessage.To.Add(new MailAddress("dvlachopoulos@dvldev.com"));
                mailMessage.Subject = "Crash Report";
                mailMessage.Body = $"{crash.CreatedOn}{Environment.NewLine}Exception Error: {crash.ExceptionMessage}{Environment.NewLine}User's extra information: {crash.UserExtraInformation}";
                mailMessage.IsBodyHtml = true;

                smtpClient.Port = Convert.ToInt32(Properties.Resources.SmtpPort);
                smtpClient.Host = Properties.Resources.SmtpHost;
                smtpClient.EnableSsl = Convert.ToBoolean(Properties.Resources.SmtpSsl);
                smtpClient.UseDefaultCredentials = Convert.ToBoolean(Properties.Resources.SmtpDefaultCrendential);
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;

                if (!smtpClient.UseDefaultCredentials)
                {
                    smtpClient.Credentials = new NetworkCredential(Properties.Resources.SmtpUsername, Properties.Resources.SmtpPassword);
                }

                smtpClient.Send(mailMessage);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return Ok();
        }
    }
}
