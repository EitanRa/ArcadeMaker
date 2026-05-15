using System;
using System.Collections.Generic;
using System.Text;

namespace ArcadeMaker.Core.Exceptions
{
    public class NoActivatedRoomException() : Exception("There is no currently activated room.");
}
