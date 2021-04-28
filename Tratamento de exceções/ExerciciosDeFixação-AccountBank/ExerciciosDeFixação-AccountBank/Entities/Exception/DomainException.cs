using System;

namespace AccountBank.Entities.Exception
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {
        }
    }
}
