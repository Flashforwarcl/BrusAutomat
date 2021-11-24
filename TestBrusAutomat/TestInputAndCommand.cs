using BrusAutomat;
using NUnit.Framework;

namespace TestBrusAutomat
{
    class TestInputAndCommand
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void TestInputCommandResponse()
        {
            HandleInput.Input = "Any input that is not an correct Input";
            HandleInput.SetResponse();
            Assert.That(actual: HandleInput.Response, Is.EqualTo(HandleInput.UnknownCommand()).NoClip);
        }
        [Test]
        public void TestInputUnknown()
        {
            HandleInput.Input = "";
            HandleInput.SetResponse();
            Assert.That(actual: HandleInput.Response, Is.EqualTo(HandleInput.UnknownCommand()).NoClip);
        }
        [Test]
        public void TestInputHelp()
        {
            HandleInput.Input = "Help";
            HandleInput.SetResponse();
            Assert.That(actual: HandleInput.Response, Is.EqualTo(HandleInput.Help()).NoClip);
        }
        [Test]
        public void TestInputList()
        {
            HandleInput.Input = "list";
            HandleInput.SetResponse();
            Assert.That(actual: HandleInput.Response, Is.EqualTo(HandleInput.list()).NoClip);
        }
        [Test]
        public void TestInputClear()
        {
            HandleInput.Input = "clear";
            HandleInput.SetResponse();


        }
    }
}

