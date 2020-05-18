using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
using System;

namespace VendasWebMVC.Services.Exceptions
{
    public class IntegrityException : ApplicationException
    {
        public IntegrityException(string message) : base(message)
        {
        }
    }
}
