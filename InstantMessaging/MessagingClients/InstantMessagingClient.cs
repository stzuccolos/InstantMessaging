using InstantMessaging.Exceptions;
using System;
using System.Net.NetworkInformation;
using System.Threading;
using System.Threading.Tasks;

namespace InstantMessaging.MessagingClients
{
    public abstract class InstantMessagingClient
    {
        protected UserCredintials userCredintials;
        protected InstantMessagingClient(UserCredintials userCredintials)
        {
            this.userCredintials = userCredintials;
        }

        protected static void CheckConnection(string hostname)
        {
            var ping = new Ping();
            var pong = ping.Send(hostname);

            if (!Enum.IsDefined(pong.Status))
                throw new UndefinedPingStatusException(pong.Status);

            if (pong.Status != IPStatus.Success)
                throw new UnsuccessfulConnectionException(pong.Status);
        }

        public Task SendMessage(string to, string message) => SendMessage(to, message, CancellationToken.None);
        public abstract Task SendMessage(string to, string message, CancellationToken cancellationToken);

        public abstract string ReceiveMessage();
        public async Task<string> ReceiveMessageAsync() => await ReceiveMessageAsync(CancellationToken.None);
        public abstract Task<string> ReceiveMessageAsync(CancellationToken cancellationToken);
    }
}