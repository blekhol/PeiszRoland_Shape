namespace a
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Rectangle rectangle = new Rectangle(false, "red", 1, 2);

			Shape[] shapes = { rectangle, new Square(true, "blue", 1, 1), new Circle(false, "yellow", 5) };

			Square square = new Square(false, "red", 5, 5);

			Rectangle rect = square;
			Shape shape = square;
		}
	}
}
