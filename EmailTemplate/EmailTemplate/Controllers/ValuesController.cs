using EmailTemplate.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmailTemplate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly EmailService _emailService;

        public ValuesController(EmailService emailService)
        {
            _emailService = emailService;
        }

        [HttpPost]
        [Route("sendmail")]
        public IActionResult SendMail([FromBody] EmailRequest request)
        {
            bool result = _emailService.SendEmail(request.Email);
            if (result)
            {
                return Ok("Success");
            }
            return StatusCode(StatusCodes.Status500InternalServerError, "Failed to send email");
        }

    }
}
