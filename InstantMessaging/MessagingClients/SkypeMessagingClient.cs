using System.Threading;
using System.Threading.Tasks;

namespace InstantMessaging.MessagingClients
{
    public class SkypeMessagingClient : InstantMessagingClient
    {
        private readonly string hostname = "www.skype.com";
        public SkypeMessagingClient(UserCredintials credintials) : base(credintials)
        {
        }

        public override string ReceiveMessage()
        {
            CheckConnection(hostname);

            string message = SkypeApi.GetNextMessage(userCredintials.UserName,userCredintials.Password);
            return message;
        }

        public override async Task<string> ReceiveMessageAsync(CancellationToken cancellationToken)
        {
            CheckConnection(hostname);

            string message = await SkypeApi.GetNextMessageAsync(userCredintials.UserName,userCredintials.Password);
            return message;
        }

        public override Task SendMessage(string to, string message, CancellationToken cancellationToken)
        {
            CheckConnection(hostname);

            return Task.Run(() =>
                    SkypeApi.SendMessage(to,
                                         message,
                                         userCredintials.UserName,
                                         userCredintials.Password),
                    cancellationToken);
        }
    }
}
