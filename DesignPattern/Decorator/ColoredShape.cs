namespace Decorator
{
    // CRTP cannot be done
    //public class ColoredShape2<T> : T where T : Shape { }

    public class ColoredShape<T> : Shape
      where T : Shape, new()
    {
        private readonly string color;
        private readonly T shape = new T();

        public ColoredShape() : this("black")
        {

        }

        public ColoredShape(string color) // no constructor forwarding
        {
            this.color = color;
        }

        public override string AsString()
        {
            return $"{shape.AsString()} has the color {color}";
        }
    }
}
