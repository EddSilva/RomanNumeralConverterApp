namespace RomanNumeralConverter
{
    public class Ten: Figure
    {
        private const string romanSymbol = "X";
        private const int decimalNumber = 10;
        private const int offset = 9;

        private Ten(int current) : base(current, decimalNumber, offset, romanSymbol)
        {
        }

        private Ten() : base(decimalNumber, offset, romanSymbol)
        {
        }

        public static IFigure Evaluate(int current)
        {
            return new Ten(current);
        }

        public static IFigureHandle GetFigureHandle => new Ten();
    }
}
