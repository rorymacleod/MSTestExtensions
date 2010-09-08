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
        private const string ExtensionUriString = "urn:MSTestExtensions";

        public override Uri ExtensionId
        {
            get
            {
                return new Uri(ExtensionUriString);
            }
        }

        public override TestExtensionExecution GetExecution()
        {
            return new ExtendedExecution();
        }
    }
}
