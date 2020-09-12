namespace RomanNumeralConverter.Figures
{
    public class Initial : Figure
    {
        private const string romanSymbol = "";
        private const int decimalNumber = 0;
        private const int offset = int.MaxValue;

        private Initial(int current) : base(current, decimalNumber, offset, romanSymbol)
        {
        }

        public static IFigure Evaluate(int current)
        {
            return new Initial(current);
        }
    }
}
