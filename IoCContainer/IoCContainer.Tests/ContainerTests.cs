using NUnit.Framework;
using IoCContainer.Objects;
using System;

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
        public void Get_DependencyWithOneParameterConstructor_PropertyNotNull()
        {
            // Arrange
            Container.Binde<IWeapon, Bow>();

            // Act
            var res = (Warrior)Container.Get(typeof(Warrior));

            // Assert
            Assert.NotNull(res.Weapon);
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
        public void Get_DependencyWithZeroParameterConstructor_PropertyNotNull()
        {
            // Arrange
            Container.Binde<IWeapon, Bow>();

            // Act
            var res = (Archer)Container.Get(typeof(Archer));

            // Assert
            Assert.NotNull(res.Weapon);
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

        [Test]
        public void Get_DependencyWithManyParametersConstructor_PropertyNotNull()
        {
            // Arrange
            Container.Binde<IWeapon, Bow>();
            Container.Binde<IMagicObject, MagicScroll>();

            // Act
            var res = (Wizard)Container.Get(typeof(Wizard));

            // Assert
            Assert.NotNull(res.Weapon);
        }

        [Test]
        public void Get_RegistrationInterfaceToDelegate_ReturnsObject()
        {
            // Arrange
            Container.Binde<IWeapon>(() => { return new Bow(); });

            // Act
            var res = (Warrior)Container.Get(typeof(Warrior));

            // Assert
            Assert.NotNull(res);
        }

        [Test]
        public void Get_RegistrationInterfaceToDelegate_PropertyNotNull()
        {
            // Arrange
            Container.Binde<IWeapon>(() => { return new Bow(); });

            // Act
            var res = (Warrior)Container.Get(typeof(Warrior));

            // Assert
            Assert.NotNull(res.Weapon);
        }

        [Test]
        public void Get_RegistrationWithSigleton_ReturnsObject()
        {
            // Arrange
            Container.BindeSingleton<IWeapon>(new Sward());

            // Act
            var res = (Warrior)Container.Get(typeof(Warrior));

            // Assert
            Assert.NotNull(res);
        }

        [Test]
        public void Get_RegistrationWithSigleton_PropertyNotNull()
        {
            // Arrange
            Container.BindeSingleton<IWeapon>(new Sward());

            // Act
            var res = (Warrior)Container.Get(typeof(Warrior));

            // Assert
            Assert.NotNull(res.Weapon);
        }

        [Test]
        public void Get_RegistrationWithSigletonToDelegate_ReturnsObject()
        {
            // Arrange
            Container.BindeSingleton<IWeapon>(() => { return new Bow(); });

            // Act
            var res = (Warrior)Container.Get(typeof(Warrior));

            // Assert
            Assert.NotNull(res);
        }

        [Test]
        public void Get_RegistrationWithSigletonToDelegate_PropertyNotNull()
        {
            // Arrange
            Container.BindeSingleton<IWeapon>(() => { return new Bow(); });

            // Act
            var res = (Warrior)Container.Get(typeof(Warrior));

            // Assert
            Assert.NotNull(res.Weapon);
        }

        [Test]
        public void Get_AbstractClass_ThrowsAnException()
        {
            // Arrange
            Container.Binde<IWeapon, Sward>();

            // Assert
            Assert.Throws<InvalidOperationException>(() => Container.Get(typeof(Thief)));
        }

        [Test]
        public void Get_GetInstanceOfClassWithoutRegistration_ReturnsObject()
        {
            // Act
            var res = (Archer)Container.Get(typeof(Archer));

            // Assert
            Assert.NotNull(res);
        }

        [Test]
        public void Get_GetInstanceOfClassWithoutRegistration_PropertyNotNull()
        {
            // Act
            var res = (Archer)Container.Get(typeof(Archer));

            // Assert
            Assert.NotNull(res.Weapon);
        }

        [Test]
        public void Get_DependencyHasNotBeenRegistered_ThrowsAnException()
        {
            // Act
            var res = (Archer)Container.Get(typeof(Archer));

            // Assert
            Assert.Throws<InvalidOperationException>(() => Container.Get(typeof(Thief)));
        }

        [Test]
        public void Binde_BindeInterfaceToRelevantImplementation_RegListHasDependency()
        {
            // Act
            Container.Binde<IWeapon, Bow>();

            // Assert
            Assert.IsTrue(Container.reg.Count.Equals(1));
        }

        [Test]
        public void Binde_BindeInterfaceToDelegate_RegListHasDependency()
        {
            // Act
            Container.BindeSingleton<IWeapon>(() => { return new Bow(); });

            // Assert
            Assert.IsTrue(Container.reg.Count.Equals(1));
        }
        
        [Test]
        public void BindeSingletone_BindeInterfaceToRelevantImplementation_RegListHasDependency()
        {
            // Act
            Container.BindeSingleton<IWeapon>(new Bow());

            // Assert
            Assert.IsTrue(Container.reg.Count.Equals(1));
        }

        [Test]
        public void BindeSingletone_BindeInterfaceToDelegate_RegListHasDependency()
        {
            // Act
            Container.BindeSingleton<IWeapon>(() => { return new Bow(); });

            // Assert
            Assert.IsTrue(Container.reg.Count.Equals(1));
        }
    }
}
