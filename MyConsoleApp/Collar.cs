namespace MyConsoleApp
{
    public class Collar
    {
        //private int X;
        //private int Y;

        //public Collar(int x, int y)
        //{
        //    X = x;
        //    Y = y;
        //}

        //public int GetAndSetX
        //{
        //    get { return this.X; }
        //    set { this.X = value; }
        //}

        //public int GetAndSetY
        //{
        //    get { return this.Y; }
        //    set { this.Y = value; }
        //}

        //public static int Sum(int x, int y)
        //{
        //    int result = x + y;
        //    return result;
        //}


        private static double PI = 22 / 7d;
        private double Radius;

        public Collar(double radius)
        {
            Radius = radius;
        }

        public static double CalculateSurface(double radius)
        {
            double result = (PI * radius * radius);
            return result;
        }

        public void PrintSurface()
        {
            var surface = CalculateSurface(Radius);
            Console.WriteLine("Surface is: " + surface);
        }
    }
}
