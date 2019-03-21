using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FirstAppCore.Services
{
    public class DebugMailService : IMailService
    {
        public void SendMail(string to, string from, string subject, string body)
        {
            Debug.WriteLine($"Sending mail: To {to},from {from},with object {subject} and body {body}");
        }
    }
}
