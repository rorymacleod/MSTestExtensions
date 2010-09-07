using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestExtensions
{
    [Serializable]
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class ExtendedTestClassAttribute : TestClassExtensionAttribute
    {
        public override Uri ExtensionId
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override TestExtensionExecution GetExecution()
        {
            throw new NotImplementedException();
        }

    }
}
