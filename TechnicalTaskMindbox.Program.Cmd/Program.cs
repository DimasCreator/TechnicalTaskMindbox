using System;
using System.Collections.Generic;
using TechnicalTaskMindbox.ShapeLibrary.Shapes;

var shapes = new List<IShape>
{
    new Circle(3.4),
    new Circle(56),
    new Circle(4.2),
    new Circle(1.2),
    new Circle(12.4),
    new Triangle(12, 40, 36),
    new Triangle(32.4, 14, 25.2),
    new Triangle(20, 41.2, 33),
    new Triangle(10, 50, 41),
    new Triangle(42, 54, 20)
};

foreach (var shape in shapes)
{
    Console.WriteLine(shape.Area());
}