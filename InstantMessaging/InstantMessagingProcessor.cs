using InstantMessaging.Exceptions;
using InstantMessaging.MessagingClients;
using System.Threading.Tasks;

namespace InstantMessaging
{
    public class InstantMessagingProcessor
    {
        private readonly InstantMessagingClient messagingClient;

        public InstantMessagingProcessor(UserCredintials userCredintials,
                                         InstantMessagingClients messagingClient)
        {

            try
            {
                this.messagingClient = InstantMessagingClientFactory.Create(messagingClient, userCredintials);

            }
            catch (UndefinedClientException e)
            {
                Log.Error($"Undefined messaging client requested: {e.MessagingClient}", e);
                throw;
            }
        }

        public Task SendMessage(string to, string message)
        {
            try
            {
                var task = messagingClient.SendMessage(to, message);
                task.Start();
                return task;
            }
            catch (ConnectionException e)
            {
                Log.Error($"Error connecting to host. Reason: {e.PingStatus}", e);
                throw;
            }
        }

        public async Task<string> GetMessage()
        {
            try
            {
                return await messagingClient.ReceiveMessageAsync();
            }
            catch (ConnectionException e)
            {
                Log.Error($"Error connecting to host. Reason: {e.PingStatus}", e);
                throw;
            }
        }
    }
}
