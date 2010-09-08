using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestExtensions.UnitTests.Base
{
    [TestClass]
    public abstract class TestClassExtensionAttributeTests
    {
        protected TestClassExtensionAttribute Instance;

        protected abstract TestClassExtensionAttribute CreateInstance();

        [TestInitialize]
        public virtual void TestInitialize()
        {
            Instance = CreateInstance();
        }

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void ExtensionIdReturnsNonNullUri()
        {
            Assert.IsNotNull(Instance.ExtensionId);
        }
    }
}