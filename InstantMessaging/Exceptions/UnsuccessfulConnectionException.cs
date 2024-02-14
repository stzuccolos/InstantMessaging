using System;
using System.Net.NetworkInformation;

namespace InstantMessaging.Exceptions;
public class UnsuccessfulConnectionException : ConnectionException
{
    public UnsuccessfulConnectionException(IPStatus status) : base(status)
    {
    }

    public UnsuccessfulConnectionException(string? message) : base(message)
    {
    }

    public UnsuccessfulConnectionException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}