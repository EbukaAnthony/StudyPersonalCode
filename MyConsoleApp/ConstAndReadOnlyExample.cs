namespace MyConsoleApp
{
    public class ConstAndReadOnlyExample
    {
        public const double PI = 3.1415926535897932385;
        public readonly double Size;

        public ConstAndReadOnlyExample(double size)
        {
            Size = size;
        }
    }
}
