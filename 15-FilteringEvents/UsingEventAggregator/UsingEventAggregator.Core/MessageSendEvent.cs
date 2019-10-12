using System;
using System.Collections.Generic;
using System.Text;
using Prism.Events;

namespace UsingEventAggregator.Core {
    public class MessageSendEvent : PubSubEvent<Message> {
    }
}
