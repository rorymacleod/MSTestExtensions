using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestExtensions
{
    public class ExtendedExecution : TestExtensionExecution
    {
        public override void Initialize(TestExecution execution)
        {
            execution.AfterAssemblyInitialize += AssemblyInitialize;
        }

        private void AssemblyInitialize(object sender, AfterAssemblyInitializeEventArgs e)
        {
            
        }

        public override ITestMethodInvoker CreateTestMethodInvoker(TestMethodInvokerContext context)
        {
            return new ExtendedTestInvoker(context);
        }

        public override void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}