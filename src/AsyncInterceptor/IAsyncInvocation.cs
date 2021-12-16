// Copyright (c) 2020 stakx
// License available at https://github.com/stakx/DynamicProxy.AsyncInterceptor/blob/master/LICENSE.md.

using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;

namespace Castle.DynamicProxy
{
    public interface IAsyncInvocation
    {
        IReadOnlyList<object> Arguments { get; }
        MethodInfo Method { get; }
        MethodInfo MethodInvocationTarget { get; }
        object Result { get; set; }
        ValueTask ProceedAsync();
    }
}
