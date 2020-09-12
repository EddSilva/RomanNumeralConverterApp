using System.Collections.Generic;

namespace RomanNumeralConverter
{
    public class OffsetHandler
    {
        private readonly IList<IFigureHandle> figures;

        public OffsetHandler(params IFigureHandle[] figures)
        {
            this.figures = figures;
        }

        public string Handle(int value)
        {
            foreach (var figure in figures)
            {
                if (figure.Handle(value, out string symbol))
                {
                    return symbol;
                }
            }

           return string.Empty;
        }
    }
}
