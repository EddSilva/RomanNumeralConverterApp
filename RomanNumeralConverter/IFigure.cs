namespace RomanNumeralConverter
{
    public interface IFigure : IFigureHandle
    {
        int Current { get; }
        bool IsExact { get; }
        int Remaning { get; }
        int ContainsCount { get; }
    }
}
