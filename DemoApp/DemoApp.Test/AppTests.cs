using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DemoApp.Test
{
    [TestClass]
    public class AppTests
    {
        [TestMethod]
        public void Items_Ordered() => Assert.IsTrue(MainWindow.Items.SequenceEqual(MainWindow.Items.OrderBy(x => x)));
    }
}
