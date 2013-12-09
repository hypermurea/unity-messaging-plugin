using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnityMessaging
{
    public class MessagingClient
    {
        private static MessagingClient clientInstance = new MessagingClient();

        public static MessagingClient Client {
            get {
                return clientInstance;
            }
        }

        public void SendMessage(string key, string value) {
            // do nothing
        }

    }
}
