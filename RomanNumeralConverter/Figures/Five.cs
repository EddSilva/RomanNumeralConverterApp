namespace RomanNumeralConverter
{
    public class Five : Figure
    {
        private const string romanSymbol = "V";
        private const int decimalNumber = 5;
        private const int offset = 4;

        private Five(int current) : base(current, decimalNumber, offset, romanSymbol)
        {
        }

        private Five() : base(decimalNumber, offset, romanSymbol)
        {
        }

        public static IFigure Evaluate(int current)
        {
            return new Five(current);
        }

        public static IFigureHandle GetFigureHandle => new Five();
    }
}
