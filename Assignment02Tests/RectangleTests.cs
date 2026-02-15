using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Assignment_02;

namespace Assignment_02.Tests
{
    [TestFixture]
    public class RectangleTests
    {
        // Unit testing
        [Test]
        public void GetLength_MinValue_ReturnsOne()
        {
            // Arrange
            Rectangle rect = new Rectangle(1, 5);

            // Act
            int actual = rect.GetLength();

            // Assert
            Assert.That(actual, Is.EqualTo(1));
        }

        [Test]
        public void GetLength_NormalValue_ReturnsCorrectLength()
        {
            // Arrange
            Rectangle rect = new Rectangle(10, 5);

            // Act
            int actual = rect.GetLength();

            // Assert
            Assert.That(actual, Is.EqualTo(10));
        }

        [Test]
        public void GetLength_MaxValue_ReturnsMaxLength()
        {
            // Arrange
            Rectangle rect = new Rectangle(4500, 5);

            // Act
            int actual = rect.GetLength();

            // Assert
            Assert.That(actual, Is.EqualTo(4500));
        }

        // =======================
        // SetLength() TESTS
        // =======================

        [Test]
        public void SetLength_MinValue_UpdatesLength()
        {
            // Arrange
            Rectangle rect = new Rectangle();

            // Act
            int actual = rect.SetLength(1);

            // Assert
            Assert.That(actual, Is.EqualTo(1));
        }

        [Test]
        public void SetLength_NormalValue_UpdatesLength()
        {
            // Arrange
            Rectangle rect = new Rectangle();

            // Act
            int actual = rect.SetLength(20);

            // Assert
            Assert.That(actual, Is.EqualTo(20));
        }

        [Test]
        public void SetLength_MaxValue_UpdatesLength()
        {
            // Arrange
            Rectangle rect = new Rectangle();

            // Act
            int actual = rect.SetLength(4500);

            // Assert
            Assert.That(actual, Is.EqualTo(4500));
        }

        // =======================
        // GetWidth() TESTS
        // =======================

        [Test]
        public void GetWidth_MinValue_ReturnsOne()
        {
            // Arrange
            Rectangle rect = new Rectangle(5, 1);

            // Act
            int actual = rect.GetWidth();

            // Assert
            Assert.That(actual, Is.EqualTo(1));
        }

        [Test]
        public void GetWidth_NormalValue_ReturnsCorrectWidth()
        {
            // Arrange
            Rectangle rect = new Rectangle(5, 10);

            // Act
            int actual = rect.GetWidth();

            // Assert
            Assert.That(actual, Is.EqualTo(10));
        }

        [Test]
        public void GetWidth_MaxValue_ReturnsMaxWidth()
        {
            // Arrange
            Rectangle rect = new Rectangle(5, 4500);

            // Act
            int actual = rect.GetWidth();

            // Assert
            Assert.That(actual, Is.EqualTo(4500));
        }

        // =======================
        // SetWidth() TESTS
        // =======================

        [Test]
        public void SetWidth_MinValue_UpdatesWidth()
        {
            // Arrange
            Rectangle rect = new Rectangle();

            // Act
            int actual = rect.SetWidth(1);

            // Assert
            Assert.That(actual, Is.EqualTo(1));
        }

        [Test]
        public void SetWidth_NormalValue_UpdatesWidth()
        {
            // Arrange
            Rectangle rect = new Rectangle();

            // Act
            int actual = rect.SetWidth(25);

            // Assert
            Assert.That(actual, Is.EqualTo(25));
        }

        [Test]
        public void SetWidth_MaxValue_UpdatesWidth()
        {
            // Arrange
            Rectangle rect = new Rectangle();

            // Act
            int actual = rect.SetWidth(4500);

            // Assert
            Assert.That(actual, Is.EqualTo(4500));
        }

        // =======================
        // GetArea() TESTS
        // =======================

        [Test]
        public void GetArea_MinValues_ReturnsCorrectArea()
        {
            // Arrange
            Rectangle rect = new Rectangle(1, 1);

            // Act
            int actual = rect.GetArea();

            // Assert
            Assert.That(actual, Is.EqualTo(1));
        }

        [Test]
        public void GetArea_NormalValues_ReturnsCorrectArea()
        {
            // Arrange
            Rectangle rect = new Rectangle(10, 5);

            // Act
            int actual = rect.GetArea();

            // Assert
            Assert.That(actual, Is.EqualTo(50));
        }

        [Test]
        public void GetArea_MaxValues_ReturnsCorrectArea()
        {
            // Arrange
            Rectangle rect = new Rectangle(4500, 4500);

            // Act
            int actual = rect.GetArea();

            // Assert
            Assert.That(actual, Is.EqualTo(20250000));
        }

        // =======================
        // GetPerimeter() TESTS
        // =======================

        [Test]
        public void GetPerimeter_MinValues_ReturnsCorrectPerimeter()
        {
            // Arrange
            Rectangle rect = new Rectangle(1, 1);

            // Act
            int actual = rect.GetPerimeter();

            // Assert
            Assert.That(actual, Is.EqualTo(4));
        }

        [Test]
        public void GetPerimeter_NormalValues_ReturnsCorrectPerimeter()
        {
            // Arrange
            Rectangle rect = new Rectangle(10, 5);

            // Act
            int actual = rect.GetPerimeter();

            // Assert
            Assert.That(actual, Is.EqualTo(30));
        }

        [Test]
        public void GetPerimeter_MaxValues_ReturnsCorrectPerimeter()
        {
            // Arrange
            Rectangle rect = new Rectangle(4500, 4500);

            // Act
            int actual = rect.GetPerimeter();

            // Assert
            Assert.That(actual, Is.EqualTo(18000));
        }


    }
}
