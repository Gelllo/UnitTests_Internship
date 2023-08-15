using Shapes.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace Shapes.UnitTests
{
    public class SphereTests
    {
        [Fact]
        public void When_SphereRadiusIsSet_Should_HaveCorrectRadius()
        {
            //Arrange

            //Act

            var systemUnderTest = new Sphere(75.50, "cm");

            //Assert

            systemUnderTest.Radius.Should().Be(75.50);
        }

        [Fact]
        public void When_SphereRadiusIsSet_Should_BeNonNegative()
        {
            // Act and Assert
            Action result = () => new Sphere(-0.005, "cm");
            result.Should().Throw<ArgumentOutOfRangeException>();
        }

        [Fact]
        public void When_SphereRadiusIsSet_Should_NotBeZero()
        {
            //Act
            Action result = () => new Sphere(0, "cm");

            //Assert
            result.Should().Throw<ArgumentOutOfRangeException>();

        }

        [Fact]
        public void When_SphereUnitIsSet_Should_NotBeNull()
        {
            // Act
            var systemUnderTest = new Sphere(5.25, "cm");

            // Assert
            systemUnderTest.Unit.Should().NotBeNull();
        }

        [Fact]
        public void When_SphereUnitIsSet_Should_NotBeEmpty()
        {
            // Act
            var systemUnderTest = new Sphere(27.50, "cm");

            // Assert
            systemUnderTest.Unit.Should().NotBeEmpty();
        }

        [Theory]
        [InlineData(20.0, 5026.548245743669)]
        [InlineData(5.0, 3.1421231)]
        public void When_SphereRadiusIsSet_Should_HaveCorrectArea(double radius, double expectedArea)
        {
            // Arrange
            var systemUnderTest = new Sphere(radius, "m");

            // Act
            var sphereArea = systemUnderTest.GetArea();

            // Assert
            sphereArea.Should().Be(expectedArea);
        }

        [Theory]
        [InlineData(30.0, 36000.0)]
        [InlineData(125.0, 3.1421231)]
        public void When_SphereRadiusIsSet_Should_HaveCorrectVolume(double radius, double expectedVolume)
        {
            // Arrange
            var systemUnderTest = new Sphere(radius, "m");

            // Act
            var sphereVolume = systemUnderTest.GetVolume();

            // Assert
            sphereVolume.Should().Be(expectedVolume);
        }

    }
}
