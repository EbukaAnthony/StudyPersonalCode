namespace MyConsoleApp
{
    public static class SqrtPreCalculated
    {
        public const int MaxValue = 1000;
        private static int[] sqrtValues;

        static SqrtPreCalculated()
        {
            sqrtValues = new int[MaxValue + 1];
            for (int i = 0; i < sqrtValues.Length; i++)
            {
                sqrtValues[i] = (int)Math.Sqrt(i);
            }
        }

        public static int GetSqrt(int value)
        {
            if ((value < 0) || (value > MaxValue))
            {
                throw new ArgumentOutOfRangeException(String.Format("The value must be from range of [0....{0}] ", MaxValue));
            }
            return sqrtValues[value];
        }
    }
}
