using System;
using System.Runtime.Serialization;

namespace CoinAPI.REST.V1.Exceptions
{
    public class CoinApiException : Exception
    {
        public CoinApiException()
        {
        }

        public CoinApiException(string message) : base(message)
        {
        }

        public CoinApiException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}