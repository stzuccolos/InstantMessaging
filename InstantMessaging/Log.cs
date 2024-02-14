using InstantMessaging.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstantMessaging
{
    internal static class Log
    {
        internal static void Error(string v) => throw new NotImplementedException();

        internal static void Error(string v, ConnectionException e) => throw new NotImplementedException();
    }
}
