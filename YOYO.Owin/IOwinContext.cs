﻿using System.Collections.Generic;
using System.Threading;

namespace YOYO.Owin
{
    public interface IOwinContext
    {
        CancellationToken CancellationToken { get; }

        IDictionary<string, object> Environment { get; }

        string OwinVersion { get; }

        IOwinRequest Request { get; }

        IOwinResponse Response { get; }

    }
}
