using System;
using NUnit.Framework;
using todo;

namespace todo_tests
{
    // @todo #11 Akzeptanztests
    [TestFixture]
    public class MainController_tests
    {
        [Test]
        public void Run()
        {
            var sut = new MainController(new string[0]);
            sut.Run();
        }
    }
}