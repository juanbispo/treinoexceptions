using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinamentoExceptions.Models.Exceptions
{
    internal class AccountException : ApplicationException
    {
        public AccountException(string message) : base(message)
        {
        }
    }
}
