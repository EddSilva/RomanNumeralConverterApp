namespace RomanNumeralConverter
{
    public interface IFigureHandle
    {
        string RomanSymbol { get; }
        int DecimalNumber { get; }
        int Offset { get; }
        bool Handle(int value, out string symbol);
    }
}
