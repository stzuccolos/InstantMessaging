using InstantMessaging.Exceptions;

namespace InstantMessaging.MessagingClients
{
    public static class InstantMessagingClientFactory
    {
        public static InstantMessagingClient Create(InstantMessagingClients messagingClient, UserCredintials userCredintials)
        {
            return messagingClient switch
            {
                InstantMessagingClients.Skype => new SkypeMessagingClient(userCredintials),
                InstantMessagingClients.Viber => new ViberMessagingClient(userCredintials),
                _ => throw new UndefinedClientException(),
            };
        }
    }
}