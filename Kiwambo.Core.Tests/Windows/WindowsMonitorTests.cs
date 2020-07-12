using Kiwambo.Core.Interfaces;
using Kiwambo.Core.Windows;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kiwambo.Core.Tests.Windows
{
    [TestFixture]
    public class WindowsMonitorTests
    {
        [Test]
        public void GetMonitors_ReturnsAvailableMonitor_GreaterZero()
        {

            IMonitor[] windowsMonitors = Monitor.GetMonitors();

            Assert.NotZero(windowsMonitors.Length);
        }
    }
}
