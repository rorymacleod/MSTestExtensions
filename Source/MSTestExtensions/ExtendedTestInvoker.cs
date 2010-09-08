using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestExtensions
{
    public class ExtendedTestInvoker : ITestMethodInvoker
    {
        private readonly TestMethodInvokerContext Context;

        public ExtendedTestInvoker(TestMethodInvokerContext context)
        {
            Context = context;
        }

        public TestMethodInvokerResult Invoke(params object[] parameters)
        {
            return Context.InnerInvoker.Invoke(parameters);
        }
    }
}