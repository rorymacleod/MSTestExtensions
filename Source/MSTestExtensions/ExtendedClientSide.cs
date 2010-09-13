using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.VisualStudio.TestTools.Common;

namespace MSTestExtensions
{
    public class ExtendedClientSide : TestTypeExtensionClientSide
    {
        private ITmi Tmi;

        public override string ExtensionName
        {
            get
            {
                return "ExtendedUnitTest";
            }
        }

        public override void Initialize(ITmi tmi)
        {
            Tmi = tmi;
        }
    }
}