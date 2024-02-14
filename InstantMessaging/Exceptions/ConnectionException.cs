using System;
using System.Net.NetworkInformation;

namespace InstantMessaging.Exceptions;

public class ConnectionException : Exception
{
    public ConnectionException(IPStatus pingStatus)
    {
        PingStatus = pingStatus;
    }

    public ConnectionException(string? message) : base(message)
    {
    }

    public ConnectionException(string? message,Exception? innerException) : base(message,innerException)
    {
    }

    public IPStatus PingStatus { get; }
}