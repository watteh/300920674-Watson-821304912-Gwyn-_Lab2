using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _300920674_Watson_821304912_Gwyn__Lab2.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
