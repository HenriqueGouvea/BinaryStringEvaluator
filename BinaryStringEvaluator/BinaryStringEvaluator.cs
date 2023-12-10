namespace BinaryStringEvaluator
{
    public static class BinaryStringEvaluator
    {
        public static bool Evaluate(string binaryString)
        {
            /* Write a C# function to evaluate binary strings based on specific criteria.
               1.The function accepts a binary string as input.
               2.Check if the binary string is 'good' based on these conditions:
                ● Equal number of 0's and 1's.
                ● For every prefix, the number of 1's is not less (higher or equals) than the number of 0's.*/
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