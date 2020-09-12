namespace RomanNumeralConverter
{
    public class FiveHundred : Figure
    {
        private const string romanSymbol = "D";
        private const int decimalNumber = 500;
        private const int offset = 400;

        private FiveHundred(int current) : base(current, decimalNumber, offset, romanSymbol)
        {
        }

        private FiveHundred() : base(decimalNumber, offset, romanSymbol)
        {
        }

        public static IFigure Evaluate(int current)
        {
            return new FiveHundred(current);
        }

        public static IFigureHandle GetFigureHandle => new FiveHundred();
    }
}
