using Decorator;


var cb = new CodeBuilder();
cb.AppendLine("class Foo")
  .AppendLine("{")
  .AppendLine("}");
Console.WriteLine(cb);

var circle = new Circle(2);
Console.WriteLine(circle.AsString());

var redCircle = new ColoredShape(circle, "red");
Console.WriteLine(redCircle.AsString());

var redHalfTransparentSquare = new TransparentShape(redCircle, 0.5f);
Console.WriteLine(redHalfTransparentSquare.AsString());

// static
ColoredShape<Circle> blueCircle = new ColoredShape<Circle>("blue");
Console.WriteLine(blueCircle.AsString());
// A circle of radius 0 has the color blue

TransparentShape<ColoredShape<Square>> blackHalfSquare = new TransparentShape<ColoredShape<Square>>(0.4f);
Console.WriteLine(blackHalfSquare.AsString());
// A square with side 0 has the color black has transparency 40
