using System;
using System.Runtime.Serialization;

namespace CoinAPI.REST.V1.Exceptions
{
    public class ForbiddenException : CoinApiException
    {
        public ForbiddenException()
        {
        }

        public ForbiddenException(string message) : base(message)
        {
        }

        public ForbiddenException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}