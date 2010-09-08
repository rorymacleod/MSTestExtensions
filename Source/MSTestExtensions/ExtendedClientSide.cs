using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.Common;

namespace MSTestExtensions
{
    public class ExtendedClientSide : TestTypeExtensionClientSide
    {
        public override string ExtensionName
        {
            get
            {
                return "ExtendedUnitTest";
            }
        }
    }
}