using AssemblyBrowserLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Test_4._7._2
{
    [TestClass]
    public class UnitTest1
    {
        private const string value = "C:\\Users\\kiril\\OneDrive\\Рабочий стол\\Учеба\\3 курс\\СПП\\lab3\\TestLibrary\\bin\\Debug\\TestLibrary.dll";

        [TestMethod]
        public void TestMethod1()
        {
            AssemblyBrowser assemblyBrowser = new AssemblyBrowser();
            List<ContainerInfo> container = new List<ContainerInfo>(assemblyBrowser.GetNamespaces(value));
            Assert.IsTrue(container[0].DeclarationName.Equals("TestLibrary") && container[1].DeclarationName.Equals("TestLibrary.Extension"));
        }
    }
}
