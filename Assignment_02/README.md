# Assignment 2 – Unit Testing (PROG2070: Software Quality Assurance)

Semester: Winter 2026  
Group: 3  
Course: Programming - Software Quality Assurance  
 Group Members: SADAVI CHALASANI,SARAH VELUZ , ROBERT LANGA

## Project Overview

This project demonstrates design, implementation, and unit testing of a simple C# Rectangle class using NUnit Framework.  
The class allows a user to set or get rectangle dimensions and calculate properties like perimeter and area.  

The project also uses **Git** for version control and demonstrates proper Git commit documentation, code structure, and testing methodology.



##  Rectangle Class Details

### Class:
`Rectangle` (in namespace `Assignment_02`)

### Attributes:
- `int length`
- `int width`

### Constructors:
- **Default Constructor:** Sets both `length` and `width` to `1`.
- **Parameterized Constructor:** Sets `length` and `width` to user-specified values.

### Public Methods:

| Method                  | Description                                                  | Return Type |
|---------                |--------------                                                |-------------|
| `GetLength()`           | Returns the current length                                   | `int` |
| `SetLength(int length)` | Sets the length and returns the updated value                | `int` |
| `GetWidth()`            | Returns the current width                                    | `int` |
| `SetWidth(int width)`   | Sets the width and returns the updated value                 | `int` |
| `GetPerimeter()`        | Calculates and returns the perimeter (`2 × (length + width)` | `int` |
| `GetArea()`             | Calculates and returns the area (`length × width`)           | `int` |

---

##  Unit Testing (Using NUnit)

Unit testing was performed in Visual Studio 2026 using the NUnit Framework.  
A total of 18 unique test cases were created in `RectangleTests.cs`, covering all six methods using **Arrange–Act–Assert** format and Boundary Value Analysis (BVA).

###  Test Structure:
- Arrange: Create or initialize a rectangle instance  
- Act: Call the method to test  
- Assert: Verify expected vs actual output

---

###  Test Case Summary

| Category         | Description                                          | Example Input  | Expected Output |
|-----------       |--------------                                        |----------------|----------------|
| `GetLength()`    | Returns correct length across boundary values        | 1, 10, 4500    | 1, 10, 4500 |
| `SetLength()`    | Updates rectangle length correctly                   | 1, 20, 4500    | 1, 20, 4500 |
| `GetWidth()`     | Returns correct width across boundary values         | 1, 10, 4500    | 1, 10, 4500 |
| `SetWidth()`     | Updates rectangle width correctly                    | 1, 25, 4500    | 1, 25, 4500 |
| `GetArea()`      | Calculates correct area (length × width)             | (1,1), (10,5), (4500,4500) | 1, 50, 20,250,000 |
| `GetPerimeter()` | Calculates correct perimeter (2 × (length + width))  | (1,1), (10,5), (4500,4500) | 4, 30, 18,000 |

All tests were executed successfully — no failures observed.

---

##  Example — Sample Test (AAA Format)
    csharp
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
