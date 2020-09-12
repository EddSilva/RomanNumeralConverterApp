using RomanNumeralConverter.Figures;
using System;
using System.Collections.Generic;

namespace RomanNumeralConverter
{
    public class Evaluator
    {
        private Evaluator()
        {
        }

        private Evaluator(IFigure figure, IEnumerable<string> symbols)
        {
            Figure = figure;
            Symbols = new List<string>(symbols);
        }

        public IFigure Figure { get; }
        public List<string> Symbols { get; } = new List<string>();

        public static Evaluator Assert(int current)
        {
            return new Evaluator(Initial.Evaluate(current), new List<string>());
        }

        public string Resolve()
        {
            return string.Join(string.Empty, this.Symbols);
        }

        public Evaluator Also(Func<int, IFigure> func)
        {
            var nextFigure = func(this.Figure.Remaning);

            if (nextFigure.IsExact)
            {
                this.Symbols.Add(nextFigure.RomanSymbol);
                return new Evaluator(nextFigure, this.Symbols);
            }

            if (nextFigure.ContainsCount > 0)
            {
                if (nextFigure.ContainsCount == 4)
                {
                    this.Symbols.Add(nextFigure.RomanSymbol);

                    var total = nextFigure.ContainsCount * nextFigure.DecimalNumber;

                    if (this.Figure.Current >= this.Figure.Offset && this.Figure.ContainsCount == 1)
                    {
                        total = total + this.Figure.DecimalNumber;
                    }

                    var handler = new OffsetHandler(
                                            Five.GetFigureHandle,
                                            Ten.GetFigureHandle,
                                            Fifty.GetFigureHandle,
                                            OneHundred.GetFigureHandle,
                                            FiveHundred.GetFigureHandle,
                                            OneThousand.GetFigureHandle);

                    var offset = handler.Handle(total);
                    this.Symbols.Add(offset);
                }
                else if (nextFigure.Current < this.Figure.Offset)
                {
                    for (int i = 0; i < nextFigure.ContainsCount; i++)
                    {
                        this.Symbols.Add(nextFigure.RomanSymbol);
                    }
                }
            }

            return new Evaluator(nextFigure, this.Symbols);
        }
    }
}
