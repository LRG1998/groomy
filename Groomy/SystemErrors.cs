using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Groomy
{
    internal class  IncorrectUsernamePassword: Exception
    {
        public string UserName { get; }
        public string Password { get; }
        

        public IncorrectUsernamePassword() { }
        public IncorrectUsernamePassword(string message) : base(message) { }

        public IncorrectUsernamePassword(string message, Exception inner) : base(message, inner) { }
        
    }
}
