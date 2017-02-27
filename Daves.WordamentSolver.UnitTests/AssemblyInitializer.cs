﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Daves.WordamentSolver.UnitTests
{
    [TestClass]
    public static class AssemblyInitializer
    {
        [AssemblyInitialize]
        public static void InitializeAssembly(TestContext context)
        {
            Solution.SetDictionary(File.ReadLines(@"TWL06Dictionary.txt"));
        }
    }
}