using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolgrot.Core.Ankama.Protocol.Messages
{
    public class OnConnectionEventMessage : NetworkMessage
    {

	    public int eventType;


        public OnConnectionEventMessage()
        {
        }

        public OnConnectionEventMessage(int eventType)
        {
            this.eventType = eventType;

        }
    }
}