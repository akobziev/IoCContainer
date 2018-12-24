using System;
using NUnit.Framework;
using IoCContainer;
using IoCContainer.Test;

namespace IoCContainer.Tests
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void Get_DependencyWithOneParameterConstructor_ReturnsObject()
        {
            // Arrange
            var container = new Container();
            container.Binde<IWeapon, Bow>();

            // Act
            var res = (Warrior)container.Get(typeof(Warrior));

            // Assert
            Assert.NotNull(res);
        }
    }
}
