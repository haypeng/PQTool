using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PQToolBoxCore.Common
{
    public class AddToolEvent : PubSubEvent
    {

    }
    public class DeleteToolEvent : PubSubEvent<object>
    {

    }
    public class SelectToolEvent : PubSubEvent<ToolType>
    {

    }
}
