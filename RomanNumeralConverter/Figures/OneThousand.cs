namespace RomanNumeralConverter
{
    public class OneThousand : Figure
    {
        private const string romanSymbol = "M";
        private const int decimalNumber = 1000;
        private const int offset = 900;

        private OneThousand(int current) : base(current, decimalNumber, offset, romanSymbol)
        {
        }

        private OneThousand() : base(decimalNumber, offset, romanSymbol)
        {
        }

        public static IFigure Evaluate(int current)
        {
            return new OneThousand(current);
        }

        public static IFigureHandle GetFigureHandle => new OneThousand();
    }
}
