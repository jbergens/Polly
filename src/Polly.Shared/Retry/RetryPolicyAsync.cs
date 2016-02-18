﻿#if SUPPORTS_ASYNC

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Polly.Retry
{
    public partial class RetryPolicy
    {
        internal RetryPolicy(Func<Func<CancellationToken, Task>, Context, CancellationToken, bool, Task> asyncExceptionPolicy, IEnumerable<ExceptionPredicate> exceptionPredicates)
           : base(asyncExceptionPolicy, exceptionPredicates)
        {
        }
    }
}

#endif