using Shapes.Core;

namespace Shapes.UnitTests
{
    public class CubeTests
    {
        [Fact]
        public void When_CubeSideIsSet_Should_HaveCorrectSide()
        {
            //Arrange

            //Act

            var systemUnderTest = new Cube(5.50, "cm");

            //Assert

            Assert.Equal(5.50, systemUnderTest.Side);
        }

        [Fact]
        public void When_CubeSideIsSet_Should_BeNonNegative()
        {
            //Act
            Action result = () => new Cube(-0.001, "cm");

            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(result);
        }

        [Fact]
        public void When_CubeSideIsSet_Should_NotBeZero()
        {
            //Act
            Action result = () => new Cube(0, "cm");

            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(result);
        }

        [Fact]
        public void When_CubeUnitIsSet_Should_NotBeNull()
        {
            //Act
            var systemUnderTest = new Cube(115.50, "cm");

            //Assert
            Assert.NotNull(systemUnderTest.Unit);
        }

        [Fact]
        public void When_CubeUnitIsSet_Should_NotBeEmpty()
        {
            //Act
            var systemUnderTest = new Cube(52.50, "cm");

            //Assert
            Assert.NotEmpty(systemUnderTest.Unit);
        }

        [Theory]
        [InlineData(20.0, 2400.0)]
        [InlineData(5.0, 3.1421231)]
        public void When_CubeSideIsSet_Should_HaveCorrectArea(double side, double expectedArea)
        {
            //Arrange
            var systemUnderTest = new Cube(side, "m");

            //Act
            var cubeArea = systemUnderTest.GetArea();

            //Assert

            Assert.Equal(expectedArea, cubeArea);
        }

        [Theory]
        [InlineData(30.0, 27000.0)]
        [InlineData(125.0, 3.1421231)]
        public void When_CubeSideIsSet_Should_HaveCorrectVolume(double side, double expectedVolume)
        {
            //Arrange
            var systemUnderTest = new Cube(side, "m");

            //Act
            var cubeVolume = systemUnderTest.GetVolume();

            //Assert
            Assert.Equal(expectedVolume, cubeVolume);
        }


    }
}