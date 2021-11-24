using BrusAutomat;
using NUnit.Framework;

namespace TestBrusAutomat
{
    public class TestIsItRunning
    {
        [Test]
        public void TestIsRunning()
        {
            Checks.Running(true);
            Assert.True(Checks.IsRunning);
        }

        [Test]
        public void TestNotRunning()
        {
            Checks.Running(false);
            Assert.False(Checks.IsRunning);
        }
    }
}