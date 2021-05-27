using System;
using System.Runtime.Serialization;

namespace CoinAPI.REST.V1.Exceptions
{
    public class UnauthorizedException : CoinApiException
    {
        public UnauthorizedException()
        {
        }

        public UnauthorizedException(string message) : base(message)
        {
        }

        public UnauthorizedException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}