using System;
using System.Runtime.Serialization;

namespace InstantMessaging.Exceptions
{
    public class HostNotConnectedException : Exception
    {
        public HostNotConnectedException()
        {
        }

        public HostNotConnectedException(string? message) : base(message)
        {
        }

        public HostNotConnectedException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}