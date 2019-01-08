using NUnit.Framework;
using IoCContainer.Objects;

namespace IoCContainer.Tests
{
    [TestFixture]
    public class ContainerTests : Preconditions
    {
        [Test]
        public void Get_DependencyWithOneParameterConstructor_ReturnsObject()
        {
            // Arrange
            Container.Binde<IWeapon, Bow>();
                        
            // Act
            var res = (Warrior)Container.Get(typeof(Warrior));

            // Assert
            Assert.NotNull(res);
        }

        [Test]
        public void Get_DependencyWithZeroParameterConstructor_ReturnsObject()
        {
            // Arrange
            Container.Binde<IWeapon, Bow>();

            // Act
            var res = (Archer)Container.Get(typeof(Archer));

            // Assert
            Assert.NotNull(res);
        }

        [Test]
        public void Get_DependencyWithManyParametersConstructor_ReturnsObject()
        {
            // Arrange
            Container.Binde<IWeapon, Bow>();
            Container.Binde<IMagicObject, MagicScroll>();

            // Act
            var res = (Wizard)Container.Get(typeof(Wizard));

            // Assert
            Assert.NotNull(res);
        }
    }
}
