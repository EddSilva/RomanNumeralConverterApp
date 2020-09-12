namespace RomanNumeralConverter
{
    public static class Converter
    {
        public static string ToRoman(this int value)
        {
            return Evaluator.Assert(value)
                                .Also((n) => OneThousand.Evaluate(n))
                                .Also((n) => FiveHundred.Evaluate(n))
                                .Also((n) => OneHundred.Evaluate(n))
                                .Also((n) => Fifty.Evaluate(n))
                                .Also((n) => Ten.Evaluate(n))
                                .Also((n) => Five.Evaluate(n))
                                .Also((n) => One.Evaluate(n))
                                .Resolve();
        }
    }
}
