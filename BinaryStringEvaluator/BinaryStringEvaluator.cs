namespace BinaryStringEvaluator
{
    public static class BinaryStringEvaluator
    {
        public static bool Evaluate(string binaryString)
        {
            if (string.IsNullOrWhiteSpace(binaryString))
                return false;

            int zeros = 0, ones = 0;
            var onesNotLess = true;
            var hasInvalidChar = false;

            for (int i = 0; i < binaryString.Length; i++)
            {
                var bit = binaryString[i];

                if (bit == '1') ones++;
                else if (bit == '0') zeros++;
                else
                {
                    hasInvalidChar = true;
                    break;
                }

                if (i == 0 && bit == '0' || zeros > ones)
                {
                    onesNotLess = false;
                    break;
                }
            }

            return onesNotLess && zeros == ones && !hasInvalidChar;
        }
    }
}