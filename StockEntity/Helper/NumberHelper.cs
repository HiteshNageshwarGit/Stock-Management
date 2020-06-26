namespace StockEntity.Helper
{
    public class NumberHelper
    {
        public static bool IsValidNumber(string numberText)
        {
            if (numberText.Length == 0)
            {
                return true;
            }

            float val;
            if (float.TryParse(numberText, out val))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
