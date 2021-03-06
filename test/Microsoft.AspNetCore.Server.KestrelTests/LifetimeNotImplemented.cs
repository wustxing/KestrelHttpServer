// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Threading;
using Microsoft.AspNetCore.Hosting;

namespace Microsoft.AspNetCore.Server.KestrelTests
{
    public class LifetimeNotImplemented : IApplicationLifetime
    {
        public CancellationToken ApplicationStarted
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public CancellationToken ApplicationStopped
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public CancellationToken ApplicationStopping
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void StopApplication()
        {
            throw new NotImplementedException();
        }
    }
}
