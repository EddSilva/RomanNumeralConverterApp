namespace RomanNumeralConverter
{
    public class OneHundred : Figure
    {
        private const string romanSymbol = "C";
        private const int decimalNumber = 100;
        private const int offset = 90;

        private OneHundred(int current) : base(current, decimalNumber, offset, romanSymbol)
        {
        }

        private OneHundred() : base(decimalNumber, offset, romanSymbol)
        {
        }

        public static IFigure Evaluate(int current)
        {
            return new OneHundred(current);
        }

        public static IFigureHandle GetFigureHandle => new OneHundred();
    }
}
