namespace RomanNumeralConverter
{
    public class Fifty : Figure
    {
        private const string romanSymbol = "L";
        private const int decimalNumber = 50;
        private const int offset = 40;

        private Fifty(int current) : base(current, decimalNumber, offset, romanSymbol)
        {
        }

        private Fifty() : base(decimalNumber, offset, romanSymbol)
        {
        }

        public static IFigure Evaluate(int current)
        {
            return new Fifty(current);
        }

        public static IFigureHandle GetFigureHandle => new Fifty();
    }
}
