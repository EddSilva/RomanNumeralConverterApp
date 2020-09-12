namespace RomanNumeralConverter
{
    public abstract class Figure : IFigure
    {
        protected Figure(int current, int decimalNumner, int offset, string romanNumber) : this(decimalNumner, offset, romanNumber)
        {
            this.Current = current;
        }

        protected Figure(int decimalNumner, int offset, string romanNumber)
        {
            this.DecimalNumber = decimalNumner;
            this.Offset = offset;
            this.RomanSymbol = romanNumber;
        }

        public string RomanSymbol { get; }
        public int DecimalNumber { get; }
        public int Offset { get; }
        public int Current { get; }
        public bool IsExact => DecimalNumber == Current;
        public int Remaning => DecimalNumber != 0 ? Current % DecimalNumber : Current;
        public int ContainsCount => DecimalNumber != 0 ? Current / DecimalNumber : 0;

        public bool Handle(int value, out string symbol)
        {
            symbol = this.RomanSymbol;

            return this.Offset == value;
        }
    }
}
