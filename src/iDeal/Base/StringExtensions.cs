namespace iDeal.Base
{
    public static class StringExtensions
    {
        public static bool IsNullEmptyOrWhiteSpace(this string value)
        {
            return value == null || string.IsNullOrEmpty(value.Trim());
        }
    }
}
