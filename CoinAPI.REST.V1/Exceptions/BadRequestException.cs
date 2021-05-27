using System;
using System.Runtime.Serialization;

namespace CoinAPI.REST.V1.Exceptions
{
    public class BadRequestException : CoinApiException
    {
        public BadRequestException()
        {
        }

        public BadRequestException(string message) : base(message)
        {
        }

        public BadRequestException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}