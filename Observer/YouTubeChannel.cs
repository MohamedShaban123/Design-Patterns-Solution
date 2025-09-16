using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    // Subject
    public class YouTubeChannel
    {

        public event  Action<string> Subscribers;
    
        
         public void  NotifySubscribers(string MessageToSubscribers)
        {
            Subscribers?.Invoke(MessageToSubscribers);
        }
    }
}
