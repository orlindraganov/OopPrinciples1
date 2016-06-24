namespace SchoolClasses.Validator
{
    using System;

    public static class Validator
    {
        public static void ValidateNullOrWhiteSpace(string input, string paramName = "The parameter")
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentOutOfRangeException(paramName, "Cannot be null, empty or whitespace.");
            }
        }

        public static void ValidateNonNegative(int input, string paramName = "The parameter")
        {
            if (input < 0)
            {
                throw new ArgumentOutOfRangeException(paramName, "Cannot be negative.");
            }
        }
    }
}
