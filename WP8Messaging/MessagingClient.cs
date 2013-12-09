using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace UnityMessaging {
    public class MessagingClient {
        private static MessagingClient clientInstance = new MessagingClient();

        public static MessagingClient Client {
            get {
                return clientInstance;
            }
        }

        public delegate void MessageReceived(string key, string value);
        public event MessageReceived NewMessageReceived;


        public void SendMessage(string key, string value) {
            if(NewMessageReceived != null) {
                NewMessageReceived(key, value);
            }
        }

    }
}
