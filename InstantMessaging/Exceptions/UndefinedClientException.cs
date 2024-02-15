using InstantMessaging.MessagingClients;
using System;
using System.Runtime.Serialization;

namespace InstantMessaging.Exceptions
{
    public class UndefinedClientException : Exception
    {
        public UndefinedClientException()
        {
        }

        public UndefinedClientException(string? message) : base(message)
        {
        }

        public UndefinedClientException(InstantMessagingClients messagingClient)
        {
            MessagingClient = messagingClient;
        }

        public UndefinedClientException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        public InstantMessagingClients MessagingClient { get; }
    }
}