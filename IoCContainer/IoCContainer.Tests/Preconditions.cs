using NUnit.Framework;

namespace IoCContainer.Tests
{
    [SetUpFixture]
    public abstract class Preconditions
    {
        public Container Container { get; private set; }

        [SetUp]
        public void SetUp()
        {
            Container = new Container();
        }

        [TearDown]
        public void TearDown()
        {

        }
    }
}
