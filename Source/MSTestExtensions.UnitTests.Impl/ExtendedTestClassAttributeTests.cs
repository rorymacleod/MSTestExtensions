using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTestExtensions.UnitTests.Base;

namespace MSTestExtensions.UnitTests.Impl
{
    [ExtendedTestClass]
    public class ExtendedTestClassAttributeTests : TestClassExtensionAttributeTests
    {
        protected override TestClassExtensionAttribute CreateInstance()
        {
            return (ExtendedTestClassAttribute)Attribute.GetCustomAttribute(typeof(ExtendedTestClassAttributeTests),
                typeof(ExtendedTestClassAttribute));
        }

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void ExtensionUriReturnsExpectedValue()
        {
            Assert.AreEqual("urn:MSTestExtensions", Instance.ExtensionId.ToString());
        }
    }
}