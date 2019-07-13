using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sisso.DAL
{
    public class MyExecutionStrategy : ExecutionStrategy
    {
        public MyExecutionStrategy(SissoContext context) : this(context, DefaultMaxRetryCount, DefaultMaxDelay)
        {
        }

        public MyExecutionStrategy(SissoContext context, int maxRetryCount, TimeSpan maxRetryDelay) : base(context, maxRetryCount, maxRetryDelay)
        {
        }

        public MyExecutionStrategy(ExecutionStrategyDependencies dependencies) : this(dependencies, DefaultMaxRetryCount, DefaultMaxDelay)
        {
        }

        public MyExecutionStrategy(ExecutionStrategyDependencies dependencies, int maxRetryCount, TimeSpan maxRetryDelay) : base(dependencies, maxRetryCount, maxRetryDelay)
        {
        }

        protected override bool ShouldRetryOn(Exception exception)
        {
            return true;
        }
    }
}
