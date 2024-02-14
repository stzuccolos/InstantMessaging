using System;
using System.Net.NetworkInformation;
using System.Runtime.Serialization;

namespace InstantMessaging.Exceptions
{
    public class UndefinedPingStatusException : ConnectionException
    {
        public UndefinedPingStatusException(IPStatus status) : base(status)
        {
        }

        public UndefinedPingStatusException(string? message) : base(message)
        {
        }

        public UndefinedPingStatusException(string? message,Exception? innerException) : base(message,innerException)
        {
        }

        public IPStatus Status { get; }
    }
}