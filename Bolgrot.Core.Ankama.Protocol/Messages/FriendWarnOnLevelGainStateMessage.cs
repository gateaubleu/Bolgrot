using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolgrot.Core.Ankama.Protocol.Messages
{
    public class FriendWarnOnLevelGainStateMessage : NetworkMessage
    {

	    public bool enable;


        public FriendWarnOnLevelGainStateMessage()
        {
        }

        public FriendWarnOnLevelGainStateMessage(bool enable)
        {
            this.enable = enable;

        }
    }
}