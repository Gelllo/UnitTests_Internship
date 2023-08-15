using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Shapes.Core;

namespace Shapes.UnitTests
{
    public class ShapeListTests
    {
        private readonly ShapeList _systemUnderTest;

        //Setup
        public ShapeListTests()
        {
            _systemUnderTest = new ShapeList();
            _systemUnderTest.AddShape(new Cube(4.0, "cm"));
            _systemUnderTest.AddShape(new Cube(10.0, "mm"));
            _systemUnderTest.AddShape(new Sphere(20.0, "dm"));
            _systemUnderTest.AddShape(new Sphere(2.0, "hm"));
        }

        [Fact]
        public void When_ShapeIsAddedToList_Should_IncrementShapesCount()
        {
            //Arrange
            var cube = new Cube(30, "km");
            //Act
            _systemUnderTest.AddShape(cube);
            //Assert
            _systemUnderTest.GetNumberOfShapes().Should().Be(5);
        }

        [Fact] 
        public void When_ShapeIsRemovedFromList_Should_DecrementShapesCount()
        {
            //Arrange
            var shapeToRemove = _systemUnderTest.GetShapeList().First();
            //Act
            _systemUnderTest.RemoveShape(shapeToRemove);
            //Assert
            _systemUnderTest.GetNumberOfShapes().Should().Be(3);
        }

        [Theory]
        [InlineData(20.0, 10799.361973944775)]
        [InlineData(5.0, 3.1421231)]
        public void When_ShapeIsAdded_Should_HaveCorrectTotalArea(double length, double expectedArea)
        {
            // Arrange
             _systemUnderTest.AddShape(new Sphere(length, "m"));

            // Act
            var shapesTotalArea = _systemUnderTest.GetTotalArea();
            // Assert
            shapesTotalArea.Should().Be(expectedArea);
        }

        [Theory]
        [InlineData(1, 10741.333333333332)]
        [InlineData(2, 3.1421231)]
        public void When_ShapeIsRemoved_Should_HaveCorrectVolume(int index, double expectedVolume)
        {                                
            // Arrange 
            var shapeToRemove = _systemUnderTest.GetShapeList().ElementAt(index);
            _systemUnderTest.RemoveShape(shapeToRemove);

            // Act
            var shapesTotalVolume = _systemUnderTest.GetTotalVolume();

            // Assert
            shapesTotalVolume.Should().Be(expectedVolume);
        }
    }
}
