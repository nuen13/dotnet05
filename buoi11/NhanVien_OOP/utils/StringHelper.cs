

public static class StringHelper
{
    public static string ToSlug(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            return string.Empty;

        // Trim, split by spaces (ignore extra spaces), lowercase, join with hyphen
        var words = input
            .Trim()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(word => word.ToLower());

        return string.Join("-", words);
    }


}
