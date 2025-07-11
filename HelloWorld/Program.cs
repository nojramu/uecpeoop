namespace Program
{
    class Hello
    {
        static void Main(string[] args)
        {
            var c = new Cartesian(3, 4);
            if (Polar.TryConvert(c, out var R, out var Theta))
            {
                System.Console.WriteLine(R);
            }
        }
    }

    public class Cartesian
    {
        public int X { get; }
        public int Y { get; }

        public Cartesian(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    public static class Polar
    {
        public static bool TryConvert(Cartesian c, out double R, out double Theta)
        {
            R = Math.Sqrt(c.X * c.X + c.Y * c.Y);
            Theta = Math.Atan2(c.Y, c.X);
            return c.X != 0 || c.Y != 0;
        }
    }
}
