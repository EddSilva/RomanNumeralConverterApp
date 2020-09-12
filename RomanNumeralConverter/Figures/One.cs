namespace RomanNumeralConverter
{
    public class One : Figure
    {
        private const string romanSymbol = "I";
        private const int decimalNumber = 1;
        private const int offset = 0;

        private One(int current):base(current, decimalNumber, offset, romanSymbol)
        {
        }

        private One() : base(decimalNumber, offset, romanSymbol)
        {
        }

        public static IFigure Evaluate(int current)
        {
            return new One(current);
        }

        public static IFigureHandle GetFigureHandle => new One();
    }
}
