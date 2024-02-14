using System.Threading;
using System.Threading.Tasks;

namespace InstantMessaging.MessagingClients
{
    internal class ViberMessagingClient : InstantMessagingClient
    {
        private const string hostname = "www.viber.com";
        public ViberMessagingClient(UserCredintials credintials) : base(credintials)
        {

        }

        public override string ReceiveMessage()
        {
            CheckConnection(hostname);

            string message = ViberApi.GetNextMessage(userCredintials.UserName,userCredintials.Password);
            return message;
        }

        public override async Task<string> ReceiveMessageAsync(CancellationToken cancellationToken)
        {
            CheckConnection(hostname);

            string message = await ViberApi.GetNextMessageAsync(userCredintials.UserName,userCredintials.Password);
            return message;
        }

        public override Task SendMessage(string to, string message, CancellationToken cancellationToken)
        {
            CheckConnection(hostname);

            return new Task(() => ViberApi.SendMessage(to,
                                                       message,
                                                       userCredintials.UserName,
                                                       userCredintials.Password),
                            cancellationToken);
        }
    }
}