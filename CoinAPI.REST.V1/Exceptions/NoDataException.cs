using System;
using System.Runtime.Serialization;

namespace CoinAPI.REST.V1.Exceptions
{
    public class NoDataException : CoinApiException
    {
        public NoDataException()
        {
        }

        public NoDataException(string message) : base(message)
        {
        }

        public NoDataException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}